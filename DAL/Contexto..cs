using Microsoft.EntityFrameworkCore;
using Registro_prestamo.Entidades;

namespace Registro_prestamo.DAL{
    public class Contexto: DbContext{
        public DbSet<Prestamo> Prestamo{get;set;}
         public DbSet<Personas> Personas{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Data/Prestamo.db");
        }


        

    }

}