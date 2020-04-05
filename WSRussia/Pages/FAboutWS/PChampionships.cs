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
    public partial class PChampionships : WSRussia.PBase
    {
        public PChampionships()
        {
            InitializeComponent();
            labelPageTitle.Text = "Чемпионаты стран WSI";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    DialogResult res = MessageBox.Show("Выберите только один фильтр",
                        "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Championship champ;
                try
                {
                    champ = ParentF.db.Championships.FirstOrDefault(c => c.Id == int.Parse(textBox1.Text));
                }
                catch
                {
                    DialogResult res = MessageBox.Show("Введенное ID - не число",
                        "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (champ == null)
                {
                    DialogResult res = MessageBox.Show("Не найдено элементов с этим ID",
                        "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(champ.Id, champ.Year, champ.Location, champ.Participants);
                }
            }
            else
            {
                List<Championship> champs = new List<Championship>();
                champs = ParentF.db.Championships.Where(c => c.Location.Contains(textBox2.Text)).ToList();
                if (champs.Count == 0)
                {
                    DialogResult res = MessageBox.Show("Не найдено элементов с такой локацией",
                        "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataGridView1.Rows.Clear();
                foreach (var c in champs)
                {
                    dataGridView1.Rows.Add(c.Id, c.Year, c.Location, c.Participants);
                }
            }
            labelRecordCount.Text = "Число записей: " + dataGridView1.Rows.Count;
        }

        private void PChampionships_Load(object sender, EventArgs e)
        {
            if (ParentF == null)
            {
                return;
            }
            foreach (var c in ParentF.db.Championships)
            {
                dataGridView1.Rows.Add(c.Id, c.Year, c.Location, c.Participants);
            }
            labelRecordCount.Text = "Число записей: " + dataGridView1.Rows.Count;
        }
    }
}
