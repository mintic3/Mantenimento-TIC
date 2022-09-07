using System;
using Aplicacion.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.App.Persistencia
{
    public class ApplicationContext: DbContext {
        private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=MantenimientoTIC;Integrated Security=True;";
        public DbSet<Persona> Persona {get; set;}
        public DbSet<Cliente> Cliente {get; set;}
        public DbSet<Login> login{get; set;}
        public DbSet<Tecnico> Tecnico {get; set;}
        public DbSet<Revision> Revision {get; set;}
        public DbSet<Vehiculo> Vehiculo {get; set;}
        //public DbSet<Auto> Auto {get; set;}
       // public DbSet<Camioneta> Camioneta {get; set;}

        public ApplicationContext(){}

        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options) {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
