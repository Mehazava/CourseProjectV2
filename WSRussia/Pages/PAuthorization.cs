using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WSRussia
{
    public partial class PAuthorization : WSRussia.PBase
    {
        public PAuthorization()
        {
            InitializeComponent();
            labelPageTitle.Text = "Форма авторизации";
            pictureBox1.Image = Properties.Resources.NoRobo;
        }

        private void buttonCancelLogin_Click(object sender, EventArgs e)
        {
            ParentF.GoPage(Page.Title);
        }

        private void buttonLoginGo_Click(object sender, EventArgs e)
        {
            if (textBoxLoginId.Text == "")
            {
                DialogResult res = MessageBox.Show("Заполните поле ID", 
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxLoginPassword.Text == "")
            {
                DialogResult res = MessageBox.Show("Введите пароль",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxPersonType.SelectedIndex == -1)
            {
                DialogResult res = MessageBox.Show("Выберите вашу позицию",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int IdLog;
            if (!int.TryParse(textBoxLoginId.Text, out IdLog))
            {
                DialogResult res = MessageBox.Show("Введенное ID - не число",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (comboBoxPersonType.SelectedIndex)
            {
                case 0:
                    ParentF.Login = ParentF.db.Participants.FirstOrDefault(p =>
                        p.Id == IdLog && p.Password == textBoxLoginPassword.Text);
                    ParentF.LoginType = 1;
                    break;
                case 1:
                    ParentF.Login = ParentF.db.Coordinators.FirstOrDefault(p =>
                        p.Id == IdLog && p.Password == textBoxLoginPassword.Text);
                    ParentF.LoginType = 2;
                    break;
                case 2:
                    ParentF.Login = ParentF.db.Experts.FirstOrDefault(p =>
                        p.Id == IdLog && p.Password == textBoxLoginPassword.Text);
                    ParentF.LoginType = 3;
                    break;
                case 3:
                    ParentF.Login = ParentF.db.Administrators.FirstOrDefault(p =>
                        p.Id == IdLog && p.Password == textBoxLoginPassword.Text);
                    ParentF.LoginType = 4;
                    break;
            }
            if (ParentF.Login == null)
            {
                DialogResult res = MessageBox.Show("Неправильный Id или пароль",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ParentF.LoginType = 0;
                return;
            }
            if (checkBoxRemember.Checked == true)
            {
                try
                {
                    string[] lines = { ParentF.Login.Id.ToString(),
                        ParentF.Login.Password, ParentF.LoginType.ToString() };
                    File.WriteAllLines(Path.Combine(Directory.GetCurrentDirectory(),
                        "login.txt"), lines);
                }
                finally { }
            }
            switch (comboBoxPersonType.SelectedIndex)
            {
                case 0:
                    ParentF.GoPage(Page.Participant);
                    break;
                case 1:
                    ParentF.GoPage(Page.Coordinator);
                    break;
                case 2:
                    ParentF.GoPage(Page.Expert);
                    break;
                case 3:
                    ParentF.GoPage(Page.Administrator);
                    break;
            }
        }
    }
}
