using MyShop.Domain.Models;
using MyShop.Infrastructure.Interfaces;

namespace MyShop.Infrastructure.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
		private ShoppingContext context;
		private IRepository<Order> orderRepository;
		private IRepository<Product> productRepository;
		private IRepository<Customer> customerRepository;

		public UnitOfWork(ShoppingContext context)
		{
			this.context = context;	
		}
	
		public void SaveChanges()
		{
			context.SaveChanges();
		}

		public IRepository<Order> OrderRepository
		{
			get
			{
				if (orderRepository == null)
					orderRepository = new OrderRepository(context);
				
				return orderRepository;
			}
		}

		public IRepository<Product> ProductRepository
		{
			get
			{
				if (productRepository == null)
					productRepository = new ProductRepository(context);
				
				return productRepository;
			}
		}

		public IRepository<Customer> CustomerRepository
		{
			get
			{
				if (customerRepository == null)
					customerRepository = new CustomerRepository(context);
				
				return customerRepository;
			}
		}
	}
}