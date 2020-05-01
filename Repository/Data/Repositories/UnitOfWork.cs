using Repository.Data;

namespace Repository.Repositories
{
    public class UnitOfWork
    {
        private CompanyDbContext _dbContext;

        public UnitOfWork(CompanyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}