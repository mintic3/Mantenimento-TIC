using System;
using Aplicacion.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace persistencia
{
    public class ApplicationContext: DbContext
    {
        private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=MantenimientoTIC;Integrated Security=True;";
        public DbSet<Persona> Persona {get; set;}

        public ApplicationContext(){}

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        :base(options)
    {
    }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }

    }
}
