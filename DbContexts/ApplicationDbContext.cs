using Microsoft.EntityFrameworkCore;
using NttProject1.Model;
using System;

namespace NttProject1.DbContexts
{
    public class ApplicationDbContext:DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        }

        public DbSet<Bom> Bom { get; set; }

        public DbSet<BomHead> BomHead { get; set; }

        public DbSet<BomDetail> BomDetail { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BomHead>()
                .HasIndex(p => new { p.BomCode })
                .IsUnique(true);
        }
    }
}
