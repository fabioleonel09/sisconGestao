using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisconGestão
{
    public partial class frmEvidencias : Form
    {
        #region DECLARAÇÃO DAS VARIÁVEIS PRIVADAS

        private string logadoCliente; // Variável de classe para armazenar o valor

        #endregion

        public frmEvidencias(string paraCliente)
        {
            InitializeComponent();

            logadoCliente = paraCliente;

            HabilitaPesquisa();

            InabilitaComponetesTela(); 
        }

        private void eVIDENCIASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SalvaAcao();
        }

        private void frmEvidencias_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sISCONPROJECTSDataSet.EVIDENCIAS'. Você pode movê-la ou removê-la conforme necessário.
            this.eVIDENCIASTableAdapter.Fill(this.sISCONPROJECTSDataSet.EVIDENCIAS);

        }

        private void rbPesquisaNome_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaPesquisa();
            txtPesquisaEvidencia.Clear();
        }

        private void rbPesquisaTipo_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaPesquisa();
            txtPesquisaEvidencia.Clear();
        }

        private void rbPesquisaData_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaEvidencia.Clear();
            txtPesquisaEvidencia.Enabled = false;
        }

        private void btnPesquisarEvidencias_Click(object sender, EventArgs e)
        {
            FiltrosPesquisa();
        }        

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tbEvidencias.Enabled = true;
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
            tbEvidencias.Enabled = true;
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

        private void HabilitaPesquisa()
        {
            //inicia a txt como habilitada
            txtPesquisaEvidencia.Enabled = true;
        }

        private void InabilitaComponetesTela()
        {
            if (logadoCliente == "Cliente")
            {
                InabilitaComponetesParaCliente();
            }
            else
            {
                tbEvidencias.Enabled = false;
                tsbEnviar.Enabled = false;
                tsbBaixar.Enabled = false;
            }      
        }       

        private void SalvaAcao()
        {
            try
            {
                if (nomeEvidenciaTextBox.TextLength > 200)
                {
                    MessageBox.Show("O campo Nome Evidência não pode ter mais do que 200 caracteres!.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information); //dispara a mensagem
                    return;
                }
                   
                if (desenvolvedorEvidenciaTextBox.TextLength > 100)
                {
                    MessageBox.Show("O campo Nome do Desenvolvedor não pode ter mais do que 100 caracteres!.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information); //dispara a mensagem
                    return;
                }
                  
                if (descricaoEvidenciaTextBox.TextLength > 1000)
                {
                    MessageBox.Show("O campo Descrição Evidência não pode ter mais do que 1000 caracteres!.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information); //dispara a mensagem
                    return;
                }
                 
                this.Validate();
                this.eVIDENCIASBindingSource.EndEdit();
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

        private void FiltrosPesquisa()
        {
            if (rbPesquisaNome.Checked == true)
            {
                eVIDENCIASBindingSource.Filter = $"NomeEvidencia like '*{txtPesquisaEvidencia.Text}*'";
            }
            if (rbPesquisaTipo.Checked == true)
            {
                eVIDENCIASBindingSource.Filter = $"TipoDocumento like '*{txtPesquisaEvidencia.Text}*'";
            }
            if (rbPesquisaData.Checked == true)
            {
                txtPesquisaEvidencia.Text = "A pesquisa será realizada por data.";
                eVIDENCIASBindingSource.Filter = $"DataInclusao >= '#{mkdtxtPesquisaData.Text}#'";
            }
            if ((rbPesquisaNome.Checked == false) && (rbPesquisaTipo.Checked == false) && (rbPesquisaData.Checked == false))
            {
                MessageBox.Show("Escolha uma das opções para realizar a pesquisa.", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (string.IsNullOrEmpty(txtPesquisaEvidencia.Text))
            {
                MessageBox.Show("Preencha o campo de pesquisa com o mome ou o tipo de documento.", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void InabilitaComponetesParaCliente()
        {
            ((Control)tbEvidencias.TabPages["tpCapaEvidencia"]).Enabled = false;
            ((Control)tbEvidencias.TabPages["tpDetalhesEvidencia"]).Enabled = true;

            bindingNavigatorAddNewItem.Enabled = false;
            eVIDENCIASBindingNavigatorSaveItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            tsbEditar.Enabled = false;
            tsbBloquear.Enabled = false;
            tsbEnviar.Enabled = false;
            tsbBaixar.Enabled = false;
        }

        private void EnviaArquivo()
        {
            string nomeEvidencia = nomeEvidenciaTextBox.Text;
            string codigo = ".Enviar";

            var fae = new frmArquivosEvidencias(nomeEvidencia, codigo);
            fae.ShowDialog();
        }

        private void BaixaArquivo()
        {
            string nomeEvidencia = nomeEvidenciaTextBox.Text;
            string codigo = ".Baixar";

            var fae = new frmArquivosEvidencias(nomeEvidencia,codigo);
            fae.ShowDialog();
        }
    }
}
