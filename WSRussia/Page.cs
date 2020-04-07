using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSRussia
{
    public enum Page
    {
        Title = 0,

        AboutWS = 1,
            HistoryWS = 10,
            Competencies = 11,
            Championships = 12,
        AboutWSRussia = 2,
        AboutPrim = 3,
        Authorization = 4,
            Participant = 40,
                MyProfile = 400,
                MyCompetention = 401,
                MyResults = 402,
            Coordinator = 41,
                EditVolunteer = 410,
                    LoadVolunteer = 4100,
                    DistributeVolunteer = 4101,
                EditSponsor = 411,
                MyResultsCoor = 412,
            Administrator = 42,
                EditChampionship = 420,
                EditParticipant = 421,
                    AddParticipant = 4210,
                    ModParticipant = 4211,
            Expert = 43,
                Draw = 430,
                Rating = 431,
                CheckResults = 432,
        Error = 666
    }
}
