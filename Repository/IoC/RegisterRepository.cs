using Microsoft.Extensions.DependencyInjection;
using Repository.Data.Repositories;
using Repository.Repositories;

namespace Repository.IoC
{
    public static class Register
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<EmployeeRepository>();
            services.AddTransient<UnitOfWork>();
        }
    }
}