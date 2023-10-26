using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ler_todos_os_divisores_de_um_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1, i;
            Console.WriteLine("Varios Numeros e seus divisores");
            while (num > 0)
            {
                Console.Clear();
                Console.WriteLine("Digite um numero inteiro iu 0 para terminar:");
                num = int.Parse(Console.ReadLine());
                for(i=1; i<=num; i++) { if (num % i == 0) { Console.WriteLine(i); } }
                Console.ReadKey();
            }
        }
    }
}