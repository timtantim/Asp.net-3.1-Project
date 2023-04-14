using NttProject1.DbContexts;
using NttProject1.Model;

namespace NttProject1.RepositoryService
{
    public class BomHeadRepository:RepositoryBase<BomHead>,IBomHeadRepository
    {
        public BomHeadRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        { 
        }
    }
}
