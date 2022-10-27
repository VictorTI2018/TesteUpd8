using Upd8.Core.Domain.Entities;
using Upd8.MVC.Web.Services.Interfaces;

namespace Upd8.MVC.Web.Services
{
    public class ServiceMvcCliente: ServiceMvcBase<Cliente, Guid>, IServiceMvcCliente
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ServiceMvcCliente(IHttpClientFactory httpClientFactory) : base("/api/cliente", httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
    }
}
