using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordenar_nomes
{
    internal class classSaida
    {
        public void final()
        {
            string texto = "Deseja Finalizar o programa?";
            string titulo = "***** FIM DE PROGRAMA *****";
            if (MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
