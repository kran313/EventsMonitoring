namespace EventsMonitoring
{
    partial class MatchingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bookmakerBranchLabel = new Label();
            bookmakerTeamsLabel = new Label();
            dataGridView1 = new DataGridView();
            MatchIDColumn = new DataGridViewTextBoxColumn();
            SourceColumn = new DataGridViewTextBoxColumn();
            StartTimeColumn = new DataGridViewTextBoxColumn();
            BranchColumn = new DataGridViewTextBoxColumn();
            Team1Column = new DataGridViewTextBoxColumn();
            Team2Column = new DataGridViewTextBoxColumn();
            possibleMatchingsLabel = new Label();
            baltbetMatchIDLabel = new Label();
            baltbetMatchIDTextBox = new TextBox();
            reverseCheckBox = new CheckBox();
            acceptButton = new Button();
            cancelButton = new Button();
            textBox1 = new TextBox();
            matchingFormQuestionButton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // bookmakerBranchLabel
            // 
            bookmakerBranchLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bookmakerBranchLabel.Location = new Point(3, 3);
            bookmakerBranchLabel.Name = "bookmakerBranchLabel";
            bookmakerBranchLabel.Size = new Size(1416, 50);
            bookmakerBranchLabel.TabIndex = 0;
            bookmakerBranchLabel.Text = "label1";
            bookmakerBranchLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bookmakerTeamsLabel
            // 
            bookmakerTeamsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bookmakerTeamsLabel.Location = new Point(3, 53);
            bookmakerTeamsLabel.Name = "bookmakerTeamsLabel";
            bookmakerTeamsLabel.Size = new Size(1416, 50);
            bookmakerTeamsLabel.TabIndex = 1;
            bookmakerTeamsLabel.Text = "label1";
            bookmakerTeamsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MatchIDColumn, SourceColumn, StartTimeColumn, BranchColumn, Team1Column, Team2Column });
            dataGridView1.Location = new Point(67, 187);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1405, 262);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // MatchIDColumn
            // 
            MatchIDColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MatchIDColumn.DataPropertyName = "matchID";
            MatchIDColumn.HeaderText = "ID Матча";
            MatchIDColumn.Name = "MatchIDColumn";
            MatchIDColumn.ReadOnly = true;
            // 
            // SourceColumn
            // 
            SourceColumn.DataPropertyName = "status";
            SourceColumn.HeaderText = "Примечание";
            SourceColumn.Name = "SourceColumn";
            SourceColumn.ReadOnly = true;
            SourceColumn.Visible = false;
            // 
            // StartTimeColumn
            // 
            StartTimeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            StartTimeColumn.DataPropertyName = "startTime";
            StartTimeColumn.HeaderText = "Время начала";
            StartTimeColumn.Name = "StartTimeColumn";
            StartTimeColumn.ReadOnly = true;
            StartTimeColumn.Width = 134;
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
            Team1Column.Width = 111;
            // 
            // Team2Column
            // 
            Team2Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Team2Column.DataPropertyName = "team2";
            Team2Column.HeaderText = "Команда 2";
            Team2Column.Name = "Team2Column";
            Team2Column.ReadOnly = true;
            Team2Column.Width = 111;
            // 
            // possibleMatchingsLabel
            // 
            possibleMatchingsLabel.Location = new Point(3, 13);
            possibleMatchingsLabel.Name = "possibleMatchingsLabel";
            possibleMatchingsLabel.Size = new Size(284, 26);
            possibleMatchingsLabel.TabIndex = 3;
            possibleMatchingsLabel.Text = "Поиск по всем матчам по подстроке";
            possibleMatchingsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // baltbetMatchIDLabel
            // 
            baltbetMatchIDLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            baltbetMatchIDLabel.Location = new Point(0, 0);
            baltbetMatchIDLabel.Name = "baltbetMatchIDLabel";
            baltbetMatchIDLabel.Size = new Size(1405, 42);
            baltbetMatchIDLabel.TabIndex = 4;
            baltbetMatchIDLabel.Text = "Введите ID матча в Балтбете";
            baltbetMatchIDLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // baltbetMatchIDTextBox
            // 
            baltbetMatchIDTextBox.Location = new Point(611, 45);
            baltbetMatchIDTextBox.Name = "baltbetMatchIDTextBox";
            baltbetMatchIDTextBox.Size = new Size(165, 29);
            baltbetMatchIDTextBox.TabIndex = 5;
            baltbetMatchIDTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // reverseCheckBox
            // 
            reverseCheckBox.AutoSize = true;
            reverseCheckBox.Location = new Point(611, 80);
            reverseCheckBox.Name = "reverseCheckBox";
            reverseCheckBox.Size = new Size(168, 25);
            reverseCheckBox.TabIndex = 6;
            reverseCheckBox.Text = "Обратный порядок";
            reverseCheckBox.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            acceptButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            acceptButton.Location = new Point(445, 121);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(250, 60);
            acceptButton.TabIndex = 7;
            acceptButton.Text = "Связать команды";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(710, 121);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(250, 60);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(293, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1109, 29);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // matchingFormQuestionButton
            // 
            matchingFormQuestionButton.FlatAppearance.BorderSize = 0;
            matchingFormQuestionButton.FlatStyle = FlatStyle.Flat;
            matchingFormQuestionButton.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            matchingFormQuestionButton.Image = Properties.Resources.help;
            matchingFormQuestionButton.Location = new Point(6, 12);
            matchingFormQuestionButton.Name = "matchingFormQuestionButton";
            matchingFormQuestionButton.Size = new Size(55, 55);
            matchingFormQuestionButton.TabIndex = 11;
            matchingFormQuestionButton.UseVisualStyleBackColor = true;
            matchingFormQuestionButton.Click += matchingFormQuestionButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(bookmakerBranchLabel);
            panel1.Controls.Add(bookmakerTeamsLabel);
            panel1.Location = new Point(67, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(1405, 107);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Controls.Add(possibleMatchingsLabel);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(67, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(1405, 52);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(acceptButton);
            panel3.Controls.Add(cancelButton);
            panel3.Controls.Add(baltbetMatchIDLabel);
            panel3.Controls.Add(baltbetMatchIDTextBox);
            panel3.Controls.Add(reverseCheckBox);
            panel3.Location = new Point(67, 457);
            panel3.Name = "panel3";
            panel3.Size = new Size(1405, 194);
            panel3.TabIndex = 14;
            // 
            // MatchingForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 661);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(matchingFormQuestionButton);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MatchingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MatchingForm";
            Load += MatchingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label bookmakerBranchLabel;
        private System.Windows.Forms.Label bookmakerTeamsLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label possibleMatchingsLabel;
        private System.Windows.Forms.Label baltbetMatchIDLabel;
        private System.Windows.Forms.TextBox baltbetMatchIDTextBox;
        private System.Windows.Forms.CheckBox reverseCheckBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox textBox1;
        private Button matchingFormQuestionButton;
        private DataGridViewTextBoxColumn MatchIDColumn;
        private DataGridViewTextBoxColumn SourceColumn;
        private DataGridViewTextBoxColumn StartTimeColumn;
        private DataGridViewTextBoxColumn BranchColumn;
        private DataGridViewTextBoxColumn Team1Column;
        private DataGridViewTextBoxColumn Team2Column;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}