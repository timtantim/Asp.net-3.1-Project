using Microsoft.EntityFrameworkCore;
using NttProject1.Model;

namespace NttProject1.DbContexts
{
    public interface IApplicationDbContext
    {
        DbSet<Bom> Bom { get; set; }

    }
}
