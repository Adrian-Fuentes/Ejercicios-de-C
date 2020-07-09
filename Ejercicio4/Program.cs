using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Ejercicio4
{
    class Program
    {
       public enum Semana
        {
            lunes = 1,
            martes,
            miercoles,
            jueves,
            viernes,
            sabado,
            domingo
        }
        static void Main(string[] args)
        {
            string Dia;
            int nds = 0;
            Console.WriteLine("Ingresa el Día de la Semana en el cual te encuantras");
            Dia = Console.ReadLine();
            switch (Dia)
            {
                case "lunes":
                    Dia = "1";
                    nds = int.Parse(Dia);
                    break;
                case "martes":
                    Dia = "2";
                    nds = int.Parse(Dia);
                    break;
                case "miercoles":
                    Dia = "3";
                    nds = int.Parse(Dia);
                    break;
                case "jueves":
                    Dia = "4";
                    nds = int.Parse(Dia);
                    break;
                case "viernes":
                    Dia = "5";
                    nds = int.Parse(Dia);
                    break;
                case "sabado":
                    Dia = "6";
                    nds = int.Parse(Dia);
                    break;
                case "domingo":
                    Dia = "7";
                    nds = int.Parse(Dia);
                    break;
                default:
                    Console.WriteLine("El dia de la semana escrito '{0}' no es válido",Dia);
                    break;
            }

            Semana ds = (Semana)nds;


            switch (ds)
            {
                case Semana.lunes:
                    Console.WriteLine("Hoy no es fin de semana");
                    break;
                case Semana.martes:
                    Console.WriteLine("Hoy no es fin de semana");
                    break;
                case Semana.miercoles:
                    Console.WriteLine("Hoy no es fin de semana");
                    break;
                case Semana.jueves:
                    Console.WriteLine("Hoy no es fin de semana");
                    break;
                case Semana.viernes:
                    Console.WriteLine("Hoy no es fin de semana");
                    break;
                case Semana.sabado:
                    Console.WriteLine("Hoy es fin de semana :D");
                    break;
                case Semana.domingo:
                    Console.WriteLine("Hoy es fin de semana :D");
                    break;

            }

        }
    }
}
