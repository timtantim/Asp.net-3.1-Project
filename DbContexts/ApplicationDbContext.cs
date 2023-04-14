using Microsoft.EntityFrameworkCore;
using NttProject1.Model;

namespace NttProject1.DbContexts
{
    public class ApplicationDbContext:DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        }

        public DbSet<Bom> Bom { get; set; }
    }
}
