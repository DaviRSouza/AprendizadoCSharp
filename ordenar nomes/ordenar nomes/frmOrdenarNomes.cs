using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordenar_nomes
{
    public partial class frmOrdenarNomes : Form
    {
        public frmOrdenarNomes()
        {
            InitializeComponent();
        }

        #region Classificar Nomes
        private void btnClassificar_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[5];
            string aux;
            nomes[0] = txtNome1.Text;
            nomes[1] = txtNome2.Text;
            nomes[2] = txtNome3.Text;
            nomes[3] = txtNome4.Text;
            nomes[4] = txtNome5.Text;
            for(int j = 0; j<= 4; j++)
            {
                if (nomes[j].Length >= 15) 
                {
                    lblOrdenada.Font = new Font("Arial Narrow", 10, System.Drawing.FontStyle.Bold);
                }
            }
            //ordenação da lista
            for(int i = 0; i <= 4; i++)
            {
                for(int j = i + 1; j <= 4; j++)
                {
                    if (String.CompareOrdinal(nomes[1], nomes[j]) > 0)
                    {
                        aux= nomes[i];
                        nomes[i] = nomes[j];
                        nomes[j] = aux;
                    }
                }
            }
            //exibir a lista na label de saida (lblOrdenada)
            groupBox2.Visible= true;
            for (int x = 0; x <= 4; x++)
            {
                lblOrdenada.Text += "\n" + nomes[x] + "\n";
            }
        }
        #endregion

        #region Codigo do Botão Cancelar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        #endregion

        #region Codigo do metodo Limpar
        public void Limpar()
        {
            txtNome1.Clear();
            txtNome2.Clear();
            txtNome3.Clear();
            txtNome4.Clear();
            txtNome5.Clear();
            txtNome6.Clear();
            groupBox2.Visible = false;
            lblOrdenada.Font = new Font("Verdana", 9, System.Drawing.FontStyle.Bold);
        }
        #endregion

        #region
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void txtNome1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return) 
            {
                txtNome2.Focus();
            }
        }

        private void txtNome2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtNome3.Focus();
            }
        }

        private void txtNome3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtNome4.Focus();
            }
        }

        private void txtNome4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtNome5.Focus();
            }
        }

        private void txtNome5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtNome6.Focus();
            }
        }

        private void txtNome6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnClassificar.Focus();
            }
        }
    }
}
