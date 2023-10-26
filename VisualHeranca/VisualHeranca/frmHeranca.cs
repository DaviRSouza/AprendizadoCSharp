using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualHeranca
{
    public partial class frmHeranca : Form
    {
        public frmHeranca()
        {
            InitializeComponent();
        }
        private void btnProcessa_Click(object sender, EventArgs e)
        {
            //Criamos uma instancia da classe Funcionario que herda caracteristicas da classe DadosPessoais
            ConsoleHeranca.funcionario f = new ConsoleHeranca.funcionario();
            ConsoleHeranca.dadosPessoais d = new ConsoleHeranca.dadosPessoais();
            //Passa o Conteudo Digitado para as variaveis definidas nos setters
            d.setNome(txtNome.Text);
            d.setEnde(txtEndereco.Text);
            d.setCidade(txtCidade.Text);
            d.setFone(txtFone.Text);
            f.setFuncao(txtFuncao.Text);
            
            try
            {
                f.setSalario(double.Parse(txtSalario.Text));
                string saida = "Nome...................." + d.getNome().ToUpper() + "\n" + "Endereço..........: " + d.getEnde().ToUpper() + "\n" + "Cidade.............:" + d.getCidade().ToUpper() + "\n" + "Fone.............." + d.getFone().ToUpper() + "Função........:" + f.getFuncao().ToUpper() + "\n" + "Salario..........:" + f.getSalario().ToString();
                MessageBox.Show(saida, "**** SAIDA DE DADOS ****", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "**** ERRO DE ENTRADA ****", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCidade.Clear();
            txtSalario.Clear();
            txtFuncao.Clear();
            txtFone.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
            txtNome.Focus();
        }

        private void btnSaiir_Click(object sender, EventArgs e)
        {
            string texto = "Deseja sair do programa?";
            string titulo = "***** FINALIZADO *****";
            if(MessageBox.Show(texto,titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtCidade.Clear();
                txtSalario.Clear();
                txtFuncao.Clear();
                txtFone.Clear();
                txtEndereco.Clear();
                txtNome.Clear();
                txtNome.Focus();
            }
        }
    }
}