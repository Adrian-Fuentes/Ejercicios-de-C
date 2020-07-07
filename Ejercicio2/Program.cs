using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, ciudad;
            Console.WriteLine("Favor de Ingresar su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Favor de Ingresar una ciudad");
            ciudad = Console.ReadLine();

            Console.WriteLine("Hola {0} bienvenido a {1} :D", nombre, ciudad);
            Console.WriteLine("Presione cualquier tecla para finalizar"); Console.ReadLine();
        }
    }
}
