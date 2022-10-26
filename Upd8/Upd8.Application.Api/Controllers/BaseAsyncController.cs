using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Upd8.Core.Domain.Entities;
using Upd8.Core.Domain.Interfaces.Services;

namespace Upd8.Application.Api.Controllers
{
    [ApiController]
    public class BaseAsyncController<TEntity, TKey> : ControllerBase where TEntity : BaseEntity
    {
        private readonly IServiceBase<TEntity, TKey> _serviceBase;

        public BaseAsyncController(IServiceBase<TEntity, TKey> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _serviceBase.GetAsync());
        }
    }
}
