using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeranca
{
    //A classe Funcionario herda Argumentos de DadosPessoais
    internal class funcionario
    {
        //Declaração das variaveis privadas
        private double salario;
        private string funcao;

        //Metodo para definir(ler) o salario do funcionario
        public void setSalario(double salario) { this.salario = salario; }

        //Metodo para definir(ler) a funcao do funcionario
        public void setFuncao(string funcao) { this.funcao = funcao; }

        //Metodo para Obter (Imprimir) o salario do funcionario
        public double getSalario() { return this.salario; }

        //Metodo para Obter (Imprimir) a função do funcionario
        public string getFuncao() { return this.funcao; }
    }
}
