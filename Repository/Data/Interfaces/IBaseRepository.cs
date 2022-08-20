using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Repository.Data.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> List();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        T Insert(T entity);
        T Update(T entity);
        void Delete(T entity);
        void Save();
    }
}