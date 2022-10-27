using AutoMapper;
using Upd8.Core.Domain.Entities;
using Upd8.MVC.Web.Models;
using Upd8.MVC.Web.Services.Interfaces;

namespace Upd8.MVC.Web.Controllers
{
    public class ClienteController : BaseMvcController<Cliente, Guid, ClienteModel>
    {
        private readonly IMapper _mapper;
        private readonly IServiceMvcCliente _serviceMvcCliente;

        public ClienteController(IMapper mapper, IServiceMvcCliente serviceMvcCliente) : base(mapper, serviceMvcCliente)
        {
            _mapper = mapper;
            _serviceMvcCliente = serviceMvcCliente;
        }
    
        protected override void Listagem()
        {
            //throw new NotImplementedException();
        }
    }
}
