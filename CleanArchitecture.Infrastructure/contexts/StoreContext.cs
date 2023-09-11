using CleanArchitecture.Domain.entities;
using Microsoft.EntityFrameworkCore;


namespace CleanArchitecture.Infrastructure.contexts
{
	public class StoreContext : DbContext
	{
		public StoreContext(DbContextOptions<StoreContext> options) : base(options)
		{

		}

		public DbSet<Product> Products { get; set; }
	}
}
