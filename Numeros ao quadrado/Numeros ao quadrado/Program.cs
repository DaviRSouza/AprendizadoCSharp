using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_ao_quadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i = 0;
            for (i = 1; i <= 20; i++)
            {
                Console.WriteLine(i + "² = " + Math.Pow(i,2));
            }
            Console.ReadKey();
        }
    }
}
