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
using System.Windows.Forms;

namespace WSRussia.Models
{
    public class WSRContext : DbContext
    {
        public DbSet<Championship> Championships { get; set; }
        public DbSet<Competention> Competentions { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Coordinator> Coordinators { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Infrastructure> Infrastructures { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<SMP> SMPs { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }

        public WSRContext()
        {
            //if (!(Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists())
            Database.EnsureDeleted();
            Database.EnsureCreated();
            if (!Participants.Any())
            {
                string DPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
                DPath += "\\CSV\\";
                Database.OpenConnection();
                using (var reader = new StreamReader(DPath + "Participants.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    Participants.AddRange(csv.GetRecords<Participant>());
                }
                Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Participants ON;");
                SaveChanges();
                Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Participants OFF;");
                using (var reader = new StreamReader(DPath + "Experts.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    Experts.AddRange(csv.GetRecords<Expert>());
                }
                Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Experts ON;");
                SaveChanges();
                Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Experts OFF;");
                using (var reader = new StreamReader(DPath + "Admins.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    Administrators.AddRange(csv.GetRecords<Administrator>());
                }
                Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Administrators ON;");
                SaveChanges();
                Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Administrators OFF;");
                using (var reader = new StreamReader(DPath + "Coordinators.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    Coordinators.AddRange(csv.GetRecords<Coordinator>());
                }
                Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Coordinators ON;");
                SaveChanges();
                Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Coordinators OFF;");
                List<Competention> temp = new List<Competention>();
                using (var reader = new StreamReader(DPath + "Competentions.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    temp.AddRange(csv.GetRecords<Competention>());
                }
                using (var reader = new StreamReader(DPath + "CompetentionDesc.txt", Encoding.Default))
                {
                    Competention CurrC;
                    for (int Counter = 1; Counter <= temp.Count; Counter++)//relies on competencies being consequentioal from 1
                    {
                        CurrC = temp.FirstOrDefault(c => c.Id == Counter);
                        CurrC.Description = reader.ReadLine();
                    }
                }
                Competentions.AddRange(temp);
                Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Competentions ON;");
                SaveChanges();
                Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Competentions OFF;");
                using (var reader = new StreamReader(DPath + "Championships.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    Championships.AddRange(csv.GetRecords<Championship>());
                }
                Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Championships ON;");
                SaveChanges();
                Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Championships OFF;");
                Database.CloseConnection();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(Properties.Settings.Default.DBConnection);
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = WSRdb; Trusted_Connection = True;");
        }
    }
}
