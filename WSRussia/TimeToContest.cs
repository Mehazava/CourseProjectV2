using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSRussia
{
    public class TimeToContest
    {
        public TimeToContest()
        {
            ContestDate = DateTime.Parse("2/5/2020");
            myTimer = new Timer();
            myTimer.Interval = 1000;
            myTimer.Tick += UpdateLabel;
            myTimer.Start();
            Label = null;
        }
        private DateTime ContestDate;
        private string EndsWith(int num, int type)
        {
            int OwO;
            if (num / 10 == 1)
            {
                OwO = 3;
            }
            else
            {
                if (num % 10 == 1)
                {
                    OwO = 1;
                }
                else if ((num % 10 < 5) || (num % 10 == 0))
                {
                    OwO = 2;
                }
                else
                {
                    OwO = 3;
                }
            }
            switch (type)
            {
                case 0://days
                    switch (OwO)
                    {
                        case 1: return "день";
                        case 2: return "дня";
                        case 3: return "дней";
                    }
                    break;
                case 1://hours
                    switch (OwO)
                    {
                        case 1: return "час";
                        case 2: return "часа";
                        case 3: return "часов";
                    }
                    break;
                case 2://minutes
                    switch (OwO)
                    {
                        case 1: return "минута";
                        case 2: return "минуты";
                        case 3: return "минут";
                    }
                    break;
            }
            return "error";
        }
        private void UpdateLabel(object sender, EventArgs e)
        {
            if (Label != null)
            {
                Label.Text = RemainingTime;
            }
        }
        private Timer myTimer;
        public Label Label { get; set; }
        public string RemainingTime
        {
            get
            {
                if (ContestDate < DateTime.Now)
                {
                    return "Контест уже начался";
                }
                TimeSpan span = (ContestDate - DateTime.Now);
                return $"{span.Days} {EndsWith(span.Days, 0)}, " +
                    $"{span.Hours} {EndsWith(span.Hours, 1)} и " +
                    $"{span.Minutes} {EndsWith(span.Minutes, 2)} до начала чемпионата!";
            }
        }
    }
}
