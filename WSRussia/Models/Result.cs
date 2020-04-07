using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSRussia.Models
{
    public class Result
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Championship { get; set; }
        public string Location { get; set; }
        public string Grade { get; set; }//separated by spaces(15.50 10.00)
    }
}
