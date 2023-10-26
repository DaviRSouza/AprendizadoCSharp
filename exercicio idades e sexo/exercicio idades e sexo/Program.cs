using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Várias_idades_e_sexos___calculos_diversos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade, sexo, soma = 0, media, conta_maior = 0, conta_menor = 0, cont = 0;
            double conta_m_maior = 0, porc_maior, porc_menor, porc_m_maior;
            Console.WriteLine("Várias pessoas - Idade e Sexo");
            Console.WriteLine("Digite a idade da pessoa:");
            idade = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o sexo (0 - M | 1 - F):");
            sexo = double.Parse(Console.ReadLine());
            while (idade >= 0)
            {
                cont++;//cont = cont + 1;
                soma += idade;//soma = soma + idade;
                if (idade >= 18) { conta_maior++; }
                else { conta_menor++; }
                if (idade >= 18 && sexo == 1) { conta_m_maior++; }
                Console.WriteLine("Digite a idade da pessoa:");
                idade = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o sexo (0 - M | 1 - F):");
                sexo = double.Parse(Console.ReadLine());
            }
            media = soma / cont;
            porc_maior = 100 * conta_maior / cont;
            porc_menor = 100 * conta_menor / cont;
            porc_m_maior = 100 * conta_m_maior / cont;
            Console.Clear();
            Console.WriteLine("Média das Idades Digitadas: " + Math.Round(media, 1));
            Console.WriteLine("Porcentagem de Maiores de Idade: " + Math.Round(porc_maior, 2) + "%");
            Console.WriteLine("Porcentagem de Menores de Idade: " + Math.Round(porc_menor, 2) + "%");
            Console.WriteLine("Porcentagem de Mulheres, Maiores de Idade: " + Math.Round(porc_m_maior, 2) + "%");
            Console.ReadKey();
        }
    }
}