using EventsMonitoring;
using EventsMonitoring.CommonClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FonbetMonitoring
{
    public class FonbetMissingEvents
    {
        public static List<Event> GetMatches(Dictionary<string, Event> baltBetMatchesSource,
                                             Dictionary<string, Event> fonBetMatchesSource,
                                             bool isExclusive)
        {

            var baltBetMatches = Converter.Convert(baltBetMatchesSource);
            var fonBetMatches = Converter.ConvertAndChangeIDs(fonBetMatchesSource, "fonbet");

            var baltBetMatchesStatistics = baltBetMatchesSource.Values.Where(t => t.isStatistic).ToList();
            var fonBetMatchesStatistics = fonBetMatchesSource.Values.Where(t => t.isStatistic).ToList();

            var matchesToDisplay = new List<Event>();


            foreach (var fonBetPairID in fonBetMatches.Keys)
            {
                foreach (var fonbetMatch in fonBetMatches[fonBetPairID])
                {

                    if (fonbetMatch.isStatistic)
                    {
                        continue;
                    }


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
                                    fonbetMatch.linkedBaltBetMatchID = baltbetMatch.matchID;
                                    break;
                                }
                                else if (
                                    Math.Abs(fonbetMatch.startTime.Subtract(baltbetMatch.startTime).TotalMinutes) >= 30 && 
                                    baltbetMatch.sport == "Теннис")
                                {
                                    fonbetMatch.status = "Ок";
                                    fonbetMatch.linkedBaltBetMatchID = baltbetMatch.matchID;
                                    break;
                                }


                            }

                            foreach (var baltbetMatch in baltBetMatches[fonBetPairID])
                            {
                                if (baltbetMatch.sport != "Теннис")
                                {
                                    if (baltbetMatch != null && fonbetMatch.sport == baltbetMatch.sport && baltbetMatch.status != "ок" &&
                                    Math.Abs(fonbetMatch.startTime.Subtract(baltbetMatch.startTime).TotalMinutes) >= 30 &&
                                    Math.Abs(fonbetMatch.startTime.Subtract(baltbetMatch.startTime).TotalMinutes) < 60 * 24)
                                    {
                                        var timeDifference = (int)fonbetMatch.startTime.Subtract(baltbetMatch.startTime).TotalMinutes;

                                        if (timeDifference > 0)
                                        {
                                            fonbetMatch.status = $"У нас раньше на {timeDifference / 60} : {timeDifference % 60}";
                                        }
                                        else
                                        {
                                            fonbetMatch.status = $"У нас позже на {-timeDifference / 60} : {-timeDifference % 60}";
                                        }

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

            var matchings = MatchingDatabase.GetMatchingsTeams();

            foreach (var fonBetMatchStatistic in fonBetMatchesStatistics)
            {
                if (matchings.ContainsKey(fonBetMatchStatistic.parent1ID) && matchings.ContainsKey(fonBetMatchStatistic.parent2ID))
                {

                    if (baltBetMatchesStatistics.Where(
                        t => 
                        t.parent1ID == matchings[fonBetMatchStatistic.parent1ID] &&
                        t.parent2ID == matchings[fonBetMatchStatistic.parent2ID] &&
                        t.statistic == fonBetMatchStatistic.statistic).Count() > 0
                     )
                    {
                        continue;
                    }
                    else
                    {
                        fonBetMatchStatistic.status = "Нет данных";
                        matchesToDisplay.Add(fonBetMatchStatistic);
                    }
                }
 
            }

            return matchesToDisplay;
        }
    }
}
