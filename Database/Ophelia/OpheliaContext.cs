using Microsoft.EntityFrameworkCore;
using Modelo.Ophelia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class OpheliaContext:DbContext
    {
        public OpheliaContext(DbContextOptions<OpheliaContext> options):base(options)
        {
        }

        public DbSet<Productos> Productos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Estimado> Estimado { get; set; }
    }
}
