using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void opção1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formularios.frmOpcao1 frmOpcao1 = new Formularios.frmOpcao1();
            frmOpcao1.Show();
        }

        private void opção2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmOpcao2 frmOpcao2 = new Formularios.frmOpcao2();
            frmOpcao2.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
