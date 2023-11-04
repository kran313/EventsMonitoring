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
        public SameIdForm(string teamName, string Id1, string Id2)
        {
            InitializeComponent();

            teamNameLabel.Text = teamName;
            textBox1.Text = Id1;
            textBox2.Text = Id2;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
