using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSREntryGenerator.Models
{
    public class SMP
    {
        public int Id { get; set; }
        public string Time { get; set; }//? how to separate?
        public string Description { get; set; }
    }
}
