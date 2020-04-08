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
            tabControl1.SelectedIndex = 2;
            panelHL3.BackColor = Color.FromArgb(255, 192, 192);
            panelHL2.BackColor = Color.Transparent;
            panelHL1.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            panelHL3.BackColor = Color.Transparent;
            panelHL2.BackColor = Color.FromArgb(255, 192, 192);
            panelHL1.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            panelHL3.BackColor = Color.Transparent;
            panelHL2.BackColor = Color.Transparent;
            panelHL1.BackColor = Color.FromArgb(255, 192, 192);
        }
    }
}
