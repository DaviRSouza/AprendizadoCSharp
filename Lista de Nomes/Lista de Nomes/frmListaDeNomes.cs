using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Nomes
{
    public partial class frmListaDeNomes : Form
    {
        public frmListaDeNomes()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            lstNome.Items.Add(nome.ToUpper());
            txtNome.Clear();
            txtNome.Focus();
        }

        private void btnRm_Click(object sender, EventArgs e)
        {
            int valor = lstNome.SelectedIndex;//indice do vetor lstNome se chama valor
            if (valor == -1)
            {
                MessageBox.Show("Para excluir um item da lista \n e nescessario primeiro seleciona-lo", "*** EXCLUINDO ITEM DA LISTA ***", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else
            {
                lstNome.Items.RemoveAt(valor);
            }
        }

        private void btnRmT_Click(object sender, EventArgs e)
        {
            if(lstNome.Items.Count == 0)
            {
                MessageBox.Show("A Lista Esta Vazia!!!\n Adicione primeiro um item\n e depois selecione para remove-lo","*** Excluindo toda a lista ***", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else
            {
                lstNome.Items.Clear();
                txtNome.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstNome.Items.Clear();
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja sair do programa?", "**** Finalizando o Programa ****",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                lstNome.Items.Clear();
                txtNome.Focus();
            }
        }
    }
}
