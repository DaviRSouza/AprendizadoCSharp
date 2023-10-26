using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClasse
{
    internal class ClassPrincipal
    {
        static void Main(string[] args)
        {
            /*
            criamos um objeto da classe Pessoa e o chamamos de p
            ou seja, criamos uma instancia da classe pessoa
            pois todo o objeto e uma instancia de uma classe
            */
            Pessoa p = new Pessoa();
            Linha();//invocando o metodo Linha
            Console.Write("\nDigite seu nome: ");
            p.setNome(Console.ReadLine());//set - obter o nome da pessoa
            Linha();
            try
            {
                Console.Write("\nDigite sua idade: ");
                //setIdade obtem a idade da pessoa
                p.setIdade(int.Parse(Console.ReadLine()));
                //getNome() exibe os dados de nome e getIdade() exibe os dados de Idade
                Console.WriteLine("\nNome: " + p.getNome().ToUpper() + " - idade: " + p.getIdade() + " Anos");
                Linha();
            }
            catch (Exception erro)
            {
                Linha();
                //Exibe a mensagem de erro gerada pela exceçao
                Console.Write("\n" + erro.Message + "\n");
                Linha();
            }
            //o bloco finally ocorrera após a entrada positiva ou a exceção
            finally 
            {
                Console.WriteLine("\n\nPressione uma tecla para finalizar...");
                Console.ReadKey();
            }
        }
        public static void Linha()
        {
            for (int i = 0;i < 40; i++)
            {
                Console.Write("=");
            }
        }
    }
}
