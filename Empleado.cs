using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaClasesObjetos
{
    class Empleado
    {
        public int idEmpleado;
        public string nombresEmpleado;
        public string cargoEmpleado;
        public string direccionTrabajo;

        public void trabajar()
        {
            Console.WriteLine($"\nDatos Personales del arrendatario: \nNombres completos: {nombresEmpleado}");
            Console.WriteLine($"\nCargo: {cargoEmpleado} \nDirección de trabajo: {direccionTrabajo}");
        }
    }
}