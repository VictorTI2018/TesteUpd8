using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Upd8.MVC.Web.Services.Interfaces;
using X.PagedList;

namespace Upd8.MVC.Web.Controllers
{
    public abstract class BaseMvcController<TEntity, TKey, TEntityModel> : Controller where TEntity : class
    {
        private readonly IMapper _mapper;
        private readonly IServiceMvcBase<TEntity, TKey> _serviceBase;
        private const int QuantidadeDeLinhas = 4;

        public BaseMvcController(IMapper mapper, IServiceMvcBase<TEntity, TKey> serviceMvcBase)
        {
            _mapper = mapper;
            _serviceBase = serviceMvcBase;
        }
    
        protected abstract void Listagem();

        public async Task<IActionResult> List(int? page)
        {
            IEnumerable<TEntity> lista = await _serviceBase.GetAsync();

            IEnumerable<TEntityModel> listTmodel = _mapper.Map<IEnumerable<TEntityModel>>(lista);

            int pageNumber = (page ?? 1);

            Listagem();
            return View(listTmodel.ToPagedList(pageNumber, QuantidadeDeLinhas));
        }

        protected abstract void ViewBagCreate();

        public async Task<IActionResult> Create()
        {
            ViewBagCreate();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TEntityModel model)
        {
            TEntity dados = _mapper.Map<TEntity>(model);
            if(ModelState.IsValid)
            {
                var response = await _serviceBase.SaveAsync(dados);
                if (response != null) return RedirectToAction(nameof(List));
                return View(model);
            }
            return View(model);
            
        }

        protected abstract void ViewBagEdit();
        public async Task<IActionResult> Edit(TKey id)
        {
            TEntity dados = await _serviceBase.GetByIdAsync(id);
            ViewBag["id"] = id;

            ViewBagEdit();
            if (dados != null) return View(_mapper.Map<TEntityModel>(dados));
            return NotFound();
        }
    }
}
