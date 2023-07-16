using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisconGestão
{
    public partial class frmConexaoServidor : Form
    {
        public frmConexaoServidor()
        {
            InitializeComponent();
        }

        private void btnSalvarConexao_Click(object sender, EventArgs e)
        {
            // Obtenha a connection string digitada pelo usuário
            string connectionString = txtConexaoServidor.Text;

            // Salve a connection string no App.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["sisconGestão.Properties.Settings.SISCONPROJECTSConnectionString"].ConnectionString = connectionString;
            config.Save(ConfigurationSaveMode.Modified);

            //lança a mensagem de aviso 
            MessageBox.Show("Ação realizada com sucesso!.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Feche o formulário de inserção da connection string
            this.Close();
        }

        private void btnLimparConexao_Click(object sender, EventArgs e)
        {
            txtConexaoServidor.Clear();
        }
    }
}
