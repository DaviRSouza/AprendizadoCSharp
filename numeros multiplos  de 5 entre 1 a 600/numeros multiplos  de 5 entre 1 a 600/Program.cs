using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_multiplos__de_5_entre_1_a_600
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine("Numeros Multiplos de 5 entre 1 a 600");
            while ( i < 600 )
            {
                i++;
                if (i%5 == 0) {Console.WriteLine(i);}
            }
            Console.ReadKey();
        }
    }
}
