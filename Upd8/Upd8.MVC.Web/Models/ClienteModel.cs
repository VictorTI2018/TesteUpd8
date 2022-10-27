using Upd8.MVC.Web.Utils;

namespace Upd8.MVC.Web.Models
{
    public class ClienteModel
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Logradouro { get; set; }

        public char UF { get; set; }

        public string Cidade { get; set; }

        public EnumCliente Genero { get; set; }
    }
}
