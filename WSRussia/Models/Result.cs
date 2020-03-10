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
        public Person Person { get; set; }
        //competention is throug person
        public string Time { get; set; }//separated by spaces
    }
}
