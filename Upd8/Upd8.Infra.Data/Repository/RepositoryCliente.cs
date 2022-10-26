using Upd8.Core.Domain.Entities;
using Upd8.Core.Domain.Interfaces.Repositories;
using Upd8.Infra.Data.Context;

namespace Upd8.Infra.Data.Repository
{
    public class RepositoryCliente: RepositoryBase<Cliente, Guid>, IRepositoryCliente
    {
        private readonly SqlContext _sqlContext;

        public RepositoryCliente(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext
        }
    }
}
