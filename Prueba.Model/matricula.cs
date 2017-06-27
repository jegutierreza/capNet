using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Model
{
   public class matricula
    {
        public int matriculaId { get; set; }
        public DateTime fechaMatricula { get; set; }
        public int alumnoId { get; set; }
        public int cursoId { get; set; }

    }
}
