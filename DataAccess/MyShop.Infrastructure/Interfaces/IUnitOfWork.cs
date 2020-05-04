using MyShop.Domain.Models;

namespace MyShop.Infrastructure.Interfaces
{
	public interface IUnitOfWork
	{
		IRepository<Order> OrderRepository { get; }
		IRepository<Product> ProductRepository { get; }
		IRepository<Customer> CustomerRepository { get; }
		void SaveChanges();	
	}
}