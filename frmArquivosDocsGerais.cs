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
    public partial class frmArquivosDocsGerais : Form
    {
        #region VARIAVEIS PRIVADAS E STRINGS DE CONEXAO
        private string nomeDocGeralPesquisa;
        #endregion

        public frmArquivosDocsGerais(string nomeDocumentoGeral)
        {
            InitializeComponent();

            nomeDocGeralPesquisa = nomeDocumentoGeral;

            txtPesquisaNomeArquivoDocsGerais.Text = nomeDocGeralPesquisa;
        }
    }
}
