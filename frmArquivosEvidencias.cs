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
    public partial class frmArquivosEvidencias : Form
    {
        #region VARIAVEIS PRIVADAS E STRINGS DE CONEXAO
        private string nomeEvidenciaPesquisa;
        #endregion

        public frmArquivosEvidencias( string nomeEvidencia)
        {
            InitializeComponent();

            nomeEvidenciaPesquisa = nomeEvidencia;

            txtPesquisaNomeArquivoEvidencias.Text = nomeEvidenciaPesquisa;
        }
    }
}
