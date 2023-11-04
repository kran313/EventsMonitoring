using EventsMonitoring.CommonClasses;
using FonbetMonitoring;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EventsMonitoring.Parsing
{
    public class BetcityParsing
    {
        public static Dictionary<string, Event> GetMatches(string lineLive)
        {
            using (ZipWebClient wc = new ZipWebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var jsonText = wc.DownloadString(@"https://ad.betcity.ru/d/off/events");
                var betcityEvents = JsonConvert.DeserializeObject<EventsReply>(jsonText).reply.sports.ToList();

                Dictionary<string, Event> betcityMatches = new Dictionary<string, Event>();

                foreach (var sport in betcityEvents)
                {
                    var sportName = sport.Value.name_sp;
                    var sportId = sport.Value.id_sp;

                    foreach (var champ in sport.Value.chmps)
                    {
                        var branchName = champ.Value.name_cp;
                        var branchId = champ.Value.id_cp;

                        if (ForbiddenSubStrings.isAllowed(branchName, lineLive))
                        {
                            continue;
                        }

                            foreach (var match in champ.Value.evts)
                        {

                            try
                            {

                                var matchId = match.Value.id_ev;
                                var matchStartTime = match.Value.date_ev;
                                Team team1 = new Team(sportName, match.Value.id_ht, match.Value.name_ht);
                                Team team2 = new Team(sportName, match.Value.id_at, match.Value.name_at);

                                betcityMatches[matchId] = new Event(matchId, sportName, branchName, team1, team2, matchStartTime);
                            }
                            catch (Exception)
                            {
                            }

                        }
                    }
                }
                return betcityMatches;
            }
        } 
    }


    public class EventsReply
    {
        public Reply reply { get; set; }
        public bool ok { get; set; }
        public int lng { get; set; }
    }

    public class Reply
    {
        public string curr_time { get; set; }
        public int ntime_templates { get; set; }
        public int ntime_vg { get; set; }
        public int ntime { get; set; }
        public Dictionary<int, Sport> sports { get; set; }
    }


    public class Sport
    {
        public int id_sp { get; set; }
        public string name_sp { get; set; }
        public int order { get; set; }
        public Dictionary<int, Championship> chmps { get; set; }

    }


    public class Championship
    {
        public int id_cp { get; set; }
        public string name_cp { get; set; }

        public Dictionary<int, BetcityEvent> evts { get; set; }
    }


    public class BetcityEvent
    {
        public bool IsActive { get; set; }
        public string id_ev { get; set; }
        public int is_online { get; set; }
        public long date_ev { get; set; }
        public string date_ev_str { get; set; }
        public int md_ev { get; set; }
        public int is_live { get; set; }
        public string id_ht { get; set; }
        public string id_at { get; set; }
           
        public string name_ht { get; set; }
        public string name_at { get; set; }
    }
}
