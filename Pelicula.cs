using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaClasesObjetos
{
    class Pelicula
    {
        List<PeliculaEstreno> lista = new List<PeliculaEstreno>();
        public void Guardar(PeliculaEstreno modelo)
        {
            lista.Add(modelo);
        }
        public List<PeliculaEstreno> Consultar()
        {
            return lista;
        }
    }
}
