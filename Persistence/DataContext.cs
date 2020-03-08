using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Persistence
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options): base(options) { }

        public DbSet<Zone> Zones { get; set; }
        public DbSet<Ville> Villes { get; set; }
        public DbSet<Province> Provinces { get; set; }
    }
}
