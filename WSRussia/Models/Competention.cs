﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSRussia.Models
{
    public class Competention
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [MaxLength(2000)]
        public string Description { get; set; }
        //by groups they are separated in tree:
        //1 : Civ transport maintenance
        //2 : Building specialists
        //3 : Industrial specialists
        //4 : Comm&Info specialists
        //5 : Art&Design
        //6 : kk
        public int Group { get; set; }
        public int SMP { get; set; }
        public int Infrastructure { get; set; }
        public string MapPath { get; set; }
    }
}
