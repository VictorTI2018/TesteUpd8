using Upd8.MVC.Web.Services.Interfaces;
using Upd8.MVC.Web.Utils.Extensions;

namespace Upd8.MVC.Web.Services
{
    public class ServiceMvcBase<TEntity, TKey> : IServiceMvcBase<TEntity, TKey> where TEntity : class
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public string BasePath = "";

        public ServiceMvcBase(string basePath, IHttpClientFactory httpClientFactory)
        {
            BasePath = basePath;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<TEntity>> GetAsync()
        {
            var _cliente = _httpClientFactory.CreateClient("clienteType");
            var response = await _cliente.GetAsync(BasePath);
            return await response.ReadAsJsonAsync<IEnumerable<TEntity>>();
        }

        public Task<TEntity> GetByIdAsync(TKey id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> SaveAsync(TEntity dados)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity dados)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(TKey id)
        {
            throw new NotImplementedException();
        }
    }
}
