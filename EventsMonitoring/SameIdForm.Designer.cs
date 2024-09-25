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
            sameIdQuestionbutton = new Button();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameLabel
            // 
            teamNameLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            teamNameLabel.Location = new Point(4, 46);
            teamNameLabel.Margin = new Padding(4, 0, 4, 0);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(770, 54);
            teamNameLabel.TabIndex = 0;
            teamNameLabel.Text = "label1";
            teamNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 19);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 29);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 51);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 29);
            textBox2.TabIndex = 2;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(770, 32);
            label1.TabIndex = 3;
            label1.Text = "Найдено задвоение Id";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(4, 22);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 4;
            label2.Text = "Старый ID:";
            // 
            // label3
            // 
            label3.Location = new Point(4, 54);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 29);
            label3.TabIndex = 5;
            label3.Text = "Новый ID:";
            // 
            // OKButton
            // 
            OKButton.Location = new Point(293, 43);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(180, 39);
            OKButton.TabIndex = 6;
            OKButton.Text = "Перезаписать";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(484, 43);
            button1.Name = "button1";
            button1.Size = new Size(180, 39);
            button1.TabIndex = 7;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sameIdQuestionbutton
            // 
            sameIdQuestionbutton.FlatAppearance.BorderSize = 0;
            sameIdQuestionbutton.FlatStyle = FlatStyle.Flat;
            sameIdQuestionbutton.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            sameIdQuestionbutton.Image = Properties.Resources.help;
            sameIdQuestionbutton.Location = new Point(6, 12);
            sameIdQuestionbutton.Name = "sameIdQuestionbutton";
            sameIdQuestionbutton.Size = new Size(55, 55);
            sameIdQuestionbutton.TabIndex = 8;
            sameIdQuestionbutton.UseVisualStyleBackColor = true;
            sameIdQuestionbutton.Click += sameIdQuestionbutton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(241, 22);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(241, 54);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(102, 43);
            button2.Name = "button2";
            button2.Size = new Size(180, 39);
            button2.TabIndex = 11;
            button2.Text = "Сохранить в буфер";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(teamNameLabel);
            panel1.Location = new Point(67, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 100);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(67, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(778, 92);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(OKButton);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(67, 210);
            panel3.Name = "panel3";
            panel3.Size = new Size(778, 100);
            panel3.TabIndex = 14;
            // 
            // SameIdForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 322);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(sameIdQuestionbutton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "SameIdForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SameIdForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
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
        private Button sameIdQuestionbutton;
        private Label label4;
        private Label label5;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}