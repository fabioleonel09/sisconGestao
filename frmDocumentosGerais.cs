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
            if (rbPesquisaNome.Checked || rbPesquisaTipo.Checked || rbPesquisaData.Checked == false)
            {
                MessageBox.Show("Escolha uma das opções para realizar a pesquisa.", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(txtPesquisaDocumento.Text))
            {
                MessageBox.Show("Preencha o campo de pesquisa com o mome ou o tipo de documento.", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbPesquisaNome.Checked == true)
            {

            }
            else if (rbPesquisaTipo.Checked == true)
            {

            }
            else if (rbPesquisaData.Checked == true)
            {

            }
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
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (filePath.EndsWith(".jpg") || filePath.EndsWith(".png") || filePath.EndsWith(".gif") || filePath.EndsWith(".bmp"))
                {
                    // Código para salvar o arquivo conforme especificado no primeiro "if"

                    // Exemplo: Salvar o arquivo em uma coluna do tipo varbinary(max) no banco de dados
                    byte[] fileBytes = File.ReadAllBytes(filePath);
                    // Insira o "fileBytes" na coluna varbinary(max) do banco de dados

                    this.arquivosPictureBox.Image = System.Drawing.Image.FromFile(filePath);
                    arquivoSalvoTextBox.Text = filePath;
                }
                else
                {
                    // Código para salvar o arquivo de outro tipo na coluna do tipo varbinary(max)

                    // Exemplo: Salvar o arquivo em uma coluna do tipo varbinary(max) no banco de dados
                    byte[] fileBytes = File.ReadAllBytes(filePath);
                    // Insira o "fileBytes" na coluna varbinary(max) do banco de dados

                    arquivosPictureBox.Image = Icon.ExtractAssociatedIcon(filePath).ToBitmap();
                    arquivoSalvoTextBox.Text = filePath;
                }

                MessageBox.Show("Arquivos enviados com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbBaixar_Click(object sender, EventArgs e)
        {
            if (dOCUMENTOS_GERAISDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dOCUMENTOS_GERAISDataGridView.SelectedRows[0];
                string filePath = selectedRow.Cells["ArquivoSalvo"].Value.ToString(); // Supondo que a coluna que contém o caminho do arquivo se chama "CaminhoArquivo"
                byte[] fileBytes = null;

                // Obtenha o conteúdo do arquivo binário correspondente ao caminho do arquivo selecionado
                // Exemplo: Use uma consulta SQL para recuperar os bytes do arquivo do banco de dados
                // Armazene os bytes do arquivo na variável "fileBytes"

                if (fileBytes != null)
                {
                    // Salve o arquivo temporariamente em algum local para permitir o download
                    string tempFilePath = Path.GetTempFileName();
                    File.WriteAllBytes(tempFilePath, fileBytes);

                    // Abra o diálogo de salvar arquivo para permitir que o usuário escolha o local de download
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.FileName = Path.GetFileName(filePath); // Defina o nome de arquivo padrão como o nome original do arquivo
                    saveFileDialog.Filter = "Todos os arquivos (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string savePath = saveFileDialog.FileName;

                        // Mova o arquivo temporário para o local selecionado pelo usuário
                        File.Move(tempFilePath, savePath);

                        MessageBox.Show("Arquivo baixado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Se o usuário cancelou a operação de salvar arquivo, exclua o arquivo temporário
                        File.Delete(tempFilePath);
                    }
                }
                else
                {
                    MessageBox.Show("O arquivo selecionado não possui conteúdo para download.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nenhum arquivo selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

    }
}
