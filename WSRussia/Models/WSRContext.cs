using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSRussia.Models
{
    public class WSRContext : DbContext
    {
        public DbSet<Championship> Championships { get; set; }
        public DbSet<Competention> Competitions { get; set; }
        public DbSet<Person> Experts { get; set; }
        public DbSet<Person> Volonteurs { get; set; }
        public DbSet<Person> Participants { get; set; }
        public DbSet<Person> Administrators { get; set; }
        public DbSet<Infrastructure> Infrastructures { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<SMP> SMPs { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }

        public WSRContext()
        {
            //if (Database) { }
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Properties.Settings.Default.DBConnection);
        }
    }
}
