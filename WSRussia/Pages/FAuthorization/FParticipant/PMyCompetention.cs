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
    public partial class PMyCompetention : WSRussia.PBase
    {
        Competention Comp;
        public PMyCompetention()
        {
            InitializeComponent();
            labelPageTitle.Text = "Моя компетенция";
        }

        private void PMyCompetention_Load(object sender, EventArgs e)
        {
            if (ParentF == null)
            {
                return;
            }
            Comp = ParentF.db.Competentions.FirstOrDefault(c => c.Id == ParentF.Login.CompetentionId);
            if (Comp == null)
            {
                throw new Exception("Couldn't find competention.");
            }
            List<Participant> ps;
            ps = ParentF.db.Participants.Where(p => p.CompetentionId == Comp.Id).ToList();
            foreach (var Parti in ps)
            {
                ListViewItem item = new ListViewItem(Parti.Name, 0);
                listView1.Items.Add(item);
            }
        }
    }
}
