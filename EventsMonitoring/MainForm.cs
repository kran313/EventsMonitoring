using EventsMonitoring.CommonClasses;
using EventsMonitoring.Parsing;
using FonbetMonitoring;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;

namespace EventsMonitoring
{
    public partial class MainForm : Form
    {
        public List<Event> matchesToDisplay;
        public List<Event> matchesToDisplayDubles;
        public Dictionary<string, Event> hiddenMatches;
        public List<string> hiddenBranches;
        public List<string> hiddenSports;
        public Dictionary<string, Event> baltBetMatches;
        public Dictionary<string, Event> fonBetMatches;
        public Dictionary<(string, string), List<Event>> baltBetMatchesConverted;
        public Dictionary<(string, string), List<Event>> fonBetMatchesConverted;
        public List<string> rememberedCheckedSportTypes;
        public DateTime savedTime;
        public bool isLive;
        public bool isStatistic;
        public bool isExclusive;
        public bool flag;
        public int sortIndex = -1;
        public string[] qwaszx;

        public MainForm()
        {
            InitializeComponent();
            hiddenMatches = new Dictionary<string, Event>();
            hiddenBranches = new List<string>();
            hiddenSports = new List<string>();
            isLive = false;
            isStatistic = false;
            isExclusive = false;
            flag = false;
            rememberedCheckedSportTypes = new List<string>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("checkedSportTypes.txt"))
            {
                StreamReader sr = new StreamReader("checkedSportTypes.txt");

                while (!sr.EndOfStream)
                {
                    rememberedCheckedSportTypes.Add(sr.ReadLine());
                }

                sr.Close();

                if (rememberedCheckedSportTypes[0] == "1")
                {
                    isLive = true;
                    liveRadioButton.Checked = true;
                }
                if (rememberedCheckedSportTypes[1] == "1")
                {
                    isStatistic = true;
                    statisticCheckBox.Checked = true;
                }

                for (var i = 0; i < sportTypesCheckedListBox.Items.Count; i++)
                {
                    if (rememberedCheckedSportTypes.Contains(sportTypesCheckedListBox.Items[i]))
                    {
                        sportTypesCheckedListBox.SetItemCheckState(i, CheckState.Checked);
                    }
                }
            }

            panel1.Dock = DockStyle.Fill;
            dataGridView1.Dock = DockStyle.Fill;

            panel1.Visible = false;
            dataGridView1.Visible = true;

            dataGridView2.DataSource = new List<Hidden>();
            dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic, isExclusive);


