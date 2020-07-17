using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.BR.Models
{
    public class Ingresso
    {

        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public int clienteId{ get; set; }
        public Evento Evento { get; set; }
        public int eventoId { get; set; }
        public double preco { get; set; }

    }
}
