using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_numero_primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nd, c;

            Console.WriteLine("Identificar numeros primos");
            Console.WriteLine("Digite o numero: ");
            nd = int.Parse(Console.ReadLine());

            for(c = 1; c <= nd; c++)
            {
                if(nd%c == 0){Console.WriteLine(c + " e primo");}
                else { Console.WriteLine(c + " Não e primo");}
            }
            Console.ReadKey();
        }
    }
}
