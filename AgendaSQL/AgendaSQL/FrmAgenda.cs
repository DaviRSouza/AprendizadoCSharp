using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSQL
{
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroAgendaDataSet.TabAgenda'. Você pode movê-la ou removê-la conforme necessário.
            this.tabAgendaTableAdapter.Fill(this.cadastroAgendaDataSet.TabAgenda);

        }
    }
}
