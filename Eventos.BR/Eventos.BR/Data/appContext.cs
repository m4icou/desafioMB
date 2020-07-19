using Eventos.BR.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.BR.Data
{
    public class appContext: DbContext
    {
        public appContext(DbContextOptions<appContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Administrador> Admistradores { get; set; }
        public DbSet<Evento> Eventos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=123456;Persist Security Info=True;User ID=sa;Initial Catalog=EventosBR;Data Source=DESKTOP-70CJ1PO");
        }

        public DbSet<Eventos.BR.Models.Ingresso> Ingresso { get; set; }


    }
}
