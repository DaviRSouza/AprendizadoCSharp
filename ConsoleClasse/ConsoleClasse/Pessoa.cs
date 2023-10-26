using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClasse
{
    internal class Pessoa
    {
        //Variaveis Privadas para o nome e idade da pessoa
        private string nome;
        private int Idade;

        //Metodo (setter) que permite definir o nome da pessoa (obter)
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        //Metodo (setter) que permite definir a idade da pessoa (obter)
        public void setIdade(int Idade) 
        {
            this.Idade = Idade;
        }
        //metodo que permite obter o nome da pessoa
        public string getNome() 
        {
            return this.nome;
        }
        //metodo que permite obter(escrever) a idade da pessoa
        public int getIdade()
        {
            return this.Idade;
        }
    }
}
