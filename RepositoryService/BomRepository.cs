using NttProject1.DbContexts;
using NttProject1.Model;

namespace NttProject1.RepositoryService
{
    public class BomRepository : RepositoryBase<Bom>, IBomRepository
    {
        public BomRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

    }
}
