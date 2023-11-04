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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lineLiveGroupBox = new GroupBox();
            ExclusiveRadioButton = new RadioButton();
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
            panel1.Size = new Size(200, 901);
            panel1.TabIndex = 1;
            // 
            // lineLiveGroupBox
            // 
            lineLiveGroupBox.Controls.Add(ExclusiveRadioButton);
            lineLiveGroupBox.Controls.Add(liveRadioButton);
            lineLiveGroupBox.Controls.Add(lineRadioButton);
            lineLiveGroupBox.Location = new Point(13, 74);
            lineLiveGroupBox.Name = "lineLiveGroupBox";
            lineLiveGroupBox.Size = new Size(167, 131);
            lineLiveGroupBox.TabIndex = 5;
            lineLiveGroupBox.TabStop = false;
            // 
            // ExclusiveRadioButton
            // 
            ExclusiveRadioButton.AutoSize = true;
            ExclusiveRadioButton.Location = new Point(7, 93);
            ExclusiveRadioButton.Name = "ExclusiveRadioButton";
            ExclusiveRadioButton.Size = new Size(106, 25);
            ExclusiveRadioButton.TabIndex = 2;
            ExclusiveRadioButton.TabStop = true;
            ExclusiveRadioButton.Text = "Эксклюзив";
            ExclusiveRadioButton.UseVisualStyleBackColor = true;
            ExclusiveRadioButton.Visible = false;
            // 
            // liveRadioButton
            // 
            liveRadioButton.AutoSize = true;
            liveRadioButton.Location = new Point(7, 61);
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
            refreshButton.Location = new Point(13, 12);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(167, 55);
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
            timeIntervalGroupBox.Location = new Point(3, 606);
            timeIntervalGroupBox.Name = "timeIntervalGroupBox";
            timeIntervalGroupBox.Size = new Size(181, 290);
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
            label1.Location = new Point(10, 233);
            label1.Name = "label1";
            label1.Size = new Size(182, 22);
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
            sportTypesCheckedListBox.Items.AddRange(new object[] { "Футбол", "Теннис", "Баскетбол", "Единоборства", "Бокс", "Гандбол", "Хоккей", "Волейбол", "Футзал", "Бейсбол", "Шахматы", "Хоккей с мячом", "Пляжный футбол", "Все виды спорта" });
            sportTypesCheckedListBox.Location = new Point(10, 258);
            sportTypesCheckedListBox.Name = "sportTypesCheckedListBox";
            sportTypesCheckedListBox.Size = new Size(182, 336);
            sportTypesCheckedListBox.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SourceColumn, IDColumn, StartTimeColumn, BranchColumn, Team1Column, Team2Column });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(200, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1284, 901);
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
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1284, 0);
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
            ClientSize = new Size(1484, 901);
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
        private RadioButton ExclusiveRadioButton;
        private RadioButton SixHoursRadioButton;
    }
}