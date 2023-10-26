using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varios_Numeros___pares_e_ou_impares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, soma_impar = 0, prod_par = 1;

            Console.WriteLine("Varios numeros - e/ou impares");
            Console.WriteLine("Digite um numero positivo, ou 0 ou negativo, para terminar: ");
            num = int.Parse(Console.ReadLine());
            while (num > 0)//flag
            {
                if (num % 2 == 0) { prod_par *= num; }// prod_par = prod_par * num;
                else { soma_impar += num; }// soma_impar = soma_impar + num; 
                Console.WriteLine("Digite um n positivo, ou 0 ou negativo, para terminar: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Produto dos pares digitados: " + prod_par);
            Console.WriteLine("Soma dos impares digitados: " + soma_impar);
            Console.ReadKey();
        }
    }
}
