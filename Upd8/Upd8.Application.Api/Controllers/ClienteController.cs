using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Upd8.Core.Domain.Dtos;
using Upd8.Core.Domain.Entities;
using Upd8.Core.Domain.Interfaces.Services;

namespace Upd8.Application.Api.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController : BaseAsyncController<Cliente, Guid, ClienteDto>
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapper _mapper;

        public ClienteController(IServiceCliente serviceCliente, IMapper mapper) : base(serviceCliente, mapper)
        {
            _serviceCliente = serviceCliente;
            _mapper = mapper;
        }

        [HttpGet("filtro")]
        public IActionResult Filtro([FromQuery] ClienteDto filter)
        {
            Cliente cliente = _mapper.Map<Cliente>(filter);
            return Ok(_serviceCliente.RetornarClientesFiltrados(cliente));
        }
    }
}
