using EventsMonitoring.CommonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FonbetMonitoring
{
    public class FonbetMissingEvents
    {
        public static List<Event> GetMatches(Dictionary<(string, string), List<Event>> baltBetMatches, 
                                             Dictionary<(string, string), List<Event>> fonBetMatches)
        {
            var matchesToDisplay = new List<Event>();

            foreach (var fonBetPairID in fonBetMatches.Keys)
            {
                foreach (var fonbetMatch in fonBetMatches[fonBetPairID])
                {
                    if (fonbetMatch.status == "Ок")
                    {
                        continue;
                    }
                    else if (fonbetMatch.status == "Нет данных")
                    {
                        matchesToDisplay.Add(fonbetMatch);
                    }
                    else
                    {
                        if (baltBetMatches.ContainsKey(fonBetPairID))
                        {
                            foreach (var baltbetMatch in baltBetMatches[fonBetPairID])
                            {
                                if (Math.Abs(fonbetMatch.startTime.Subtract(baltbetMatch.startTime).TotalMinutes) < 30)
                                {
                                    fonbetMatch.status = "Ок";
                                    break;
                                }
                            }

                            foreach (var baltbetMatch in baltBetMatches[fonBetPairID])
                            {
                                if (baltbetMatch.sport != "Теннис")
                                {
                                    if (baltbetMatch != null && fonbetMatch.sport == baltbetMatch.sport && baltbetMatch.status != "ок" &&
                                    Math.Abs(fonbetMatch.startTime.Subtract(baltbetMatch.startTime).TotalMinutes) >= 30 &&
                                    Math.Abs(fonbetMatch.startTime.Subtract(baltbetMatch.startTime).TotalMinutes) < 1440)
                                    {
                                        var timeDifference = Math.Abs((int)fonbetMatch.startTime.Subtract(baltbetMatch.startTime).TotalMinutes);
                                        fonbetMatch.status = $"Время {timeDifference/60} : {timeDifference%60}";
                                        fonbetMatch.linkedBaltBetMatchID = baltbetMatch.matchID;
                                        matchesToDisplay.Add(fonbetMatch);
                                    }
                                }
                            }
                        }
                        else if (baltBetMatches.ContainsKey((fonBetPairID.Item2, fonBetPairID.Item1)))
                        {
                            foreach (var baltbetMatch in baltBetMatches[(fonBetPairID.Item2, fonBetPairID.Item1)])
                            {
                                if (baltbetMatch != null && fonbetMatch.sport == baltbetMatch.sport && Math.Abs(fonbetMatch.startTime.Subtract(baltbetMatch.startTime).TotalMinutes) <= 720)
                                {
                                    fonbetMatch.status = "Перевертыш";
                                    fonbetMatch.linkedBaltBetMatchID = baltbetMatch.matchID;
                                    matchesToDisplay.Add(fonbetMatch);
                                }
                            }
                        }

                        else
                        {
                            fonbetMatch.status = "Нет матча/поменялся ID";
                            matchesToDisplay.Add(fonbetMatch);
                        }
                    }
                }
            }
            return matchesToDisplay;
        }
    }
}
