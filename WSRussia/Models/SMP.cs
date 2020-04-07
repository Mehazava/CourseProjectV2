using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSRussia.Models
{
    public class SMP
    {
        public int Id { get; set; }
        public int Category { get; set; }//change to if not 0
        public int Next { get; set; }//0 == last in list
        public string Time { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
    }
}
