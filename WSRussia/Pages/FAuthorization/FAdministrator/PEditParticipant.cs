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
    public partial class PEditParticipant : WSRussia.PBase
    {
        Dictionary<int, String> Comps = new Dictionary<int, string>();
        String[] Sex = { "Жен.", "Муж." };
        public PEditParticipant()
        {
            InitializeComponent();
            labelPageTitle.Text = "Управление участниками";
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
        String CellValid(int row, int col)
        {
            int cId;
            String sNum;
            switch (col)
            {
                case 0://id
                    break;
                case 1://name
                    if (String.IsNullOrEmpty(dataGridView1.Rows[row].Cells[col].Value?.ToString()))
                    {
                        return "Enter the name.";
                    }
                    if (dataGridView1.Rows[row].Cells[col].Value.ToString().Length > 20)
                    {
                        return "Name too long.";
                    }
                    break;
                case 2://sex
                    if (String.IsNullOrEmpty(dataGridView1.Rows[row].Cells[col].Value?.ToString()))
                    {
                        return "Choose sex.";
                    }
                    break;
                case 3://country
                    if (String.IsNullOrEmpty(dataGridView1.Rows[row].Cells[col].Value?.ToString()))
                    {
                        return "Enter the country.";
                    }
                    if (dataGridView1.Rows[row].Cells[col].Value.ToString().Length > 20)
                    {
                        return "Country name too long.";
                    }
                    break;
                case 4://competention
                    if (String.IsNullOrEmpty(dataGridView1.Rows[row].Cells[col].Value?.ToString()))
                    {
                        return "Choose competention.";
                    }
                    try
                    {
                        sNum = dataGridView1.Rows[row].Cells[col].Value.ToString();
                        cId = int.Parse(sNum.Substring(0, sNum.IndexOf(' ')));
                    }
                    catch
                    {
                        return "Competention id is not a number.";
                    }
                    if (ParentF.db.Competentions.FirstOrDefault(c => c.Id == cId) == null)
                    {
                        return "Competention not found.";
                    }
                    break;
                case 5://result
                    if (String.IsNullOrEmpty(dataGridView1.Rows[row].Cells[col].Value?.ToString()))
                    {
                        return "Write resultId.";
                    }
                    try
                    {
                        cId = int.Parse(dataGridView1.Rows[row].Cells[col].Value.ToString());
                    }
                    catch
                    {
                        return "ResultId is not a number.";
                    }
                    if (cId != 0 && ParentF.db.Results.FirstOrDefault(c => c.Id == cId) == null)
                    {
                        return $"Result not found. ({cId})";
                    }
                    break;
                case 6://telephone
                    if (dataGridView1.Rows[row].Cells[col].Value == null)
                    {
                        return null;
                    }
                    if (dataGridView1.Rows[row].Cells[col].Value.ToString().Length > 20)
                    {
                        return "Contact number too long.";
                    }
                    break;
                case 7://email
                    if (dataGridView1.Rows[row].Cells[col].Value == null)
                    {
                        return null;
                    }
                    if (dataGridView1.Rows[row].Cells[col].Value.ToString().Length > 20)
                    {
                        return "Email too long.";
                    }
                    break;
                case 8://bday
                    DateTime dTcheck;
                    if (dataGridView1.Rows[row].Cells[col].Value == null)
                    {
                        return "Enter the birth day.";
                    }
                    try
                    {
                        dTcheck = DateTime.Parse(dataGridView1.Rows[row].Cells[col].Value.ToString());
                    }
                    catch
                    {
                        return "Incorrect bday format.";
                    }
                    break;
                case 9://password
                    if (String.IsNullOrEmpty(dataGridView1.Rows[row].Cells[col].Value?.ToString()))
                    {
                        return "Write password.";
                    }
                    if (dataGridView1.Rows[row].Cells[col].Value.ToString().Length > 20)
                    {
                        return "Password too long.";
                    }
                    break;
                case 10:
                    break;
            }
            return null;
        }

        private void PEditParticipant_Load(object sender, EventArgs e)
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

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
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
                    for (int i = 1; i <= 10; i++)//check new row
                    {
                        if (CellValid(e.RowIndex, i) != null)
                        {
                            return;
                        }
                    }
                    try
                    {
                        DataGridViewCellCollection r = dataGridView1.Rows[e.RowIndex].Cells;
                        Participant newP = new Participant
                        {
                            Name = r[1].Value.ToString(),
                            Sex = r[2].Value.ToString()[0] == 'Ж' ? 0 : 1,
                            Country = r[3].Value.ToString(),
                            CompetentionId = int.Parse(r[4].Value.ToString()
                                .Substring(0, r[4].Value.ToString().IndexOf(' '))),
                            ResultId = int.Parse(r[5].Value.ToString()),
                            ContactNumber = r[6].Value.ToString(),
                            EMail = r[7].Value.ToString(),
                            BDay = DateTime.Parse(r[8].Value.ToString()),
                            Password = r[9].Value.ToString(),
                            PicPath = r[10].Value?.ToString()
                        };
                        ParentF.db.Participants.Add(newP);
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
                Participant pE = ParentF.db.Participants.FirstOrDefault(p => p.Id == pId);
                if (pE == null)
                {
                    DialogResult res = MessageBox.Show("Участник не найден.",
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
                        case 1: oldVal = pE.Name; break;
                        case 2: oldVal = Sex[pE.Sex]; break;
                        case 3: oldVal = pE.Country; break;
                        case 4: oldVal = Comps[pE.CompetentionId]; break;
                        case 5: oldVal = pE.ResultId; break;
                        case 6: oldVal = pE.ContactNumber; break;
                        case 7: oldVal = pE.EMail; break;
                        case 8: oldVal = pE.BDay; break;
                        case 9: oldVal = pE.Password; break;
                        case 10: oldVal = pE.PicPath; break;
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
                        case 1: pE.Name = newVal.ToString(); break;
                        case 2: pE.Sex = newVal.ToString()[0] == 'Ж' ? 0 : 1; break;
                        case 3: pE.Country = newVal.ToString(); break;
                        case 4:
                            String s = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(); 
                            pE.CompetentionId = int.Parse(s.Substring(0, s.IndexOf(' ')));
                            break;
                        case 5: pE.ResultId = int.Parse(newVal.ToString()); break;
                        case 6: pE.ContactNumber = newVal.ToString(); break;
                        case 7: pE.EMail = newVal.ToString(); break;
                        case 8: pE.BDay = DateTime.Parse(newVal.ToString()); break;
                        case 9: pE.Password = newVal.ToString(); break;
                        case 10: pE.PicPath = newVal?.ToString(); break;
                    }

                }
            }
        }
    }
}
