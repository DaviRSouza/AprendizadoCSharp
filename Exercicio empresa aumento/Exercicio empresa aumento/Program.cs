using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_empresa_aumento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cargo ,salario, aumento, nsalario = 0;
            Console.WriteLine("Aumento de salario");
            Console.WriteLine("Digite o seu salario atual");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("101 - Gerente");
            Console.WriteLine("102 - Engenheiro");
            Console.WriteLine("103 - Tecnico");
            Console.WriteLine("XXX - Outros");
            Console.WriteLine("Digite o Codigo do seu Cargo");
            cargo = double.Parse(Console.ReadLine());

            switch (cargo)
            {
                case 101:
                    aumento = salario * 0.10;
                    break;
                case 102:
                    aumento = salario * 0.20;
                    break;
                case 103:
                    aumento = salario * 0.30;
                    break;
                default:
                    aumento = salario * 0.40;
                    break;
            }
            nsalario = salario + aumento;
            Console.Clear();
            Console.WriteLine("Seu salario atual é: R$ " + Math.Round(salario, 2));
            Console.WriteLine("Aumento de salario: R$ " + Math.Round(aumento, 2));
            Console.WriteLine("Seu novo salario sera: R$ " + Math.Round(nsalario, 2));

            Console.ReadKey();
        }
    }
}
