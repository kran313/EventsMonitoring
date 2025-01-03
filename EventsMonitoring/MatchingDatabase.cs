﻿using EventsMonitoring.CommonClasses;
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

        private static string _connectionString = "data source=srvapkbb8.gkbaltbet.local;initial catalog=EventMatching;user Id=event_match;password=umbMzLQB3hKo69VG8F4N;" +
                                  "Integrated Security=false;MultipleActiveResultSets=true;TrustServerCertificate=true";
        private static string _sqlExpression;


        public static Dictionary<string, string> GetMatchings()
        {
            _sqlExpression = $"SELECT * FROM ImportTable";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(_sqlExpression, connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    _pairs[reader.GetString(0)] = reader.GetString(1);
                }
            }
            return _pairs;
        }

        public static void AddMatching(string team1Id, string team2Id)
        {

            var matchings = GetMatchings();

            if (matchings.ContainsKey(team1Id))
            {
                _sqlExpression = "UPDATE ImportTable SET BaltbetId=(@team2Id) WHERE FonbetId=(@team1Id)";
            }
            else
            {
                _sqlExpression = "INSERT INTO ImportTable VALUES (@team1Id, @team2Id)";
            }


            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(_sqlExpression, connection);
                command.Parameters.AddWithValue("@team1Id", team1Id);
                command.Parameters.AddWithValue("@team2Id", team2Id);

                command.ExecuteNonQuery();
            }
        }
    }
}
