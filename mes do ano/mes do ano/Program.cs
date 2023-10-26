using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mes_do_ano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mes;
            Console.WriteLine("Mes - quantos dias ele tem?");
            Console.WriteLine("Digite o mes do ano que deseja saber quantos dias possui...");
            mes = Console.ReadLine();
            switch (mes)
            {
                case "Janeiro":
                case "Março":
                case "Maio":
                case "Julho":
                case "Agosto":
                case "Outubro":
                case "Dezembro":
                    Console.WriteLine("Este mes tem 31 dias");
                    break;
                case "Abril":
                case "Junho":
                case "Setembro":
                case "Novembro":
                    Console.WriteLine("Este mes tem 30 dias");
                    break;
                case "Fevereiro":
                    Console.WriteLine("Este mes tem 28 ou 29 dias");
                    break;
                default:
                    Console.WriteLine("Este mes nào existe!!");
                    Console.WriteLine("Digite qualque tecla para sair do programa");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
            Console.ReadKey(true);
        }
    }
}
