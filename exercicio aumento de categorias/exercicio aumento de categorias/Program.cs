using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exercicio_aumento_de_categorias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco, aumento = 0, npreco, imposto; int categoria;  string situacao;

            Console.WriteLine("produtos");
            Console.WriteLine("Qual o preço do seu produto?");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a categoria do seu produto?(1, 2 e 3)");
            categoria = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a situação do produto? ([R] - Precisa de Refrigeração [n] - Não precisa de refrígeração)");
            situacao = Console.ReadLine();

            if (preco <= 25)
            {
                if (categoria == 1) { aumento = preco * 0.05; }
                else if (categoria == 2) { aumento = preco * 0.08; }
                else if (categoria == 3) { aumento = preco * 0.10; }
                else
                {
                    Console.WriteLine("Categoria Erronea");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            else
            {
                if (categoria == 1) { aumento = preco * 0.12; }
                else if (categoria == 2) { aumento = preco * 0.15; }
                else if (categoria == 3) { aumento = preco * 0.18; }
                else
                {
                    Console.WriteLine("Categoria Erronea");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

            if (categoria == 2 || situacao == "R") { imposto = (preco * 5) / 100; }
            else { imposto = (preco * 8) / 100; }

            npreco = preco+aumento+imposto;

            Console.WriteLine ("Preço Original: R$ " + preco);
            Console.WriteLine("Valor do Aumento: R$ " + Math.Round(aumento,2));
            Console.WriteLine("Valor do Imposto: R$ " + Math.Round(imposto, 2));
            Console.Write("Novo Preço: R$ " + Math.Round(npreco,2) + " - ");

            if(npreco <= 50) { Console.WriteLine("Barato"); }
            else if (npreco < 120) { Console.WriteLine("Normal"); }
            else { Console.WriteLine("Caro"); }

            Console.ReadKey();
        }
    }
}
