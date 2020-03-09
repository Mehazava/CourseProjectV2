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
    }
}
