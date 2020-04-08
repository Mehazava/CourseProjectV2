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
    public partial class PCheckResults : WSRussia.PBase
    {
        Dictionary<int, String> Comps = new Dictionary<int, string>();
        public PCheckResults()
        {
            InitializeComponent();
            labelPageTitle.Text = "Просмотр результатов";
        }
        void LoadGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in ParentF.db.Results.ToList())
            {
                Participant pE = ParentF.db.Participants.FirstOrDefault(p => p.ResultId == item.Id);
                if (pE == null)
                {
                    DialogResult res = MessageBox.Show("Владелец результата не найден.",
                        "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                double fullR = item.Grade.Split(' ').Select(g => double.Parse(g)).Sum();
                dataGridView1.Rows.Add(item.Id, pE.Name, Comps[pE.CompetentionId],
                    fullR, item.Grade, item.Location, item.Championship);
            }
            ApplyFilter();
        }
        void ApplyFilter()
        {
            string filter = textBoxFilter.Text.ToLower();
            int index = comboBoxField.SelectedIndex;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[index].Value == null)
                {
                    row.Visible = true;
                }
                else if (row.Cells[index].Value.ToString().ToLower().Contains(filter))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
        private void comboBoxField_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void PCheckResults_Load(object sender, EventArgs e)
        {
            if (ParentF != null)
            {
                comboBoxField.SelectedIndex = 0;
                foreach (var i in ParentF.db.Competentions)
                {
                    Comps.Add(i.Id, i.Id + " - " + i.Name);
                    (dataGridView1.Columns[2] as DataGridViewComboBoxColumn)
                        .Items.Add(Comps[i.Id]);
                }
                labelCount.Text = ParentF.db.Results.ToList().Count.ToString();
                LoadGrid();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected && oneCell.OwningRow != null)
                {
                    if (String.IsNullOrEmpty(dataGridView1.Rows[oneCell.RowIndex].Cells[0].Value?.ToString()))
                    {
                        DialogResult res = MessageBox.Show("Выбраная строка не связанна с записью.",
                            "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int pId = (int)dataGridView1.Rows[oneCell.RowIndex].Cells[0].Value;
                    Result rE = ParentF.db.Results.FirstOrDefault(r => r.Id == pId);
                    if (rE == null)
                    {
                        DialogResult res = MessageBox.Show("Запись не была найдена.",
                            "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                        return;
                    }
                    Participant pE = ParentF.db.Participants.FirstOrDefault(p => p.ResultId == rE.Id);
                    if (pE == null)
                    {
                        DialogResult res = MessageBox.Show("Связанный участник был найден.",
                            "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DialogResult Ask = MessageBox.Show("Вы уверены что хотите удалить данную запись?\n" +
                        "Результат для участника:\n" +
                        dataGridView1.Rows[oneCell.RowIndex].Cells[1].Value.ToString(),
                            "Вопрос есть", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (Ask == DialogResult.OK)
                    {
                        ParentF.db.Results.Remove(rE);
                        pE.ResultId = 0;
                        ParentF.db.SaveChanges();
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                        labelCount.Text = ParentF.db.Participants.ToList().Count.ToString();
                    }
                }
            }
        }
    }
}
