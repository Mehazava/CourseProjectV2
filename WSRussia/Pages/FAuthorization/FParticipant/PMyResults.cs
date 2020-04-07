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
    public partial class PMyResults : WSRussia.PBase
    {
        Result result;
        public PMyResults()
        {
            InitializeComponent();
            labelPageTitle.Text = "Мои результаты";
        }

        private void PMyResults_Load(object sender, EventArgs e)
        {
            if (ParentF == null)
            {
                return;
            }
            result = ParentF.db.Results.FirstOrDefault(r => r.PersonId == ParentF.Login.Id);
            if (result == null)
            {
                throw new Exception("Result not found.");
            }
            labelName.Text = ParentF.Login.Name;
            labelRId.Text = result.Id.ToString();
            labelPlace.Text = result.Location;
            labelSex.Text = ParentF.Login.Sex == 0 ? "Female" : "Male";
            labelChampionship.Text = result.Championship;
            labelCompetention.Text = ParentF.db.Competentions
                .FirstOrDefault(c => c.Id == ParentF.Login.CompetentionId)?.Name;
            labelPersonId.Text = ParentF.Login.Id.ToString();
            char[] separator = { ' ' };
            List<string> marks = result.Grade.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
            textBoxM1.Text = marks[0];
            textBoxM2.Text = marks[1];
            textBoxM3.Text = marks[2];
            textBoxM4.Text = marks[3];
            textBoxM5.Text = marks[4];
            try
            {
                labelFResult.Text = marks.Select(s => Double.Parse(s)).Sum().ToString();
            }
            catch
            {
                throw new Exception("Corrupted marks data.");
            }
        }
    }
}
