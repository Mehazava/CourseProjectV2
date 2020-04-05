using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                    break;
                case 1:
                    ParentF.Login = ParentF.db.Coordinators.FirstOrDefault(p =>
                        p.Id == IdLog && p.Password == textBoxLoginPassword.Text);
                    break;
                case 2:
                    ParentF.Login = ParentF.db.Experts.FirstOrDefault(p =>
                        p.Id == IdLog && p.Password == textBoxLoginPassword.Text);
                    break;
                case 3:
                    ParentF.Login = ParentF.db.Administrators.FirstOrDefault(p =>
                        p.Id == IdLog && p.Password == textBoxLoginPassword.Text);
                    break;
            }
            if (ParentF.Login == null)
            {
                DialogResult res = MessageBox.Show("Неправильный Id или пароль",
                    "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (comboBoxPersonType.SelectedIndex)
            {
                case 0:
                    ParentF.LoginType = 1;
                    ParentF.GoPage(Page.Participant);
                    break;
                case 1:
                    ParentF.LoginType = 2;
                    ParentF.GoPage(Page.Coordinator);
                    break;
                case 2:
                    ParentF.LoginType = 3;
                    ParentF.GoPage(Page.Expert);
                    break;
                case 3:
                    ParentF.LoginType = 4;
                    ParentF.GoPage(Page.Administrator);
                    break;
            }
        }
    }
}
