using LogHandler.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogHandler.DAL
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext()
        { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LogsDb;Trusted_Connection=True;MultipleActiveResultSets=true")
                    .LogTo(Console.WriteLine);
            }
        }


        public DbSet<Log> Logs { get; set; }
        public DbSet<Subsystem> Subsystems { get; set; }
        public DbSet<Entities.Type> Types { get; set; }

    }
}
