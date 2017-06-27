using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit.DAO
{
    public class Contexto: DbContext
    {
        public Contexto():base("Contexto")
        {

        }

        public IDbSet<Clase> Clases { get; set; }

        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<alumno> Alumnos { get; set; }

        public DbSet<matricula> Matricula { get; set; }

        public DbSet<curso> Cursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}
