using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSRussia.Models
{
    public class Infrastructure
    {
        public int Id { get; set; }
        public int Position { get; set; }//position in list
        public int Next { get; set; }//id of next in list
        public string Name { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        public string Measurement { get; set; }
        public int Amount { get; set; }
    }
}
