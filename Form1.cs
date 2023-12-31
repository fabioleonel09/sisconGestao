﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace sisconGestão
{
    public partial class Form1 : Form
    {
        #region VARIAVEIS E INSTANCIAS DE CONEXAO
        //aqui ocorre as instâncias do sql: conexão, comandos e leituras. E dá nome à conexão.
        private SqlConnection conexao;
        SqlCommand comando;
        SqlDataReader dr;
        string strSQL;
        #endregion

        public Form1()
        {
            InitializeComponent();

            InabilitaBotoesBarraFerramentas();

            gbCadastroUsuario.Visible = false; //inicia o gb do cadastro de usuários com visibilidade falsa

            //deixa a grid de cadastro inabilitada
            uSUARIOS_SENHASDataGridView.Enabled = false;
        }       

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try //try e cacth para tratamento de erros de conexão com o banco de dados.
            {
                //instancia-se a conexão como o banco de dados, escolhendo a tabela e as colunas e associando-as aos txt`s
                using (conexao = ConexaoDB.AbrirConexao())
                {
                    BuscaColunasTabela();

                    if (dr.Read()) //se acontecer a leitura
                    {
                        //esta classe "autenticação" foi criada e funciona como um MVC, controlando o que tem de dados nas colunas e comparando-os
                        autenticacao.Entrar(dr["Usuario"].ToString(), dr["Competencia"].ToString(), dr["Senha"].ToString());

                        this.Visible = false; //deixa este frm invisível

                        //este evento chama o frm Aguarde e o associa ao método OpenData criado
                        using (frmAguarde fa = new frmAguarde(OpenData))
                        {
                            fa.ShowDialog(this);
                        }

                        //este evento chama o frmTelaProncipal
                        string logadoComo = cbLogarComo.Text;//atribui o combobox a uma variável

                        var ftp = new frmTelaPrincipal(logadoComo);//instancia o frm que abrirá com a variável
                        ftp.Show(); //mostra o frm instanciado
                    }
                    else if ((txtUsuario.Text == "") || (txtSenha.Text == "") || (cbLogarComo.Text == "")) //caso os txt's vazios
                    {
                        MessageBox.Show("Preencha os campos vazios com os dados corretos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); //lança a msg de aviso
                    }
                    else //caso os dados não coincidam com os que estão na DB
                    {
                        MessageBox.Show("Dados incorretos. Preencha novamente. Verifique o usuário, a senha e o campo 'Logar como'.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //lança a msg de aviso

                        //limpa os txt`s
                        txtUsuario.Clear();
                        txtSenha.Clear();

                        //volta com o cb para um índice vazio
                        cbLogarComo.SelectedIndex = -1;
                    }
                }                  
            }
            catch //caso erro de conexão com o servidor da DB
            {
                MessageBox.Show("Verifique a conexão com o servidor, para acessar o programa.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //evento do botão salvar na barra de ferramentas
        private void uSUARIOS_SENHASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SalvaAcao(); //entra neste método
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sISCONPROJECTSDataSet.USUARIOS_SENHAS'. Você pode movê-la ou removê-la conforme necessário.
            this.uSUARIOS_SENHASTableAdapter.Fill(this.sISCONPROJECTSDataSet.USUARIOS_SENHAS);

        }

        private void btnAdm_Click(object sender, EventArgs e) //este evento irá habilitar o gb de cadastro
        {
            if (txtSenhaAdm.Text == "adm1030#$siscon")
            {
                gbCadastroUsuario.Visible = true; //habilita o gb
                txtSenhaAdm.Clear(); //limpa a txt da senha do adm
            }
            else
            {
                MessageBox.Show("Senha incorreta! Tente novamente ou contate o suporte.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information); //dispara a mensagem informando o erro
                txtSenhaAdm.Clear(); //limpa a txt da senha do adm
            }
        }

        //evento do btn adicionar na barra de ferramentas
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //deixa a grid de cadastro habilitada
            uSUARIOS_SENHASDataGridView.Enabled = true;
        }

        //evento do botão deletar na barra de ferramentas
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            SalvaAcao(); //entra neste método
        }

        //evento do btn editar na barra de ferramentas
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            //deixa a grid de cadastro habilitada
            uSUARIOS_SENHASDataGridView.Enabled = true;
        }

        //evento do btn bloquear na barra de ferramentas
        private void tsbBloquear_Click(object sender, EventArgs e)
        {
            SalvaAcao(); //entra neste método
        }       

        //evento do btn finaliza na aba de cadastros
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            gbCadastroUsuario.Visible = false; //inicia o gb do cadastro de usuários com visibilidade falsa

            //deixa a grid de cadastro inabilitada
            uSUARIOS_SENHASDataGridView.Enabled = false;

            txtSenhaAdm.Clear(); //limpa a txt da senha do adm
        }       

        private void btnMascara_Click(object sender, EventArgs e)
        {
            if (btnMascara.Text == "| | |")
            {
                txtSenha.PasswordChar = '\0';
                
                btnMascara.Text = "* * *";
            }
            else if(btnMascara.Text == "* * *")
            {
                txtSenha.PasswordChar = '*';
                btnMascara.Text = "| | |";
            }
        }

        private void btnConexaoServidor_Click(object sender, EventArgs e)
        {
            frmConexaoServidor fdc = new frmConexaoServidor();
            fdc.ShowDialog();
        }

        private void BuscaColunasTabela()
        {
            strSQL = "SELECT * FROM USUARIOS_SENHAS WHERE Usuario = @USUARIO AND Competencia = @COMPETENCIA AND Senha = @SENHA";
            comando = new SqlCommand(strSQL, conexao);
            comando.Parameters.AddWithValue("@USUARIO", txtUsuario.Text);
            comando.Parameters.AddWithValue("@COMPETENCIA", cbLogarComo.Text);
            comando.Parameters.AddWithValue("@SENHA", txtSenha.Text);

            dr = comando.ExecuteReader(); //executa a leitura da tabela e das colunas escolhidas
        }

        //este comando controla a velocidade da barra de status e o tempo de aparecimento da janela "Aguarde"
        void OpenData()
        {
            for (int i = 0; i <= 400; i++)
            {
                Thread.Sleep(5);
            }
        }

        private void SalvaAcao() //método salva ação
        {
            try //tratamento de erros para salvar em db
            {
                //crud entre a barra de ferramentas e a DB
                this.Validate();
                this.uSUARIOS_SENHASBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sISCONPROJECTSDataSet);

                MessageBox.Show("Ação realizada com sucesso!.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information); //dispara a mensagem informando que foi realizada a ação

                //deixa a grid de cadastro inabilitada
                uSUARIOS_SENHASDataGridView.Enabled = false;
            }
            catch (SqlException ex) //se ocorrer algum erro técnico, dipara a msg
            {
                // Verifique se a exceção é de chave duplicada (ou outra exceção específica relacionada à PK)
                if (ex.Number == 2627)
                {
                    // Trate o caso de chave duplicada
                    MessageBox.Show("A chave de registro já está em uso. Por favor, feche a janela de Enviar Arquivo e tente novamente.", "Conflito de inserção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Outras ações apropriadas, como limpar campos ou notificar o usuário sobre o conflito
                }
                else if (ex.Number == 547)
                {
                    MessageBox.Show("Os campos Usuário, Senha e Competência devem ter no máximo 100 caracteres.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Trate outras exceções que possam ocorrer
                    MessageBox.Show("Erro durante a inserção: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InabilitaBotoesBarraFerramentas()
        {
            //deixa dos botões de enviar arquivo e baixar arquivo inabilitados na janela de login
            tsbEnviarArquivo.Enabled = false;
            tsbBaixarArquivo.Enabled = false;
        }

        private void btnMascaraCadastro_Click(object sender, EventArgs e)
        {
            if (btnMascaraCadastro.Text == "| | |")
            {
                txtSenhaAdm.PasswordChar = '\0';

                btnMascaraCadastro.Text = "* * *";
            }
            else if (btnMascaraCadastro.Text == "* * *")
            {
                txtSenhaAdm.PasswordChar = '*';
                btnMascaraCadastro.Text = "| | |";
            }
        }
    }
}
