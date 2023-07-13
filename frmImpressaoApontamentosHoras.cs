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
            //gerenciamentoEmpreendedorBindingSource.Filter = string.Format("dataVenda >= '#{0:dd/MM/yyyy}#' And dataVenda <= '#{1:dd/MM/yyyy}#'", maskedTextBox1.Text, maskedTextBox2.Text); //filtra a BD por protutos vendidos
            lANCAMENTOHORARIOSBindingSource.Filter = $"NomeDesenvolvedor like '*{txtNomeDesenvolvedor.Text}*'";
            lANCAMENTOHORARIOSBindingSource.Filter = $"DataLancamento >= '#{mkdtxtDe.Text}#' AND DataLancamento <= '#{mkdtxtAte.Text}#'";
            rpvApontamentosHoras.Visible = true;
        }

        private void dataLancamentoFillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lANCAMENTO_HORARIOSTableAdapter.DataLancamentoFillBy(this.sISCONPROJECTSDataSet.LANCAMENTO_HORARIOS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataLancamentoFillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.lANCAMENTO_HORARIOSTableAdapter.DataLancamentoFillBy(this.sISCONPROJECTSDataSet.LANCAMENTO_HORARIOS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
