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
    public partial class PMyProphile : WSRussia.PBase
    {
        public PMyProphile()
        {
            InitializeComponent();
            labelPageTitle.Text = "Мой профиль";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                panel1.Enabled = true;
                panel1.Visible = true;
            }
            else
            {
                panel1.Enabled = false;
                panel1.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.UseSystemPasswordChar = false;
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void PMyProphile_Paint(object sender, PaintEventArgs e)
        {
            if (!String.IsNullOrEmpty(ParentF.Login.PicPath))
            {
                throw new Exception("Sorry, but we don't allow personal pictures there.");
            }
            pictureYou.Image = Properties.Resources.Spidey;
            labelName.Text = ParentF.Login.Name;
            labelSex.Text = (ParentF.Login.Sex == 0) ? "F" : "M";
            labelDoB.Text = ParentF.Login.BDay.ToString("dd/MM/yyyy");
            labelId.Text = ParentF.Login.Id.ToString();
            labelCountry.Text = ParentF.Login.Country;
            labelTNumber.Text = ParentF.Login.ContactNumber;
            labelEMail.Text = ParentF.Login.EMail;
        }

        private void buttonSavePassword_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                DialogResult res = MessageBox.Show("Введите старый пароль",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Person CUser = ParentF.db.Participants.FirstOrDefault(u => u.Id == ParentF.Login.Id);
            if (textBox1.Text != CUser.Password)
            {
                DialogResult res = MessageBox.Show("Старый пароль неверен",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox2.Text == "")
            {
                DialogResult res = MessageBox.Show("Введите новый пароль",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CUser.Password = textBox2.Text;
            ParentF.db.SaveChanges();
            ParentF.UpdateLogin();
        }
    }
}
