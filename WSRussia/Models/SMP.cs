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
        public string Category { get; set; }
        public int Next { get; set; }
        public string Time { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
    }
}
