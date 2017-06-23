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
        Contexto liscontexto = new Contexto();
        public ClaseRepositorio()
        {

        }

        public List<Clase> ListarClases()
        {
            List<Clase> lista = new List<Clase>();
            lista = liscontexto.Clases.ToList();
            //Clase cl1 = new Clase() { ClaseID = 1, Nombre = "Clase1", Comentario = "Hola" };
            //Clase cl2 = new Clase() { ClaseID = 1, Nombre = "Clase2", Comentario = "Hola" };
            //Clase cl3 = new Clase() { ClaseID = 1, Nombre = "Clase3", Comentario = "Hola" };
            //lista.Add(cl1);
            //lista.Add(cl2);
            //lista.Add(cl3);
            return lista;
        }

    }
}
