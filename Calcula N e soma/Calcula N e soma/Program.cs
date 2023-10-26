using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcula_N_e_soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n, s=0, i;
            Console.WriteLine("Soma de n frações: 1/1 + 1/2 + 1/3 + ... 1/n");
            Console.WriteLine("Digite o n de fraçoes: ");
            n = double.Parse(Console.ReadLine());

            for(i = 1; i <= n; i++)
            {
                s += 1 / i;// soma = soma + 1 / i
            }
            Console.WriteLine("Soma das frações: " + Math.Round(s,3));
            Console.ReadKey();
        }
    }
}
