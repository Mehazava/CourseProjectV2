using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSRussia.Models;

namespace WSRussia
{
    public partial class MainForm : Form
    {
        private TimeToContest TimeRemaining;
        private Page CurrentPage;
        private UserControl ControlPage;
        public WSRContext db;
        public Person Login;
        public int LoginType;//0 - no, 1 - parti, 2 - coor, 3 - expe, 4 - admi 
        public MainForm()
        {
            InitializeComponent();
            TimeRemaining = new TimeToContest();
            TimeRemaining.Label = labelTimeRemaining;
            CurrentPage = Page.Error;
            db = new WSRContext();
            if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "login.txt")))
            {
                try
                {
                    string[] log = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "login.txt"));
                    int lid = int.Parse(log[0]);
                    int lty = int.Parse(log[2]);
                    Login = null;
                    switch (lty)
                    {
                        case 1:
                            Login = db.Participants.FirstOrDefault(p =>
                                p.Id == lid && p.Password == log[1]);
                            break;
                        case 2:
                            Login = db.Coordinators.FirstOrDefault(p =>
                                p.Id == lid && p.Password == log[1]);
                            break;
                        case 3:
                            Login = db.Experts.FirstOrDefault(p =>
                                p.Id == lid && p.Password == log[1]);
                            break;
                        case 4:
                            Login = db.Administrators.FirstOrDefault(p =>
                                p.Id == lid && p.Password == log[1]);
                            break;
                    }
                    if (Login == null)
                    {
                        LoginType = 0;
                        DialogResult reso = MessageBox.Show("Record for autologin not found",
                            "Не так надо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LoginType = lty;
                    }
                }
                catch
                {
                    Login = null;
                    LoginType = 0;
                }
            }
            else
            {
                Login = null;
                LoginType = 0;
            }
            ControlPage = null;
            GoPage(Page.Title);
        }
        public void GoPage(Page page)
        {
            SetupForm(page);
            CurrentPage = page;
        }
        public void UpdateLogin()
        {
            Person GetUser = null;
            switch (LoginType)
            {
                case 1:
                    GetUser = db.Participants.FirstOrDefault(u => u.Id == Login.Id);
                    break;
                case 2:
                    GetUser = db.Coordinators.FirstOrDefault(u => u.Id == Login.Id);
                    break;
                case 3:
                    GetUser = db.Experts.FirstOrDefault(u => u.Id == Login.Id);
                    break;
                case 4:
                    GetUser = db.Administrators.FirstOrDefault(u => u.Id == Login.Id);
                    break;
            }
            if (GetUser == null)
            {
                throw new Exception("User not found.");
            }
            Login = GetUser;
        }
        private void SetupForm(Page page)
        {
            if (Login == null)
            {
                buttonLogout.Enabled = false;
                buttonLogout.Visible = false;
            }
            else
            {
                buttonLogout.Enabled = true;
                buttonLogout.Visible = true;
            }
            if (page == Page.Title)
            {
                if (CurrentPage != Page.Title)
                {
                    pictureBoxLogo.SetBounds(25, 25, 100, 100);
                    pictureBoxLogo.Image = Properties.Resources.Logo100_100;
                    buttonBack.Enabled = false;
                    buttonBack.Hide();
                    labelCLocation.Show();
                    labelCTime.Show();
                    panelPage.Height = 400;
                    panelPage.Top = 134;
                    this.Text = "WSR 2020";
                }
                PTitle SelectPage = new PTitle();
                if (Login != null)
                {
                    SelectPage.buttonGoLogin.Text = "User's page";
                }
                else
                {
                    SelectPage.buttonGoLogin.Text = "Login";
                }
                if (SelectPage == null)
                {
                    throw new Exception("Failed to construct a page.");
                }
                SelectPage.Dock = DockStyle.Fill;
                this.panelPage.Controls.Add(SelectPage);
                this.panelPage.Controls.Remove(ControlPage);
                ControlPage = SelectPage;
            }
            else
            {
                PBase SelectPage = null;
                if (CurrentPage == Page.Title || CurrentPage == Page.Error)
                {
                    pictureBoxLogo.SetBounds(12, 12, 100, 50);
                    pictureBoxLogo.Image = Properties.Resources.Logo100_50;
                    buttonBack.Enabled = true;
                    buttonBack.Show();
                    labelCLocation.Hide();
                    labelCTime.Hide();
                    panelPage.Height = 468;
                    panelPage.Top = 66;
                }
                switch (page)
                {
                    case Page.AboutWS:
                        SelectPage = new PAboutWS();
                        break;
                    case Page.Championships:
                        SelectPage = new PChampionships();
                        break;
                    case Page.Competencies:
                        SelectPage = new PCompetencies();
                        break;
                    case Page.HistoryWS:
                        SelectPage = new PHistoryWS();
                        break;
                    case Page.AboutWSRussia:
                        SelectPage = new PAboutWSRussia();
                        break;
                    case Page.AboutPrim:
                        SelectPage = new PAboutPrim();
                        break;
                    case Page.Authorization:
                        SelectPage = new PAuthorization();
                        break;
                    case Page.EditChampionship:
                        SelectPage = new PEditChampionship();
                        break;
                    case Page.EditParticipant:
                        SelectPage = new PEditParticipant();
                        break;
                    case Page.CheckResults:
                        SelectPage = new PCheckResults();
                        break;
                    case Page.Draw:
                        SelectPage = new PDraw();
                        break;
                    case Page.Rating:
                        SelectPage = new PRating();
                        break;
                    case Page.MyCompetention:
                        SelectPage = new PMyCompetention();
                        break;
                    case Page.MyProfile:
                        SelectPage = new PMyProphile();
                        break;
                    case Page.MyResults:
                        SelectPage = new PMyResults();
                        break;
                    case Page.DistributeVolunteer:
                        SelectPage = new PDistributeVolonteur();
                        break;
                    case Page.EditVolunteer:
                        SelectPage = new PEditVolonteur();
                        break;
                    case Page.EditSponsor:
                        SelectPage = new PEditSponsor();
                        break;
                    case Page.LoadVolunteer:
                        SelectPage = new PLoadVolonteur();
                        break;
                    case Page.MyResultsCoor:
                        SelectPage = new PMyResultsCoor();
                        break;
                    case Page.Participant:
                        SelectPage = new PParticipant();
                        break;
                    case Page.Expert:
                        SelectPage = new PExpert();
                        break;
                    case Page.Coordinator:
                        SelectPage = new PCoordinator();
                        break;
                    case Page.Administrator:
                        SelectPage = new PAdministrator();
                        break;
                }
                if (SelectPage == null)
                {
                    throw new Exception("Failed to construct a page.");
                }
                SelectPage.Dock = DockStyle.Fill;
                this.panelPage.Controls.Add(SelectPage);
                this.panelPage.Controls.Remove(ControlPage);
                ControlPage = SelectPage;
                this.Text = "WSR 2020 - " + SelectPage.labelPageTitle.Text;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            GoPage((Page)((int)CurrentPage / 10));
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login = null;
            LoginType = 0;
            if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "login.txt")))
            {
                File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "login.txt"));
            }
            GoPage(Page.Title);
        }
    }
}
