using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_de_polignos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double NL, L, A=0;

            Console.WriteLine("Calcular area de poligono a partir dos lados dele");
            Console.WriteLine("Qual o numero de lados que esse poligno tem?");
            NL = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o tamanho desses lados?");
            L = double.Parse(Console.ReadLine());

            switch(NL)
            {
                case 3:
                    A = Math.Pow(L,2) * Math.Sqrt(3) / 4;
                    break;
                case 4:
                    A = Math.Pow(L, 2);
                    break;
                case 6:
                    A = 6 * Math.Pow(L, 2) * Math.Sqrt(3) / 4;
                    break;

                default:
                    Console.WriteLine("Não sei calcular a área");
                    Console.WriteLine("Digite uma tecla para sair do programa...");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("Tamanho da area: " + Math.Round(A,2)) ;
            Console.ReadKey(true);
        }
    }
}
