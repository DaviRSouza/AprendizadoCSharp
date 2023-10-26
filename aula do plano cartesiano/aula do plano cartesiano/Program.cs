using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_do_plano_cartesiano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X, Y, Q = 0;
            Console.WriteLine("Plano Cartesiano");
            Console.WriteLine("Digite o eixo X");
            X = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o eixo Y");
            Y = double.Parse(Console.ReadLine());

            if (X > 0 && Y > 0) { Q = 1; }
            else if (X < 0 && Y > 0) { Q = 2; }
            else if (X < 0 && Y < 0){ Q = 3; }
            else if (X > 0 && Y < 0){ Q = 4; }
            else
            {
                Console.WriteLine("Ponto de Origem");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.WriteLine("o quadrante que esta é " + Q);
            Console.ReadKey();
        }
    }
}