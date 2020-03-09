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
    public partial class PBase : UserControl
    {
        public PBase()
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
    }
}
