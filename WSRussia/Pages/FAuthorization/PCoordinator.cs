using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSRussia
{
    public partial class PCoordinator : WSRussia.PBase
    {
        public PCoordinator()
        {
            InitializeComponent();
            labelPageTitle.Text = "Меню координатора";
        }

        private void PCoordinator_Paint(object sender, PaintEventArgs e)
        {
            if (DateTime.Now.Hour < 10)
            {
                labelGreeting.Text = "Доброе утро\n";
            }
            else if (DateTime.Now.Hour < 18)
            {
                labelGreeting.Text = "Добрый день\n";
            }
            else
            {
                labelGreeting.Text = "Добрый вечер\n";
            }
            if (ParentF.Login == null)
            {
                throw new Exception("Not logged in when you should be.");
            }
            if (ParentF.Login.Sex == 0)
            {
                labelGreeting.Text += "Ms. ";
            }
            else
            {
                labelGreeting.Text += "Mr. ";
            }
            labelGreeting.Text += ParentF.Login.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParentF.GoPage(Page.EditVolunteer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParentF.GoPage(Page.EditSponsor);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParentF.GoPage(Page.MyResultsCoor);
        }
    }
}
