using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WSRussia
{
    public partial class PParticipant : WSRussia.PBase
    {
        public PParticipant()
        {
            InitializeComponent();
            labelPageTitle.Text = "Меню участника";
        }

        private void PParticipant_Paint(object sender, PaintEventArgs e)
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
            if (!String.IsNullOrEmpty(ParentF.Login.PicPath))
            {
                throw new Exception("Sorry, but we don't allow personal pictures there.");
            }
            pictureYou.Image = Properties.Resources.Spidey;
        }

        private void buttonMyProfile_Click(object sender, EventArgs e)
        {
            ParentF.GoPage(Page.MyProfile);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParentF.GoPage(Page.MyCompetention);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ParentF.db.Results.FirstOrDefault(r => r.Id == ParentF.Login.ResultId) == null)
            {
                DialogResult res = MessageBox.Show("Ваши результаты еще не опубликованны",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ParentF.GoPage(Page.MyResults);
        }
    }
}
