using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upd8.Core.Domain.Enum;

namespace Upd8.Core.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public string? Nome { get; set; }

        public string? CPF { get; set; }

        public DateTime? DataNascimento { get; set; }

        public ClienteEnum Genero { get; set; }

        public string? Logradouro { get; set; }

        public char UF { get; set; }

        public string? Cidade { get; set; }
    }
}
