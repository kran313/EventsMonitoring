namespace EventsMonitoring
{
    partial class SameIdForm
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
            teamNameLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            OKButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // teamNameLabel
            // 
            teamNameLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            teamNameLabel.Location = new Point(15, 42);
            teamNameLabel.Margin = new Padding(4, 0, 4, 0);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(385, 69);
            teamNameLabel.TabIndex = 0;
            teamNameLabel.Text = "label1";
            teamNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 133);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 29);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(177, 185);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 29);
            textBox2.TabIndex = 2;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(385, 32);
            label1.TabIndex = 3;
            label1.Text = "Найдено задвоение Id";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(59, 136);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 32);
            label2.TabIndex = 4;
            label2.Text = "Id №1:";
            // 
            // label3
            // 
            label3.Location = new Point(59, 185);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 29);
            label3.TabIndex = 5;
            label3.Text = "Id №2:";
            // 
            // OKButton
            // 
            OKButton.Location = new Point(15, 261);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(174, 39);
            OKButton.TabIndex = 6;
            OKButton.Text = "Объединить";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(226, 261);
            button1.Name = "button1";
            button1.Size = new Size(174, 39);
            button1.TabIndex = 7;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SameIdForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 322);
            Controls.Add(button1);
            Controls.Add(OKButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(teamNameLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "SameIdForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SameIdForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label teamNameLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button OKButton;
        private Button button1;
    }
}