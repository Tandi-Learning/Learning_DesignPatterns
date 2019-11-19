using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Repository.Data.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        T Get(int id);
        IList<T> List();
        IList<T> List(Expression<Func<T, bool>> expression);
        int Insert(T entity);
        int Update(T entity);
        void Delete(T entity);
    }
}