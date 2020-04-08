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
    public partial class PEditChampionship : WSRussia.PBase
    {
        public PEditChampionship()
        {
            InitializeComponent();
            labelPageTitle.Text = "Управление чемпионатами";
        }
        void LoadGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in ParentF.db.Championships.ToList())
            {
                dataGridView1.Rows.Add(item.Id, item.Location, item.Year, item.Participants);
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
        String CellValid(int row, int col)
        {
            int cId;
            switch (col)
            {
                case 0://id
                    break;
                case 1://place
                    if (String.IsNullOrEmpty(dataGridView1.Rows[row].Cells[col].Value?.ToString()))
                    {
                        return "Enter the place.";
                    }
                    if (dataGridView1.Rows[row].Cells[col].Value.ToString().Length > 20)
                    {
                        return "Place name too long.";
                    }
                    break;
                case 2://year
                    if (String.IsNullOrEmpty(dataGridView1.Rows[row].Cells[col].Value?.ToString()))
                    {
                        return "Enter the year.";
                    }
                    try
                    {
                        cId = int.Parse(dataGridView1.Rows[row].Cells[col].Value.ToString());
                    }
                    catch
                    {
                        return "Year is not a number.";
                    }
                    break;
                case 3://participants
                    if (String.IsNullOrEmpty(dataGridView1.Rows[row].Cells[col].Value?.ToString()))
                    {
                        return "Enter the amount of participants.";
                    }
                    if (dataGridView1.Rows[row].Cells[col].Value.ToString().Length > 20)
                    {
                        return "Number of participants data too long.";
                    }
                    break;
            }
            return null;
        }

        private void PEditChampionship_Load(object sender, EventArgs e)
        {
            if (ParentF != null)
            {
                comboBoxField.SelectedIndex = 0;
                labelCount.Text = ParentF.db.Championships.ToList().Count.ToString();
                LoadGrid();
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

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            String err = CellValid(e.RowIndex, e.ColumnIndex);
            if (String.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString()))//is for created element
            {
                if (err != null)
                {
                    DialogResult res = MessageBox.Show("Плохое значение клетки:\n" + err,
                        "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                    return;
                }
                else
                {
                    for (int i = 1; i <= 3; i++)//check new row
                    {
                        if (CellValid(e.RowIndex, i) != null)
                        {
                            return;
                        }
                    }
                    try
                    {
                        DataGridViewCellCollection r = dataGridView1.Rows[e.RowIndex].Cells;
                        Championship newP = new Championship
                        {
                            Location = r[1].Value.ToString(),
                            Year = int.Parse(r[2].Value.ToString()),
                            Participants = r[3].Value.ToString()
                        };
                        ParentF.db.Championships.Add(newP);
                        ParentF.db.SaveChanges();
                        r[0].Value = newP.Id;
                        DialogResult res = MessageBox.Show("Новая запись добавлена",
                            "Ну ок", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        DialogResult res = MessageBox.Show("Ошибка при добавлении элемента.",
                            "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                int pId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                Championship pE = ParentF.db.Championships.FirstOrDefault(p => p.Id == pId);
                if (pE == null)
                {
                    DialogResult res = MessageBox.Show("Соревнование не найдено.",
                        "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (err != null)
                {
                    object oldVal = null;
                    DialogResult res = MessageBox.Show("Плохое значение клетки:\n" + err,
                        "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    switch (e.ColumnIndex)//restore data from db
                    {
                        case 0: oldVal = pE.Id; break;
                        case 1: oldVal = pE.Location; break;
                        case 2: oldVal = pE.Year; break;
                        case 3: oldVal = pE.Participants; break;
                    }
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldVal;
                    return;
                }
                else
                {
                    object newVal = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    switch (e.ColumnIndex)//write data to db
                    {
                        case 0:
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = pE.Id;
                            break;
                        case 1: pE.Location = newVal.ToString(); break;
                        case 2: pE.Year = int.Parse(newVal.ToString()); break;
                        case 3: pE.Participants = newVal.ToString(); break;
                    }
                }
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
                    Championship pE = ParentF.db.Championships.FirstOrDefault(p => p.Id == pId);
                    if (pE == null)
                    {
                        DialogResult res = MessageBox.Show("Запись не была найдена.",
                            "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                        return;
                    }
                    DialogResult Ask = MessageBox.Show($"Вы уверены что хотите удалить данную запись? Id: {pId}",
                            "Вопрос есть", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (Ask == DialogResult.OK)
                    {
                        ParentF.db.Championships.Remove(pE);
                        ParentF.db.SaveChanges();
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                        labelCount.Text = ParentF.db.Championships.ToList().Count.ToString();
                    }
                }
            }
        }
    }
}
