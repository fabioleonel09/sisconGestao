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
        private string codigoFormulario;
        #endregion

        public frmArquivosEvidencias( string nomeEvidencia, string codigo)
        {
            InitializeComponent();

            nomeEvidenciaPesquisa = nomeEvidencia;
            codigoFormulario = codigo;

            txtPesquisaNomeArquivoEvidencias.Text = nomeEvidenciaPesquisa;

            CondicionalFormulario();
        }

        private void CondicionalFormulario()
        {
            if (codigoFormulario == ".Enviar")
            {
                btnLimpaPesquisaArquivoEvidencias.Enabled = false;
                btnPesquisarArquivosEvidencias.Enabled = false;
                btnApagaArquivoEvidencias.Enabled = false;
                btnAbrirArquivoEvidencias.Enabled = false;
            }
            else if (codigoFormulario == ".Baixar")
            {
                btnSalvarArquivoEvidencias.Enabled = false;
            }
        }
    }
}
