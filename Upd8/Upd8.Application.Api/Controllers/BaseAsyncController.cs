using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Upd8.Core.Domain.Entities;
using Upd8.Core.Domain.Interfaces.Services;

namespace Upd8.Application.Api.Controllers
{
    [ApiController]
    public class BaseAsyncController<TEntity, TKey, TEntityDto> : ControllerBase where TEntity : BaseEntity
    {
        private readonly IServiceBase<TEntity, TKey> _serviceBase;
        private readonly IMapper _mapper;

        public BaseAsyncController(IServiceBase<TEntity, TKey> serviceBase,
            IMapper mapper)
        {
            _serviceBase = serviceBase;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _serviceBase.GetAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(TKey id)
        {
            return Ok(await _serviceBase.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(TEntityDto dto)
        {
            try
            {
                return Ok(await _serviceBase.CreateAsync(_mapper.Map<TEntity>(dto)));
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
