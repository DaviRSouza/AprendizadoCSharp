using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Varios_numeros_fatoriais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num = 1;

            Console.WriteLine("Varios Numeros - Fatorial de cada um");
            while (num > 0)
            {
                int r = 1;
                Console.WriteLine("Digite um numero");
                num = int.Parse(Console.ReadLine());
                for (i = 1; i <= num; i++) { r *= i; }
                Console.Clear();
                Console.WriteLine(num + "! = " + r);
            }
            Console.ReadKey();
        }
    }
}
