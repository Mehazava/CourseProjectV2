using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSRussia
{
    public partial class PRating : WSRussia.PBase
    {
        public PRating()
        {
            InitializeComponent();
            labelPageTitle.Text = "Ввод оценок";
        }
    }
}
