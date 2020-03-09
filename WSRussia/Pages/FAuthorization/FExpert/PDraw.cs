using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSRussia
{
    public partial class PDraw : WSRussia.PBase
    {
        public PDraw()
        {
            InitializeComponent();
            labelPageTitle.Text = "Жеребьевка";
        }
    }
}
