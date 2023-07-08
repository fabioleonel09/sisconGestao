using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisconGestão
{
    static class autenticacao //classe criada para funcionar como controladora entre DB e txt's
    {
        //declaração das variáveis
        static string Usuario;
        static string Competencia;
        static string Senha;

        public static void Entrar(string usuario, string competencia, string senha) //declaração do evento
        {
            //associação das variáveis aos eventos
            Usuario = usuario;
            Competencia = competencia;
            Senha = senha;
        }
    }
}
