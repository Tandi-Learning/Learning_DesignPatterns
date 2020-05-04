using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MyShop.Domain.Models;
using MyShop.Infrastructure;
using MyShop.Infrastructure.Interfaces;

public class OrderRepository : BaseRepository<Order>
{
	private ShoppingContext context;
	private IRepository<Order> orderRepository;
	private IRepository<Product> productRepository;

	public OrderRepository(ShoppingContext context) : base(context) => this.context = context;

	public override IEnumerable<Order> Find(Expression<Func<Order, bool>> predicate)
	{
		return context.Orders
			.Include(o => o.LineItems)
			.ThenInclude(o => o.Product)
			.Where(predicate)
			.ToList();
	}

	public override Order Update(Order entity)
	{
		var order = context.Orders
			.Include(o => o.LineItems)
			.ThenInclude(o => o.Product)
			.Single(o => o.OrderId == entity.OrderId);

		return base.Update(order);
	}
}