using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto_Igual_a_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i;
            Console.WriteLine("Numeros entre 100 e 2000, que, quando divididos por 11, dão resto 5: ");
            for(i = 1000; i <= 2000; i++)
            {
                if (i % 11 == 5) {Console.WriteLine(i);}
            }
            Console.ReadKey();
        }
    }
}
