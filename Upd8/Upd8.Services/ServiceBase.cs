using Upd8.Core.Domain.Entities;
using Upd8.Core.Domain.Interfaces.Repositories;
using Upd8.Core.Domain.Interfaces.Services;

namespace Upd8.Services
{
    public class ServiceBase<TEntity, TKey> : IServiceBase<TEntity, TKey> where TEntity : BaseEntity
    {
        protected readonly IRepositoryBase<TEntity, TKey> _repoBase;

        public ServiceBase(IRepositoryBase<TEntity, TKey> repositoryBase)
        {
            _repoBase = repositoryBase;
        }

        public async Task<IEnumerable<TEntity>> GetAsync()
        {
            return await _repoBase.GetAsync();
        }

        public async Task<TEntity> GetByIdAsync(TKey id)
        {
            return await _repoBase.GetByIdAsync(id);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            return await _repoBase.UpdateAsync(entity);
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            return await _repoBase.CreateAsync(entity);
        }

        public async Task<bool> DeleteAsync(TKey id)
        {
            return await _repoBase.DeleteAsync(id);
        }
    }
}
