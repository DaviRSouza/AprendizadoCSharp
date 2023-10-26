using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSQLCrud
{
    public partial class frmCRUD : Form
    {
        public frmCRUD()
        {
            InitializeComponent();
        }

        private void tabAgendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabAgendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroAgendaDataSet);
        }

        private void frmCRUD_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela '_teste_1_0DataSet.Customer'. Você pode movê-la ou removê-la conforme necessário.
            this.customerTableAdapter.Fill(this._teste_1_0DataSet.Customer);
        }
    }
}