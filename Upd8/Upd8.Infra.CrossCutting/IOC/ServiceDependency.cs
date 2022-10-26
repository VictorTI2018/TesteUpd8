using Microsoft.Extensions.DependencyInjection;
using Upd8.Core.Domain.Interfaces.Services;
using Upd8.Services;

namespace Upd8.Infra.CrossCutting.IOC
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IServiceCliente, ServiceCliente>();
        }
    }
}
