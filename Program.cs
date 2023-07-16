using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisconGestão
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
                // Verifique se a connection string está vazia
                var connectionString = ConfigurationManager.ConnectionStrings["sisconGestão.Properties.Settings.SISCONPROJECTSConnectionString"].ConnectionString;

                if (string.IsNullOrEmpty(connectionString))
                {
                    // Abra o formulário para inserir a connection string
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new frmConexaoServidor());
                }

                else
                {
                    try
                    {
                        // Abra o formulário de login ou outro formulário principal
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Form1());
                    }
                    catch //caso erro de conexão com o servidor da DB
                    {
                        MessageBox.Show("Verifique a conexão com o servidor, para acessar o programa.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }
    }
}
