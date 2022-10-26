using Microsoft.Extensions.DependencyInjection;
using Upd8.Core.Domain.Interfaces.Repositories;
using Upd8.Infra.Data.Repository;

namespace Upd8.Infra.CrossCutting.IOC
{
    public static class RepositoryDependency
    {

        public static void AddRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryCliente, RepositoryCliente>();
        }
    }
}
