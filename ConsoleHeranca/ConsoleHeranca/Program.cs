using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cria a Instancia da Classe Funcionario que herda caracteristicas da classe DadosPessoais
            dadosPessoais d = new dadosPessoais();
            funcionario f = new funcionario();
            //entrada de Dados
            //exceto funcao e salario, os demais campos pertencem a classe dadosPessoase são utilizados em conjunto a classe funcionario
            //em conjunto com a classe funcionario
            Console.WriteLine("Dados Cadastrais");
            Linha();
            Console.Write("\nNome    :");d.setNome(Console.ReadLine());
            Console.Write("Endereço  :");d.setEnde(Console.ReadLine());
            Console.Write("Cidade    :");d.setCidade(Console.ReadLine());
            Console.Write("Telefone  :");d.setFone(Console.ReadLine());
            Console.Write("Função    :");f.setFuncao(Console.ReadLine());

            try 
            {
                Console.Write("Salario  :");f.setSalario(double.Parse(Console.ReadLine()));
                Linha();
                //saida de dados
                Console.Clear();
                Console.WriteLine("\nNome    :" + d.getNome().ToUpper());
                Console.WriteLine("Endereço  :" + d.getEnde().ToUpper());
                Console.WriteLine("Cidade    :" + d.getCidade().ToUpper());
                Console.WriteLine("Telefone  :" + d.getFone().ToUpper());
                Console.WriteLine("Função    :" + f.getFuncao().ToUpper());
                Console.WriteLine("Salario   :" + f.getSalario().ToString());
                Linha();
            }
            catch (Exception erro)
            {
                Console.Write(erro.Message);
            }
            finally 
            {
                Console.WriteLine("\n\n     Pressione qualquer tecla para finalizar");
                Console.ReadKey();
            }
        }
        public static void Linha()
        {
            for(int i = 1; i<= 60; i++) { Console.Write("="); }
        }
    }
}