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
    public partial class frmLancamentoHoras : Form
    {
        public frmLancamentoHoras()
        {
            InitializeComponent();
        }

        private void lANCAMENTO_HORARIOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lANCAMENTO_HORARIOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sISCONPROJECTSDataSet);

        }

        private void frmLancamentoHoras_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sISCONPROJECTSDataSet.LANCAMENTO_HORARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.lANCAMENTO_HORARIOSTableAdapter.Fill(this.sISCONPROJECTSDataSet.LANCAMENTO_HORARIOS);

        }
    }
}
