﻿using System;
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
    public partial class frmArquivosDocsGerais : Form
    {
        #region VARIAVEIS PRIVADAS E STRINGS DE CONEXAO
        private string nomeDocGeralPesquisa;
        private string codigoFormulario;
        //aqui ocorre as instâncias do sql: conexão, comandos e leituras. E dá nome à conexão.
        private SqlConnection conexao;
        SqlCommand comando;
        SqlDataReader dr;
        string strSQL;
        #endregion

        public frmArquivosDocsGerais(string nomeDocumentoGeral, string codigo)
        {
            InitializeComponent();

            nomeDocGeralPesquisa = nomeDocumentoGeral;
            codigoFormulario = codigo;

            txtPesquisaNomeArquivoDocsGerais.Text = nomeDocGeralPesquisa;

            CondicionalFormulario();

            CarregaGrid();
        }

        private void btnLimpaPesquisaArquivoDocsGerais_Click(object sender, EventArgs e)
        {
            //instancia a messageBox 
            dynamic mboxResult = MessageBox.Show("Deseja apagar o campo de nome de pesquisa?", "Confirmação!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (mboxResult == DialogResult.Cancel)  //se escolher cancel no dialógo
            {
                txtPesquisaNomeArquivoDocsGerais.Text = nomeDocGeralPesquisa;
            }
            else if (mboxResult == DialogResult.OK) //se escolher ok
            {
                txtPesquisaNomeArquivoDocsGerais.Clear();
            }
        }

        private void btnPesquisarArquivosDocsGerais_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisaNomeArquivoDocsGerais.Text))
            {
                MessageBox.Show("Atenção, é necessário um nome de documento para realizar a pesquisa exata!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);//lança msg
            }
            else
            {
                aRQUIVOS_DOCS_GERAISBindingSource.Filter = $"NomeDocGeral like '*{txtPesquisaNomeArquivoDocsGerais.Text}*'";
            }
        }

        private void btnApagaArquivoDocsGerais_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarArquivoDocsGerais_Click(object sender, EventArgs e)
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

        private void btnAbrirArquivoDocsGerais_Click(object sender, EventArgs e)
        {
            try
            {
                using (conexao = ConexaoDB.AbrirConexao())
                {
                    using (var conectar = conexao.CreateCommand())
                    {
                        conectar.CommandText = "SELECT ArquivoDocGeral FROM ARQUIVOS_DOCS_GERAIS WHERE (ArquivoDocsGeraisId = @ArquivoDocsGeraisId)";
                        ConfigurarParametrosAbrir(conectar);

                        var bytes = conectar.ExecuteScalar() as byte[];
                        if (bytes != null)
                        {
                            var nomeArquivo = dgvArquivosDosGerais.CurrentRow.Cells["NomeDocGeral"].Value.ToString();
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
                btnLimpaPesquisaArquivoDocsGerais.Enabled = false;
                btnPesquisarArquivosDocsGerais.Enabled = false;
                btnApagaArquivoDocsGerais.Enabled = false;
                btnAbrirArquivoDocsGerais.Enabled = false;
            }
            else if (codigoFormulario == ".Baixar")
            {
                btnSalvarArquivoDocsGerais.Enabled = false;
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
                        conectar.CommandText = "SELECT ArquivoDocsGeraisId, NomeDocGeral, ArquivoDocGeral FROM ARQUIVOS_DOCS_GERAIS";
                        var reader = conectar.ExecuteReader();
                        var table = new DataTable();
                        table.Load(reader);
                        dgvArquivosDosGerais.DataSource = table;
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
                    conectar.CommandText = "INSERT INTO ARQUIVOS_DOCS_GERAIS (NomeDocGeral, ArquivoDocGeral) VALUES (@NomeDocGeral, @ArquivoDocGeral)";
                    
                    ConfigurarParametrosSalvar(conectar, arquivo);
                    conectar.ExecuteNonQuery();
                    CarregaGrid();
                }
            }
        }

        private void ConfigurarParametrosSalvar(IDbCommand conectar, string arquivo)
        {
            conectar.Parameters.Add(new SqlParameter("NomeDocGeral", Path.GetFileName(arquivo)));
            conectar.Parameters.Add(new SqlParameter("ArquivoDocGeral", File.ReadAllBytes(arquivo)));
        }

        private void ConfigurarParametrosAbrir(IDbCommand conectar)
        {
            conectar.Parameters.Add(new SqlParameter("ArquivoDocsGeraisId", dgvArquivosDosGerais.CurrentRow.Cells["ArquivoDocsGeraisId"].Value));
        }

        //*** Apenas para fazer a ponte de conexão entre o frm e a DB para usar a txt da coluna nome do documento ***
        private void aRQUIVOS_DOCS_GERAISBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aRQUIVOS_DOCS_GERAISBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sISCONPROJECTSDataSet);

        }

        private void frmArquivosDocsGerais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sISCONPROJECTSDataSet.ARQUIVOS_DOCS_GERAIS'. Você pode movê-la ou removê-la conforme necessário.
            this.aRQUIVOS_DOCS_GERAISTableAdapter.Fill(this.sISCONPROJECTSDataSet.ARQUIVOS_DOCS_GERAIS);

        }
    }
}
