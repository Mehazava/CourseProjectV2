using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSREntryGenerator.Models;

namespace WSREntryGenerator
{
    public partial class Form1 : Form
    {
        static string[] FMaleNames = {
            "Bob",
            "Igor",
            "Pavel",
            "Mark",
            "Charlie",
            "Peter",
            "John",
            "Sergey",
            "Jabba",
            "Cid",
            "Sam"
        };
        static string[] FFemaleNames =
        {
            "Jane",
            "Sophie",
            "Elena",
            "Darya",
            "Sasha",
            "Tanya",
            "Trisha"
        };
        static string[] SNames =
        {
            "Belkov",
            "Potter",
            "Smith",
            "Sergushev",
            "Preton",
            "Caramba",
            "Dzerghinsky",
            "Parker",
            "Perky"
        };
        static string[] Countries =
        {
            "USA",
            "Russia",
            "Belarus",
            "China",
            "Japan",
            "South Korea",
            "Germany",
            "Italy",
            "Brazil",
            "Canada",
            "Spain",
            "Switzerland"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)//bday
            {
                panelBDay.Enabled = true;
            }
            else
            {
                panelBDay.Enabled = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                panelCompetetion.Enabled = true;
            }
            else
            {
                panelCompetetion.Enabled = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                panelResult.Enabled = true;
            }
            else
            {
                panelResult.Enabled = false;
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Random rnd = new Random();
                int Last = (int)numericUpDown7.Value + (int)numericUpDownQuantity.Value;
                List<Person> people = new List<Person>();
                for (int Id = (int)numericUpDown7.Value; Id < Last; ++Id)
                {
                    Person p = new Person();
                    p.Id = Id;
                    if (checkBox9.Checked)//sex
                    {
                        p.Sex = rnd.Next(0, 2);
                    }
                    else
                    {
                        p.Sex = comboBox1.SelectedIndex;
                    }
                    if (checkBox1.Checked)//Name
                    {
                        if (p.Sex == 1)
                        {
                            p.Name = FMaleNames[rnd.Next(0, FMaleNames.Length)];
                        }
                        else
                        {
                            p.Name = FFemaleNames[rnd.Next(0, FFemaleNames.Length)];
                        }
                        p.Name += " " + SNames[rnd.Next(0, SNames.Length)];
                    }
                    else
                    {
                        p.Name = textBox1.Text;
                    }
                    if (checkBox2.Checked)//Password
                    {
                        p.Password = rnd.Next(100000, 1000000).ToString();
                    }
                    else
                    {
                        p.Password = textBox2.Text;
                    }
                    if (checkBox3.Checked)//Country
                    {
                        p.Country = Countries[rnd.Next(0, Countries.Length)];
                    }
                    else
                    {
                        p.Country =  textBox3.Text;
                    }
                    if (checkBox4.Checked)//mail
                    {
                        p.EMail = String.Join("", p.Name.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                            .Select(s => s.Substring(0, 2)));
                        p.EMail.Replace(" ", string.Empty);
                        p.EMail += rnd.Next(100, 1000).ToString() + "@gmail.com";
                    }
                    else
                    {
                        p.EMail = textBox4.Text + "@gmail.com";
                    }
                    if (checkBox5.Checked)//ConNum
                    {
                        p.ContactNumber = "2" + rnd.Next(100000, 999999).ToString();
                    }
                    else
                    {
                        p.ContactNumber = textBox5.Text;
                    }
                    if (checkBox6.Checked)//Bday
                    {
                        TimeSpan span = dateTimePicker3.Value - dateTimePicker2.Value;
                        p.BDay = dateTimePicker2.Value + TimeSpan.FromMilliseconds(span.TotalMilliseconds * rnd.NextDouble());
                    }
                    else
                    {
                        p.BDay = dateTimePicker1.Value;
                    }
                    if (checkBox7.Checked)//Competention
                    {
                        p.CompetentionId = rnd.Next((int)numericUpDown2.Value, (int)numericUpDown3.Value);
                    }
                    else
                    {
                        p.CompetentionId = (int)numericUpDown1.Value;
                    }
                    if (checkBox8.Checked)//Result
                    {
                        p.ResultId = rnd.Next((int)numericUpDown4.Value, (int)numericUpDown5.Value);
                    }
                    else
                    {
                        p.ResultId = (int)numericUpDown6.Value;
                    }
                    people.Add(p);
                }
                string DPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\"));
                using (var writer = new StreamWriter(DPath + textFilename.Text + ".csv"))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(people);
                    writer.Flush();
                }
            }
        }
    }
}
