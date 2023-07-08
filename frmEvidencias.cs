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
    public partial class frmEvidencias : Form
    {
        public frmEvidencias()
        {
            InitializeComponent();
        }

        private void eVIDENCIASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eVIDENCIASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sISCONPROJECTSDataSet);

        }

        private void frmEvidencias_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sISCONPROJECTSDataSet.EVIDENCIAS'. Você pode movê-la ou removê-la conforme necessário.
            this.eVIDENCIASTableAdapter.Fill(this.sISCONPROJECTSDataSet.EVIDENCIAS);

        }
    }
}
