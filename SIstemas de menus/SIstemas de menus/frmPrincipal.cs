using ordenar_nomes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIstemas_de_menus
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void calculoDaMediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculo_de_media.FrmCalcMedia item1 = new Calculo_de_media.FrmCalcMedia();
            item1.MdiParent = this;
            item1.Show();
        }
        private void classificarNomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ordenar_nomes.frmOrdenarNomes item2 = new ordenar_nomes.frmOrdenarNomes();
            item2.MdiParent = this;
            item2.Show();
        }
        private void listaDeNomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista_de_Nomes.frmListaDeNomes item3 = new Lista_de_Nomes.frmListaDeNomes();
            item3.MdiParent = this;
            item3.Show();
        }

        private void movimentarImagemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoviTeclas.FrmMoviTeclas item4 = new MoviTeclas.FrmMoviTeclas();
            item4.MdiParent= this;
            item4.Show();
        }

        private void visualizarImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizadorDeImagens.FrmImagem item5 = new VisualizadorDeImagens.FrmImagem();
            item5.MdiParent = this;
            item5.Show();
        }

        private void relogioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relogios.frmRelogios item6 = new Relogios.frmRelogios();
            item6.MdiParent = this;
            item6.Show();
        }

        private void sairDoProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string texto = "Deseja sair do programa?";
            string titulo = "***** FINALIZANDO *****";
            if (MessageBox.Show(texto,titulo, MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
