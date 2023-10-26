using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verificar_Numeros
{
    public partial class FrmVerifica : Form
    {
        public FrmVerifica()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(txtNum.Text);
            if (num % 2 == 0 ) 
            {
                lblResultado.Text = "O Numero " + num.ToString() + " E Par";
            }
            else
            {
                lblResultado.Text = "O Numero " + num.ToString() + " E Impar";
            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            lblResultado.Text = "";
            txtNum.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
