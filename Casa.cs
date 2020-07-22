using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaClasesObjetos
{
    class Casa
    {
        //Estados (atributos)
        public int idCasa;
        public string direccionCasa;
        public string colorCasa;
        public int numeroDeDormitorios;
        public int numeroDePisos;


        //Comportamiento - (Métodos)
        public void vender()
        {
            //Interpolación

            Console.WriteLine($"\nLa casa asignada N°: {idCasa}. \nDirección: {direccionCasa}");
            Console.WriteLine($"\tColor {colorCasa}");
            Console.WriteLine($"\tLa casa consta con {numeroDePisos} pisos y con un total de {numeroDeDormitorios} pisos");

        }
    }
}
