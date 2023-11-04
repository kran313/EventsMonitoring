using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsMonitoring.CommonClasses
{
    public class Team
    {
        public string sport { get; set; }
        public string teamId { get; set; }
        public string teamName { get; set; }

        public string teamId1 { get; set; }
        public string teamName1 { get; set; }
        public string teamId2 { get; set; }
        public string teamName2 { get; set; }

        public Team(string sport, string teamId, string teamName)
        {
            this.sport = sport;
            this.teamId = teamId;
            this.teamName = teamName;
        }

        public Team(string sport, string teamId1, string teamName1, string teamId2, string teamName2)
        {
            this.sport = sport;
            teamId = $"{teamId1}/{teamId2}";
            teamName = $"{teamName1}/{teamName2}";
        }
        public override string ToString()
        {
            return teamName;
        }
    }
}
