using Upd8.Core.Domain.Entities;
using Upd8.Core.Domain.Interfaces.Repositories;
using Upd8.Core.Domain.Interfaces.Services;

namespace Upd8.Services
{
    public class ServiceCliente : ServiceBase<Cliente, Guid>, IServiceCliente
    {
        private readonly IRepositoryCliente _repoCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
        {
            _repoCliente = repositoryCliente;
        }
    }
}
