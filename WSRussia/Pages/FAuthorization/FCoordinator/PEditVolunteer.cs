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
    public partial class PEditVolonteur : WSRussia.PBase
    {
        public PEditVolonteur()
        {
            InitializeComponent();
            labelPageTitle.Text = "Управление волонтерами";
        }

        void LoadGrid()
        {
            dataGridView1.Rows.Clear();
            int SelId;
            if (comboBoxCompetention.SelectedIndex == 0)
            {
                SelId = 0;
            }
            else
            {
                try
                {
                    SelId = int.Parse(comboBoxCompetention.Text
                        .Substring(0, comboBoxCompetention.Text.IndexOf(' ')));
                }
                catch
                {
                    DialogResult res = MessageBox.Show("Ошибка при получении Id выбранной компетенции",
                        "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            foreach (var item in ParentF.db.Volunteers.ToList())
            {
                if (SelId == 0 || item.CompetentionId == SelId)
                {
                    dataGridView1.Rows.Add(item.Id, item.Name, item.Sex == 0 ? "Жен" : "Муж",
                        item.Place, (item.CompetentionId + " - " + ParentF.db.Competentions
                            .FirstOrDefault(c => c.Id == item.CompetentionId).Name));
                }
            }
            labelCount.Text = dataGridView1.Rows.Count.ToString();
        }

        private void PEditVolonteur_Load(object sender, EventArgs e)
        {
            if (ParentF != null)
            {
                comboBoxCompetention.SelectedIndex = 0;
                foreach (var item in ParentF.db.Competentions)
                {
                    comboBoxCompetention.Items.Add(item.Id + " - " + item.Name);
                }
                LoadGrid();
            }
        }
        private void comboBoxCompetention_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void buttonFileLoad_Click(object sender, EventArgs e)
        {
            ParentF.GoPage(Page.LoadVolunteer);
        }

        private void buttonDistribute_Click(object sender, EventArgs e)
        {
            ParentF.GoPage(Page.DistributeVolunteer);
        }
    }
}
