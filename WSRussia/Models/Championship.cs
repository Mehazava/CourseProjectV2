using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSRussia.Models
{
    public class Championship
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public int Year { get; set; }
        public int Participants { get; set; }
    }
}
