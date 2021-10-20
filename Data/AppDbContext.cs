using Baraja2_juangonzales.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baraja2_juangonzales.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // Agregar los modelos a utilizar
        public DbSet<Naipe> Naipe { get; set; }

    }
}
