using EventsMonitoring.CommonClasses;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EventsMonitoring
{
    public static class MatchingDatabase
    {
        private static Dictionary<string, Dictionary<string, string>> _pairs;

        private static string _connectionString = "data source=analytic.gkbaltbet.local;initial catalog=EventMatching;user Id=event_match;password=umbMzLQB3hKo69VG8F4N;" +
                                                  "Integrated Security=false;MultipleActiveResultSets=true;TrustServerCertificate=true";
        private static string _sqlExpression;


        public static Dictionary<string, Dictionary<string, string>> GetMatchings()
        {
            _sqlExpression = $"SELECT * FROM IdLinksCyberSport";
            _pairs = new Dictionary<string, Dictionary<string, string>>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                     
                    SqlCommand command = new SqlCommand(_sqlExpression, connection);
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (!_pairs.ContainsKey(reader.GetString(0)))
                        {
                            _pairs[reader.GetString(0)] = new Dictionary<string, string>();
                        }
                        _pairs[reader.GetString(0)][reader.GetString(1)] = reader.GetString(2);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Database crashed! Try again later.");
                    throw new Exception("Database crashed! Try again later.");
                }
            }

            return _pairs;
        }

        public static void AddMatching(string sport, string team1Id, string team2Id, string team1Name, string team2Name)
        {

            var matchings = GetMatchings();
            if (!matchings.ContainsKey(sport))
            {
                matchings[sport] = new Dictionary<string, string>();
            }

            if (matchings[sport].ContainsKey(team1Id))
            {
                _sqlExpression = "UPDATE IdLinksCyberSport SET BaltbetId=(@team2Id) WHERE Sport = (@sport) AND FonbetId=(@team1Id)";
            }
            else
            {
                _sqlExpression = "INSERT INTO IdLinksCyberSport VALUES (@sport, @team1Id, @team2Id, @team1Name, @team2Name)";
            }


            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(_sqlExpression, connection);
                command.Parameters.AddWithValue("@sport", sport);
                command.Parameters.AddWithValue("@team1Id", team1Id);
                command.Parameters.AddWithValue("@team2Id", team2Id);
                command.Parameters.AddWithValue("@team1Name", team1Name);
                command.Parameters.AddWithValue("@team2Name", team2Name);

                command.ExecuteNonQuery();
            }
        }
    }
}
