
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eventos.BR.Models
{

   
    public class Evento
    {
        public int Id { get; set; }
        public Administrador administrador { get; set; }
        public int admId { get; set; }
        public string nome { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dataInicio { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dataFim { get; set; }

        public int lotacao { get; set; }
        public string descricao{ get; set; }
        public List<Ingresso> Ingressos { get; set; }

    }
}
