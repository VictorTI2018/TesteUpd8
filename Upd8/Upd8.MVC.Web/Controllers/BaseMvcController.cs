using Microsoft.AspNetCore.Mvc;

namespace Upd8.MVC.Web.Controllers
{
    public abstract class BaseMvcController : Controller
    {
        protected abstract void Listagem();

        public async Task<IActionResult> List()
        {
            Listagem();
            return Ok();
        }
    }
}
