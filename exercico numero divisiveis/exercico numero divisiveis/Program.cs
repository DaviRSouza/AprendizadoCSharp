using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Divisores_de_um_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i, cont = 0;
            Console.WriteLine("Divisores de um nº inteiro");
            Console.WriteLine("Digite um nº inteiro positivo:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Divisores de " + num + ":");
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0) { Console.WriteLine(i); cont++; }
            }
            Console.WriteLine(num + " possui " + cont + " divisores...");
            Console.ReadKey();
        }
    }
}