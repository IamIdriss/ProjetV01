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

        public DbSet<ProjetV01.Shared.Agent> Agent { get; set; }

        public DbSet<ProjetV01.Shared.Mail> Mail { get; set; }

        public DbSet<ProjetV01.Shared.Position> Position { get; set; }
    }
}
