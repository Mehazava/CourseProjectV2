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
    public partial class PEditSponsor : WSRussia.PBase
    {
        public PEditSponsor()
        {
            InitializeComponent();
            labelPageTitle.Text = "Управление спонсорами";
        }

        void LoadGrid()
        {
            dataGridView1.Rows.Clear();

            foreach (var item in ParentF.db.Sponsors)
            {
                dataGridView1.Rows.Add(item.Id, item.Name, item.Link);
            }
            ApplyFilter();
        }

        void ApplyFilter()
        {
            string filter = textBoxFilter.Text.ToLower();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value.ToString().ToLower().Contains(filter))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        void ClearText()
        {
            textBoxId.Text = "";
            textBoxLink.Text = "";
            textBoxName.Text = "";
            buttonDelete.Enabled = false;
            buttonEdit.Enabled = false;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
            {
                DialogResult res = MessageBox.Show("Выберите элемент",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Sponsor sponsor;
            try
            {
                sponsor = ParentF.db.Sponsors.FirstOrDefault(s => s.Id == int.Parse(textBoxId.Text));
            }
            catch
            {
                DialogResult res = MessageBox.Show("Ошибка при взятии Id",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sponsor == null)
            {
                DialogResult res = MessageBox.Show("Ошибка при взятии элемента",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sponsor.Link = textBoxLink.Text;
            sponsor.Name = textBoxName.Text;
            ParentF.db.SaveChanges();
            LoadGrid();
            ClearText();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
            {
                DialogResult res = MessageBox.Show("Выберите элемент",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Sponsor sponsor;
            try
            {
                sponsor = ParentF.db.Sponsors.FirstOrDefault(s => s.Id == int.Parse(textBoxId.Text));
            }
            catch
            {
                DialogResult res = MessageBox.Show("Ошибка при взятии Id",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sponsor == null)
            {
                DialogResult res = MessageBox.Show("Ошибка при взятии элемента",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ParentF.db.Sponsors.Remove(sponsor);
            ParentF.db.SaveChanges();
            LoadGrid();
            ClearText();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                DialogResult res = MessageBox.Show("Предоставте имя",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxLink.Text == "")
            {
                DialogResult res = MessageBox.Show("Предоставте ссылку",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Sponsor sponsor = new Sponsor();
            sponsor.Link = textBoxLink.Text;
            sponsor.Name = textBoxName.Text;
            ParentF.db.Sponsors.Add(sponsor);
            ParentF.db.SaveChanges();
            LoadGrid();
            ClearText();
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
            Sponsor sponsor = ParentF.db.Sponsors.FirstOrDefault(s => s.Id == SId);
            if (sponsor == null)
            {
                DialogResult res = MessageBox.Show("Ошибка при взятии элемента",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBoxId.Text = sponsor.Id.ToString();
            textBoxLink.Text = sponsor.Link;
            textBoxName.Text = sponsor.Name;
            buttonDelete.Enabled = true;
            buttonEdit.Enabled = true;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void PEditSponsor_Load(object sender, EventArgs e)
        {
            if (ParentF != null)
            {
                LoadGrid();
            }
        }
    }
}
