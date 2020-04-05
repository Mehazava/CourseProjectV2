using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSRussia
{
    public partial class PTitle : UserControl
    {
        public PTitle()
        {
            InitializeComponent();
        }
        public MainForm ParentF
        {
            get
            {
                MainForm form = this.ParentForm as MainForm;
                if (form == null)
                {
                    throw new Exception("An error getting a parent form of user control.");
                }
                return form;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ParentF.GoPage(Page.AboutWS);
        }

        private void buttonGoAboutWSR_Click(object sender, EventArgs e)
        {
            ParentF.GoPage(Page.AboutWSRussia);
        }

        private void buttonGoAboutPrim_Click(object sender, EventArgs e)
        {
            ParentF.GoPage(Page.AboutPrim);
        }

        private void buttonGoLogin_Click(object sender, EventArgs e)
        {
            if (ParentF.Login == null)
            {
                ParentF.GoPage(Page.Authorization);
            }
            else
            {
                switch (ParentF.LoginType)
                {
                    case 1:
                        ParentF.GoPage(Page.Participant);
                        break;
                    case 2:
                        ParentF.GoPage(Page.Coordinator);
                        break;
                    case 3:
                        ParentF.GoPage(Page.Expert);
                        break;
                    case 4:
                        ParentF.GoPage(Page.Administrator);
                        break;
                }
            }
        }
    }
}
