using System.Linq;
using MyShop.Domain.Models;
using MyShop.Infrastructure;

public class ProductRepository : BaseRepository<Product>
{
	private ShoppingContext context;
  	public ProductRepository(ShoppingContext context) : base(context) => this.context = context;

	public override Product Update(Product entity)
	{
		var product = context.Products.Single(p => p.ProductId == entity.ProductId);

		product.Name = entity.Name;
		product.Price = entity.Price;

		return base.Update(product);
	}
}