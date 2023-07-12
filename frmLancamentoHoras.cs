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

            InabilitaBotoesBarraFerramentas();

            HabilitaPesquisa();

            tbLancamentoHoras.Enabled = false;
        }
        
        private void lANCAMENTO_HORARIOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SalvaAcao();          
        }

        private void frmLancamentoHoras_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sISCONPROJECTSDataSet.LANCAMENTO_HORARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.lANCAMENTO_HORARIOSTableAdapter.Fill(this.sISCONPROJECTSDataSet.LANCAMENTO_HORARIOS);

        }

        private void rbPesquisaNome_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaPesquisa();
            txtPesquisaHorarios.Clear();
        }

        private void rbPesquisaTipo_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaPesquisa();
            txtPesquisaHorarios.Clear();
        }

        private void rbPesquisaData_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaHorarios.Clear();
            txtPesquisaHorarios.Enabled = false;
        }

        private void btnPesquisarLancamentos_Click(object sender, EventArgs e)
        {
            FiltraPesquisa();
        }       

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tbLancamentoHoras.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            SalvaAcao();
            tbLancamentoHoras.Enabled = false;
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            tbLancamentoHoras.Enabled = true;
        }

        private void tsbBloquear_Click(object sender, EventArgs e)
        {
            SalvaAcao();
            tbLancamentoHoras.Enabled = false;
        }

        private void InabilitaBotoesBarraFerramentas()
        {
            //deixa dos botões de enviar arquivo e baixar arquivo inabilitados na janela de lançamentos de horas
            tsbEnviar.Enabled = false;
            tsbBaixar.Enabled = false;
        }

        private void SalvaAcao()
        {
            try
            {
                this.Validate();
                this.lANCAMENTO_HORARIOSBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sISCONPROJECTSDataSet);

                MessageBox.Show("Ação realizada com sucesso!.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information); //dispara a mensagem informando que foi realizada a ação

                tbLancamentoHoras.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HabilitaPesquisa()
        {
            //inicia a txt como habilitada
            txtPesquisaHorarios.Enabled = true;
        }

        private void FiltraPesquisa()
        {
            if (rbPesquisaNome.Checked == true)
            {
                lANCAMENTO_HORARIOSBindingSource.Filter = $"NomeDesenvolvedor like '*{txtPesquisaHorarios.Text}*'";
            }
            if (rbPesquisaTipo.Checked == true)
            {
                lANCAMENTO_HORARIOSBindingSource.Filter = $"TipoLancamento like '*{txtPesquisaHorarios.Text}*'";
            }
            if (rbPesquisaData.Checked == true)
            {
                txtPesquisaHorarios.Text = "A pesquisa será realizada por data.";
                lANCAMENTO_HORARIOSBindingSource.Filter = $"DataLancamento >= '#{mkdtxtDataLancamento.Text}#'";
            }
            if ((rbPesquisaNome.Checked == false) && (rbPesquisaTipo.Checked == false) && (rbPesquisaData.Checked == false))
            {
                MessageBox.Show("Escolha uma das opções para realizar a pesquisa.", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (string.IsNullOrEmpty(txtPesquisaHorarios.Text))
            {
                MessageBox.Show("Preencha o campo de pesquisa com o mome ou o tipo de documento.", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