            dataGridView1.Columns[0].Width = 140;
            dataGridView1.Columns[5].Width = 110;
            dataGridView1.Columns[3].Width = 230;
            dataGridView1.Columns[4].Width = 230;
            dataGridView1.Columns[2].Width = 1300 - 140 - 110 - 230 - 230;
        }


        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                dataGridView1.DataSource = new List<Event>();

                panel1.Visible = !panel1.Visible;
                dataGridView1.Visible = !dataGridView1.Visible;
            }

            dataGridView2.DataSource = new List<Hidden>();
            dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic, isExclusive);
        }


        public List<Event> GetMatchesToDisplay(bool isLive, int sortIndex, bool isStatistic, bool isExclusive)
        {
            DateTime currentTime = DateTime.Now;

            if (Math.Abs(savedTime.Subtract(currentTime).TotalSeconds) > 3 || flag == true)
            {
                savedTime = currentTime;
                baltBetMatches = BaltBetParsing.GetMatches(isLive, isStatistic);
                fonBetMatches = FonBetParsing.GetMatches(isLive, isStatistic);

                flag = false;
            }


            matchesToDisplay = FonbetMissingEvents.GetMatches(baltBetMatches, fonBetMatches, isExclusive);



            if (!(sportTypesCheckedListBox.CheckedItems.Contains("Все виды спорта") || sportTypesCheckedListBox.CheckedItems.Count == 0))
            {
                matchesToDisplay = matchesToDisplay.Where(t => sportTypesCheckedListBox.CheckedItems.Contains(t.sport)).ToList();
            }

            if (isLive)
            {
                matchesToDisplay = matchesToDisplay.Where(t => t.status != "Ок" && !t.status.Contains("Время")).ToList();
            }

            else
            {
                if (!AllTimeRadioButton.Checked)
                {
                    int timeDelta = int.MaxValue;
                    if (OneHourRadioButton.Checked)
                        timeDelta = 60 * 60 * 1;
                    else if (ThreeHoursRadioButton.Checked)
                        timeDelta = 60 * 60 * 3;
                    else if (SixHoursRadioButton.Checked)
                        timeDelta = 60 * 60 * 6;
                    else if (TwelweHoursRadioButton.Checked)
                        timeDelta = 60 * 60 * 12;
                    else if (OneDayRadioButton.Checked)
                        timeDelta = 60 * 60 * 24;
                    else if (TwoDaysRadioButton.Checked)
                        timeDelta = 60 * 60 * 48;
                    else if (OneWeekRadioButton.Checked)
                        timeDelta = 60 * 60 * 24 * 7;


                    DateTime timeToWatch = DateTime.UtcNow.AddSeconds(60 * 60 * 3 + timeDelta);
                    matchesToDisplay = matchesToDisplay.Where(t => t.startTime <= timeToWatch).ToList();
                }

            }

            matchesToDisplayDubles = baltBetMatches.Values.Where(t => t.status == "Дубль" || t.status == "Нужно проверить основной матч").ToList();
            matchesToDisplayDubles.AddRange(matchesToDisplay);

            matchesToDisplayDubles = matchesToDisplayDubles.Where(t => !hiddenMatches.Keys.Contains(t.matchID) && !hiddenBranches.Contains(t.branch) && !hiddenSports.Contains(t.sport)).ToList();

            if (sortIndex == 5)
            {
                return matchesToDisplayDubles.
                    OrderBy(t => t.startTime).
                    ThenBy(t => t.branch).
                    ToList();
            }
            else if (sortIndex == 2)
            {
                return matchesToDisplayDubles.
                    OrderBy(t => t.branch).
                    ThenBy(t => t.startTime).
                    ToList();
            }
            else if (sortIndex == 0)
            {
                return matchesToDisplayDubles.
                    OrderBy(t => t.status).
                    ThenBy(t => t.branch).
                    ThenBy(t => t.startTime).
                    ToList();
            }
            else if (sortIndex == 3)
            {
                return matchesToDisplayDubles.
                    OrderBy(t => t.team1.teamName).
                    ThenBy(t => t.branch).
                    ThenBy(t => t.startTime).
                    ToList();
            }
            else if (sortIndex == 4)
            {
                return matchesToDisplayDubles.
                    OrderBy(t => t.team2.teamName).
                    ThenBy(t => t.branch).
                    ThenBy(t => t.startTime).
                    ToList();
            }
            else
            {
                return matchesToDisplayDubles;
            }
        }


        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {

                }
                else
                {
                    var hti = dataGridView1.HitTest(e.X, e.Y);
                    dataGridView1.ClearSelection();
                    if (hti.RowIndex != -1)
                    {
                        dataGridView1.Rows[hti.RowIndex].Selected = true;
                    }
                }
            }
        }

        private void dataGridView1_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            if (isExclusive)
            {
                EventContextMenuStrip.Enabled = false;
            }
            else
            {
                EventContextMenuStrip.Enabled = true;
            }


            if (dataGridView1.SelectedRows.Count > 1)
            {
                EventContextMenuStrip.Items[0].Visible = false;
                EventContextMenuStrip.Items[1].Visible = false;
                EventContextMenuStrip.Items[3].Visible = false;
                EventContextMenuStrip.Items[2].Text = "Скрыть события";
            }
            else
            {
                EventContextMenuStrip.Items[0].Visible = true;
                EventContextMenuStrip.Items[1].Visible = true;
                EventContextMenuStrip.Items[3].Visible = true;
                EventContextMenuStrip.Items[2].Text = "Скрыть событие";

                Event selectedMatch = dataGridView1.SelectedRows[0].DataBoundItem as Event;

                if (new List<string> { "Нет матча/поменялся ID", "Нет данных", "" }.Contains(selectedMatch.status))
                {
                    EventContextMenuStrip.Items[1].Text = "Скопировать инфо о матче";
                    EventContextMenuStrip.Items[0].Enabled = true;
                }
                else
                {
                    EventContextMenuStrip.Items[1].Text = "Скопировать ID матча";
                    EventContextMenuStrip.Items[0].Enabled = false;
                }
            }

            e.ContextMenuStrip = EventContextMenuStrip;


            //SaveIDToolStripMenuItem.Click += SaveIDToolStripMenuItem_Click;
            //MatchingToolStripMenuItem.Click += MatchingToolStripMenuItem_Click;
            //HideEventToolStripMenuItem.Click += HideEventToolStripMenuItem_Click;

        }


        private void SaveIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Event selectedMatch = dataGridView1.SelectedRows[0].DataBoundItem as Event;

            if (selectedMatch.linkedBaltBetMatchID != "")
            {
                Clipboard.SetText(selectedMatch.linkedBaltBetMatchID, TextDataFormat.UnicodeText);
            }
            else if (selectedMatch.status == "Baltbet")
            {
                Clipboard.SetText(selectedMatch.matchID, TextDataFormat.UnicodeText);
            }
            else
            {
                Clipboard.SetText($"{selectedMatch.startTime}  {selectedMatch.branch}  {selectedMatch.team1.teamName} - {selectedMatch.team2.teamName}", TextDataFormat.UnicodeText);
            }
        }

        private void MatchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Event selectedMatch = dataGridView1.SelectedRows[0].DataBoundItem as Event;
            int selectedMatchIndex = dataGridView1.SelectedRows[0].Index;


            if (selectedMatch.status == "Baltbet")
            {

            }
            else if (selectedMatch.isStatistic)
            {
                MessageBox.Show("Статистику нельзя связывать");
            }
            else
            {
                Event matchingMatch;

                matchingMatch = fonBetMatches[selectedMatch.matchID];


                if (!selectedMatch.status.Contains("Дубль") || !selectedMatch.status.Contains("Нужно проверить основной матч"))
                {
                    MatchingForm form = new MatchingForm(matchingMatch, baltBetMatches);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // dataGridView1.DataSource = new List<Event>();
                        dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic, isExclusive);
                        dataGridView1.ClearSelection();

                        if (dataGridView1.RowCount <= 1)
                        {

                        }
                        else if (dataGridView1.RowCount > selectedMatchIndex)
                        {
                            dataGridView1.FirstDisplayedScrollingRowIndex = selectedMatchIndex > 10 ? selectedMatchIndex - 10 : 0;
                            dataGridView1.Rows[selectedMatchIndex].Selected = true;
                        }
                        else
                        {
                            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                            dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Смотри примечание!");
                }
            }

        }


        private void lineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lineRadioButton.Checked)
            {
                isLive = false;
                timeIntervalGroupBox.Visible = true;
                exclusiveCheckBox.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                dataGridView2.Visible = true;
            }
            else
            {
                isLive = true; ;
                timeIntervalGroupBox.Visible = false;
                exclusiveCheckBox.Checked = false;
                exclusiveCheckBox.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                dataGridView2.Visible = false;
            }

            flag = true;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                sortIndex = 5;
                dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic, isExclusive);
            }
            else if (e.ColumnIndex == 2)
            {
                sortIndex = 2;
                dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic, isExclusive);
            }
            else if (e.ColumnIndex == 0)
            {
                sortIndex = 0;
                dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic, isExclusive);
            }
            else if (e.ColumnIndex == 3)
            {
                sortIndex = 3;
                dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic, isExclusive);
            }
            else if (e.ColumnIndex == 4)
            {
                sortIndex = 4;
                dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic, isExclusive);
            }
            else
            {
                sortIndex = -1;
                dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic, isExclusive);
            }
        }

        private void statisticCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (statisticCheckBox.Checked)
            {
                isStatistic = true;
            }
            else
            {
                isStatistic = false; ;
            }
        }

        private void HideBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Event selectedMatch = dataGridView1.SelectedRows[0].DataBoundItem as Event;
            int selectedMatchIndex = dataGridView1.SelectedRows[0].Index;
            hiddenBranches.Add(selectedMatch.branch);

            // dataGridView1.DataSource = new List<Event>();
            dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic, isExclusive);
            dataGridView1.ClearSelection();


            if (dataGridView1.RowCount <= 1)
            {

            }
            else if (dataGridView1.RowCount > selectedMatchIndex)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = selectedMatchIndex > 10 ? selectedMatchIndex - 10 : 0;
                dataGridView1.Rows[selectedMatchIndex].Selected = true;
            }
            else
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
            }
        }

        private void HideSportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Event selectedMatch = dataGridView1.SelectedRows[0].DataBoundItem as Event;
            int selectedMatchIndex = dataGridView1.SelectedRows[0].Index;
            hiddenSports.Add(selectedMatch.sport);

            // dataGridView1.DataSource = new List<Event>();
            dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic, isExclusive);
            dataGridView1.ClearSelection();


            if (dataGridView1.RowCount <= 1)
            {

            }
            else if (dataGridView1.RowCount > selectedMatchIndex)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = selectedMatchIndex > 10 ? selectedMatchIndex - 10 : 0;
                dataGridView1.Rows[selectedMatchIndex].Selected = true;
            }
            else
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
            }
        }

        private void mainFormQuestionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это основное окно программы.\n" +
                            "Нажав на шестеренку, можно выбрать настройки для отображающихся матчей.\n" +
                            "Нажав на стрелки, обновится список из потенциально некорректных или отсутствующих матчей в сравнении с Фонбетом.\n\n" +
                            "В колонке Примечание возможны следующие варианты:\n" +
                            "Время чч:мм - показывает на сколько часов и минут матч не совпадает.\n" +
                            "Дубль - если у нас есть матч, в котором совпадает первая или вторая команда.\n" +
                            "Перевертыш - если у нас команды в обратном порядке.\n" +
                            "Нет данных - хотя бы одна из команд не связана.\n" +
                            "Нет матча/поменялся ID - либо этого матча у нас нет, либо у одной из команд сменился ID.\n" +
                            "Не совпадают названия команд - названия команд в статистике не совпадают с родительскими названиями. Или такую статистику просто нужно скрыть, для этого напишите мне\n\n" +
                            "Для взаимодействия с любым матчем нужно нажать на него правой клавишей мышки и выбрать один из пунктов меню:\n" +
                            "Скрыть событие/ветку/спорт - в списке матчей перестанет показываться текущее событие/ветка/спорт только на вашем компьютере.\n" +
                            "Скопировать ID матча - если в колонке примечание указано Время, Дубль или Перевертыш, тогда в память скопируется ID нашего матча. В ином случае скопируется полная информация о матче с Фонбета.\n" +
                            "Связать команды - если в колонке примечание указано Нет данных или Нет матча/поменялся ID, то нужно связать ID команд. После связывание матч либо исчезнет, если с ним все ок, либо останется и в колонке примечание будет написана причина.\n" +
                            "Матчи статистики связать нельзя, они должны автоматически пропадать, если все хорошо.\n\n\n" +
                            "По всем вопросам/предложениям/ошибкам писать Литвинову Артему в дискорд.", "Основное окно");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sr = new StreamWriter("checkedSportTypes.txt", false);

            if (liveRadioButton.Checked)
            {
                sr.WriteLine("1");
            }
            else
            {
                sr.WriteLine("0");
            }

            if (statisticCheckBox.Checked)
            {
                sr.WriteLine("1");
            }
            else
            {
                sr.WriteLine("0");
            }


            for (var i = 0; i < sportTypesCheckedListBox.Items.Count; i++)
            {
                if (sportTypesCheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    sr.WriteLine(sportTypesCheckedListBox.Items[i]);
                }
            }

            sr.Close();
        }

        private void hideEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                for (var i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Event selectedMatch = dataGridView1.SelectedRows[i].DataBoundItem as Event;
                    hiddenMatches[selectedMatch.matchID] = selectedMatch;
                }
                var selectedMatchIndex = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(t => t.Index).ToList().Min();

                dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic, isExclusive);
                dataGridView1.ClearSelection();


                if (dataGridView1.RowCount <= 1)
                {

                }
                else if (dataGridView1.RowCount > selectedMatchIndex)
                {
                    dataGridView1.FirstDisplayedScrollingRowIndex = selectedMatchIndex > 10 ? selectedMatchIndex - 10 : 0;
                    dataGridView1.Rows[selectedMatchIndex].Selected = true;
                }
                else
                {
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
                }
            }
            else
            {
                Event selectedMatch = dataGridView1.SelectedRows[0].DataBoundItem as Event;
                int selectedMatchIndex = dataGridView1.SelectedRows[0].Index;
                hiddenMatches[selectedMatch.matchID] = selectedMatch;

                // dataGridView1.DataSource = new List<Event>();
                dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic, isExclusive);
                dataGridView1.ClearSelection();


                if (dataGridView1.RowCount <= 1)
                {

                }
                else if (dataGridView1.RowCount > selectedMatchIndex)
                {
                    dataGridView1.FirstDisplayedScrollingRowIndex = selectedMatchIndex > 10 ? selectedMatchIndex - 10 : 0;
                    dataGridView1.Rows[selectedMatchIndex].Selected = true;
                }
                else
                {
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
                }
            }
        }

        private void exclusiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (exclusiveCheckBox.Checked)
            {
                isExclusive = true;
                statisticCheckBox.Checked = false;
                statisticCheckBox.Enabled = false;
            }
            else
            {
                isExclusive = false;
                statisticCheckBox.Enabled = true;
            }
        }

        private void hudeMenuBarButton_Click(object sender, EventArgs e)
        {

            panel1.Visible = !panel1.Visible;
            dataGridView1.Visible = !dataGridView1.Visible;
        }



        public class Hidden
        {
            public string id { get; set; }
            public string sport { get; set; }
            public string branch { get; set; }
            public string match { get; set; }
            public CheckState state { get; set; }

            public Hidden(string id, string sport, string branch, string match, CheckState state = CheckState.Unchecked)
            {
                this.id = id;
                this.sport = sport;
                this.branch = branch;
                this.match = match;
                this.state = state;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var tempHiddenMatches = new List<Hidden>();
            foreach (var item in hiddenMatches.Values)
            {
                if (item.startTime > DateTime.Now)
                {
                    tempHiddenMatches.Add(new Hidden(item.matchID, item.sport, item.branch, $"{item.team1.teamName} - {item.team2.teamName}"));
                }
                else
                {
                    hiddenMatches.Remove(item.matchID);
                }
            }
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[2].Visible = true;
            dataGridView2.Columns[3].Visible = true;

            dataGridView2.DataSource = tempHiddenMatches;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tempHiddenBranches = new List<Hidden>();
            foreach (var item in hiddenBranches)
            {
                tempHiddenBranches.Add(new Hidden("Ветка", "", item, ""));
            }
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[2].Visible = true;
            dataGridView2.Columns[3].Visible = false;

            dataGridView2.DataSource = tempHiddenBranches;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var tempHiddenSports = new List<Hidden>();
            foreach (var item in hiddenSports)
            {
                tempHiddenSports.Add(new Hidden("Спорт", item, "", ""));
            }
            dataGridView2.Columns[1].Visible = true;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[3].Visible = false;

            dataGridView2.DataSource = tempHiddenSports;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                Hidden hiddenLine = dataGridView2.Rows[i].DataBoundItem as Hidden;
                if (hiddenLine.state == CheckState.Checked)
                {
                    if (hiddenLine.id == "Ветка")
                    {
                        hiddenBranches.Remove(hiddenLine.branch);
                    }
                    else if (hiddenLine.id == "Спорт")
                    {
                        hiddenSports.Remove(hiddenLine.sport);
                    }
                    else
                    {
                        hiddenMatches.Remove(hiddenLine.id);
                    }
                }
            }
            var data = dataGridView2.DataSource as List<Hidden>;
            dataGridView2.DataSource = data.Where(t => t.state == CheckState.Unchecked).ToList();
        }
    }
}