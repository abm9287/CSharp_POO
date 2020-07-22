using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaClasesObjetos
{
    class Persona
    {
        public int idPersona;
        public string nombresPersona;
        public string direccionPersona;
        public string emailPersona;
        public int contrasenaPersona;

        //Métodos
        public void alquilar()
        {
            Console.WriteLine($"\nEl nuevo arrendatario: {nombresPersona}, se le enviará la documentación del alquiler. \nDirección: {direccionPersona}");
            Console.WriteLine($"\nSe le enviará una copia de la documentación a correo personal: {emailPersona} espere unos momentos para que llene un formulario.......... ");
        }
    }
}