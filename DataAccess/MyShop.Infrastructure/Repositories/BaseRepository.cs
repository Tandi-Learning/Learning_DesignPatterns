using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MyShop.Infrastructure;
using MyShop.Infrastructure.Interfaces;

public abstract class BaseRepository<T> : IRepository<T> where T : class
{
	private ShoppingContext context;

	public BaseRepository(ShoppingContext context)
	{
		this.context = context;
	}

  	public virtual T Add(T entity)
	{
		return context.Add(entity).Entity;
	}

	public virtual IEnumerable<T> All()
	{
		return context.Set<T>().ToList();
	}

	public virtual void Delete(Guid id)
	{
		context.Remove(Get(id));
	}

	public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
	{
		return context.Set<T>()
			// .AsQueryable()
			.Where(predicate)
			.ToList();
	}

	public virtual T Get(Guid id)
	{
		return context.Find<T>(id);
	}

	public virtual void SaveChanges()
	{
		 context.SaveChanges();
	}

	public virtual T Update(T entity)
	{
		return context.Update(entity).Entity;
	}
}