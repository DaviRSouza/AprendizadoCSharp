using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double menu, valor1, valor2, result = 0;

            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("┃      Bem Vindo a Calculadora feita em C#       ┃");
            Console.WriteLine("┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");
            Console.WriteLine("┃            1 - Soma de Dois Numeros            ┃");        
            Console.WriteLine("┃            2 - Subtrair Dois Numeros           ┃");
            Console.WriteLine("┃            3 - Multiplicar Dois Numeros        ┃");
            Console.WriteLine("┃            4 - Dividir Dois Numeros            ┃");
            Console.WriteLine("┃            5 - Raiz Quadrada de um Numero      ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.Write("Selecione o tipo de calculo que voce quer fazer:");
            menu = double.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Voce selecionou Soma!!! ");
                    Console.WriteLine("Digite o Primeiro Valor para soma: ");
                    valor1= double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o Segundo Valor para soma: ");
                    valor2= double.Parse(Console.ReadLine());
                    result = valor1 + valor2;
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Voce selecionou Subtração!!! ");
                    Console.WriteLine("Digite o Primeiro Valor para Subtração: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o Segundo Valor para Subtração: ");
                    valor2 = double.Parse(Console.ReadLine());
                    result = valor1 - valor2;
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Voce selecionou Multiplicação!!! ");
                    Console.WriteLine("Digite o Primeiro Valor para Multiplicar: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o Segundo Valor para Multiplicar: ");
                    valor2 = double.Parse(Console.ReadLine());
                    result = valor1 * valor2;
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Voce selecionou Divisão!!! ");
                    Console.WriteLine("Digite o Primeiro Valor para Dividir: ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o Segundo Valor para Dividir: ");
                    valor2 = double.Parse(Console.ReadLine());
                    result = valor1 / valor2;
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Voce selecionou Raiz Quadrada!!! ");
                    Console.WriteLine("Digite o Valor da Raiz: ");
                    valor1 = double.Parse(Console.ReadLine());
                    result = Math.Sqrt(valor1);
                    break;
                default:
                    Console.WriteLine("Seleção errada ");
                    Console.WriteLine("Digite qualquer tecla para sair do programa");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("O Resultado do seu calculo sera: " + Math.Round(result,2));
            Console.ReadKey();
        }
    }
}
