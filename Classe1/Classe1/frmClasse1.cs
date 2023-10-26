using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe1
{
    public partial class frmClasse1 : Form
    {
        public frmClasse1()
        {
            InitializeComponent();
        }

        private void frmClasse1_Load(object sender, EventArgs e)
        {
            txtPI.Text = Math.Round(Math.PI,5).ToString();
        }
    }
}
