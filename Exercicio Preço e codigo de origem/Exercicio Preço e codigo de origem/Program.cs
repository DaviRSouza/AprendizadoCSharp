using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Preço_e_codigo_de_origem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int co;
            double preco;

            Console.WriteLine("Procedencia de produtos");
           
            Console.WriteLine("Digite o codigo de origem: ");
            co = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do produto: R$ ");
            preco = double.Parse(Console.ReadLine());

            switch (co)
            {
               int co;
            double preco;

            Console.WriteLine("Procedencia de produtos");

            Console.WriteLine("Digite o codigo de origem: ");
            co = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do produto: R$ ");
            preco = double.Parse(Console.ReadLine());

            switch (co)
            {
                case 1:
                    Console.WriteLine("Origem: SUL");
                    break;
                case 2:
                    Console.WriteLine("Origem: NORTE");
                    break;
                case 3:
                    Console.WriteLine("Origem: LESTE");
                    break;
                case 4:
                    Console.WriteLine("Origem: OESTE");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("Origem: NORDESTE");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Origem: SUDESTE");
                    break;
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    Console.WriteLine("Origem: CENTRO-OESTE");
                    break;
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                    Console.WriteLine("Origem: NORDESTE");
                    break;
                default:
                    Console.WriteLine("Codigo Invalido");
                    Console.WriteLine("Digite uma tecla para sair do programa...");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }

