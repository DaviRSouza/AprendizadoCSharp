using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassVisual
{
    public partial class frmClassVisual : Form
    {
        public frmClassVisual()
        {
            InitializeComponent();
        }

        private void btnProcessa_Click(object sender, EventArgs e)
        {
            //instanciamos a classe Pessoa
            ConsoleClasse.Pessoa p = new ConsoleClasse.Pessoa();
            //Obter nome (setter)
            p.setNome(txtNome.Text);
            try
            {
                p.setIdade(int.Parse(txtIdade.Text));
                //Escrevemos o nome e a idade da pessoa (getters)
                string xnome = p.getNome();
                int xidade = p.getIdade();
                string strsaida = "Nome : " + xnome.ToUpper() + "\n\n" + xidade.ToString();
                MessageBox.Show(strsaida, "**** Resultado ****", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + "\n\n Tente novamente...", "**** ERRO DE ENTRADA ****", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtNome.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            string texto = "Deseja sair do programa?";
            string titulo = "***** FINALIZANDO *****";
            if (MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}