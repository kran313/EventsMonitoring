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
            panel1 = new Panel();
            panel3 = new Panel();
            panel7 = new Panel();
            button4 = new Button();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewCheckBoxColumn();
            panel6 = new Panel();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            lineLiveGroupBox = new GroupBox();
            statisticCheckBox = new CheckBox();
            liveRadioButton = new RadioButton();
            lineRadioButton = new RadioButton();
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
            hudeMenuBarButton = new Button();
            mainFormQuestionButton = new Button();
            refreshButton = new Button();
            SaveIDToolStripMenuItem = new ToolStripMenuItem();
            MatchingToolStripMenuItem = new ToolStripMenuItem();
            HideToolStripMenuItem = new ToolStripMenuItem();
            HideBranchToolStripMenuItem = new ToolStripMenuItem();
            HideSportToolStripMenuItem = new ToolStripMenuItem();
            EventContextMenuStrip = new ContextMenuStrip(components);
            hideEventToolStripMenuItem = new ToolStripMenuItem();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            SourceColumn = new DataGridViewTextBoxColumn();
            IDColumn = new DataGridViewTextBoxColumn();
            StartTimeColumn = new DataGridViewTextBoxColumn();
            BranchColumn = new DataGridViewTextBoxColumn();
            Team1Column = new DataGridViewTextBoxColumn();
            Team2Column = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel6.SuspendLayout();
            lineLiveGroupBox.SuspendLayout();
            timeIntervalGroupBox.SuspendLayout();
            EventContextMenuStrip.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(lineLiveGroupBox);
            panel1.Controls.Add(timeIntervalGroupBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(sportTypesCheckedListBox);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(8, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1381, 830);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(573, 7);
            panel3.Name = "panel3";
            panel3.Size = new Size(805, 820);
            panel3.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel7.Controls.Add(button4);
            panel7.Controls.Add(dataGridView2);
            panel7.Location = new Point(13, 80);
            panel7.Name = "panel7";
            panel7.Size = new Size(775, 737);
            panel7.TabIndex = 12;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.Location = new Point(240, 669);
            button4.MaximumSize = new Size(260, 54);
            button4.Name = "button4";
            button4.Size = new Size(260, 54);
            button4.TabIndex = 10;
            button4.Text = "Отобразить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column5, Column6, Column2 });
            dataGridView2.Location = new Point(14, 16);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(751, 635);
            dataGridView2.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id";
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.Visible = false;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "sport";
            Column4.FillWeight = 99.4923859F;
            Column4.HeaderText = "Вид спорта";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "branch";
            Column5.FillWeight = 99.4923859F;
            Column5.HeaderText = "Ветка";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "match";
            Column6.FillWeight = 99.4923859F;
            Column6.HeaderText = "Матч";
            Column6.Name = "Column6";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "state";
            Column2.FillWeight = 101.522842F;
            Column2.HeaderText = "Отобразить";
            Column2.Name = "Column2";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.Controls.Add(button2);
            panel6.Controls.Add(button1);
            panel6.Controls.Add(button3);
            panel6.Location = new Point(13, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(775, 72);
            panel6.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(279, 4);
            button2.MaximumSize = new Size(245, 68);
            button2.Name = "button2";
            button2.Size = new Size(221, 68);
            button2.TabIndex = 7;
            button2.Text = "Показать скрытые ветки";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(14, 4);
            button1.MaximumSize = new Size(245, 68);
            button1.Name = "button1";
            button1.Size = new Size(221, 68);
            button1.TabIndex = 6;
            button1.Text = "Показать скрытые события";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(544, 4);
            button3.MaximumSize = new Size(245, 68);
            button3.Name = "button3";
            button3.Size = new Size(221, 68);
            button3.TabIndex = 8;
            button3.Text = "Показать скрытые виды спорта";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lineLiveGroupBox
            // 
            lineLiveGroupBox.Controls.Add(statisticCheckBox);
            lineLiveGroupBox.Controls.Add(liveRadioButton);
            lineLiveGroupBox.Controls.Add(lineRadioButton);
            lineLiveGroupBox.Location = new Point(12, 7);
            lineLiveGroupBox.Name = "lineLiveGroupBox";
            lineLiveGroupBox.Size = new Size(555, 55);
            lineLiveGroupBox.TabIndex = 5;
            lineLiveGroupBox.TabStop = false;
            // 
            // statisticCheckBox
            // 
            statisticCheckBox.AutoSize = true;
            statisticCheckBox.Location = new Point(310, 23);
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
            liveRadioButton.Location = new Point(114, 23);
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
            lineRadioButton.Location = new Point(14, 23);
            lineRadioButton.Name = "lineRadioButton";
            lineRadioButton.Size = new Size(74, 25);
            lineRadioButton.TabIndex = 0;
            lineRadioButton.TabStop = true;
            lineRadioButton.Text = "Линия";
            lineRadioButton.UseVisualStyleBackColor = true;
            lineRadioButton.CheckedChanged += lineRadioButton_CheckedChanged;
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
            timeIntervalGroupBox.Location = new Point(372, 87);
            timeIntervalGroupBox.Name = "timeIntervalGroupBox";
            timeIntervalGroupBox.Size = new Size(195, 358);
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
            label1.Location = new Point(138, 87);
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
            sportTypesCheckedListBox.Items.AddRange(new object[] { "Все виды спорта", "Киберспорт", "Хоккей", "Баскетбол", "Теннис", "Волейбол", "Единоборства", "Австралийский футбол", "Авто-Мотоспорт", "Американский футбол", "Армрестлинг", "Бадминтон", "Баскетбол 3х3", "Бейсбол", "Бобслей", "Бокс", "Бол-хоккей", "Боулинг", "Биатлон", "Бильярд", "Велоспорт", "Водные виды", "Водное поло", "Волейбол на снегу", "Гандбол", "Гимнастика", "Гольф", "Горные лыжи", "Гребля", "Гэльский футбол", "Дартс", "Индор-хоккей", "Кабадди", "Керлинг", "Конный спорт", "Конькобежный спорт", "Крикет", "Лакросс", "Легкая атлетика", "Лыжи", "Лыжное двоеборье", "Микрофутзал", "Настольный теннис", "Нетбол", "Падел", "Парусный спорт", "Пелота", "Песапалло", "Пляжное регби", "Пляжный волейбол", "Пляжный гандбол", "Пляжный футбол", "Поло", "Прыжки на батуте", "Прыжки с трамплина", "Пятиборье", "Регби", "Санный спорт", "Сепактакрау", "Серфинг", "Скалолазание", "Сквош", "Скейтбординг", "Скелетон", "Сноуборд", "Снукер", "Софтбол", "Стрелковый спорт", "Стрельба из лука", "Текбол", "Триатлон", "Тяжелая атлетика", "Фехтование", "Фигурное катание", "Флорбол", "Формула 1", "Фрисби", "Футзал", "Херлинг", "Хоккейбол", "Хоккей на роликах", "Хоккей на траве", "Хоккей на траве в залах", "Хоккей с мячом", "Шары", "Шахматы", "Шашки", "Шорт-трек" });
            sportTypesCheckedListBox.Location = new Point(12, 114);
            sportTypesCheckedListBox.Name = "sportTypesCheckedListBox";
            sportTypesCheckedListBox.Size = new Size(341, 696);
            sportTypesCheckedListBox.TabIndex = 0;
            // 
            // hudeMenuBarButton
            // 
            hudeMenuBarButton.BackColor = SystemColors.Menu;
            hudeMenuBarButton.FlatAppearance.BorderSize = 0;
            hudeMenuBarButton.FlatStyle = FlatStyle.Flat;
            hudeMenuBarButton.Image = Properties.Resources.settings;
            hudeMenuBarButton.Location = new Point(0, 61);
            hudeMenuBarButton.Name = "hudeMenuBarButton";
            hudeMenuBarButton.Size = new Size(55, 55);
            hudeMenuBarButton.TabIndex = 7;
            hudeMenuBarButton.UseVisualStyleBackColor = false;
            hudeMenuBarButton.Click += hudeMenuBarButton_Click;
            // 
            // mainFormQuestionButton
            // 
            mainFormQuestionButton.BackColor = SystemColors.Menu;
            mainFormQuestionButton.FlatAppearance.BorderSize = 0;
            mainFormQuestionButton.FlatStyle = FlatStyle.Flat;
            mainFormQuestionButton.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            mainFormQuestionButton.Image = Properties.Resources.help;
            mainFormQuestionButton.Location = new Point(0, 122);
            mainFormQuestionButton.Name = "mainFormQuestionButton";
            mainFormQuestionButton.Size = new Size(55, 55);
            mainFormQuestionButton.TabIndex = 6;
            mainFormQuestionButton.UseVisualStyleBackColor = false;
            mainFormQuestionButton.Click += mainFormQuestionButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = SystemColors.Menu;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Image = Properties.Resources.update1;
            refreshButton.Location = new Point(0, 0);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(55, 55);
            refreshButton.TabIndex = 4;
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
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
            // HideToolStripMenuItem
            // 
            HideToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { HideBranchToolStripMenuItem, HideSportToolStripMenuItem });
            HideToolStripMenuItem.Name = "HideToolStripMenuItem";
            HideToolStripMenuItem.Size = new Size(196, 22);
            HideToolStripMenuItem.Text = "Скрыть";
            // 
            // HideBranchToolStripMenuItem
            // 
            HideBranchToolStripMenuItem.Name = "HideBranchToolStripMenuItem";
            HideBranchToolStripMenuItem.Size = new Size(108, 22);
            HideBranchToolStripMenuItem.Text = "Ветку";
            HideBranchToolStripMenuItem.Click += HideBranchToolStripMenuItem_Click;
            // 
            // HideSportToolStripMenuItem
            // 
            HideSportToolStripMenuItem.Name = "HideSportToolStripMenuItem";
            HideSportToolStripMenuItem.Size = new Size(108, 22);
            HideSportToolStripMenuItem.Text = "Спорт";
            HideSportToolStripMenuItem.Click += HideSportToolStripMenuItem_Click;
            // 
            // EventContextMenuStrip
            // 
            EventContextMenuStrip.Items.AddRange(new ToolStripItem[] { MatchingToolStripMenuItem, SaveIDToolStripMenuItem, hideEventToolStripMenuItem, HideToolStripMenuItem });
            EventContextMenuStrip.Name = "contextMenuStrip1";
            EventContextMenuStrip.Size = new Size(197, 92);
            // 
            // hideEventToolStripMenuItem
            // 
            hideEventToolStripMenuItem.Name = "hideEventToolStripMenuItem";
            hideEventToolStripMenuItem.Size = new Size(196, 22);
            hideEventToolStripMenuItem.Text = "Скрыть событие";
            hideEventToolStripMenuItem.Click += hideEventToolStripMenuItem_Click;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Controls.Add(mainFormQuestionButton);
            panel4.Controls.Add(refreshButton);
            panel4.Controls.Add(hudeMenuBarButton);
            panel4.Location = new Point(3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(58, 192);
            panel4.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SourceColumn, IDColumn, StartTimeColumn, BranchColumn, Team1Column, Team2Column });
            dataGridView1.Location = new Point(1395, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(12, 830);
            dataGridView1.TabIndex = 0;
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            dataGridView1.RowContextMenuStripNeeded += dataGridView1_RowContextMenuStripNeeded;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // 
            // SourceColumn
            // 
            SourceColumn.DataPropertyName = "status";
            SourceColumn.HeaderText = "Примечание";
            SourceColumn.Name = "SourceColumn";
            SourceColumn.ReadOnly = true;
            // 
            // IDColumn
            // 
            IDColumn.DataPropertyName = "matchID";
            IDColumn.HeaderText = "Матч ID";
            IDColumn.Name = "IDColumn";
            IDColumn.ReadOnly = true;
            IDColumn.Visible = false;
            // 
            // StartTimeColumn
            // 
            StartTimeColumn.DataPropertyName = "startTime";
            StartTimeColumn.HeaderText = "Время начала";
            StartTimeColumn.Name = "StartTimeColumn";
            StartTimeColumn.ReadOnly = true;
            // 
            // BranchColumn
            // 
            BranchColumn.DataPropertyName = "branch";
            BranchColumn.HeaderText = "Ветка";
            BranchColumn.Name = "BranchColumn";
            BranchColumn.ReadOnly = true;
            // 
            // Team1Column
            // 
            Team1Column.DataPropertyName = "team1";
            Team1Column.HeaderText = "Команда 1";
            Team1Column.Name = "Team1Column";
            Team1Column.ReadOnly = true;
            // 
            // Team2Column
            // 
            Team2Column.DataPropertyName = "team2";
            Team2Column.HeaderText = "Команда 2";
            Team2Column.Name = "Team2Column";
            Team2Column.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(65, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1419, 861);
            panel2.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1484, 861);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monitoring Ver.1.8";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel6.ResumeLayout(false);
            lineLiveGroupBox.ResumeLayout(false);
            lineLiveGroupBox.PerformLayout();
            timeIntervalGroupBox.ResumeLayout(false);
            timeIntervalGroupBox.PerformLayout();
            EventContextMenuStrip.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.ToolStripMenuItem SaveIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MatchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HideToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip EventContextMenuStrip;
        private System.Windows.Forms.GroupBox lineLiveGroupBox;
        private System.Windows.Forms.RadioButton liveRadioButton;
        private System.Windows.Forms.RadioButton lineRadioButton;
        private RadioButton SixHoursRadioButton;
        private CheckBox statisticCheckBox;
        private ToolStripMenuItem HideBranchToolStripMenuItem;
        private ToolStripMenuItem HideSportToolStripMenuItem;
        private Button mainFormQuestionButton;
        private ToolStripMenuItem hideEventToolStripMenuItem;
        private Button hudeMenuBarButton;
        private Panel panel4;
        private DataGridView dataGridView1;
        private Panel panel2;
        private DataGridViewTextBoxColumn SourceColumn;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn StartTimeColumn;
        private DataGridViewTextBoxColumn BranchColumn;
        private DataGridViewTextBoxColumn Team1Column;
        private DataGridViewTextBoxColumn Team2Column;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView2;
        private Button button4;
        private Panel panel3;
        private Panel panel6;
        private Panel panel7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewCheckBoxColumn Column2;
    }
}