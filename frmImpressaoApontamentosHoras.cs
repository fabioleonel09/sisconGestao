using Microsoft.Reporting.WinForms;
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
        public frmImpressaoApontamentosHoras(string nomeDesenvolvedor)
        {
            InitializeComponent();

            txtNomeDesenvolvedor.Text = nomeDesenvolvedor;

            rpvApontamentosHoras.Visible = false;
        }

        private void frmImpressaoApontamentosHoras_Load(object sender, EventArgs e)
        {

            this.rpvApontamentosHoras.RefreshReport();
            this.rpvApontamentosHoras.RefreshReport();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            rpvApontamentosHoras.Visible = true;
        }
    }
}
