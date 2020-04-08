using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSRussia.Models;

namespace WSRussia
{
    public partial class FormEnterRData : Form
    {
        WSRContext db;
        Participant pE;
        public FormEnterRData()
        {
            InitializeComponent();
        }
        public FormEnterRData(WSRContext maindb, int pId)
        {
            InitializeComponent();
            db = maindb;
            pE = db.Participants.FirstOrDefault(p => p.Id == pId);
            labelName.Text = pE.Name;
        }
        String CheckData()
        {
            if (String.IsNullOrEmpty(textBoxPlace.Text))
            {
                return "Enter the location.";
            }
            if (textBoxPlace.Text.Length > 20)
            {
                return "Location name too long.";
            }
            if (String.IsNullOrEmpty(textBoxChampionship.Text))
            {
                return "Enter the championship.";
            }
            if (textBoxChampionship.Text.Length > 20)
            {
                return "Championship name too long.";
            }
            double[] grade = new double[5];
            try
            {
                grade[0] = double.Parse(textBoxResult1.Text);
                grade[1] = double.Parse(textBoxResult2.Text);
                grade[2] = double.Parse(textBoxResult3.Text);
                grade[3] = double.Parse(textBoxResult4.Text);
                grade[4] = double.Parse(textBoxResult5.Text);
            }
            catch
            {
                return "Wrong result format.";
            }
            for (int i = 0; i < 5; i++)
            {
                if (grade[i] < 0 || grade[i] > 20)
                {
                    return "Grade must be in the range of 0 to 20.";
                }
            }
            return null;
        }
        private void button1_Click(object sender, EventArgs e)//save
        {
            String CheckState = CheckData();
            if (CheckState != null)
            {
                DialogResult res = MessageBox.Show("Ошибка с датой:\n" + CheckState,
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Result newR = new Result()
                {
                    Championship = textBoxChampionship.Text,
                    Location = textBoxPlace.Text,
                    Grade = $"{textBoxResult1.Text} {textBoxResult2.Text}" +
                    $" {textBoxResult3.Text} {textBoxResult4.Text} {textBoxResult5.Text}"
                };
                db.Results.Add(newR);
                db.SaveChanges();
                pE.ResultId = newR.Id;
                db.SaveChanges();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)//cancel
        {
            this.Close();
        }
    }
}
