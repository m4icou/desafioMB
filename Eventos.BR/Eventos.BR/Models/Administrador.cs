using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Eventos.BR.Models
{
    public class Administrador
    {
        public int Id { get; set; }

        [StringLength(30, ErrorMessage = "O tamanho máximo de caracteres no campo é 30.", MinimumLength = 2)]
        public string nome { get; set; }

        [StringLength(30, ErrorMessage = "O tamanho máximo de caracteres no campo é 30.", MinimumLength = 2)]
        public string sobrenome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public int fone { get; set; }
        public List<Evento> Eventos { get; set; }
    }
}
