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
        private static string _connectionString = "data source=srvapkbb8.gkbaltbet.local;initial catalog=EventMatching;user Id=event_match;password=umbMzLQB3hKo69VG8F4N;" +
                                  "Integrated Security=false;MultipleActiveResultSets=true;TrustServerCertificate=true";
        private static string _sqlExpression;
        public static List<string> forbiddenStrings;


        public static List<string> GetForbiddenStrings(string liveLine)
        {
            _sqlExpression = $"SELECT * FROM {liveLine}ForbiddenStrings";
            forbiddenStrings = new List<string>();

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
                    MessageBox.Show("Database crashed! Try again later.");
                    throw new Exception("Database crashed! Try again later.");
                }

            }
            return forbiddenStrings;
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
