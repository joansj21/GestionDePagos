using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Proyecto.DA.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DA.Contexto
{
    public class GestionPagoContext : DbContext
    {

        public GestionPagoContext(DbContextOptions options) : base(options) { }

        public DbSet<PagoDA> pagoDA { get; set; }

    }
}
