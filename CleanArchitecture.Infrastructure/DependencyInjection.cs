using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Infrastructure.contexts;
using CleanArchitecture.Infrastructure.persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration conf)
		{
			var defaultConnectionString = conf.GetConnectionString("Default connection");
			services.AddDbContext<StoreContext>(opts =>
				opts.UseSqlServer(defaultConnectionString));
			services.AddScoped<IProductRepository, ProductRepository>();

			return services;
			
		}
	}
}
