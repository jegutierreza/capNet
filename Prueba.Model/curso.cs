using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Model
{
   public class curso
    {
        public int cursoId { get; set; }
        public string nombre { get; set; }
        public int numeroCreditos { get; set; }

        public virtual ICollection<matricula> Matricula { get; set; }

    }

    
}
