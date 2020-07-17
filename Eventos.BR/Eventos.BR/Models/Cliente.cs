using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.BR.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string email { get; set; }
        public string  senha { get; set; }
        public int fone { get; set; }
        public List<Ingresso> Ingressos { get; set; }
    }
}
