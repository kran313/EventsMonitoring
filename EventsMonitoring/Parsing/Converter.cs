using EventsMonitoring;
using EventsMonitoring.CommonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FonbetMonitoring
{
    public static class Converter
    {
        public static Dictionary<(string, string), List<Event>> Convert(Dictionary<string, Event> matchesID)
        {
            Dictionary<(string, string), List<Event>> convertedMatches = new Dictionary<(string, string), List<Event>>();

            foreach (var match in matchesID.Values)
            {
                if (match.isStatistic)
                {
                    continue;
                }

                if (!convertedMatches.ContainsKey((match.team1.teamId, match.team2.teamId)))
                {
                    convertedMatches[(match.team1.teamId, match.team2.teamId)] = new List<Event>();
                }

                convertedMatches[(match.team1.teamId, match.team2.teamId)].Add(match);
            }

            return convertedMatches;
        }


        public static Dictionary<(string, string), List<Event>> ConvertAndChangeIDs(Dictionary<string, Event> matchesID, string source)
        {
            string team1ID;
            string team2ID;
            var matchings = MatchingDatabase.GetMatchingsTeams();
            Dictionary<(string, string), List<Event>> convertedMatchesAndChangedIDs = new Dictionary<(string, string), List<Event>>();

            foreach (var match in matchesID.Values)
            {

                if (!(matchings.ContainsKey(match.team1.teamId) && matchings.ContainsKey(match.team2.teamId)))
                {
                    match.status = "Нет данных";
                    team1ID = match.team1.teamId;
                    team2ID = match.team2.teamId;
                }
                else
                {
                    team1ID = matchings[match.team1.teamId];
                    team2ID = matchings[match.team2.teamId];
                }


                if (!convertedMatchesAndChangedIDs.ContainsKey((team1ID, team2ID)))
                {
                    convertedMatchesAndChangedIDs[(team1ID, team2ID)] = new List<Event>();
                }

                convertedMatchesAndChangedIDs[(team1ID, team2ID)].Add(match);
            }

            return convertedMatchesAndChangedIDs;
        }
    }
}
