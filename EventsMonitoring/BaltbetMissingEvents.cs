using EventsMonitoring.CommonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsMonitoring
{
    public class BaltbetMissingEvents
    {
        public static List<Event> GetMatches(Dictionary<(string, string), List<Event>> baltBetMatches,
                                             Dictionary<(string, string), List<Event>> fonBetMatches)
        {
            var matchesToDisplay = new List<Event>();

            foreach (var baltBetPairID in baltBetMatches.Keys)
            {
                if (!fonBetMatches.ContainsKey(baltBetPairID) && !fonBetMatches.ContainsKey((baltBetPairID.Item2, baltBetPairID.Item1)))
                {
                    foreach (var baltbetMatch in baltBetMatches[baltBetPairID])
                    {
                        if (baltbetMatch.startTime > DateTime.Now)
                        {
                            matchesToDisplay.Add(baltbetMatch);
                        }
                    }
                }
                else
                {
                    if (fonBetMatches.ContainsKey(baltBetPairID))
                    {
                        foreach (var baltbetMatch in baltBetMatches[baltBetPairID])
                        {
                            int flag = 0;
                            foreach (var fonbetMatch in fonBetMatches[baltBetPairID])
                            {
                                if (Math.Abs(baltbetMatch.startTime.Subtract(fonbetMatch.startTime).TotalMinutes) <= 900)
                                {
                                    flag = 1;
                                }
                            }
                            if (flag == 0)
                            {
                                if (baltbetMatch.startTime > DateTime.Now)
                                {
                                    matchesToDisplay.Add(baltbetMatch);
                                }
                            }
                        }
                    }

                    else
                    {
                        foreach (var baltbetMatch in baltBetMatches[baltBetPairID])
                        {
                            int flag = 0;
                            foreach (var fonbetMatch in fonBetMatches[(baltBetPairID.Item2, baltBetPairID.Item1)])
                            {
                                if (Math.Abs(baltbetMatch.startTime.Subtract(fonbetMatch.startTime).TotalMinutes) <= 900)
                                {
                                    flag = 1;
                                }
                            }
                            if (flag == 0)
                            {
                                if (baltbetMatch.startTime > DateTime.Now)
                                {
                                    matchesToDisplay.Add(baltbetMatch);
                                }
                            }
                        }
                    }
                    
                }
            }
            return matchesToDisplay;
        }
    }
}
