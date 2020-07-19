using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventos.BR.Models
{
    public class Ingresso
    {

        public int Id { get; set; }

        public Cliente Cliente { get; set; }
        public int clienteId{ get; set; }


        public Evento Evento { get; set; }
        public int eventoId { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal preco { get; set; }

    }
}
