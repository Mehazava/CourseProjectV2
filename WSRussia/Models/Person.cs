using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSRussia.Models
{
    public class Person
    {
        public int Id { get; set; }
        public int Sex { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string EMail { get; set; }
        public string ContactNumber { get; set; }
        public int ResultId { get; set; }
        public int CompetentionId { get; set; }
        public DateTime BDay { get; set; }
        public string PicPath { get; set; }
    }
    public class Participant : Person
    {
    }
    public class Expert : Person
    {
    }
    public class Coordinator : Person
    {
    }
    public class Administrator : Person
    {
    }
}
