using NttProject1.DbContexts;

namespace NttProject1.RepositoryService
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        private ApplicationDbContext _applicationContext;
        private IBomRepository _bom;


        public RepositoryWrapper(ApplicationDbContext applicationDbContext) {
            _applicationContext = applicationDbContext;
        }
        public IBomRepository Bom {
            get {
                if (_bom == null) {
                    _bom = new BomRepository(_applicationContext);
                }
                return _bom;
            }
        }

        public void save()
        {
            _applicationContext.SaveChanges();
        }
    }
}
