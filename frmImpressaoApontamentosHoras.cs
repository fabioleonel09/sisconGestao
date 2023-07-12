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
    public partial class frmImpressaoApontamentosHoras : Form
    {
        public frmImpressaoApontamentosHoras()
        {
            InitializeComponent();
        }

        private void frmImpressaoApontamentosHoras_Load(object sender, EventArgs e)
        {

            this.rpvApontamentosHoras.RefreshReport();
            this.rpvApontamentosHoras.RefreshReport();
        }
    }
}
