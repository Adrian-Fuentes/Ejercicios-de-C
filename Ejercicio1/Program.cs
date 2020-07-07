using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
            
        {

            List<int> pares = new List<int>();
            Console.WriteLine("Interlineado de numeros: 1 - 100");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0) {

                    pares.Add(i);
               
                    
                    
                    
                }
            }
            int[] Par = pares.ToArray();
            Console.WriteLine("los numeros pares son:");
            for (int i = 0; i < Par.Length; i++)
            {
                Console.Write(Par[i]+",");
                
            }
            Console.WriteLine("");




        }
    }
}
