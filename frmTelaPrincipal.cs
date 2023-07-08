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
    public partial class frmTelaPrincipal : Form
    {
        #region DECLARAÇÃO DAS VARIÁVEIS PRIVADAS
        
        private Timer timer; // Declara o timer como uma variável de classe
        private string logado; // Variável de classe para armazenar o valor

        #endregion

        public frmTelaPrincipal(string logadoComo)
        {
            InitializeComponent();

            //associa a lbl numa concatenação
            lblLogadoComo.Text = "Você está logado como: \n" + logadoComo;

            AtualizaHora();

            BotoesInativos();

            logado = logadoComo;

            //método de condição para verificação do usuário logado
            VerificaUsuarioLogado();
        }

        //este evento encerra a aplicação, o frm seja fechado pelo "X" da janela
        private void frmTelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)//instancia o evento de reação ao fechar o frm
            {
                //instancia a messageBox de confirmação de saída do sistema
                dynamic mboxResult = MessageBox.Show("Deseja sair do sistema?", "Confirmação!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (mboxResult == DialogResult.Cancel)  //se escolher cancel no dialógo
                {
                    e.Cancel = true;  //realmente cancela a ação e volta ao frm
                }
                else if (mboxResult == DialogResult.OK) //se escolher ok
                {
                    Application.Exit(); //fecha a aplicação
                }
            }
        }

        private void btnDocsGerais_Click(object sender, EventArgs e) //evento do botão documentos gerais
        {
            frmDocumentosGerais fdg = new frmDocumentosGerais(); //instancia o frmDocumentosGerias para ser chamado neste frm
            fdg.ShowDialog();   //chama o frm e o mantém como ativo na tela
        }

        private void btnEvidencias_Click(object sender, EventArgs e) //evento do botão evidências
        {
            frmEvidencias fe = new frmEvidencias(); //instancia o frmEvidencias para ser chamado neste frm
            fe.ShowDialog(); //chama o frm e o mantém como ativo na tela
        }

        private void btnLancamentoHoras_Click(object sender, EventArgs e) //evento do botão lançamento horas
        {
            frmLancamentoHoras flh = new frmLancamentoHoras(); //instancia o frmLancamentoHoras para ser chamado neste frm
            flh.ShowDialog(); //chama o frm e o mantém como ativo na tela
        }
        
        private void Timer_Tick(object sender, EventArgs e) //este é o evento do componete Timer para atualizar a hora no frm
        {
            //para mostrar a hora no painel
            var dataHora = DateTime.Now; //associa a data atual numa variável
            lblHoraDia.Text = "Data de hoje: " + dataHora.ToString();  //associa à lbl a concatenação da frase com a variável
        }

        private void AtualizaHora() //método para atualizar a hora no painel do frm
        {
            // Inicialize o timer e defina o intervalo
            timer = new Timer();
            timer.Interval = 1000; // Atualiza a cada segundo (1000 milissegundos)
            timer.Tick += Timer_Tick; // Defina o evento de Tick
            timer.Start(); // Inicie o timer
        }

        private void BotoesInativos()
        {
            btnDocsGerais.Enabled = false;
            btnEvidencias.Enabled = false;
            btnLancamentoHoras.Enabled = false;
        }

        private void VerificaUsuarioLogado()
        {
            if (logado == "Administrador")
            {
                btnDocsGerais.Enabled = true;
                btnEvidencias.Enabled = true;
                btnLancamentoHoras.Enabled = true;
            }
            else if (logado == "Desenvolvedor")
            {
                btnEvidencias.Enabled = true;
                btnLancamentoHoras.Enabled = true;
            }
            else if(logado == "Cliente")
            {
                btnEvidencias.Enabled = true;
            }
        }
    }
}
