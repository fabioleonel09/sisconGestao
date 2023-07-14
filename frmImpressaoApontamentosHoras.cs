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
            // TODO: esta linha de código carrega dados na tabela 'sISCONPROJECTSDataSet.LANCAMENTO_HORARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.lANCAMENTO_HORARIOSTableAdapter.Fill(this.sISCONPROJECTSDataSet.LANCAMENTO_HORARIOS);

            this.rpvApontamentosHoras.RefreshReport();
            this.rpvApontamentosHoras.RefreshReport();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FiltroPesquisa();
        }

        private void FiltroPesquisa()
        {
            if (string.IsNullOrEmpty(mkdtxtDe.Text) || string.IsNullOrEmpty(mkdtxtAte.Text))
            {
                MessageBox.Show("Atenção, preencha todos os campos de datas para a pesquisa!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);//lança msg

                mkdtxtDe.Clear();
                mkdtxtAte.Clear();
            }
            else
            {
                this.rpvApontamentosHoras.RefreshReport();

                lANCAMENTO_HORARIOSBindingSource.Filter = $"NomeDesenvolvedor like '*{txtNomeDesenvolvedor.Text}*'";

                lANCAMENTO_HORARIOSBindingSource.Filter = string.Format("DataLancamento >= '#{0:dd/MM/yyyy}#' And DataLancamento <= '#{1:dd/MM/yyyy}#'", mkdtxtDe.Text, mkdtxtAte.Text); //filtra a BD por protutos vendidos

                rpvApontamentosHoras.Visible = true;
            }
        }
    }
}
