using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Numeros_Perfeitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, soma = 0, i;
            Console.WriteLine("Números Perfeitos");
            Console.WriteLine("Digite um nº inteiro positivo:");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i < num; i++)
            {
                if (num % i == 0) { soma += i; }// soma = soma + i; }
            }
            if (soma == num) { Console.WriteLine(num + " é perfeito!"); }
            else { Console.WriteLine(num + " NÃO é perfeito!"); }
            Console.ReadKey();
        }
    }
}