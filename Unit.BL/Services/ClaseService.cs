using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit.DAO;

namespace Unit.BL.Services
{
    public class ClaseService
    {
        ClaseRepositorio repositorio = new ClaseRepositorio();

        public ClaseService()
        {
                
        }

        public List<Clase> ListarClases()
        {
            List<Clase> lista = new List<Clase>();
            lista = repositorio.ListarClases();
            //List<Clase> lista = new List<Clase>();
            //Clase cl1 = new Clase() { ClaseID = 1, Nombre = "Clase", Comentario = "Hola" };
            //Clase cl2 = new Clase() { ClaseID = 1, Nombre = "Clase2", Comentario = "Hola" };
            //Clase cl3 = new Clase() { ClaseID = 1, Nombre = "Clase3", Comentario = "Hola" };
            //lista.Add(cl1);
            //lista.Add(cl2);
            //lista.Add(cl3);
            return lista;
        }

    }
}
