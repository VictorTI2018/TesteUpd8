using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Upd8.Core.Domain.Entities;
using Upd8.Core.Domain.Interfaces.Services;

namespace Upd8.Application.Api.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController : BaseAsyncController<Cliente, Guid>
    {
        private readonly IServiceCliente _serviceCliente;

        public ClienteController(IServiceCliente serviceCliente) : base(serviceCliente)
        {
            _serviceCliente = serviceCliente;
        }
    }
}
