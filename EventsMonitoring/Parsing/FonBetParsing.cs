using EventsMonitoring.CommonClasses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FonbetMonitoring
{
    public static class FonBetParsing
    {
        public static Dictionary<string, Event> GetMatches(string lineLive)
        {
            if (lineLive == "exclusive")
            {
                lineLive = "line";
            }
            using (ZipWebClient wc = new ZipWebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var jsonText = wc.DownloadString(@"https://line02w.bk6bba-resources.com/events/listBase?lang=ru&scopeMarket=1600");
                var fonBetEvents = JsonConvert.DeserializeObject<FonBetEventFon>(jsonText);

                Dictionary<string, SportFonBet> sportFonBet = new Dictionary<string, SportFonBet>();
                foreach (var item in fonBetEvents.sports)
                    sportFonBet[item.id] = new SportFonBet(item.id, item.parentId, item.name);

                Dictionary<string, Event> allFonbetMatches = new Dictionary<string, Event>();
                Dictionary<string, Event> filteredFonbetMatches = new Dictionary<string, Event>();

                foreach (var item in fonBetEvents.events)
                {
                    string sport = sportFonBet[sportFonBet[item.sportId].parentId].name;
                    string branch;
                    Team? teamHome = null;
                    Team? teamAway = null;

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

                    if (sport == "Волейбол" && new List<string>() { "эйсы", "ошибки на подаче", "блоки" }.Any(t => branch.Contains(t)))
                    {
                        allFonbetMatches[item.id] = new Event(
                            item.id, 
                            sport, 
                            branch, 
                            new Team(sport, teamHome.teamId + "(" + item.name + ")", teamHome.teamName + "(" + item.name + ")"),
                            new Team(sport, teamAway.teamId + "(" + item.name + ")", teamAway.teamName + "(" + item.name + ")"), 
                            item.startTime, 
                            item.sportId, 
                            item.name, 
                            item.place, 
                            "Fonbet"
                            );
                    }
                    else
                    {
                        allFonbetMatches[item.id] = new Event(
                            item.id, 
                            sport, 
                            branch, 
                            teamHome, 
                            teamAway, 
                            item.startTime, 
                            item.sportId, 
                            item.name, 
                            item.place, 
                            "Fonbet"
                            );
                    }


                    if ((sport == "Волейбол" && 
                        item.place == lineLive && 
                        new List<string>() { "эйсы", "ошибки на подаче", "блоки" }.Any(t => branch.Contains(t))) ||
                        
                        (ForbiddenSubStrings.isAllowed(branch, lineLive) && 
                        item.place == lineLive &&
                        teamAway.teamId != "0" && 
                        item.level == 1))
                    {
                        filteredFonbetMatches[item.id] = allFonbetMatches[item.id];
                    }
                }
                return filteredFonbetMatches;
            }
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
