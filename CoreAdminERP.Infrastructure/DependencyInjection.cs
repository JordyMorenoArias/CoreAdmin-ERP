using CoreAdmin_ERP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoreAdminERP.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Register the DbContext with the connection string from configuration
            services.AddDbContext<CoreAdminERPContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")
                    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")
                ));

            // Register repositories and other services here
            // services.AddScoped<IUserRepository, UserRepository>();
            // services.AddScoped<IProductRepository, ProductRepository>();
            // Etc.
            return services;
        }
    }
}
