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
        private static Dictionary<string, string> _pairs = new Dictionary<string, string>();

        private static string _connectionString = "data source=agl-anal.gkbaltbet.local;initial catalog=EventMatching;user Id=event_match;password=umbMzLQB3hKo69VG8F4N;" +
                                  "Integrated Security=false;MultipleActiveResultSets=true;MultiSubnetFailover=True;TrustServerCertificate=true";
        private static string _sqlExpression;


        public static Dictionary<string, string> GetMatchingsTeams()
        {
            _sqlExpression = $"SELECT * FROM ImportTable";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(_sqlExpression, connection);
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        _pairs[reader.GetString(0)] = reader.GetString(1);
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


        public static Dictionary<string, string> GetMatchingsBranches()
        {
            _sqlExpression = $"SELECT * FROM BranchesLinks";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(_sqlExpression, connection);
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        _pairs[reader.GetString(0)] = reader.GetString(1);
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


        public static void AddMatchingTeams(string sport, string team1Id, string team2Id, string team1Name, string team2Name)
        {
            var userName = SystemInformation.UserName + ";" + Environment.MachineName;
            var date = DateTime.Now;
            var matchings = GetMatchingsTeams();

            if (matchings.ContainsKey(team1Id))
            {
                _sqlExpression = "UPDATE ImportTable SET BaltbetId=(@team2Id), Sport=(@sport), FonbetName=(@team1Name), BaltbetName=(@team2Name), UserName=(@userName), Date=(@date) WHERE FonbetId=(@team1Id)";
            }
            else
            {
                _sqlExpression = "INSERT INTO ImportTable VALUES (@team1Id, @team2Id, @sport, @team1Name, @team2Name, @userName, @date)";
            }


            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(_sqlExpression, connection);
                command.Parameters.AddWithValue("@team1Id", team1Id);
                command.Parameters.AddWithValue("@team2Id", team2Id);
                command.Parameters.AddWithValue("@sport", sport);
                command.Parameters.AddWithValue("@team1Name", team1Name);
                command.Parameters.AddWithValue("@team2Name", team2Name);
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@date", date);

                command.ExecuteNonQuery();
            }
        }


        public static void AddMatchingBranches(string sport, string branch1Id, string branch2Id, string branch1Name, string branch2Name)
        {
            var userName = SystemInformation.UserName + ";" + Environment.MachineName;
            var date = DateTime.Now;
            var matchings = GetMatchingsBranches();

            if (matchings.ContainsKey(branch1Id))
            {
                _sqlExpression = "UPDATE BranchesLinks SET BaltbetId=(@branch2Id), FonbetName=(@branch1Name), BaltbetName=(@branch2Name), UserName=(@userName), Date=(@date) WHERE FonbetId=(@branch1Id)";
            }
            else
            {
                _sqlExpression = "INSERT INTO BranchesLinks VALUES (@branch1Id, @branch2Id, @sport, @branch1Name, @branch2Name, @userName, @date)";
            }


            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(_sqlExpression, connection);
                command.Parameters.AddWithValue("@branch1Id", branch1Id);
                command.Parameters.AddWithValue("@branch2Id", branch2Id);
                command.Parameters.AddWithValue("@sport", sport);
                command.Parameters.AddWithValue("@branch1Name", branch1Name);
                command.Parameters.AddWithValue("@branch2Name", branch2Name);
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@date", date);

                command.ExecuteNonQuery();
            }
        }
    }
}
