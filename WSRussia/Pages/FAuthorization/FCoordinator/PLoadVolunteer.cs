using CsvHelper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WSRussia.Models;

namespace WSRussia
{
    public partial class PLoadVolonteur : WSRussia.PBase
    {
        string filePath = null;
        List<Volunteer> replaced = new List<Volunteer>();
        List<int> added = new List<int>();
        public PLoadVolonteur()
        {
            InitializeComponent();
            labelPageTitle.Text = "Загрузка волонтеров";
        }

        private void buttonSeek_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                RestoreDirectory = true,
                Title = "Browse Text Files",
                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 1,
                CheckFileExists = true,
                CheckPathExists = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxFileName.Text = openFileDialog1.SafeFileName;
                filePath = openFileDialog1.FileName;
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (filePath == null)
            {
                DialogResult res = MessageBox.Show("Выберите фаил",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            replaced.Clear();
            added.Clear();
            labelLine1.Text = "";
            labelLine1.Text = "";
            try
            {
                List<Volunteer> vls = new List<Volunteer>();
                int NewR = 0;
                int ReR = 0;
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    vls.AddRange(csv.GetRecords<Volunteer>());
                }
                foreach (var v in vls)
                {
                    if (String.IsNullOrEmpty(v.Name))
                    {
                        throw new Exception("Record had no name.");
                    }
                    if (v.Sex != 0 && v.Sex != 1)
                    {
                        throw new Exception("Record has weird sex.");
                    }
                    if (String.IsNullOrEmpty(v.Place))
                    {
                        throw new Exception("Record had no name.");
                    }
                    if (v.CompetentionId < 1 || ParentF.db.Competentions
                        .FirstOrDefault(c => c.Id == v.CompetentionId) == null)
                    {
                        throw new Exception("Record has bad competention id.");
                    }
                    if (v.Id < 0)
                    {
                        throw new Exception("Record has bad id.");
                    }
                    else if (v.Id == 0)//new record
                    {
                        ParentF.db.Volunteers.Add(v);
                        ParentF.db.SaveChanges();
                        added.Add(v.Id);
                        NewR++;
                    }
                    else if ((ParentF.db.Volunteers.FirstOrDefault(vol => vol.Id == v.Id)) == null)//new record with id
                    {
                        ParentF.db.Database.OpenConnection();
                        ParentF.db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Volunteers ON;");
                        ParentF.db.Volunteers.Add(v);
                        ParentF.db.SaveChanges();
                        added.Add(v.Id);
                        ParentF.db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Volunteers OFF;");
                        ParentF.db.Database.CloseConnection();
                        NewR++;
                    }
                    else//edit record
                    {
                        var rec = ParentF.db.Volunteers.FirstOrDefault(vol => vol.Id == v.Id);
                        replaced.Add(new Volunteer
                        {
                            Id = rec.Id,
                            Sex = rec.Sex,
                            CompetentionId = rec.CompetentionId,
                            Place = rec.Place,
                            Name = rec.Name
                        });
                        ParentF.db.Entry(rec).CurrentValues.SetValues(v);
                        ParentF.db.SaveChanges();
                        ReR++;
                    }
                }
                labelLine1.Text = "Загрузка завершена успешно!";
                labelLine2.Text = $"Всего загружено {ReR + NewR} записей. Новых {NewR}. Перезаписано {ReR}.";
                buttonCancel.Enabled = true;
            }
            catch (Exception excep)
            {
                DialogResult res = MessageBox.Show("Ошибка при импорте данных:\n" + excep.Message,
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                buttonCancel.Enabled = false;
                replaced.Reverse();
                foreach (var v in replaced)
                {
                    var rec = ParentF.db.Volunteers.FirstOrDefault(vol => vol.Id == v.Id);
                    ParentF.db.Entry(rec).CurrentValues.SetValues(v);
                }
                foreach (var i in added)
                {
                    Volunteer ToDel = ParentF.db.Volunteers.FirstOrDefault(v => v.Id == i);
                    ParentF.db.Volunteers.Remove(ToDel);
                }
                ParentF.db.SaveChanges();
                replaced.Clear();
                added.Clear();
                labelLine1.Text = "Последние изменения отменены";
                labelLine1.Text = "";
            }
            catch (Exception excep)
            {
                DialogResult res = MessageBox.Show("Ошибка при отмене изменений:\n" + excep.Message,
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
