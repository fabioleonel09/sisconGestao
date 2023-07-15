using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        #endregion

        public frmArquivosDocsGerais(string nomeDocumentoGeral, string codigo)
        {
            InitializeComponent();

            nomeDocGeralPesquisa = nomeDocumentoGeral;
            codigoFormulario = codigo;

            txtPesquisaNomeArquivoDocsGerais.Text = nomeDocGeralPesquisa;

            CondicionalFormulario();
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
    }
}
