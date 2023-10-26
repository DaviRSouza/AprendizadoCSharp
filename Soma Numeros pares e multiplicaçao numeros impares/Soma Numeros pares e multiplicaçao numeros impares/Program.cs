using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_Numeros_pares_e_multiplicaçao_numeros_impares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, aux, c, s_pares = 0, prod_impares = 1;
            Console.WriteLine("Numeros pares e impares 2 numeros");
            Console.WriteLine("Digite o primeiro valor");
            v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            v2 = double.Parse(Console.ReadLine());

            if (v1 > v2)
            {
                aux = v1;
                v1 = v2;
                v2 = aux;
            }

            for (c = v1; c <= v2; c++)
            {
                if (c % 2 == 0) { s_pares += c; }
                else { prod_impares *= c; }
            }
            Console.WriteLine("Soma de numeros pares: " + s_pares);
            Console.WriteLine("Produto dos numeros impares: " + prod_impares);
            Console.ReadKey();
        }
    }
}
