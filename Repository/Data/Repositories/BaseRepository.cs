using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Repository.Data.Interfaces;

namespace Repository.Data.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private CompanyDbContext DbContext;

        public BaseRepository(CompanyDbContext DbContext)
        {
            this.DbContext = DbContext;
        }

        public void Delete(T entity)
        {
            DbContext.Set<T>().Remove(entity);
        }

        public T Get(int id)
        {
            return DbContext.Set<T>().Find(id);
        }

        public int Insert(T entity)
        {
            DbContext.Set<T>().Add(entity);
            return DbContext.SaveChanges();
        }

        public IList<T> List()
        {
            return DbContext.Set<T>().ToList();
        }

        public IList<T> List(Expression<Func<T, bool>> expression)
        {
            return DbContext.Set<T>().Where(expression).ToList();
        }

        public int Update(T entity)
        {
            DbContext.Entry<T>(entity).State = EntityState.Modified;
            return DbContext.SaveChanges();
        }
    }
}