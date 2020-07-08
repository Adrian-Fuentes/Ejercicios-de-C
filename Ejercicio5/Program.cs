using System;
using System.Globalization;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Dato;
            int Metodo, cuenta;
            decimal Precio;
            Console.WriteLine("Ingrese el Precio del articulo a comprar");
            Dato = Console.ReadLine();
         
            Precio = decimal.Parse(Dato);
            if (Precio <=0)
                {
                Console.WriteLine("Error, digitacion de precio no valida"); 
                }
            else
            {
                Console.WriteLine("Ingrese su metodo a pagar:");
                Console.WriteLine("Si es en efectivo Dijite 1");
                Console.WriteLine("Si es con tarjeta Dijite 2");
                Dato = Console.ReadLine();
                Metodo = int.Parse(Dato);
                //Wea que necesito analizar a mucha mas profundidad
                CultureInfo usa = new CultureInfo("en-US");
                NumberFormatInfo nfi = usa.NumberFormat;
                nfi = (NumberFormatInfo)nfi.Clone();
                // Console.WriteLine(Precio.ToString("c", nfi));
                //fin de la wea
                switch (Metodo)
                    {
                        case 1:
                        string dat1 = "Efectivo";
                        
                        Console.WriteLine("Debe Pagar: "+Precio.ToString("c",nfi) +". Su metodo de Pago es: {0} . ",dat1);
                        
                        break;

                        case 2:
                            Console.WriteLine("Favor de ingresar su numero de cuenta:");
                            Dato = Console.ReadLine();
                            cuenta = int.Parse(Dato);
                            if (cuenta < 0)
                                {
                                    Console.WriteLine("Error, digitacion de cuenta no valida");
                                }
                            else
                                {
                            string dat2 = "Tarjeta";
                            Console.WriteLine("Debe Pagar: "+ Precio.ToString("c",nfi)+". Su metodo de Pago es: {0} . A la cuenta: {1}"
                                                ,dat2, cuenta);
                                }
                        break;

                
                    }
            }
        }
    }
}
