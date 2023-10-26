using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_media
{
    public partial class FrmCalcMedia : Form
    {
        public FrmCalcMedia()
        {
            InitializeComponent();
        }
        #region codigo do botao calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ClassCalculo valores = new ClassCalculo();
            double a = new double();
            double b = new double();
            double c = new double();
            double d = new double();
            double valor = new double();
            #region "Entrada de dados"
            try
            {
                string v1 = txtn1.Text;
                v1 = v1.Replace('.', ',');
                a  = double.Parse(v1);

                string v2 = txtn2.Text;
                v2 = v2.Replace('.', ',');
                b = double.Parse(v2);

                string v3 = txtn3.Text;
                v3 = v3.Replace('.', ',');
                c = double.Parse(v3);

                string v4 = txtn4.Text;
                v4 = v4.Replace('.', ',');
                d = double.Parse(v4);

                if (a < 0 || a > 10 || b < 0 || b > 10 || c < 0 || c > 10 || d < 0 || d > 10)
                {
                    MessageBox.Show("Entrada de notas invalida \nDigite as notas novamente (0 e 10)!!!", "****NOTAS INVALIDAS****", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpar();
                }
                else
                {
                    valor = valores.Processar(a,b, c, d);
                    lblMedia.Text = "A media das notas é: " + valor.ToString();
                }
            }
            catch(FormatException erro)
            {
                string mens = erro.Message;
                MessageBox.Show(mens + "\n A entrada de dados não esta em um formato correto!!!\n Tente Novamente...", "**** ERROR ****", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpar();
            }
            #endregion
        }
        #endregion

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        #region Procedimento para limpar os controles
        public void limpar()
        {
            txtn1.Clear();
            txtn2.Clear();
            txtn3.Clear();
            txtn4.Clear();
            lblMedia.Text = string.Empty;
            txtn1.Focus();
        }
        #endregion

        #region Codigo do botao sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void txtn1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return) 
            {
                txtn2.Focus();
            }
        }

        private void txtn2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtn3.Focus();
            }
        }

        private void txtn3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtn4.Focus();
            }
        }

        private void txtn4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnCalcular.Focus();
            }
        }
    }
}
