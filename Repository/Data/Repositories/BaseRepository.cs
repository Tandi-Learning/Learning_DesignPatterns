using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Repository.Data.Interfaces;
using Repository.Data.Repositories;

namespace Repository.Data.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private CompanyDbContext _dbContext;

        public BaseRepository(CompanyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public virtual T Get(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public virtual T Insert(T entity)
        {
            var result = _dbContext.Set<T>().Add(entity);

            return result.Entity;
        }

        public virtual IEnumerable<T> List()
        {
            return _dbContext.Set<T>().ToList();
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _dbContext.Set<T>().AsQueryable()
                .Where(expression)
                .ToList();
        }

        public virtual T Update(T entity)
        {
            _dbContext.Entry<T>(entity).State = EntityState.Modified;

            return entity;
        }

        public virtual void Save()
        {
        }
    }
}