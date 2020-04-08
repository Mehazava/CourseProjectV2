using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSRussia
{
    public partial class PAboutWSRussia : WSRussia.PBase
    {
        public PAboutWSRussia()
        {
            InitializeComponent();
            labelPageTitle.Text = "О WorldSkills Russia";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button3.BackColor = Color.FromArgb(255, 255, 128);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button1.BackColor = Color.FromArgb(255, 255, 128);
            button3.BackColor = Color.FromArgb(255, 255, 128);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            button3.BackColor = Color.FromArgb(255, 192, 192);
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button1.BackColor = Color.FromArgb(255, 255, 128);
        }
    }
}
