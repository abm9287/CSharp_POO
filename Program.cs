using System;

namespace PracticaClasesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n---------------------------Dashboard---------------------------");

            Casa elementoCasa1 = new Casa(); //Se instancia la clase
            //Inicia el estado (atributos)
            elementoCasa1.idCasa = 101;
            elementoCasa1.direccionCasa = "Av. Villaflora";
            elementoCasa1.colorCasa = "Celeste";
            elementoCasa1.numeroDePisos = 3;
            elementoCasa1.numeroDeDormitorios = 5;

            //se llama al método(comportamiento})
            elementoCasa1.vender();

            Persona persona1 = new Persona();
            persona1.nombresPersona = "Julio Jaramillo";
            persona1.direccionPersona = "La Magdalena";
            persona1.emailPersona = "jJaramillo@gmail.com";
            //Llamar al método
            persona1.alquilar();

            Ejecutar();
            Console.ReadKey();


        }



        private static void Ejecutar()
        {

            Pelicula dato = new Pelicula();
            char opcion = ' ';
            do
            {
                PeliculaEstreno modelo = new PeliculaEstreno();
                Console.WriteLine("\n---------------------------FORMULARIO----------------------------------------");
                Console.WriteLine("Digite el nombre de la pelicula");
                modelo.Nombre = Console.ReadLine();
                Console.WriteLine("Digite el genero de la pelicula");
                modelo.Genero = Console.ReadLine();

                Console.WriteLine("Digite el año de estreno de la pelicula");
                modelo.Estreno = int.Parse(Console.ReadLine());
                dato.Guardar(modelo);
                Console.WriteLine("Desea agregar otra pelicula digite 'S' o sino deseas agregar otra pélícula digite 'N': ");
                opcion = char.Parse(Console.ReadLine());
            } while (opcion.Equals('s') || opcion.Equals('S'));

            foreach (PeliculaEstreno item in dato.Consultar())
            {
                Console.WriteLine("-------------------------SU ELECCIÓN DE LA PELÍCULA FUE LA SIGUIENTE-------------------------");
                Console.WriteLine("Pelicula : " + item.Nombre);
                Console.WriteLine("Genero : " + item.Genero);
                Console.WriteLine("Año de estreno : " + item.Estreno);

                if (item.Estreno > 2017)
                {
                    Console.WriteLine("No se ha estrenado");
                }
                else
                {
                    Console.WriteLine("Ya se estreno");
                }
                Console.WriteLine("*--------------------------------------------------------------------------------------------*");
                Console.ReadLine();
            }
        }


    }

}