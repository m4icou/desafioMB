using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.BR.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [StringLength(30, ErrorMessage = "O tamanho máximo de caracteres no campo é 30.", MinimumLength = 2)]
        public string nome { get; set; }

        [StringLength(30, ErrorMessage = "O tamanho máximo de caracteres no campo é 30.", MinimumLength = 2)]
        public string sobrenome { get; set; }

        public string email { get; set; }
        public string  senha { get; set; }

        [Range(11111111111,99999999999)]
        public double fone { get; set; }
        public List<Ingresso> Ingressos { get; set; }
    }
}
