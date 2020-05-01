using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Repository.Data.Interfaces;
using Repository.Repositories;

namespace Repository.Data.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private CompanyDbContext _dbContext;
        private UnitOfWork _uow;

        public BaseRepository(
            CompanyDbContext dbContext,
            UnitOfWork uow)
        {
            _dbContext = dbContext;
            _uow = uow;
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            // _dbContext.SaveChanges(); // moved to unit of work
            _uow.Save();
        }

        public T Get(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            // _dbContext.SaveChanges(); // moved to unit of work
            _uow.Save();
        }

        public IList<T> List()
        {
            return _dbContext.Set<T>().ToList();
        }

        public IList<T> List(Expression<Func<T, bool>> expression)
        {
            return _dbContext.Set<T>().Where(expression).ToList();
        }

        public void Update(T entity)
        {
            _dbContext.Entry<T>(entity).State = EntityState.Modified;
            // _dbContext.SaveChanges();  // moved to unit of work
            _uow.Save();
        }
    }
}