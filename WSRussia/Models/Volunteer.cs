using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSRussia.Models
{
    public class Volunteer
    {
        public int Id {get; set;}
        public int CompetentionId { get; set; }
        //public Competention Competention { get; set; }
        public string Place { get; set; }
        public int Sex { get; set; }
        public string Name { get; set; }
    }
}
