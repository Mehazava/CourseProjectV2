using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSRussia
{
    public partial class PHistoryWS : WSRussia.PBase
    {
        public PHistoryWS()
        {
            InitializeComponent();
            labelPageTitle.Text = "История WorldSkills";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
    }
}
