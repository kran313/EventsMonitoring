using EventsMonitoring.CommonClasses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FonbetMonitoring
{
    public static class BaltBetParsing
    {
        public static Team team1;
        public static Team team2;
        public static Event currentEvent;

        public static Dictionary<string, Event> GetMatches(string lineLive)
        {
            if (lineLive == "exclusive")
            {
                lineLive = "line";
            }

            using (ZipWebClient wc = new ZipWebClient())
            {
                string link;
                if (lineLive == "line")
                {
                    link = "https://lineevent:7001/lineevent";
                }
                else
                {
                    link = "https://lineevent:7001/LiveEvent";
                }

                var jsonText = wc.DownloadString(link);
                var baltBetEvents = JsonConvert.DeserializeObject<List<BaltBetEvent>>(jsonText);
                Dictionary<string, Event> baltBetMatches = new Dictionary<string, Event>();
                Dictionary<string, List<Event>> dubles = new Dictionary<string, List<Event>>();

                foreach (var match in baltBetEvents)
                {
                    if (match.away1Id == "0")
                    {
                        continue;
                    }
                    if (match.away2Id != "0")
                    {
                        team1 = new Team(match.sport, match.home1Id, match.home1Name, match.home2Id, match.home2Name);
                        team2 = new Team(match.sport, match.away1Id, match.away1Name, match.away2Id, match.away2Name);
                    }
                    else
                    {
                        team1 = new Team(match.sport, match.home1Id, match.home1Name);
                        team2 = new Team(match.sport, match.away1Id, match.away1Name);
                    }

                    if ((match.sport == "Волейбол" && match.branch.branchName.Contains("Статистика")) ||
                        
                        (ForbiddenSubStrings.isAllowed(match.branch.branchName, lineLive)))
                    {
                        if (match.branch.branchName.ToLower().Contains("футбол. россия. 2-я лига."))
                        {
                            match.sport = "Хоккей";
                        }

                        currentEvent = new Event(match.eventId, match.sport, match.branch.branchName, team1, team2, match.startTime, "Baltbet");


                        if (!dubles.ContainsKey(currentEvent.team1.teamId))
                        {
                            dubles[currentEvent.team1.teamId] = new List<Event> { currentEvent };
                        }
                        else
                        {
                            foreach (var matchEvent in dubles[currentEvent.team1.teamId])
                            {
                                var timeDifference = Math.Abs((int)currentEvent.startTime.Subtract(matchEvent.startTime).TotalMinutes);
                                if (timeDifference < 720)
                                {
                                    currentEvent.status = "Дубль";
                                    currentEvent.linkedBaltBetMatchID = matchEvent.matchID;

                                    matchEvent.status = "Дубль";
                                    matchEvent.linkedBaltBetMatchID = currentEvent.matchID;
                                }
                            }
                            dubles[currentEvent.team1.teamId].Add(currentEvent);
                        }

                        baltBetMatches[match.eventId] = currentEvent;
                    }
                }
                return baltBetMatches;
            }
        }
    }

    public class BaltBetBranch
    {
        public string branchId { get; set; }
        public string branchName { get; set; }
    }
    public class BaltBetEventType
    {
        public string eventTypeId { get; set; }
        public string eventTypeText { get; set; }
    }
    public class BaltBetEvent
    {
        public string eventId { get; set; }
        public string sport { get; set; }
        public string name { get; set; }
        public DateTime startTime { get; set; }
        public BaltBetBranch branch { get; set; }
        public string home1Id { get; set; }
        public string home1Name { get; set; }
        public string home2Id { get; set; }
        public string home2Name { get; set; }
        public string away1Id { get; set; }
        public string away1Name { get; set; }
        public string away2Id { get; set; }
        public string away2Name { get; set; }
    }
}
