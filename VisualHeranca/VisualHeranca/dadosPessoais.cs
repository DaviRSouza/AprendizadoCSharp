using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeranca
{
    internal class dadosPessoais
    {
        //declaraçao das classes privadas
        private string nome;
        private string ende;
        private string cidade;
        private string fone;
        //metodo para definir (ler) o nome da pessoa - setter
        public void setNome(string nome) { this.nome = nome; }

        //metodo para definir (ler) o endereço da pessoa - setter
        public void setEnde(string ende) { this.ende = ende; }

        //metodo para definir (ler) o cidade da pessoa - setter
        public void setCidade(string cidade) { this.cidade = cidade; }

        //metodo para definir (ler) o telefone da pessoa - setter
        public void setFone(string fone) { this.fone = fone; }

        //Metodo para Obter (imprimir) o nome da pessoa
        public string getNome() { return this.nome;}

        //Metodo para Obter (imprimir) o ende da pessoa
        public string getEnde() { return this.ende; }

        //Metodo para Obter (imprimir) o nome da pessoa
        public string getCidade() { return this.cidade; }

        //Metodo para Obter (imprimir) o nome da pessoa
        public string getFone() { return this.fone; }
    }
}
