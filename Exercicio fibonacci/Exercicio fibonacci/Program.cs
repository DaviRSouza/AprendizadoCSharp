using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, anterior = 0, atual = 1, proximo;
            Console.WriteLine("Calculo de fibonacci");
            Console.WriteLine("Digite um numero: ");
            n = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Serie de Fibonacci com " + n + " Termos: ");
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(atual);
                proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }
            Console.ReadKey();
        }
    }
}
