using EventsMonitoring.CommonClasses;
using Grpc.Net.Client;
using Parser.Contracts.FonbetService;
using System.IO.Compression;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FonbetMonitoring
{

    public static class FonBetParsing
    {
        public static FonBetEventFon GetEvents()
        {
            var data = string.Empty;
            var fonbetProviderUri = "http://172.16.1.187:5007";
            var channel = GrpcChannel.ForAddress(fonbetProviderUri);
            var client = new FonbetDataService.FonbetDataServiceClient(channel);

            var response = client.GetData(new Google.Protobuf.WellKnownTypes.Empty());

            if (response.Algorithm.Equals("gzip")) 
            {   
                data = Decompress(Convert.FromBase64String(response.Data), Encoding.Unicode);
            }


            static string Decompress(byte[] buf, Encoding encoding)
            {
                string result = string.Empty;
                MemoryStream decompressedStream = new MemoryStream();
                using (MemoryStream ms = new MemoryStream(buf))
                {
                    using (GZipStream decompressionStream = new GZipStream(ms, CompressionMode.Decompress))
                        decompressionStream.CopyTo(decompressedStream);

                    result = encoding.GetString(decompressedStream.ToArray(), 0, (int)decompressedStream.Length);
                }
                return result;
            }

            return JsonConvert.DeserializeObject<FonBetEventFon>(data);
        }



        public static Dictionary<string, Event> GetMatches(bool isLive, bool isStatistic)
        {
            var fonBetEvents = GetEvents();
            var statisticsNames = ForbiddenSubStrings.GetStatisticsNames();


            Dictionary<string, SportFonBet> sportFonBet = new Dictionary<string, SportFonBet>();
            foreach (var item in fonBetEvents.sports)
                sportFonBet[item.id] = new SportFonBet(item.id, item.parentId, item.name);

            Dictionary<string, Event> allFonbetMatches = new Dictionary<string, Event>();
            Dictionary<string, Event> filteredFonbetMatches = new Dictionary<string, Event>();


            var LineForbiddenStrings = ForbiddenSubStrings.GetForbiddenStrings("Line");
            var LiveForbiddenStrings = ForbiddenSubStrings.GetForbiddenStrings("Live");
            var fonbetSportNames = ForbiddenSubStrings.GetFonbetSportNames();

            foreach (var item in fonBetEvents.events)
            {
                string sport = sportFonBet[sportFonBet[item.sportId].parentId].name;


                string branch;
                Team? teamHome = null;
                Team? teamAway = null;
                int level = item.level;

                if (level > 2)
                {
                    continue;
                }


                if (item.parentId == null)
                {
                    branch = string.Join(". ", sportFonBet[item.sportId].name, item.name).Trim();
                    teamHome = new Team(sport, item.team1Id, item.team1);
                    teamAway = new Team(sport, item.team2Id, item.team2);
                }
                else
                {
                    branch = string.Join(". ", allFonbetMatches[item.parentId].branch, item.name).Trim();
                    teamHome = allFonbetMatches[item.parentId].team1;
                    teamAway = allFonbetMatches[item.parentId].team2;
                }


                foreach (var fonbetSportName in fonbetSportNames.Keys)
                {
                    if (branch.Contains(fonbetSportName))
                    {
                        sport = fonbetSportNames[fonbetSportName];
                    }
                }



                if (level == 1)
                {
                    allFonbetMatches[item.id] = new Event(
                        item.id, 
                        sport, 
                        branch, 
                        new Team(sport, teamHome.teamId, teamHome.teamName),
                        new Team(sport, teamAway.teamId, teamAway.teamName), 
                        item.startTime, 
                        item.sportId, 
                        item.name, 
                        item.place == "live" ? true : false,
                        item.level,
                        item.level == 1 ? false : true,
                        "",
                        "",
                        "Fonbet"
                        );
                }
                else
                {
                    var qwerty = fonBetEvents.events.Where(t => t.id == item.parentId).First();
                    string statistic = string.Empty;

                    if (statisticsNames.ContainsKey(sport) && statisticsNames[sport].ContainsKey(item.name))
                    {
                        statistic = statisticsNames[sport][item.name];
                    }
                    else
                    {
                        statistic = item.name;
                    }

                    if (sport == "Волейбол" && item.place == "line")
                    {
                        statistic = "статистика";
                    }

                    if (sport == "Баскетбол" && statistic == "основное время")
                    {
                        continue;
                    }



                    allFonbetMatches[item.id] = new Event(
                        item.id,
                        sport,
                        branch,
                        new Team(sport, teamHome.teamId + "(" + item.name + ")", teamHome.teamName + "(" + item.name + ")"),
                        new Team(sport, teamAway.teamId + "(" + item.name + ")", teamAway.teamName + "(" + item.name + ")"),
                        item.startTime,
                        item.sportId,
                        item.name,
                        item.place == "live" ? true : false,
                        item.level,
                        item.level == 1 ? false : true,
                        statistic,
                        qwerty.team1Id,
                        qwerty.team2Id,
                        "Fonbet"
                        );
                }
                


                if (ForbiddenSubStrings.isAllowed(branch, isLive, LiveForbiddenStrings, LineForbiddenStrings) && 
                   (item.place == "live" && isLive == true || item.place == "line" && isLive == false) &&
                    teamAway.teamId != "0" &&
                    (item.level == 1 || item.level == 2 && isStatistic))
                {
                    filteredFonbetMatches[item.id] = allFonbetMatches[item.id];
                }
            }
            return filteredFonbetMatches;
        }
    }


    public class SportFonBet
    {
        public string id;
        public string parentId;
        public string name;

        public SportFonBet(string id, string parentId, string name)
        {
            this.id = id;
            this.parentId = parentId == null ? id : parentId;
            this.name = name;
        }
    }

    public class FonBetCustomFactor
    {
        public int e { get; set; }
        public int countAll { get; set; }
        public List<FonBetFactor> factors { get; set; }
    }

    public class FonBetEvent
    {
        public string id { get; set; }
        public string sortOrder { get; set; }
        public int level { get; set; }
        public int num { get; set; }
        public string sportId { get; set; }
        public int kind { get; set; }
        public int rootKind { get; set; }
        public string team1Id { get; set; }
        public string team2Id { get; set; }
        public string team1 { get; set; }
        public int team1RegionId { get; set; }
        public string team2 { get; set; }
        public int team2RegionId { get; set; }
        public string name { get; set; }
        public long startTime { get; set; }
        public string place { get; set; }
        public string statisticsType { get; set; }
        public int priority { get; set; }
        public string parentId { get; set; }
        public bool? substituteRootEvent { get; set; }
        public int? specialTableId { get; set; }
        public string team1Aliases { get; set; }
    }

    public class FonBetEventBlock
    {
        public string eventId { get; set; }
        public string state { get; set; }
        public List<int> factors { get; set; }
    }

    public class FonBetEventMisc
    {
        public string id { get; set; }
        public int liveDelay { get; set; }
        public int score1 { get; set; }
        public int score2 { get; set; }
        public int timerDirection { get; set; }
        public int timerSeconds { get; set; }
        public object timerUpdateTimestampMsec { get; set; }
        public string comment { get; set; }
    }

    public class FonBetFactor
    {
        public int f { get; set; }
        public double v { get; set; }
        public int p { get; set; }
        public string pt { get; set; }
    }

    public class FonBetLiveEventInfo
    {
        public string eventId { get; set; }
        public string timer { get; set; }
        public int timerSeconds { get; set; }
        public int timerDirection { get; set; }
        public object timerTimestampMsec { get; set; }
        public string scoreFunction { get; set; }
        public List<List<FonBetScore>> scores { get; set; }
        public List<FonBetSubscore> subscores { get; set; }
        public string scoreComment { get; set; }
        public string scoreCommentTail { get; set; }
        public string scoreCommentHead { get; set; }
    }

    public class FonBetEventFon
    {
        public long packetVersion { get; set; }
        public int fromVersion { get; set; }
        public int catalogTablesVersion { get; set; }
        public int catalogSpecialTablesVersion { get; set; }
        public int catalogEventViewVersion { get; set; }
        public int sportBasicMarketsVersion { get; set; }
        public int sportBasicFactorsVersion { get; set; }
        public int independentFactorsVersion { get; set; }
        public long factorsVersion { get; set; }
        public int comboFactorsVersion { get; set; }
        public int sportKindsVersion { get; set; }
        public int topCompetitionsVersion { get; set; }
        public List<FonBetSport> sports { get; set; }
        public List<FonBetEvent> events { get; set; }
        public List<FonBetEventBlock> eventBlocks { get; set; }
        public List<FonBetEventMisc> eventMiscs { get; set; }
        public List<FonBetLiveEventInfo> liveEventInfos { get; set; }
        public List<FonBetCustomFactor> customFactors { get; set; }
    }

    public class FonBetSport
    {
        public string id { get; set; }
        public string kind { get; set; }
        public string sortOrder { get; set; }
        public string name { get; set; }
        public string parentId { get; set; }
        public List<string> parentIds { get; set; }
        public int? regionId { get; set; }
        public List<int> outrightTableOraIds { get; set; }
    }

    public class FonBetSubscore
    {
        public string kindId { get; set; }
        public string kindName { get; set; }
        public string c1 { get; set; }
        public string c2 { get; set; }
        public string alias { get; set; }
        public string comment { get; set; }
    }

    public class FonBetScore
    {
        public string c1 { get; set; }
        public string c2 { get; set; }
        public string title { get; set; }
    }
}
