using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upd8.Core.Domain.Entities;

namespace Upd8.Core.Domain.Interfaces.Repositories
{
    public interface IRepositoryCliente: IRepositoryBase<Cliente, Guid>
    {

        IEnumerable<Cliente> RetornarClientesFiltrados(Cliente filter);
    }
}
