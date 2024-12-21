using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsMonitoring.CommonClasses
{
    public class Event
    {
        public string status { get; set; }
        public string matchID { get; set; }
        public string sport;
        public Branch branch { get; set; }
        public Team team1 { get; set; }
        public Team team2 { get; set; }
        public DateTime startTime { get; set; }
        public int firstAppear { get; set; }
        public string source {  get; set; }
        public string multiparsing { get; set; }
        public bool isStatistic;
        public string statistic;
        public string parent1ID;
        public string parent2ID;
        public string sportId;
        public string name;
        public bool place;
        public int level;
        public string linkedBaltBetMatchID;


        //FonBet
        public Event(string id, string sport, Branch branch, Team team1, Team team2, long startTime, string sportId, string name, bool place, 
                     int level, bool isStatistic = false, string statistic = "", string parent1ID = "", string parent2ID = "", string status = "",
                     string source = "", string multiparsing = "")
        {
            matchID = id;
            this.sport = sport;
            this.branch = branch;
            this.team1 = team1;
            this.team2 = team2;
            this.startTime = UnixTimeStampToDateTime(startTime);
            this.status = status;
            this.sportId = sportId;
            this.name = name;
            this.place = place;
            this.level = level;
            this.isStatistic = isStatistic;
            this.statistic = statistic;
            this.parent1ID = parent1ID;
            this.parent2ID = parent2ID;
            linkedBaltBetMatchID = "";
            firstAppear = 0;
            this.source = source;
            this.multiparsing = multiparsing;
        }

        //Betcity
        public Event(string id, string sport, Branch branch, Team team1, Team team2, long startTime, bool isStatistic = false, 
            string parent1ID = "", string parent2ID = "", string status = "", string source = "", string multiparsing = "")
        {
            matchID = id;
            this.sport = sport;
            this.branch = branch;
            this.team1 = team1;
            this.team2 = team2;
            this.startTime = UnixTimeStampToDateTime(startTime);
            this.isStatistic = isStatistic;
            this.parent1ID = parent1ID;
            this.parent2ID = parent2ID;
            this.status = status;
            linkedBaltBetMatchID = "";
            firstAppear = 0;
            this.source = source;
            this.multiparsing = multiparsing;
        }


        //BaltBet
        public Event(string id, string sport, Branch branch, Team team1, Team team2, DateTime startTime, bool isStatistic = false,
                     string statistic = "", string parent1ID = "", string parent2ID = "", string status = "", 
                     string source = "", string multiparsing = "")
        {
            matchID = id;
            this.sport = sport;
            this.branch = branch;
            this.team1 = team1;
            this.team2 = team2;
            this.startTime = startTime;
            this.status = status;
            this.isStatistic = isStatistic;
            this.statistic = statistic;
            this.parent1ID = parent1ID;
            this.parent2ID = parent2ID;
            linkedBaltBetMatchID = "";
            firstAppear = 0;
            this.source = source;
            this.multiparsing = multiparsing;
        }

        public DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }

    }
}
