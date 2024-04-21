using EventsMonitoring.CommonClasses;
using EventsMonitoring.Parsing;
using FonbetMonitoring;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace EventsMonitoring
{
    public partial class MainForm : Form
    {
        public List<Event> matchesToDisplay;
        public List<Event> matchesToDisplayDubles;
        public List<string> hiddenMatches;
        public Dictionary<string, Event> baltBetMatches;
        public Dictionary<string, Event> fonBetMatches;
        public Dictionary<(string, string), List<Event>> baltBetMatchesConverted;
        public Dictionary<(string, string), List<Event>> fonBetMatchesConverted;
        public DateTime savedTime;
        public bool isLive;
        public bool isStatistic;
        public bool flag;
        public int sortIndex = -1;

        public MainForm()
        {
            InitializeComponent();
            hiddenMatches = new List<string>();
            isLive = false;
            isStatistic = false;
            flag = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic);
        }


        private void refreshButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic);
            if (lineRadioButton.Checked)
            {
                timeIntervalGroupBox.Visible = true;
            }
            else
            {
                timeIntervalGroupBox.Visible = false;
            }
        }


        public List<Event> GetMatchesToDisplay(bool isLive, int sortIndex, bool isStatistic)
        {
            DateTime currentTime = DateTime.Now;

            if (Math.Abs(savedTime.Subtract(currentTime).TotalSeconds) > 3 || flag == true)
            {
                savedTime = currentTime;
                baltBetMatches = BaltBetParsing.GetMatches(isLive, isStatistic);
                baltBetMatchesConverted = Converter.Convert(baltBetMatches);

                fonBetMatches = FonBetParsing.GetMatches(isLive, isStatistic);
                fonBetMatchesConverted = Converter.ConvertAndChangeIDs(fonBetMatches, "fonbet");

                flag = false;
            }



            matchesToDisplay = FonbetMissingEvents.GetMatches(baltBetMatchesConverted, fonBetMatchesConverted);



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

            matchesToDisplayDubles = baltBetMatches.Values.Where(t => t.status == "Дубль").ToList();
            matchesToDisplayDubles.AddRange(matchesToDisplay);

            matchesToDisplayDubles = matchesToDisplayDubles.Where(t => !hiddenMatches.Contains(t.matchID)).ToList();

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
            else
            {
                return matchesToDisplayDubles;
            }
        }


        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dataGridView1.HitTest(e.X, e.Y);
                dataGridView1.ClearSelection();
                if (hti.RowIndex != -1)
                {
                    dataGridView1.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        private void dataGridView1_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
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
            else
            {
                Event matchingMatch;

                matchingMatch = fonBetMatches[selectedMatch.matchID];


                if (!selectedMatch.status.Contains("Дубль"))
                {
                    MatchingForm form = new MatchingForm(matchingMatch, baltBetMatches);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // dataGridView1.DataSource = new List<Event>();
                        dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic);

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
                    MessageBox.Show("Это дубль!!!");
                }
            }

        }

        private void HideEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Event selectedMatch = dataGridView1.SelectedRows[0].DataBoundItem as Event;
            int selectedMatchIndex = dataGridView1.SelectedRows[0].Index;
            hiddenMatches.Add(selectedMatch.matchID);

            // dataGridView1.DataSource = new List<Event>();
            dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic);


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

        private void lineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lineRadioButton.Checked)
            {
                isLive = false;
                timeIntervalGroupBox.Enabled = true;
            }
            else
            {
                isLive = true; ;
                timeIntervalGroupBox.Enabled = false;
            }

            flag = true;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                sortIndex = 5;
                dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic);
            }
            else if (e.ColumnIndex == 2)
            {
                sortIndex = 2;
                dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic);
            }
            else if (e.ColumnIndex == 0)
            {
                sortIndex = 0;
                dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic);
            }
            else
            {
                sortIndex = -1;
                dataGridView1.DataSource = GetMatchesToDisplay(isLive, sortIndex, isStatistic);
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
    }
}