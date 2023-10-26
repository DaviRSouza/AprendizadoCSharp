using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, i, fat = 1;
            Console.WriteLine("Fatorial de um nº inteiro positivo");
            Console.WriteLine("Digite um nº inteiro positivo:");
            num = double.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                fat *= i;//fat = fat * i;
            }
            Console.WriteLine(num + "! = " + fat);
            Console.ReadKey();
        }
    }
}
