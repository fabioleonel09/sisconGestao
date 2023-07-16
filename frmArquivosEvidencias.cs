using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisconGestão
{
    public partial class frmArquivosEvidencias : Form
    {
        #region VARIAVEIS PRIVADAS E STRINGS DE CONEXAO
        private string nomeEvidenciaPesquisa;
        private string codigoFormulario;
        //aqui ocorre as instâncias do sql: conexão, comandos e leituras. E dá nome à conexão.
        private SqlConnection conexao;
        SqlCommand comando;
        SqlDataReader dr;
        string strSQL;
        #endregion

        public frmArquivosEvidencias( string nomeEvidencia, string codigo)
        {
            InitializeComponent();

            nomeEvidenciaPesquisa = nomeEvidencia;
            codigoFormulario = codigo;

            txtPesquisaNomeArquivoEvidencias.Text = nomeEvidenciaPesquisa;

            CondicionalFormulario();

            CarregaGrid();
        }

        private void btnPesquisarArquivosEvidencias_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisaNomeArquivoEvidencias.Text))
            {
                MessageBox.Show("Atenção, é necessário um nome de evidência para realizar a pesquisa exata!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);//lança msg
            }
            else
            {
                aRQUIVOS_EVIDENCIASBindingSource.Filter = $"NomeDocGeral like '*{txtPesquisaNomeArquivoEvidencias.Text}*'";
            }
        }

        private void btnApagaArquivoEvidencias_Click(object sender, EventArgs e)//apenas limpa o txt
        {
            //instancia a messageBox 
            dynamic mboxResult = MessageBox.Show("Deseja apagar o campo de nome de pesquisa?", "Confirmação!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (mboxResult == DialogResult.Cancel)  //se escolher cancel no dialógo
            {
                txtPesquisaNomeArquivoEvidencias.Text = nomeEvidenciaPesquisa;
            }
            else if (mboxResult == DialogResult.OK) //se escolher ok
            {
                txtPesquisaNomeArquivoEvidencias.Clear();
            }
        }

        private void btnSalvarArquivoEvidencias_Click(object sender, EventArgs e)
        {
            try
            {
                var arquivo = EscolherArquivo();

                if (!string.IsNullOrWhiteSpace(arquivo))
                {
                    SalvarArquivo(arquivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAbrirArquivoEvidencias_Click(object sender, EventArgs e)
        {
            try
            {
                using (conexao = ConexaoDB.AbrirConexao())
                {
                    using (var conectar = conexao.CreateCommand())
                    {
                        conectar.CommandText = "SELECT ArquivoEvidencia FROM ARQUIVOS_EVIDENCIAS WHERE (ArquivoEvidenciaId = @ArquivoEvidenciaId)";
                        ConfigurarParametrosAbrir(conectar);

                        var bytes = conectar.ExecuteScalar() as byte[];
                        if (bytes != null)
                        {
                            var nomeArquivo = dgvArquivosEvidencias.CurrentRow.Cells["NomeEvidencia"].Value.ToString();
                            var arquivoTemp = Path.GetTempFileName();
                            arquivoTemp = Path.ChangeExtension(arquivoTemp, Path.GetExtension(nomeArquivo));
                            File.WriteAllBytes(arquivoTemp, bytes);
                            Process.Start(arquivoTemp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CondicionalFormulario()
        {
            if (codigoFormulario == ".Enviar")
            {
                bindingNavigatorDeleteItem.Enabled = false;
                btnPesquisarArquivosEvidencias.Enabled = false;
                btnApagaArquivoEvidencias.Enabled = false;
                btnAbrirArquivoEvidencias.Enabled = false;
            }
            else if (codigoFormulario == ".Baixar")
            {
                btnSalvarArquivoEvidencias.Enabled = false;
            }
        }


        private void CarregaGrid()
        {
            try
            {
                using (conexao = ConexaoDB.AbrirConexao())
                {
                    using (var conectar = conexao.CreateCommand())
                    {
                        conectar.CommandText = "SELECT ArquivoEvidenciaId, NomeEvidencia, ArquivoEvidencia FROM ARQUIVOS_EVIDENCIAS";
                        var reader = conectar.ExecuteReader();
                        var table = new DataTable();
                        table.Load(reader);
                        dgvArquivosEvidencias.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string EscolherArquivo()
        {
            var retorno = string.Empty;

            using (var caixaDialogo = new OpenFileDialog())
            {
                if (caixaDialogo.ShowDialog() == DialogResult.OK)
                {
                    retorno = caixaDialogo.FileName;
                }
            }
            return retorno;
        }

        private void SalvarArquivo(string arquivo)
        {
            using (conexao = ConexaoDB.AbrirConexao())
            {
                using (var conectar = conexao.CreateCommand())
                {
                    conectar.CommandText = "INSERT INTO ARQUIVOS_EVIDENCIAS (NomeEvidencia, ArquivoEvidencia) VALUES (@NomeEvidencia, @ArquivoEvidencia)";

                    ConfigurarParametrosSalvar(conectar, arquivo);
                    conectar.ExecuteNonQuery();
                    CarregaGrid();
                }
            }
        }

        private void ConfigurarParametrosSalvar(IDbCommand conectar, string arquivo)
        {
            conectar.Parameters.Add(new SqlParameter("NomeEvidencia", Path.GetFileName(arquivo)));
            conectar.Parameters.Add(new SqlParameter("ArquivoEvidencia", File.ReadAllBytes(arquivo)));
        }

        private void ConfigurarParametrosAbrir(IDbCommand conectar)
        {
            conectar.Parameters.Add(new SqlParameter("ArquivoEvidenciaId", dgvArquivosEvidencias.CurrentRow.Cells["ArquivoEvidenciaId"].Value));
        }

        //*** Apenas para fazer a ponte de conexão entre o frm e a DB para usar a txt da coluna nome do documento ***
        private void aRQUIVOS_EVIDENCIASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aRQUIVOS_EVIDENCIASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sISCONPROJECTSDataSet);

        }

        private void frmArquivosEvidencias_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sISCONPROJECTSDataSet.ARQUIVOS_EVIDENCIAS'. Você pode movê-la ou removê-la conforme necessário.
            this.aRQUIVOS_EVIDENCIASTableAdapter.Fill(this.sISCONPROJECTSDataSet.ARQUIVOS_EVIDENCIAS);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            SalvaAcaoApagar();
        }

        private void SalvaAcaoApagar()
        {
            try
            {
                this.Validate();
                this.aRQUIVOS_EVIDENCIASBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sISCONPROJECTSDataSet);

                MessageBox.Show("Ação realizada com sucesso!.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information); //dispara a mensagem informando que foi realizada a ação

                CarregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
