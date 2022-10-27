namespace Upd8.MVC.Web.Services.Interfaces
{
    public interface IServiceMvcBase<TEntity, TKey>
    {

        Task<IEnumerable<TEntity>> GetAsync();

        Task<TEntity> GetByIdAsync(TKey id);

        Task<TEntity> SaveAsync(TEntity dados);

        Task<TEntity> UpdateAsync(TEntity dados);

        Task<bool> DeleteAsync(TKey id);
    }
}
