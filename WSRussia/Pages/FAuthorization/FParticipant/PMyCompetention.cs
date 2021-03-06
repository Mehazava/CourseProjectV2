﻿using System;
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
        String MakeBig(String bae, int total)
        {
            int add = total - bae.Length;
            bae.PadLeft(add / 2);
            bae.PadRight(total);
            return bae;
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
            labelCompetention.Text = Comp.Id + " - " + Comp.Name;
            //page 1 2
            imageList1.Images.Add(Properties.Resources.Woman);
            imageList1.Images.Add(Properties.Resources.Man);
            foreach (var pE in ParentF.db.Participants.Where(p => p.CompetentionId == Comp.Id))
            {
                listView1.Items.Add($"{pE.Name}\n{pE.Country}", pE.Sex);
            }
            foreach (var pE in ParentF.db.Experts.Where(p => p.CompetentionId == Comp.Id))
            {
                listView2.Items.Add($"{pE.Name}\n{pE.Country}", pE.Sex);
            }
            //p 3
            pictureBoxMap.Image = Properties.Resources.Mappa;
            //p 4
            int counter = 0;
            int NextD = Comp.Infrastructure;
            Infrastructure Infra;
            while (NextD != 0)
            {
                Infra = ParentF.db.Infrastructures.FirstOrDefault(i => i.Id == NextD);
                if (Infra == null)
                {
                    throw new Exception("Couldn't find description.");
                }
                dataGridView1.Rows.Add(++counter, Infra.Name, Infra.Description, Infra.Measurement, Infra.Amount);
                NextD = Infra.Next;
            }
            //p 5
            NextD = Comp.SMP;
            SMP sMP;
            DataGridViewCellStyle Separator = new DataGridViewCellStyle();
            Separator.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Separator.BackColor = Color.Green;
            Separator.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            while (NextD != 0)
            {
                sMP = ParentF.db.SMPs.FirstOrDefault(i => i.Id == NextD);
                if (sMP == null)
                {
                    throw new Exception("Couldn't find SMP entry.");
                }
                if (sMP.Category != 0)
                {
                    if (sMP.Id != Comp.SMP)//not first in list category
                    {
                        dataGridView2.Rows.Add("", "");
                    }
                    counter = dataGridView2.Rows.Add("", "C-" + sMP.Category + "       ");
                    dataGridView2.Rows[counter].DefaultCellStyle = Separator;
                    counter = dataGridView2.Rows.Add("время","");
                    dataGridView2.Rows[counter].Cells[0].Style.Alignment = DataGridViewContentAlignment.BottomLeft;
                    dataGridView2.Rows[counter].Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
                }
                dataGridView2.Rows.Add(sMP.Time, sMP.Description);
                NextD = sMP.Next;
            }

            /*
            List<Participant> ps;
            ps = ParentF.db.Participants.Where(p => p.CompetentionId == Comp.Id).ToList();
            foreach (var Parti in ps)
            {
                ListViewItem item = new ListViewItem(Parti.Name, 0);
                listView1.Items.Add(item);
            }
            */
        }
    }
}
