using Microsoft.EntityFrameworkCore;
using Upd8.Core.Domain.Entities;
using Upd8.Core.Domain.Interfaces.Repositories;
using Upd8.Infra.Data.Context;

namespace Upd8.Infra.Data.Repository
{
    public class RepositoryBase<TEntity, TKey> : IRepositoryBase<TEntity, TKey> where TEntity : BaseEntity
    {
        private readonly SqlContext _sqlContext;
        public RepositoryBase(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public async Task<IEnumerable<TEntity>> GetAsync() => await _sqlContext.Set<TEntity>().ToListAsync();

        public async Task<TEntity> GetByIdAsync(TKey id) => await _sqlContext.Set<TEntity>().FindAsync(id);

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            try
            {
                var result = await _sqlContext.Set<TEntity>().SingleOrDefaultAsync(x => x.Id.Equals(entity.Id));

                if (result == null) throw new ArgumentException("Objeto não encontrado");

                entity.UpdateAt = DateTime.UtcNow;
                entity.CreatedAt = result.CreatedAt;

                _sqlContext.Entry(result).CurrentValues.SetValues(entity);
                await _sqlContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return entity;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            try
            {
                if (entity.Id == Guid.Empty) entity.Id = Guid.NewGuid();

                entity.CreatedAt = DateTime.UtcNow;

                _sqlContext.Set<TEntity>().Add(entity);
                await _sqlContext.SaveChangesAsync();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return entity;
        }

        public async Task<bool> DeleteAsync(TKey id)
        {
            try
            {
                var result = await _sqlContext.Set<TEntity>().SingleOrDefaultAsync(x => x.Id.Equals(id));
                if (result == null) throw new ArgumentException("Objeto não encontrado");

                _sqlContext.Set<TEntity>().Remove(result);
                await _sqlContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
