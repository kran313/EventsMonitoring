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
            this.bookmakerBranchLabel = new System.Windows.Forms.Label();
            this.bookmakerTeamsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MatchIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Team1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Team2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.possibleMatchingsLabel = new System.Windows.Forms.Label();
            this.baltbetMatchIDLabel = new System.Windows.Forms.Label();
            this.baltbetMatchIDTextBox = new System.Windows.Forms.TextBox();
            this.reverseCheckBox = new System.Windows.Forms.CheckBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookmakerBranchLabel
            // 
            this.bookmakerBranchLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookmakerBranchLabel.Location = new System.Drawing.Point(12, 9);
            this.bookmakerBranchLabel.Name = "bookmakerBranchLabel";
            this.bookmakerBranchLabel.Size = new System.Drawing.Size(1459, 50);
            this.bookmakerBranchLabel.TabIndex = 0;
            this.bookmakerBranchLabel.Text = "label1";
            this.bookmakerBranchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookmakerTeamsLabel
            // 
            this.bookmakerTeamsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookmakerTeamsLabel.Location = new System.Drawing.Point(13, 63);
            this.bookmakerTeamsLabel.Name = "bookmakerTeamsLabel";
            this.bookmakerTeamsLabel.Size = new System.Drawing.Size(1459, 50);
            this.bookmakerTeamsLabel.TabIndex = 1;
            this.bookmakerTeamsLabel.Text = "label1";
            this.bookmakerTeamsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatchIDColumn,
            this.SourceColumn,
            this.StartTimeColumn,
            this.BranchColumn,
            this.Team1Column,
            this.Team2Column});
            this.dataGridView1.Location = new System.Drawing.Point(13, 187);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1459, 262);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // MatchIDColumn
            // 
            this.MatchIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MatchIDColumn.DataPropertyName = "matchID";
            this.MatchIDColumn.HeaderText = "ID Матча";
            this.MatchIDColumn.Name = "MatchIDColumn";
            this.MatchIDColumn.ReadOnly = true;
            // 
            // SourceColumn
            // 
            this.SourceColumn.DataPropertyName = "status";
            this.SourceColumn.HeaderText = "Примечание";
            this.SourceColumn.Name = "SourceColumn";
            this.SourceColumn.ReadOnly = true;
            this.SourceColumn.Visible = false;
            // 
            // StartTimeColumn
            // 
            this.StartTimeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.StartTimeColumn.DataPropertyName = "startTime";
            this.StartTimeColumn.HeaderText = "Время начала";
            this.StartTimeColumn.Name = "StartTimeColumn";
            this.StartTimeColumn.ReadOnly = true;
            this.StartTimeColumn.Width = 134;
            // 
            // BranchColumn
            // 
            this.BranchColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BranchColumn.DataPropertyName = "branch";
            this.BranchColumn.HeaderText = "Ветка";
            this.BranchColumn.Name = "BranchColumn";
            this.BranchColumn.ReadOnly = true;
            // 
            // Team1Column
            // 
            this.Team1Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Team1Column.DataPropertyName = "team1";
            this.Team1Column.HeaderText = "Команда 1";
            this.Team1Column.Name = "Team1Column";
            this.Team1Column.ReadOnly = true;
            this.Team1Column.Width = 111;
            // 
            // Team2Column
            // 
            this.Team2Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Team2Column.DataPropertyName = "team2";
            this.Team2Column.HeaderText = "Команда 2";
            this.Team2Column.Name = "Team2Column";
            this.Team2Column.ReadOnly = true;
            this.Team2Column.Width = 111;
            // 
            // possibleMatchingsLabel
            // 
            this.possibleMatchingsLabel.Location = new System.Drawing.Point(13, 127);
            this.possibleMatchingsLabel.Name = "possibleMatchingsLabel";
            this.possibleMatchingsLabel.Size = new System.Drawing.Size(1459, 26);
            this.possibleMatchingsLabel.TabIndex = 3;
            this.possibleMatchingsLabel.Text = "Возможные совпадения";
            this.possibleMatchingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baltbetMatchIDLabel
            // 
            this.baltbetMatchIDLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.baltbetMatchIDLabel.Location = new System.Drawing.Point(12, 452);
            this.baltbetMatchIDLabel.Name = "baltbetMatchIDLabel";
            this.baltbetMatchIDLabel.Size = new System.Drawing.Size(1460, 42);
            this.baltbetMatchIDLabel.TabIndex = 4;
            this.baltbetMatchIDLabel.Text = "Введите ID матча в Балтбете";
            this.baltbetMatchIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baltbetMatchIDTextBox
            // 
            this.baltbetMatchIDTextBox.Location = new System.Drawing.Point(668, 497);
            this.baltbetMatchIDTextBox.Name = "baltbetMatchIDTextBox";
            this.baltbetMatchIDTextBox.Size = new System.Drawing.Size(165, 29);
            this.baltbetMatchIDTextBox.TabIndex = 5;
            // 
            // reverseCheckBox
            // 
            this.reverseCheckBox.AutoSize = true;
            this.reverseCheckBox.Location = new System.Drawing.Point(668, 532);
            this.reverseCheckBox.Name = "reverseCheckBox";
            this.reverseCheckBox.Size = new System.Drawing.Size(168, 25);
            this.reverseCheckBox.TabIndex = 6;
            this.reverseCheckBox.Text = "Обратный порядок";
            this.reverseCheckBox.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acceptButton.Location = new System.Drawing.Point(450, 591);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(250, 60);
            this.acceptButton.TabIndex = 7;
            this.acceptButton.Text = "Связать команды";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(800, 591);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(250, 60);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1184, 29);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(128, 152);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 25);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Полный поиск";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MatchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.reverseCheckBox);
            this.Controls.Add(this.baltbetMatchIDTextBox);
            this.Controls.Add(this.baltbetMatchIDLabel);
            this.Controls.Add(this.possibleMatchingsLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bookmakerTeamsLabel);
            this.Controls.Add(this.bookmakerBranchLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MatchingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatchingForm";
            this.Load += new System.EventHandler(this.MatchingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team2Column;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}