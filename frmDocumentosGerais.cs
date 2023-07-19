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
            EnviaArquivo();
        }

        private void tsbBaixar_Click(object sender, EventArgs e)
        {
            BaixaArquivo();
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
                if(nomeDocumentoTextBox.TextLength > 200)
                {
                    MessageBox.Show("O campo Nome Documento não pode ter mais do que 200 caracteres!.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                 
                if(descricaoDocumentoTextBox.TextLength > 1000)
                {
                    MessageBox.Show("O campo Descrição Documento não pode ter mais do que 1000 caracteres!.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information); //dispara a mensagem
                    return;
                }
                 
                this.Validate();
                this.dOCUMENTOS_GERAISBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sISCONPROJECTSDataSet);

                MessageBox.Show("Ação realizada com sucesso!.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information); //dispara a mensagem informando que foi realizada a ação

                InabilitaComponetesTela();
            }
            catch (Exception ex)
            {
                // Verifique se a exceção é de chave duplicada (ou outra exceção específica relacionada à PK)
                if (ex is SqlException sqlException && sqlException.Number == 2627)
                {
                    // Trate o caso de chave duplicada
                    MessageBox.Show("A chave de registro já está em uso. Por favor, apague esta ação (clicando em Excluir) e tente novamente.", "Conflito de inserção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Outras ações apropriadas, como limpar campos ou notificar o usuário sobre o conflito
                }
                else
                {
                    // Trate outras exceções que possam ocorrer
                    MessageBox.Show("Erro durante a inserção: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void EnviaArquivo()
        {
            string nomeDocumentoGeral = nomeDocumentoTextBox.Text;
            string codigo = ".Enviar";

            var fadg = new frmArquivosDocsGerais(nomeDocumentoGeral, codigo);
            fadg.ShowDialog();
        }

        private void BaixaArquivo()
        {
            string nomeDocumentoGeral = nomeDocumentoTextBox.Text;
            string codigo = ".Baixar";

            var fadg = new frmArquivosDocsGerais(nomeDocumentoGeral, codigo);
            fadg.ShowDialog();
        }
    }
}
