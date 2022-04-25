#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetV01.Shared;

namespace ProjetV01.Server.Data
{
    public class ProjetV01DbContext : DbContext
    {
        public ProjetV01DbContext (DbContextOptions<ProjetV01DbContext> options)
            : base(options)
        {
        }

        private const string connectionString = "Server=DESKTOP-JDGBI4U;Database=ProjetV01DB;Trusted_Connection=True;MultipleActiveResultSets=true;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connectionString);
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjetV01.Shared.Mail>()
                .Property(Mail => Mail.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<ProjetV01.Shared.Agent>()
               .Property(Agent => Agent.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<ProjetV01.Shared.Position>()
               .Property(Position => Position.Id).ValueGeneratedOnAdd();

        }

        public DbSet<ProjetV01.Shared.Agent> Agent { get; set; }

        public DbSet<ProjetV01.Shared.Mail> Mail { get; set; }

        public DbSet<ProjetV01.Shared.Position> Position { get; set; }
    }
}
