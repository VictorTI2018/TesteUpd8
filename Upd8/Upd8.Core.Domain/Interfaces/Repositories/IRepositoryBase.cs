using Upd8.Core.Domain.Entities;

namespace Upd8.Core.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity, TKey> where TEntity : BaseEntity
    {
        Task<TEntity> CreateAsync(TEntity entity);

        Task<IEnumerable<TEntity>> GetAsync();

        Task<TEntity> GetByIdAsync(TKey id);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<bool> DeleteAsync(TKey id);
    }
}
