using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upd8.Core.Domain.Entities;

namespace Upd8.Core.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity, TKey> where TEntity : BaseEntity
    {
        Task<TEntity> CreateAsync(TEntity entity);

        Task<IEnumerable<TEntity>> GetAsync();

        Task<TEntity> GetByIdAsync(TKey id);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<bool> DeleteAsync(TKey id);
    }
}
