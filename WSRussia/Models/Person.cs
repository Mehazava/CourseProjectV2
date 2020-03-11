﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSRussia.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public DateTime BDay { get; set; }
        public string Country { get; set; }
        public string ContactNumber { get; set; }
        public string EMail { get; set; }
        public string PicPath { get; set; }
        public Result Result { get; set; }
        public Competention Competention { get; set; }
    }
}