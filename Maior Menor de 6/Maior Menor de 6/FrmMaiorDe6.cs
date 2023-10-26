using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maior_Menor_de_6
{
    public partial class FrmMaiorDe6 : Form
    {
        int n1, n2, n3, n4, n5, n6, maior;
        string mensagem = "";
        private void txtN1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtN2.Focus();
            }
        }
        private void txtN2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtN3.Focus();
            }
        }
        private void txtN3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtN4.Focus();
            }
        }
        private void txtN4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtN5.Focus();
            }
        }


        private void txtN5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtN6.Focus();
            }
        }


        private void txtN6_KeyDown(object sender, KeyEventArgs e)
        {
            btnVerifica.Focus();
        }

        public FrmMaiorDe6()
        {
            InitializeComponent();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLimpa_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        #region "Entrada de Dados"
        private void btnVerifica_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = int.Parse(txtN1.Text);
                n2= int.Parse(txtN2.Text);
                n3= int.Parse(txtN3.Text);
                n4= int.Parse(txtN4.Text);
                n5= int.Parse(txtN5.Text);
                n6= int.Parse(txtN6.Text);
                Testar();
                lblResultado.Text = mensagem;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + "\nSequencia de entrada não esta em um formato correto... \nDigite apenas numeros","**** ERRO ****",
                MessageBoxButtons.OK,MessageBoxIcon.Error);
                Limpar();
            }
        }
        #endregion
        public void Testar()
        {
            if (n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5 && n1 > n6)
            {
                maior = n1;
                mensagem = "O maior numero e: " + maior.ToString();
            }
            else if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5 && n2 > n6)
            {
                maior = n2;
                mensagem = "O maior numero e: " + maior.ToString();
            }
            else if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5 && n3 > n6)
            {
                maior = n3;
                mensagem = "O maior numero e: " + maior.ToString();
            }
            else if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5 && n4 > n6)
            {
                maior = n4;
                mensagem = "O maior numero e: " + maior.ToString();
            }
            else if (n5 > n1 && n5 > n2 && n5 > n3 && n5 > n4 && n5 > n6)
            {
                maior = n5;
                mensagem = "O maior numero e: " + maior.ToString();
            }
            else if (n6 > n1 && n6 > n2 && n6 > n3 && n6 > n4 && n6 > n5)
            {
                maior = n6;
                mensagem = "O maior numero e: " + maior.ToString();
            }
            else if (n1 == n2 && n2 == n3 && n3 == n4 && n4 == n5 && n5 == n6)
            {
                mensagem = "Todos os numeros sao iguais";
            }
            else if (n1 == n2 || n2 == n3 || n3 == n4 || n4 == n5 || n5 == n6)
            {
                mensagem = "Existem numeros iguais na sequencia!!";
            }
        }
        public void Limpar()
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();
            txtN5.Clear();
            txtN6.Clear();
            lblResultado.Text= string.Empty;
            txtN1.Focus();
        }
    }
}