using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Model
{
   public class alumno
    {
        public int alumnoId { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime cumpleaño { get; set; }

        public string DNI { get; set; }

        public virtual ICollection<matricula> Matricula { get; set; }

        public virtual curso Cursos { get; set; }
        public virtual alumno Alumnos { get; set; }

    }
}
