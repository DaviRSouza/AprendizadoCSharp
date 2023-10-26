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
    public partial class frmOpcao1 : Form
    {
        public frmOpcao1()
        {
            InitializeComponent();
        }

        private void btnSaudacao_Click(object sender, EventArgs e)
        {
            Classes.clsOpcao1 opcao1 = new Classes.clsOpcao1();
            string minhaSaudacao = opcao1.saudar(txtNome.Text);
            MessageBox.Show(minhaSaudacao);
        }
    }
}
