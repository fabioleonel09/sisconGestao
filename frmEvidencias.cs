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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                EnviaArquivo(filePath);
            }
        }

        private void tsbBaixar_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(evidenciasIdTextBox.Text);
            string savePath = "C:\\Usuários"; // substitua pelo caminho onde você deseja salvar o arquivo

            //*********** MUDAR AQUI *****************
            string fileName = "nome_do_arquivo.extensao"; // substitua pelo nome desejado e extensão do arquivo

            BaixaArquivo(index, savePath, fileName);
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
                this.Validate();
                this.eVIDENCIASBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sISCONPROJECTSDataSet);

                MessageBox.Show("Ação realizada com sucesso!.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information); //dispara a mensagem informando que foi realizada a ação

                InabilitaComponetesTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void EnviaArquivo(string filePath)
        {
            string extension = Path.GetExtension(filePath);

            if (extension.Equals(".jpg") || extension.Equals(".png") || extension.Equals(".gif") || extension.Equals(".bmp"))
            {
                // Lógica para salvar a imagem
                this.arquivosPictureBox.Image = System.Drawing.Image.FromFile(filePath);
            }
            else if (extension.Equals(".doc") || extension.Equals(".docx"))
            {
                // Lógica para salvar o arquivo do Word (.doc ou .docx)
                // Implemente o código aqui para salvar o arquivo .doc ou .docx no banco de dados ou em outro local desejado
            }
            else if (extension.Equals(".pdf"))
            {
                // Lógica para salvar o arquivo PDF
                // Implemente o código aqui para salvar o arquivo PDF no banco de dados ou em outro local desejado
            }
            else if (extension.Equals(".xls") || extension.Equals(".xlsx"))
            {
                // Lógica para salvar o arquivo do Excel (.xls ou .xlsx)
                // Implemente o código aqui para salvar o arquivo .xls ou .xlsx no banco de dados ou em outro local desejado
            }
            else
            {
                MessageBox.Show("Tipo de arquivo não suportado para salvar!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BaixaArquivo(int index, string savePath, string fileName)
        {
            string extension = Path.GetExtension(fileName).ToLower();

            // Conectar-se ao banco de dados e recuperar o arquivo como um array de bytes
            string connectionString = "sua_string_de_conexao";
            string query = "SELECT Arquivos FROM EVIDENCIAS WHERE EvidenciasId = @EVIDENCIASID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EVIDENCIASID", index);

                    connection.Open();
                    byte[] fileData = (byte[])command.ExecuteScalar();
                    connection.Close();

                    // Salvar o array de bytes em um arquivo
                    string fullPath = Path.Combine(savePath, fileName);
                    File.WriteAllBytes(fullPath, fileData);

                    // Exibir uma mensagem de sucesso
                    MessageBox.Show("Arquivo baixado com sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
