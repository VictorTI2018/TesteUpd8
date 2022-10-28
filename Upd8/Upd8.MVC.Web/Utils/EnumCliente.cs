using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Upd8.MVC.Web.Utils
{
    public enum EnumCliente
    {
        [Display(Name = "M")]
        Masculino,
        [Display(Name = "F")]
        Feminino
    }
}
