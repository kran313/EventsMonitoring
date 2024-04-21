namespace EventsMonitoring
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lineLiveGroupBox = new GroupBox();
            statisticCheckBox = new CheckBox();
            liveRadioButton = new RadioButton();
            lineRadioButton = new RadioButton();
            refreshButton = new Button();
            timeIntervalGroupBox = new GroupBox();
            SixHoursRadioButton = new RadioButton();
            AllTimeRadioButton = new RadioButton();
            OneWeekRadioButton = new RadioButton();
            TwoDaysRadioButton = new RadioButton();
            OneDayRadioButton = new RadioButton();
            TwelweHoursRadioButton = new RadioButton();
            ThreeHoursRadioButton = new RadioButton();
            OneHourRadioButton = new RadioButton();
            label1 = new Label();
            sportTypesCheckedListBox = new CheckedListBox();
            dataGridView1 = new DataGridView();
            SourceColumn = new DataGridViewTextBoxColumn();
            IDColumn = new DataGridViewTextBoxColumn();
            StartTimeColumn = new DataGridViewTextBoxColumn();
            BranchColumn = new DataGridViewTextBoxColumn();
            Team1Column = new DataGridViewTextBoxColumn();
            Team2Column = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            SaveIDToolStripMenuItem = new ToolStripMenuItem();
            MatchingToolStripMenuItem = new ToolStripMenuItem();
            HideEventToolStripMenuItem = new ToolStripMenuItem();
            EventContextMenuStrip = new ContextMenuStrip(components);
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            lineLiveGroupBox.SuspendLayout();
            timeIntervalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            EventContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lineLiveGroupBox);
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(timeIntervalGroupBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(sportTypesCheckedListBox);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 861);
            panel1.TabIndex = 1;
            // 
            // lineLiveGroupBox
            // 
            lineLiveGroupBox.Controls.Add(statisticCheckBox);
            lineLiveGroupBox.Controls.Add(liveRadioButton);
            lineLiveGroupBox.Controls.Add(lineRadioButton);
            lineLiveGroupBox.Location = new Point(3, 73);
            lineLiveGroupBox.Name = "lineLiveGroupBox";
            lineLiveGroupBox.Size = new Size(215, 95);
            lineLiveGroupBox.TabIndex = 5;
            lineLiveGroupBox.TabStop = false;
            // 
            // statisticCheckBox
            // 
            statisticCheckBox.AutoSize = true;
            statisticCheckBox.Location = new Point(7, 60);
            statisticCheckBox.Name = "statisticCheckBox";
            statisticCheckBox.Size = new Size(109, 25);
            statisticCheckBox.TabIndex = 6;
            statisticCheckBox.Text = "Статистика";
            statisticCheckBox.UseVisualStyleBackColor = true;
            statisticCheckBox.CheckedChanged += statisticCheckBox_CheckedChanged;
            // 
            // liveRadioButton
            // 
            liveRadioButton.AutoSize = true;
            liveRadioButton.Location = new Point(107, 29);
            liveRadioButton.Name = "liveRadioButton";
            liveRadioButton.Size = new Size(64, 25);
            liveRadioButton.TabIndex = 1;
            liveRadioButton.Text = "Лайв";
            liveRadioButton.UseVisualStyleBackColor = true;
            // 
            // lineRadioButton
            // 
            lineRadioButton.AutoSize = true;
            lineRadioButton.Checked = true;
            lineRadioButton.Location = new Point(7, 29);
            lineRadioButton.Name = "lineRadioButton";
            lineRadioButton.Size = new Size(74, 25);
            lineRadioButton.TabIndex = 0;
            lineRadioButton.TabStop = true;
            lineRadioButton.Text = "Линия";
            lineRadioButton.UseVisualStyleBackColor = true;
            lineRadioButton.CheckedChanged += lineRadioButton_CheckedChanged;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(3, 12);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(215, 55);
            refreshButton.TabIndex = 4;
            refreshButton.Text = "Обновить";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // timeIntervalGroupBox
            // 
            timeIntervalGroupBox.Controls.Add(SixHoursRadioButton);
            timeIntervalGroupBox.Controls.Add(AllTimeRadioButton);
            timeIntervalGroupBox.Controls.Add(OneWeekRadioButton);
            timeIntervalGroupBox.Controls.Add(TwoDaysRadioButton);
            timeIntervalGroupBox.Controls.Add(OneDayRadioButton);
            timeIntervalGroupBox.Controls.Add(TwelweHoursRadioButton);
            timeIntervalGroupBox.Controls.Add(ThreeHoursRadioButton);
            timeIntervalGroupBox.Controls.Add(OneHourRadioButton);
            timeIntervalGroupBox.ForeColor = SystemColors.WindowText;
            timeIntervalGroupBox.Location = new Point(3, 574);
            timeIntervalGroupBox.Name = "timeIntervalGroupBox";
            timeIntervalGroupBox.Size = new Size(215, 284);
            timeIntervalGroupBox.TabIndex = 3;
            timeIntervalGroupBox.TabStop = false;
            timeIntervalGroupBox.Text = "Временной интервал";
            // 
            // SixHoursRadioButton
            // 
            SixHoursRadioButton.AutoSize = true;
            SixHoursRadioButton.Location = new Point(7, 93);
            SixHoursRadioButton.Name = "SixHoursRadioButton";
            SixHoursRadioButton.Size = new Size(82, 25);
            SixHoursRadioButton.TabIndex = 7;
            SixHoursRadioButton.TabStop = true;
            SixHoursRadioButton.Text = "6 часов";
            SixHoursRadioButton.UseVisualStyleBackColor = true;
            // 
            // AllTimeRadioButton
            // 
            AllTimeRadioButton.AutoSize = true;
            AllTimeRadioButton.Checked = true;
            AllTimeRadioButton.Location = new Point(7, 253);
            AllTimeRadioButton.Name = "AllTimeRadioButton";
            AllTimeRadioButton.Size = new Size(100, 25);
            AllTimeRadioButton.TabIndex = 6;
            AllTimeRadioButton.TabStop = true;
            AllTimeRadioButton.Text = "Все время";
            AllTimeRadioButton.UseVisualStyleBackColor = true;
            // 
            // OneWeekRadioButton
            // 
            OneWeekRadioButton.AutoSize = true;
            OneWeekRadioButton.Location = new Point(7, 221);
            OneWeekRadioButton.Name = "OneWeekRadioButton";
            OneWeekRadioButton.Size = new Size(80, 25);
            OneWeekRadioButton.TabIndex = 5;
            OneWeekRadioButton.Text = "Неделя";
            OneWeekRadioButton.UseVisualStyleBackColor = true;
            // 
            // TwoDaysRadioButton
            // 
            TwoDaysRadioButton.AutoSize = true;
            TwoDaysRadioButton.Location = new Point(7, 189);
            TwoDaysRadioButton.Name = "TwoDaysRadioButton";
            TwoDaysRadioButton.Size = new Size(67, 25);
            TwoDaysRadioButton.TabIndex = 4;
            TwoDaysRadioButton.Text = "2 дня";
            TwoDaysRadioButton.UseVisualStyleBackColor = true;
            // 
            // OneDayRadioButton
            // 
            OneDayRadioButton.AutoSize = true;
            OneDayRadioButton.Location = new Point(7, 157);
            OneDayRadioButton.Name = "OneDayRadioButton";
            OneDayRadioButton.Size = new Size(75, 25);
            OneDayRadioButton.TabIndex = 3;
            OneDayRadioButton.Text = "1 день";
            OneDayRadioButton.UseVisualStyleBackColor = true;
            // 
            // TwelweHoursRadioButton
            // 
            TwelweHoursRadioButton.AutoSize = true;
            TwelweHoursRadioButton.Location = new Point(7, 125);
            TwelweHoursRadioButton.Name = "TwelweHoursRadioButton";
            TwelweHoursRadioButton.Size = new Size(91, 25);
            TwelweHoursRadioButton.TabIndex = 2;
            TwelweHoursRadioButton.Text = "12 часов";
            TwelweHoursRadioButton.UseVisualStyleBackColor = true;
            // 
            // ThreeHoursRadioButton
            // 
            ThreeHoursRadioButton.AutoSize = true;
            ThreeHoursRadioButton.Location = new Point(7, 61);
            ThreeHoursRadioButton.Name = "ThreeHoursRadioButton";
            ThreeHoursRadioButton.Size = new Size(73, 25);
            ThreeHoursRadioButton.TabIndex = 1;
            ThreeHoursRadioButton.Text = "3 часа";
            ThreeHoursRadioButton.UseVisualStyleBackColor = true;
            // 
            // OneHourRadioButton
            // 
            OneHourRadioButton.AutoSize = true;
            OneHourRadioButton.Location = new Point(7, 29);
            OneHourRadioButton.Name = "OneHourRadioButton";
            OneHourRadioButton.Size = new Size(65, 25);
            OneHourRadioButton.TabIndex = 0;
            OneHourRadioButton.Text = "1 час";
            OneHourRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(3, 191);
            label1.Name = "label1";
            label1.Size = new Size(215, 22);
            label1.TabIndex = 1;
            label1.Text = "Виды спорта";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // sportTypesCheckedListBox
            // 
            sportTypesCheckedListBox.BackColor = SystemColors.Control;
            sportTypesCheckedListBox.BorderStyle = BorderStyle.None;
            sportTypesCheckedListBox.CheckOnClick = true;
            sportTypesCheckedListBox.FormattingEnabled = true;
            sportTypesCheckedListBox.Items.AddRange(new object[] { "Все виды спорта", "Футбол", "Хоккей", "Баскетбол", "Теннис", "Волейбол", "Гандбол", "Бейсбол", "Бокс", "Единоборства", "Австралийский футбол", "Авто-Мотоспорт", "Американский футбол", "Бадминтон", "Баскетбол 3х3", "Биатлон", "Бильярд", "Велоспорт", "Водное поло", "Горные лыжи", "Керлинг", "Лыжи", "Настольный теннис", "Нетбол", "Пляжный волейбол", "Пляжный футбол", "Прыжки с трамплина", "Регби", "Снукер", "Софтбол", "Флорбол", "Формула 1", "Футзал", "Хоккей на траве", "Хоккей с мячом", "Шары", "Шахматы" });
            sportTypesCheckedListBox.Location = new Point(3, 216);
            sportTypesCheckedListBox.Name = "sportTypesCheckedListBox";
            sportTypesCheckedListBox.Size = new Size(215, 336);
            sportTypesCheckedListBox.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SourceColumn, IDColumn, StartTimeColumn, BranchColumn, Team1Column, Team2Column });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(227, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1257, 860);
            dataGridView1.TabIndex = 0;
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            dataGridView1.RowContextMenuStripNeeded += dataGridView1_RowContextMenuStripNeeded;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // 
            // SourceColumn
            // 
            SourceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SourceColumn.DataPropertyName = "status";
            SourceColumn.HeaderText = "Примечание";
            SourceColumn.Name = "SourceColumn";
            SourceColumn.Width = 103;
            // 
            // IDColumn
            // 
            IDColumn.DataPropertyName = "matchID";
            IDColumn.HeaderText = "Матч ID";
            IDColumn.Name = "IDColumn";
            IDColumn.Visible = false;
            IDColumn.Width = 75;
            // 
            // StartTimeColumn
            // 
            StartTimeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            StartTimeColumn.DataPropertyName = "startTime";
            StartTimeColumn.HeaderText = "Время начала";
            StartTimeColumn.Name = "StartTimeColumn";
            StartTimeColumn.ReadOnly = true;
            // 
            // BranchColumn
            // 
            BranchColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BranchColumn.DataPropertyName = "branch";
            BranchColumn.HeaderText = "Ветка";
            BranchColumn.Name = "BranchColumn";
            BranchColumn.ReadOnly = true;
            // 
            // Team1Column
            // 
            Team1Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Team1Column.DataPropertyName = "team1";
            Team1Column.HeaderText = "Команда 1";
            Team1Column.Name = "Team1Column";
            Team1Column.ReadOnly = true;
            Team1Column.Width = 82;
            // 
            // Team2Column
            // 
            Team2Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Team2Column.DataPropertyName = "team2";
            Team2Column.HeaderText = "Команда 2";
            Team2Column.Name = "Team2Column";
            Team2Column.ReadOnly = true;
            Team2Column.Width = 82;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(221, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1263, 0);
            panel2.TabIndex = 2;
            // 
            // SaveIDToolStripMenuItem
            // 
            SaveIDToolStripMenuItem.Name = "SaveIDToolStripMenuItem";
            SaveIDToolStripMenuItem.Size = new Size(196, 22);
            SaveIDToolStripMenuItem.Text = "Скопировать ID матча";
            SaveIDToolStripMenuItem.Click += SaveIDToolStripMenuItem_Click;
            // 
            // MatchingToolStripMenuItem
            // 
            MatchingToolStripMenuItem.Name = "MatchingToolStripMenuItem";
            MatchingToolStripMenuItem.Size = new Size(196, 22);
            MatchingToolStripMenuItem.Text = "Связать команды";
            MatchingToolStripMenuItem.Click += MatchingToolStripMenuItem_Click;
            // 
            // HideEventToolStripMenuItem
            // 
            HideEventToolStripMenuItem.Name = "HideEventToolStripMenuItem";
            HideEventToolStripMenuItem.Size = new Size(196, 22);
            HideEventToolStripMenuItem.Text = "Скрыть событие";
            HideEventToolStripMenuItem.Click += HideEventToolStripMenuItem_Click;
            // 
            // EventContextMenuStrip
            // 
            EventContextMenuStrip.Items.AddRange(new ToolStripItem[] { SaveIDToolStripMenuItem, MatchingToolStripMenuItem, HideEventToolStripMenuItem });
            EventContextMenuStrip.Name = "contextMenuStrip1";
            EventContextMenuStrip.Size = new Size(197, 70);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1484, 861);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monitoring";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            lineLiveGroupBox.ResumeLayout(false);
            lineLiveGroupBox.PerformLayout();
            timeIntervalGroupBox.ResumeLayout(false);
            timeIntervalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            EventContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox timeIntervalGroupBox;
        private System.Windows.Forms.RadioButton AllTimeRadioButton;
        private System.Windows.Forms.RadioButton OneWeekRadioButton;
        private System.Windows.Forms.RadioButton TwoDaysRadioButton;
        private System.Windows.Forms.RadioButton OneDayRadioButton;
        private System.Windows.Forms.RadioButton TwelweHoursRadioButton;
        private System.Windows.Forms.RadioButton ThreeHoursRadioButton;
        private System.Windows.Forms.RadioButton OneHourRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox sportTypesCheckedListBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team2Column;
        private System.Windows.Forms.ToolStripMenuItem SaveIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MatchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HideEventToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip EventContextMenuStrip;
        private System.Windows.Forms.GroupBox lineLiveGroupBox;
        private System.Windows.Forms.RadioButton liveRadioButton;
        private System.Windows.Forms.RadioButton lineRadioButton;
        private RadioButton SixHoursRadioButton;
        private ToolTip toolTip1;
        private CheckBox statisticCheckBox;
    }
}