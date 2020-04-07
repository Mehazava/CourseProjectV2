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
    public partial class PDistributeVolonteur : WSRussia.PBase
    {
        public PDistributeVolonteur()
        {
            InitializeComponent();
            labelPageTitle.Text = "Распределение волонтеров";
        }

        void LoadGrid(int i)
        {
            if (i == 1 && comboBoxCompetention1.SelectedIndex == -1)
            {
                return;
            }
            if (i == 2 && comboBoxCompetention2.SelectedIndex == -1)
            {
                return;
            }
            DataGridViewRowCollection rows;
            int SelId;
            try
            {
                if (i == 1)
                {
                    rows = dataGridView1.Rows;
                    SelId = int.Parse(comboBoxCompetention1.Text
                        .Substring(0, comboBoxCompetention1.Text.IndexOf(' ')));
                }
                else
                {
                    rows = dataGridView2.Rows;
                    SelId = int.Parse(comboBoxCompetention2.Text
                        .Substring(0, comboBoxCompetention2.Text.IndexOf(' ')));
                }
            }
            catch
            {
                DialogResult res = MessageBox.Show("Ошибка при получении Id выбранной компетенции",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            rows.Clear();
            foreach (var v in ParentF.db.Volunteers.Where(vol => vol.CompetentionId == SelId))
            {
                rows.Add(v.Id, false, v.Name, v.Sex == 0 ? "F" : "M", v.Place);
            }
        }

        private void PDistributeVolonteur_Load(object sender, EventArgs e)
        {
            if (ParentF != null)
            {
                foreach (var item in ParentF.db.Competentions)
                {
                    comboBoxCompetention1.Items.Add(item.Id + " - " + item.Name);
                    comboBoxCompetention2.Items.Add(item.Id + " - " + item.Name);
                }
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (comboBoxCompetention1.SelectedIndex == -1)
            {
                DialogResult res = MessageBox.Show("Выберите компетенцию слева",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxCompetention2.SelectedIndex == -1)
            {
                DialogResult res = MessageBox.Show("Выберите компетенцию справа",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if ((bool)r.Cells[1].Value == true)
                {
                    dataGridView1.Rows.Remove(r);
                    dataGridView2.Rows.Add(r);
                }
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (comboBoxCompetention1.SelectedIndex == -1)
            {
                DialogResult res = MessageBox.Show("Выберите компетенцию слева",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxCompetention2.SelectedIndex == -1)
            {
                DialogResult res = MessageBox.Show("Выберите компетенцию справа",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataGridViewRow r in dataGridView2.Rows)
            {
                if ((bool)r.Cells[1].Value == true)
                {
                    dataGridView2.Rows.Remove(r);
                    dataGridView1.Rows.Add(r);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxCompetention1.SelectedIndex == -1)
            {
                DialogResult res = MessageBox.Show("Выберите компетенцию слева",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxCompetention2.SelectedIndex == -1)
            {
                DialogResult res = MessageBox.Show("Выберите компетенцию справа",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int CId1, CId2;
            try
            {
                CId1 = int.Parse(comboBoxCompetention1.Text
                    .Substring(0, comboBoxCompetention1.Text.IndexOf(' ')));
                CId2 = int.Parse(comboBoxCompetention2.Text
                    .Substring(0, comboBoxCompetention2.Text.IndexOf(' ')));
            }
            catch
            {
                DialogResult res = MessageBox.Show("Ошибка при получении Id выбранной компетенции",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                ParentF.db.Volunteers
                    .FirstOrDefault(vol => vol.Id == (int)r.Cells[0].Value).CompetentionId = CId1;
            }
            foreach (DataGridViewRow r in dataGridView2.Rows)
            {
                ParentF.db.Volunteers
                    .FirstOrDefault(vol => vol.Id == (int)r.Cells[0].Value).CompetentionId = CId2;
            }
            ParentF.db.SaveChanges();
        }

        private void comboBoxCompetention1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid(1);
            LoadGrid(2);
        }

        private void comboBoxCompetention2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid(1);
            LoadGrid(2);
        }
    }
}
