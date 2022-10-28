using System.ComponentModel.DataAnnotations;
using Upd8.MVC.Web.Utils;

namespace Upd8.MVC.Web.Models
{
    public class ClienteModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo CPF é obrigatório")]
        public string CPF { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime? DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo Endereço é obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Campo UF é obrigatório")]

        public string UF { get; set; }

        [Required(ErrorMessage = "Campo Cidade é obrigatório")]

        public string Cidade { get; set; }

        public EnumCliente Genero { get; set; }
    }
}
