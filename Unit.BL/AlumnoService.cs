using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit.DAO;

namespace Unit.BL
{
    public class AlumnoService
    {
        AlumnoRepository repositorio = null;
        public AlumnoService()
        {
            repositorio = new AlumnoRepository();
        }

        public List<alumno> Listar()
        {
            return repositorio.Listar();
        }

        public alumno BuscaPorId(int alumnoId)
        {
            return repositorio.BuscaporId(alumnoId);
        }

        public Boolean crear(alumno Alumno)
        {
            int result = repositorio.Crear(Alumno);
            if (result > 0)
                return true;
            return false;
        }


        
    }

}
