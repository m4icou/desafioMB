using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.BR.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public Administrador administrador { get; set; }
        public int admId { get; set; }
        public string nome { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get; set; }
        public int lotacao { get; set; }
        public string descricao{ get; set; }
        public List<Ingresso> Ingressos { get; set; }

    }
}
