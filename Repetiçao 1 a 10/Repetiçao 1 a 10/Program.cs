using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetiçao_1_a_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i, num;
            Console.WriteLine("Quadrado de 10 Numeros");
            for (i = 1; i <= 10; i++) 
            {
                Console.WriteLine("Digite o " + i + " para tirar raiz");
                num = double.Parse(Console.ReadLine());
                Console.WriteLine(num+"² = " + Math.Pow(num,2));
            }
        }
    }
}
