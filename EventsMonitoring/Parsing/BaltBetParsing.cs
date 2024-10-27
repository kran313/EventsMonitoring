using EventsMonitoring.CommonClasses;
using EventsMonitoring.Parsing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FonbetMonitoring
{
    public static class BaltBetParsing
    {
        public static Team team1;
        public static Team team2;
        public static Event currentEvent;

        //ghjgfj
        public static List<BaltBetEvent> GetEvents(bool isLive)
        {
            using (ZipWebClient wc = new ZipWebClient())
            {
                string link = isLive ? "https://lineevent:7001/LiveEvent" : "https://lineevent:7001/lineevent";

                var jsonText = wc.DownloadString(link);

                return JsonConvert.DeserializeObject<List<BaltBetEvent>>(jsonText);
            }
        }


        public static Dictionary<string, Event> GetMatches(bool isLive, bool isStatistic)
        {
            var LineForbiddenStrings = ForbiddenSubStrings.GetForbiddenStrings("Line");
            var LiveForbiddenStrings = ForbiddenSubStrings.GetForbiddenStrings("Live");
            var cyberSportsNames = ForbiddenSubStrings.GetCyberSportsNames();

            var baltBetEvents = GetEvents(isLive);

            Dictionary<string, Event> baltBetMatches = new Dictionary<string, Event>();
            Dictionary<string, List<Event>> dubles = new Dictionary<string, List<Event>>();

            foreach (var match in baltBetEvents)
            {

                if (match.away1Id == "0" || match.home1Name.Contains("Хозяева") || match.branch.branchName.ToLower().Contains("кибер"))
                    continue;


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


                if (ForbiddenSubStrings.isAllowed(match.branch.branchName, isLive, LiveForbiddenStrings, LineForbiddenStrings))
                {

                    if (match.branch.branchName.ToLower().Contains("россия. 2-я лига") && isLive == false)
                    {
                        match.sport = "Хоккей";
                    }


                    var statistic = match.branch.branchName.ToLower()
                        .Replace("e", "е")
                        .Replace("t", "т")
                        .Replace("o", "о")
                        .Replace("p", "р")
                        .Replace("a", "а")
                        .Replace("h", "н")
                        .Replace("k", "к")
                        .Replace("x", "х")
                        .Replace("c", "с")
                        .Replace("b", "в")
                        .Replace("m", "м")
                        .Contains("статистика");


                    if (isStatistic || (!isStatistic && !statistic))
                    {
                        currentEvent = new Event(match.eventId, match.sport, match.branch.branchName, team1, team2, match.startTime, statistic, "Baltbet");
                    }
                    else
                    {
                        continue;
                    }



                    foreach (var possibleDouble in new List<string> { currentEvent.team1.teamId, currentEvent.team2.teamId })
                    {
                        if (!dubles.ContainsKey(possibleDouble))
                        {
                            dubles[possibleDouble] = new List<Event> { currentEvent };
                        }
                        else
                        {
                            foreach (var matchEvent in dubles[possibleDouble])
                            {
                                var timeDifference = Math.Abs((int)currentEvent.startTime.Subtract(matchEvent.startTime).TotalMinutes);
                                if (((timeDifference < 15 && isLive) ||
                                    (timeDifference < 60 * 12 && !isLive && !new List<string> { "Дартс", "Шахматы", "Шары", "Снукер", "Киберспорт" }.Contains(match.sport)) ||
                                    (timeDifference < 60 * 24 * 2 && !isLive && match.sport == "Футбол")) && 
                                    (currentEvent.isStatistic == matchEvent.isStatistic))
                                {
                                    currentEvent.status = "Дубль";
                                    currentEvent.linkedBaltBetMatchID = matchEvent.matchID;

                                    matchEvent.status = "Дубль";
                                    matchEvent.linkedBaltBetMatchID = currentEvent.matchID;
                                }
                            }
                            dubles[possibleDouble].Add(currentEvent);
                        }
                    }

                    baltBetMatches[match.eventId] = currentEvent;
                }
            }

            if (isStatistic)
            {
                foreach (var item in baltBetMatches.Values)                 
                {
                    if (item.isStatistic)
                    {

                        var lastIndexOfTeam1 = item.team1.teamName.LastIndexOf("(");
                        var lastIndexOfTeam2 = item.team2.teamName.LastIndexOf("(");

                        try
                        {
                            var qwerty = baltBetMatches.Where(t => t.Value.team1.teamName == item.team1.teamName[..lastIndexOfTeam1] &&
                                                                   t.Value.team2.teamName == item.team2.teamName[..lastIndexOfTeam2]).First().Value;

                            item.parent1ID = qwerty.team1.teamId;
                            item.parent2ID = qwerty.team2.teamId;
                            item.statistic = item.team1.teamName[(lastIndexOfTeam1+1)..^1];
                        }
                        catch (Exception)
                        {
                            item.status = "Нужно проверить основной матч";
                            item.linkedBaltBetMatchID = item.matchID;
                        }
                    }
                }
            }
            return baltBetMatches;
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
