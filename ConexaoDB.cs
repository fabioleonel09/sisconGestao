using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace sisconGestão
{
    public static class ConexaoDB
    {
        public static SqlConnection AbrirConexao()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["sisconGestão.Properties.Settings.SISCONPROJECTSConnectionString"].ConnectionString;
            SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();
            return conexao;
        }

        public static void FecharConexao(SqlConnection conexao)
        {
            conexao.Close();
        }
    }
}
