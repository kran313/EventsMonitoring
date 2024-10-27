using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsMonitoring.CommonClasses
{
    public static class ForbiddenSubStrings
    {
        private static string _connectionString = "data source=analytic.gkbaltbet.local;initial catalog=EventMatching;user Id=event_match;password=umbMzLQB3hKo69VG8F4N;" +
                                  "Integrated Security=false;MultipleActiveResultSets=true;MultiSubnetFailover=True;TrustServerCertificate=true";
        private static string _sqlExpression;


        public static List<string> GetForbiddenStrings(string liveLine)
        {
            _sqlExpression = $"SELECT * FROM {liveLine}ForbiddenStrings";
            var forbiddenStrings = new List<string>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(_sqlExpression, connection);
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        forbiddenStrings.Add(reader.GetString(0));
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Database GetForbiddenStrings crashed! Try again later.");
                    throw new Exception("Database GetForbiddenStrings crashed! Try again later.");
                }

            }
            return forbiddenStrings;
        }

        public static List<string> GetCyberSportsNames()
        {
            _sqlExpression = $"SELECT * FROM CyberSportsNames";
            var cyberSportsNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(_sqlExpression, connection);
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cyberSportsNames.Add(reader.GetString(0));
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Database GetCyberSportsNames crashed! Try again later.");
                    throw new Exception("Database GetCyberSportsNames crashed! Try again later.");
                }

            }
            return cyberSportsNames;
        }


        public static Dictionary<string, Dictionary<string, string>> GetStatisticsNames()
        {
            _sqlExpression = $"SELECT * FROM StatisticNames";
            var statisticsNames = new Dictionary<string, Dictionary<string, string>>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(_sqlExpression, connection);
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (!statisticsNames.ContainsKey(reader.GetString(0)))
                        {
                            statisticsNames[reader.GetString(0)] = new Dictionary<string, string>();
                        }
                        statisticsNames[reader.GetString(0)][reader.GetString(1)] = reader.GetString(2);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Database GetStatisticsNames crashed! Try again later.");
                    throw new Exception("Database GetStatisticsNames crashed! Try again later.");
                }

            }
            return statisticsNames;
        }

        public static Dictionary<string, string> GetFonbetSportNames()
        {
            _sqlExpression = $"SELECT * FROM FonbetSportNames";
            var fonbetSportNames = new Dictionary<string, string>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(_sqlExpression, connection);
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        fonbetSportNames[reader.GetString(0)] = reader.GetString(1);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Database GetFonbetSportNames crashed! Try again later.");
                    throw new Exception("Database GetFonbetSportNames crashed! Try again later.");
                }

            }
            return fonbetSportNames;
        }


        static public bool isAllowed(string name, bool isLive, List<string> fordiddenSubStringsLive, List<string> fordiddenSubStringsLine)
        {
            if (isLive)
            {
                foreach (string subString in fordiddenSubStringsLive)
                {
                    if (name.ToLower().Contains(subString.ToLower()))
                        return false;
                }
                return true;
            }
            else
            {
                foreach (string subString in fordiddenSubStringsLine)
                {
                    if (name.ToLower().Contains(subString.ToLower()))
                        return false;
                }
                return true;
            }
        }
    }
}
