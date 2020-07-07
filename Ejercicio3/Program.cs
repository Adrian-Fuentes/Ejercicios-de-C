using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string Dato;
            Console.WriteLine("Favor de ingresar el primer numero:");
            Dato = Console.ReadLine();
            num1 = int.Parse(Dato);
            Console.WriteLine("Fvor de ingresar el Segundo numero:");
            Dato = Console.ReadLine();
            num2 = int.Parse(Dato);

            if (num1 > num2)
            {
                Console.WriteLine("El Numero Mayor es: "+ num1);
            }
            else
            {
                Console.WriteLine("El Numero Mayor es: "+ num2);
            }

           
        }
    }
}
