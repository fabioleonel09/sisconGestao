using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisconGestão
{
    public partial class frmDocumentosGerais : Form
    {
        public frmDocumentosGerais()
        {
            InitializeComponent();
        }

        private void dOCUMENTOS_GERAISBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dOCUMENTOS_GERAISBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sISCONPROJECTSDataSet);

        }

        private void frmDocumentosGerais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sISCONPROJECTSDataSet.DOCUMENTOS_GERAIS'. Você pode movê-la ou removê-la conforme necessário.
            this.dOCUMENTOS_GERAISTableAdapter.Fill(this.sISCONPROJECTSDataSet.DOCUMENTOS_GERAIS);

        }
    }
}
