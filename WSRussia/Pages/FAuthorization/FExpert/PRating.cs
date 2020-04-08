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
    public partial class PRating : WSRussia.PBase
    {
        Dictionary<int, String> Comps = new Dictionary<int, string>();
        String[] Sex = { "Жен.", "Муж." };
        public PRating()
        {
            InitializeComponent();
            labelPageTitle.Text = "Ввод оценок";
        }
        void LoadGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in ParentF.db.Participants.ToList())
            {
                dataGridView1.Rows.Add(item.Id, item.Name, Sex[item.Sex],
                    item.Country, Comps[item.CompetentionId], item.ResultId,
                        item.ContactNumber, item.EMail, item.BDay, item.Password, item.PicPath);
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

        private void PRating_Load(object sender, EventArgs e)
        {
            if (ParentF != null)
            {
                comboBoxField.SelectedIndex = 0;
                foreach (var i in ParentF.db.Competentions)
                {
                    Comps.Add(i.Id, i.Id + " - " + i.Name);
                    (dataGridView1.Columns[4] as DataGridViewComboBoxColumn)
                        .Items.Add(Comps[i.Id]);
                }
                labelCount.Text = ParentF.db.Participants.ToList().Count.ToString();
                LoadGrid();
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void comboBoxField_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int SId;
            try
            {
                SId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            }
            catch
            {
                DialogResult res = MessageBox.Show("Проблемы с получением Id выбраного ряда",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Participant pE = ParentF.db.Participants.FirstOrDefault(s => s.Id == SId);
            if (pE == null)
            {
                DialogResult res = MessageBox.Show("Ошибка при взятии элемента",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pE.ResultId != 0)
            {
                DialogResult res = MessageBox.Show("У этого участника уже проставлена оценка",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pE = null;
            FormEnterRData DialogF = new FormEnterRData(ParentF.db, SId);
            DialogF.ShowDialog();
            LoadGrid();
        }
    }
}
