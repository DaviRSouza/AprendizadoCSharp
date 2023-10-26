using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Condições_de_Pagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pe, cp, desconto = 0, aumento = 0, preco_final = 0;
            Console.WriteLine("Condições de Pagamento de um Produto");
            Console.WriteLine("Digite o preço de etiqueta:");
            pe = double.Parse(Console.ReadLine());
            Console.WriteLine("Códigos de Pagamento");
            Console.WriteLine("1 - à vista (d ou c)- 10% de desconto");
            Console.WriteLine("2 - à vista (cc)- 5% de desconto");
            Console.WriteLine("3 - Em 2x - sem juros");
            Console.WriteLine("4 - Em 3x - 10% de acréscimo");
            Console.WriteLine("Digite a forma de pagamento:");
            cp = double.Parse(Console.ReadLine());
            switch (cp)
            {
                case 1:
                    desconto = 0.10 * pe;
                    preco_final = pe - desconto;
                    break;
                case 2:
                    desconto = 0.05 * pe;
                    preco_final = pe - desconto;
                    break;
                case 3:
                    desconto = 0;
                    preco_final = pe;
                    break;
                case 4:
                    aumento = 0.10 * pe;
                    preco_final = pe + aumento;
                    break;
            }
            Console.WriteLine("Preço Final : R$ " + Math.Round(preco_final,2));
            Console.ReadKey();
        }
    }
}