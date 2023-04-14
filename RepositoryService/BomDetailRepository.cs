using NttProject1.DbContexts;
using NttProject1.Model;

namespace NttProject1.RepositoryService
{
    public class BomDetailRepository:RepositoryBase<BomDetail>,IBomDetailRepository
    {
        public BomDetailRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext) { 
        }
    }
}
