using EventsMonitoring.CommonClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsMonitoring
{
    public partial class MatchingForm : Form
    {
        public Event bookmakerMatch;
        public List<Event> matchesToDisplay;
        Dictionary<string, Event> baltBetMatches;
        public Dictionary<string, Dictionary<string, string>> pairs = MatchingDatabase.GetMatchings();

        public MatchingForm(Event selectedMatch, Dictionary<string, Event> baltBetMatches)
        {
            InitializeComponent();
            bookmakerMatch = selectedMatch;
            this.baltBetMatches = baltBetMatches;

            bookmakerBranchLabel.Text = $"{bookmakerMatch.startTime}     {bookmakerMatch.branch}";
            bookmakerTeamsLabel.Text = $"{bookmakerMatch.team1} - {bookmakerMatch.team2}";
        }

        private void MatchingForm_Load(object sender, EventArgs e)
        {
            matchesToDisplay = new List<Event>();
            foreach (var baltBetMatch in baltBetMatches.Values)
            {
                if (baltBetMatch != null && !baltBetMatch.isStatistic &&
                    baltBetMatch.sport == bookmakerMatch.sport &&
                    Math.Abs((baltBetMatch.startTime - bookmakerMatch.startTime).TotalDays) <= 3 &&
                    (PossibleMatch(baltBetMatch.team1.teamName, bookmakerMatch.team1.teamName) ||
                        PossibleMatch(baltBetMatch.team2.teamName, bookmakerMatch.team2.teamName) ||
                        PossibleMatch(baltBetMatch.team1.teamName, bookmakerMatch.team2.teamName) ||
                        PossibleMatch(baltBetMatch.team2.teamName, bookmakerMatch.team1.teamName)))
                {
                    matchesToDisplay.Add(baltBetMatch);
                }
            }
            matchesToDisplay = matchesToDisplay.
                OrderBy(t => t.branch).
                ThenBy(t => t.team1.teamName).
                ThenBy(t => t.team2.teamName).ToList();
            dataGridView1.DataSource = matchesToDisplay;
        }


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Event selectedMatch = dataGridView1.SelectedRows[0].DataBoundItem as Event;
            baltbetMatchIDTextBox.Text = selectedMatch.matchID;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            string baltBetMatchID = baltbetMatchIDTextBox.Text;

            if (!pairs.ContainsKey(bookmakerMatch.sport))
            {
                pairs[bookmakerMatch.sport] = new Dictionary<string, string>();
            }

            if (!int.TryParse(baltBetMatchID, out int number) || !baltBetMatches.ContainsKey(baltBetMatchID))
            {
                MessageBox.Show("Введите корректный ID матча");
            }
            else
            {
                if (!reverseCheckBox.Checked)
                {
                    if (pairs[bookmakerMatch.sport].ContainsKey(bookmakerMatch.team1.teamId) && pairs[bookmakerMatch.sport][bookmakerMatch.team1.teamId] != baltBetMatches[baltBetMatchID].team1.teamId)
                    {
                        SameIdForm sameIdForm = new SameIdForm(baltBetMatches[baltBetMatchID].team1.teamName, pairs[bookmakerMatch.sport][bookmakerMatch.team1.teamId], baltBetMatches[baltBetMatchID].team1.teamId);
                        if (sameIdForm.ShowDialog() == DialogResult.OK)
                        {
                            MatchingDatabase.AddMatching(bookmakerMatch.sport, bookmakerMatch.team1.teamId, baltBetMatches[baltBetMatchID].team1.teamId, bookmakerMatch.team1.teamName, baltBetMatches[baltBetMatchID].team1.teamName);
                        }
                    }
                    else
                    {
                        MatchingDatabase.AddMatching(bookmakerMatch.sport, bookmakerMatch.team1.teamId, baltBetMatches[baltBetMatchID].team1.teamId, bookmakerMatch.team1.teamName, baltBetMatches[baltBetMatchID].team1.teamName);
                    }

                    if (pairs[bookmakerMatch.sport].ContainsKey(bookmakerMatch.team2.teamId) && pairs[bookmakerMatch.sport][bookmakerMatch.team2.teamId] != baltBetMatches[baltBetMatchID].team2.teamId)
                    {
                        SameIdForm sameIdForm = new SameIdForm(baltBetMatches[baltBetMatchID].team2.teamName, pairs[bookmakerMatch.sport][bookmakerMatch.team2.teamId], baltBetMatches[baltBetMatchID].team2.teamId);
                        if (sameIdForm.ShowDialog() == DialogResult.OK)
                        {
                            MatchingDatabase.AddMatching(bookmakerMatch.sport, bookmakerMatch.team2.teamId, baltBetMatches[baltBetMatchID].team2.teamId, bookmakerMatch.team2.teamName, baltBetMatches[baltBetMatchID].team2.teamName);
                        }
                    }
                    else
                    {
                        MatchingDatabase.AddMatching(bookmakerMatch.sport, bookmakerMatch.team2.teamId, baltBetMatches[baltBetMatchID].team2.teamId, bookmakerMatch.team2.teamName, baltBetMatches[baltBetMatchID].team2.teamName);
                    }
                }
                else
                {
                    if (pairs[bookmakerMatch.sport].ContainsKey(bookmakerMatch.team1.teamId) && pairs[bookmakerMatch.sport][bookmakerMatch.team1.teamId] != baltBetMatches[baltBetMatchID].team2.teamId)
                    {
                        SameIdForm sameIdForm = new SameIdForm(baltBetMatches[baltBetMatchID].team2.teamName, pairs[bookmakerMatch.sport][bookmakerMatch.team1.teamId], baltBetMatches[baltBetMatchID].team2.teamId);
                        if (sameIdForm.ShowDialog() == DialogResult.OK)
                        {
                            MatchingDatabase.AddMatching(bookmakerMatch.sport, bookmakerMatch.team1.teamId, baltBetMatches[baltBetMatchID].team2.teamId, bookmakerMatch.team1.teamName, baltBetMatches[baltBetMatchID].team2.teamName);
                        }
                    }
                    else
                    {
                        MatchingDatabase.AddMatching(bookmakerMatch.sport, bookmakerMatch.team1.teamId, baltBetMatches[baltBetMatchID].team2.teamId, bookmakerMatch.team1.teamName, baltBetMatches[baltBetMatchID].team2.teamName);
                    }

                    if (pairs[bookmakerMatch.sport].ContainsKey(bookmakerMatch.team2.teamId) && pairs[bookmakerMatch.sport][bookmakerMatch.team2.teamId] != baltBetMatches[baltBetMatchID].team1.teamId)
                    {
                        SameIdForm sameIdForm = new SameIdForm(baltBetMatches[baltBetMatchID].team1.teamName, pairs[bookmakerMatch.sport][bookmakerMatch.team2.teamId], baltBetMatches[baltBetMatchID].team1.teamId);
                        if (sameIdForm.ShowDialog() == DialogResult.OK)
                        {
                            MatchingDatabase.AddMatching(bookmakerMatch.sport, bookmakerMatch.team2.teamId, baltBetMatches[baltBetMatchID].team1.teamId, bookmakerMatch.team2.teamName, baltBetMatches[baltBetMatchID].team1.teamName);
                        }
                    }
                    else
                    {
                        MatchingDatabase.AddMatching(bookmakerMatch.sport, bookmakerMatch.team2.teamId, baltBetMatches[baltBetMatchID].team1.teamId, bookmakerMatch.team2.teamName, baltBetMatches[baltBetMatchID].team1.teamName);
                    }
                }

                this.DialogResult = DialogResult.OK;
            }
        }


        private static bool PossibleMatch(string name1, string name2)
        {
            name1 = name1.ToLower();
            name2 = name2.ToLower();

            List<string> toDelete = new List<string>() { "(ж)", "u18", "u19", "u20", "u21", "u22", "u23",
                                                         "(18)", "(19)", "(20)", "(21)", "(22)", "(23)",
                                                         "(м)", "(мол)", "(р)", "(рез)", "(студ)", "-", "." };

            foreach (var item in toDelete)
            {
                name1 = name1.Replace(item, " ");
                name2 = name2.Replace(item, " ");
            }

            name1 = name1.Trim();
            name2 = name2.Trim();

            if (!name1.Contains(" ") && !name2.Contains(" "))
            {
                char[] name1ToChar = name1.ToCharArray();
                char[] name2ToChar = name2.ToCharArray();

                double missLetters = (double)Math.Max(
                                    name1ToChar.Distinct().Except(name2ToChar.Distinct()).Count(),
                                    name2ToChar.Distinct().Except(name1ToChar.Distinct()).Count()
                                    ) / Math.Min(name1ToChar.Length, name2ToChar.Length);

                if (missLetters <= 0.25 && Math.Abs(name1ToChar.Length - name2ToChar.Length) < 2)
                {
                    return true;
                }
            }

            else
            {
                string[] name1Array = name1.Split(' ').Where(t => t != "").ToArray();
                string[] name2Array = name2.Split(' ').Where(t => t != "").ToArray();

                if (name1Array.Length == name2Array.Length && name1Array.Length == 2)
                {
                    if (name2Array[0].Length > 2 && name2Array[1].Length > 2)
                    {
                        if (PossibleMatch(name1Array[0], name2Array[0]) || PossibleMatch(name1Array[1], name2Array[1]) ||
                            PossibleMatch(name1Array[0], name2Array[1]) || PossibleMatch(name1Array[1], name2Array[0]))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (PossibleMatch(name1Array[0], name2Array[0]) && name1Array[1][0] == name2Array[1][0] ||
                            PossibleMatch(name1Array[1], name2Array[1]) && name1Array[0][0] == name2Array[0][0] ||
                            PossibleMatch(name1Array[1], name2Array[0]) && name1Array[0][0] == name2Array[1][0] ||
                            PossibleMatch(name1Array[0], name2Array[1]) && name1Array[1][0] == name2Array[0][0])
                        {
                            return true;
                        }
                    }
                }

                else
                {
                    int sum = 0;
                    for (int i = 0; i < name1Array.Length; i++)
                    {
                        for (int j = 0; j < name2Array.Length; j++)
                        {
                            if (PossibleMatch(name1Array[i], name2Array[j]))
                            {
                                sum++;
                                if (sum > 1)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
            dataGridView1.DataSource = baltBetMatches.Values.Where(
                t => t.sport == bookmakerMatch.sport &&
                !t.isStatistic &&
                (t.branch.ToLower().Contains(textBox1.Text.ToLower()) ||
                t.team1.teamName.ToLower().Contains(textBox1.Text.ToLower()) ||
                t.team2.teamName.ToLower().Contains(textBox1.Text.ToLower()))
                ).ToList();
        }

        private void matchingFormQuestionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это окно для связвания команд.\n" + 
                            "Сверху отображается основная информация по матчу с Фонбета. Нужно вставить ID соответствующего матча с Балтбета внизу экрана. Если команды идут в обратном порядке, то поставить галочку в поле Обратный порядок.\n\n" + 
                            "В таблице посередине будет представлен список возможных совпадений. Если там есть нужный матч, кликните по нему 2 раза и ID матча автоматически подставится в нужное поле.\n" + 
                            "Если среди представленных матчей нужного нет, тогда в поле поиск всех матчей по подстроке начните вводить название ветки или название любого из участников. В таблице снизу будут появлять все матчи, в которых есть введеная вами подстрока.\n" + 
                            "Если и после этого нужного матча нет, тогда можно вручную вставить ID матча.\n" + 
                            "Как только нужный ID найден, нажмите кнопу Связать команды.\n\n" + 
                            "В случае если связать не удастся, нажмите кнопку отмена, обновите события и попробуйте еще раз (возможно ID не успел подтянуться).", "Связывание команд");
        }
    }
}
