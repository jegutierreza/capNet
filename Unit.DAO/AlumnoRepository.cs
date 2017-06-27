using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit.DAO
{
    public class AlumnoRepository
    {
        Contexto contex = null;
        public AlumnoRepository()
        {
            Contexto contex = new Contexto();
        }

        public List<alumno> Listar()
        {
            return contex.Alumnos.ToList();
        }

        public alumno BuscaporId(int Id)
        {
            alumno result = contex.Alumnos.Where(s => s.alumnoId == Id).FirstOrDefault();
            return result;
        }

        public int Crear(alumno Alumno)
        {
            alumno result = contex.Alumnos.Add(Alumno);
            contex.SaveChanges();
            return result.alumnoId;
        }
    }
}
