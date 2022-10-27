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
            _sqlContext = sqlContext;
        }

        public IEnumerable<Cliente> RetornarClientesFiltrados (Cliente filter)
        {
            IEnumerable<Cliente> query = _sqlContext.Cliente.AsQueryable();
   
            if (!string.IsNullOrEmpty(filter.Nome)) query = query.Where(x => x.Nome.Contains(filter.Nome));

            if (!string.IsNullOrEmpty(filter.CPF)) query = query.Where(x => x.CPF.Contains(filter.CPF));

            if (filter.DataNascimento.HasValue) query = query.Where(x => x.DataNascimento.Value.Date == filter.DataNascimento.Value.Date);

            if (!string.IsNullOrEmpty(filter.UF)) query = query.Where(x => x.UF.Contains(filter.UF));

            return query.ToList();
        }
    }
}
