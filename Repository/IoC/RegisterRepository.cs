using Microsoft.Extensions.DependencyInjection;
using Repository.Data.Interfaces;
using Repository.Data.Repositories;

namespace Repository.IoC
{
    public static class Register
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}