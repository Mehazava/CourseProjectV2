﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSRussia
{
    public partial class PAboutPrim : WSRussia.PBase
    {
        public PAboutPrim()
        {
            InitializeComponent();
            labelPageTitle.Text = "О Приморском крае";
        }
    }
}
