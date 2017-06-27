using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit.DAO
{
    public class ClaseRepositorio
    {
        Contexto context = new Contexto();
        public ClaseRepositorio()
        {

        }

        public List<Clase> ListarClases()
        {
            List<Clase> lista = new List<Clase>();
            lista = context.Clases.ToList();
            return lista;
        }

    }
}
