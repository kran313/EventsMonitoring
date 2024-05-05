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
            SuspendLayout();
            // 
            // teamNameLabel
            // 
            teamNameLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            teamNameLabel.Location = new Point(210, 37);
            teamNameLabel.Margin = new Padding(4, 0, 4, 0);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(385, 69);
            teamNameLabel.TabIndex = 0;
            teamNameLabel.Text = "label1";
            teamNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 119);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 29);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 151);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(118, 29);
            textBox2.TabIndex = 2;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(210, 5);
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
            label2.Location = new Point(6, 122);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 4;
            label2.Text = "Старый ID:";
            // 
            // label3
            // 
            label3.Location = new Point(6, 154);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 29);
            label3.TabIndex = 5;
            label3.Text = "Новый ID:";
            // 
            // OKButton
            // 
            OKButton.Location = new Point(342, 253);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(180, 39);
            OKButton.TabIndex = 6;
            OKButton.Text = "Перезаписать";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(533, 253);
            button1.Name = "button1";
            button1.Size = new Size(180, 39);
            button1.TabIndex = 7;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sameIdQuestionbutton
            // 
            sameIdQuestionbutton.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            sameIdQuestionbutton.Location = new Point(6, 12);
            sameIdQuestionbutton.Name = "sameIdQuestionbutton";
            sameIdQuestionbutton.Size = new Size(41, 55);
            sameIdQuestionbutton.TabIndex = 8;
            sameIdQuestionbutton.Text = "?";
            sameIdQuestionbutton.UseVisualStyleBackColor = true;
            sameIdQuestionbutton.Click += sameIdQuestionbutton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(228, 122);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(228, 154);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(151, 253);
            button2.Name = "button2";
            button2.Size = new Size(180, 39);
            button2.TabIndex = 11;
            button2.Text = "Сохранить в буфер";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SameIdForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 322);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(sameIdQuestionbutton);
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
        private Button sameIdQuestionbutton;
        private Label label4;
        private Label label5;
        private Button button2;
    }
}