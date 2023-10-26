using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_primos_entre_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i, cont, cont_primo = 0, divisor;
            Console.WriteLine("10 numeros inteiros positivos - quantos numeros");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite o numero " + i + "numero : ");
                num = int.Parse(Console.ReadLine());
                cont = 0;
                for (divisor = 1; divisor <= num; divisor++)
                {
                    if (num % divisor == 0) { cont++; }
                }
                if( cont == 2 ) { cont_primo++; }
            }
            Console.Clear();
            Console.WriteLine("Existem " + cont_primo + " Numeros primos na coleçao!");
            Console.ReadKey();
        }
    }
}
