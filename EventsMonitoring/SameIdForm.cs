﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsMonitoring
{
    public partial class SameIdForm : Form
    {
        private static string _connectionString = "data source=analytic.gkbaltbet.local;initial catalog=bbstats;" +
                                                  "user Id=event_match;password=umbMzLQB3hKo69VG8F4N;Integrated Security=false;" +
                                                  "MultipleActiveResultSets=true;MultiSubnetFailover=True;TrustServerCertificate=true";

        private static string _sqlExpression;


        public static string GetPath(string idEvent)
        {
            _sqlExpression = $"SELECT Id, Path\n" +
                             $"FROM [bbstats].[dbo].[LineMemberTree]\n" +
                             $"WHERE Id = {int.Parse(idEvent)}";

            var pathName = string.Empty;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(_sqlExpression, connection);
                    var reader = command.ExecuteReader();

                    reader.Read();
                    pathName = reader.GetString(1);
                }
                catch (Exception)
                {
                    pathName = "Участник скрыт или уже объединен. Нажмите кнопку объединить.";
                }
            }
            return pathName;
        }




        public SameIdForm(string teamName, string Id1, string Id2)
        {
            InitializeComponent();

            teamNameLabel.Text = teamName;
            textBox1.Text = Id1;
            textBox2.Text = Id2;
            try
            {
                label4.Text = GetPath(Id1);
                label5.Text = GetPath(Id2);
            }
            catch (Exception)
            {
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void sameIdQuestionbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В этом окне отображаются название команды и 2 айдишника. Оба этих ID соответствуют одной и той же команде. Такое возможно если кто-то до этого связал команду не верно или если в нашей программе созданы две одинаковых команды, но с разными ID.\n\n" +
                            "В поле Старый ID указан ID, с которым данная команда уже когда-то была связана, в поле Новый ID текущий ID.\n" +
                            "Если вы хотите перезаписать старый ID текущим, нажмите на кнопу Перезаписать.\n\n" +
                            "Желательно скинуть супервайзеру оба ID, чтобы он объединил их в базе. Скопировать оба ID можно на кнопку Сохранить в буфер.", "Дублирование ID команды");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Нужно объединить участников: " + textBox1.Text + "  и  " + textBox2.Text, TextDataFormat.UnicodeText);
        }
    }
}
