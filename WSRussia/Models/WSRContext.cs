using CsvHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
            if (!(Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists())
            {
                Database.EnsureCreated();
                string DPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
                DPath += "\\CSV\\";
                using (var reader = new StreamReader(DPath + "Participants.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    Participants.AddRange(csv.GetRecords<Person>());
                }
                using (var reader = new StreamReader(DPath + "Experts.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    Experts.AddRange(csv.GetRecords<Person>());
                }
                using (var reader = new StreamReader(DPath + "Admins.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    Administrators.AddRange(csv.GetRecords<Person>());
                }
                using (var reader = new StreamReader(DPath + "Volonteurs.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    Volonteurs.AddRange(csv.GetRecords<Person>());
                }
                this.SaveChanges();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Properties.Settings.Default.DBConnection);
        }
    }
}
