using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuForm.Formularios
{
    public partial class frmOpcao2 : Form
    {
        public frmOpcao2()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int resultado;
            Classes.clsOpcao2 opcao2 = new Classes.clsOpcao2();
            resultado = opcao2.Multiplicar(int.Parse(txtNumero1.Text), int.Parse(txtNumero2.Text));
            txtResultado.Text = resultado.ToString();
        }
    }
}
