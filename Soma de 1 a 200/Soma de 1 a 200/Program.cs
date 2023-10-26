using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_de_1_a_200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, s = 0;
            for (i = 0; i <= 200; i++)
            {
                Console.WriteLine(i);
                s += i;
            }
            Console.WriteLine("Soma dos numeros de 1 a 200 vale: " + s);
            Console.ReadKey();
        }
    }
}
