using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiPrimeraAplicacion.Models;

namespace MiPrimeraAplicacion.Data
{
    public class MiPrimeraAplicacionContext : DbContext
    {
        public MiPrimeraAplicacionContext (DbContextOptions<MiPrimeraAplicacionContext> options)
            : base(options)
        {
        }

        public DbSet<MiPrimeraAplicacion.Models.Cliente> Cliente { get; set; }
    }
}
