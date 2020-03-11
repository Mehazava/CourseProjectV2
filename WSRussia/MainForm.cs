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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            TimeRemaining = new TimeToContest();
            TimeRemaining.Label = labelTimeRemaining;
            CurrentPage = Page.Error;
            ControlPage = null;
            //db = new WSRContext();
            GoPage(Page.Title);
        }
        private TimeToContest TimeRemaining;
        private Page CurrentPage;
        private UserControl ControlPage;
        public WSRContext db;
        public void GoPage(Page page)
        {
            SetupForm(page);
            CurrentPage = page;
        }
        private void SetupForm(Page page)
        {
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
                    case Page.MyProphile:
                        SelectPage = new PMyProphile();
                        break;
                    case Page.MyResults:
                        SelectPage = new PMyResults();
                        break;
                    case Page.DistributeVolonteur:
                        SelectPage = new PDistributeVolonteur();
                        break;
                    case Page.EditVolonteur:
                        SelectPage = new PEditVolonteur();
                        break;
                    case Page.EditSponsor:
                        SelectPage = new PEditSponsor();
                        break;
                    case Page.LoadVolonteur:
                        SelectPage = new PLoadVolonteur();
                        break;
                    case Page.MyResultsCoor:
                        SelectPage = new PMyResultsCoor();
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
    }
}
