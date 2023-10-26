using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC___Visual
{
    public partial class DescubraIMC : Form
    {
        public DescubraIMC()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double altura, peso, imc;
            altura = double.Parse(txtAltura.Text);
            peso = double.Parse(txtPeso.Text);
            imc = peso / Math.Pow(altura, 2);
            txtIMC.Text = imc.ToString();
            if (imc < 20) { txtSituacao.Text = "Abaixo do peso"; }
            else if (imc < 25) { txtSituacao.Text = "Peso Normal"; }
            else if (imc < 30) { txtSituacao.Text = "SobrePeso"; }
            else if (imc < 40) { txtSituacao.Text = "Obeso"; }
            else { txtSituacao.Text = "Obeso Morbido"; }
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do programa?","Janela de confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();//fecha o formulario em uso
                //Application.Exit(); fecha o aplicativo
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtIMC.Clear();
            txtPeso.Clear();
            txtSituacao.Clear();
        }
    }
}
