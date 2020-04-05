using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WSRussia.Models;

namespace WSRussia
{
    public partial class PCompetencies : WSRussia.PBase
    {
        public PCompetencies()
        {
            InitializeComponent();
            labelPageTitle.Text = "Компетенции чемпионата";
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null)
            {
                return;
            }
            Competention Comp = ParentF.db.Competentions.FirstOrDefault(c => c.Id == (int)e.Node.Tag);
            TextBoxDescription.Text = Comp.Description;
            labelName.Text = $"{Comp.Id} - {Comp.Name}";
        }

        private void PCompetencies_Paint(object sender, PaintEventArgs e)
        {
            foreach (var c in ParentF.db.Competentions)
            {
                treeView1.Nodes[0].Nodes[c.Group - 1].Nodes.Add(c.Name).Tag = c.Id;
            }
        }
    }
}
