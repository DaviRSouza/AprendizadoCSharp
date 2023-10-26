using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_numeros_pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while(i < 200)
            {
               i+=2;
               Console.WriteLine(i);
            }
            Console.WriteLine("Outro Jeito");
            for ( i = 2; i <= 200; i += 2 ) // i += 2 equivale a i = i+2
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Outro Jeito");
            for ( i = 1; i<= 200; i++ ) 
            {
                if (i % 2 == 0) { Console.WriteLine(i); }
            }
            Console.ReadKey();
        }
    }
}
