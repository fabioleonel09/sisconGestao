using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;
using System.Diagnostics;

namespace sisconGestão
{
    public partial class frmDocumentosGerais : Form
    {
        #region VARIAVEL DE CONEXAO
        private const string connectionString = "Data Source=DESKTOP-N8EH36C\\PARTICULARSQL;Initial Catalog=SISCONPROJECTS;Integrated Security=True";
        #endregion

        public frmDocumentosGerais()
        {
            InitializeComponent();

            HabilitaPesquisa();

            InabilitaComponetesTela();
        }

        private void dOCUMENTOS_GERAISBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SalvaAcao();
        }      

        private void frmDocumentosGerais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sISCONPROJECTSDataSet.DOCUMENTOS_GERAIS'. Você pode movê-la ou removê-la conforme necessário.
            this.dOCUMENTOS_GERAISTableAdapter.Fill(this.sISCONPROJECTSDataSet.DOCUMENTOS_GERAIS);
        }

        private void btnPesquisarDocsGerais_Click(object sender, EventArgs e)
        {
            FiltrosPesquisa();   
        }

        private void rbPesquisaNome_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaPesquisa();
            txtPesquisaDocumento.Clear();
        }

        private void rbPesquisaTipo_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaPesquisa();
            txtPesquisaDocumento.Clear();
        }

        private void rbPesquisaData_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaDocumento.Clear();
            txtPesquisaDocumento.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tbDocumentosGerais.Enabled = true;
            tsbEnviar.Enabled = true;
            tsbBaixar.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            SalvaAcao();
            InabilitaComponetesTela();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            tbDocumentosGerais.Enabled = true;
            tsbEnviar.Enabled = true;
            tsbBaixar.Enabled = true;
        }

        private void tsbBloquear_Click(object sender, EventArgs e)
        {
            SalvaAcao();
            InabilitaComponetesTela();
        }

        private void tsbEnviar_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbBaixar_Click(object sender, EventArgs e)
        {
            
        }

        private void InabilitaComponetesTela()
        {
            tbDocumentosGerais.Enabled = false;
            tsbEnviar.Enabled = false;
            tsbBaixar.Enabled = false;
        }

        private void SalvaAcao()
        {
            try
            {
                this.Validate();
                this.dOCUMENTOS_GERAISBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sISCONPROJECTSDataSet);

                MessageBox.Show("Ação realizada com sucesso!.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information); //dispara a mensagem informando que foi realizada a ação

                InabilitaComponetesTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HabilitaPesquisa()
        {
            //inicia a txt como habilitada
            txtPesquisaDocumento.Enabled = true;
        }

        private void FiltrosPesquisa()
        {
            if (rbPesquisaNome.Checked == true)
            {
                dOCUMENTOS_GERAISBindingSource.Filter = $"NomeDocumento like '*{txtPesquisaDocumento.Text}*'";
            }
            if (rbPesquisaTipo.Checked == true)
            {
                dOCUMENTOS_GERAISBindingSource.Filter = $"TipoDocumento like '*{txtPesquisaDocumento.Text}*'";
            }
            if (rbPesquisaData.Checked == true)
            {
                txtPesquisaDocumento.Text = "A pesquisa será realizada por data.";
                dOCUMENTOS_GERAISBindingSource.Filter = $"DataInclusao >= '#{mkdtxtPesquisaData.Text}#'";
            }
            if ((rbPesquisaNome.Checked == false) && (rbPesquisaTipo.Checked == false) && (rbPesquisaData.Checked == false))
            {
                MessageBox.Show("Escolha uma das opções para realizar a pesquisa.", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (string.IsNullOrEmpty(txtPesquisaDocumento.Text))
            {
                MessageBox.Show("Preencha o campo de pesquisa com o mome ou o tipo de documento.", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
