﻿namespace sisconGestão
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbcTelaLogin = new System.Windows.Forms.TabControl();
            this.tbpLoginUsuario = new System.Windows.Forms.TabPage();
            this.tblTelaLogin = new System.Windows.Forms.TableLayoutPanel();
            this.gbTelaLogin = new System.Windows.Forms.GroupBox();
            this.lblLogarComo = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cbLogarComo = new System.Windows.Forms.ComboBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.tbpCadastroUsuario = new System.Windows.Forms.TabPage();
            this.tblCadastro = new System.Windows.Forms.TableLayoutPanel();
            this.gbSenhaAdm = new System.Windows.Forms.GroupBox();
            this.btnAdm = new System.Windows.Forms.Button();
            this.txtSenhaAdm = new System.Windows.Forms.TextBox();
            this.gbCadastroUsuario = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sISCONPROJECTSDataSet = new sisconGestão.SISCONPROJECTSDataSet();
            this.uSUARIOS_SENHASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOS_SENHASTableAdapter = new sisconGestão.SISCONPROJECTSDataSetTableAdapters.USUARIOS_SENHASTableAdapter();
            this.tableAdapterManager = new sisconGestão.SISCONPROJECTSDataSetTableAdapters.TableAdapterManager();
            this.uSUARIOS_SENHASBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uSUARIOS_SENHASDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.pbTelaLoginLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pbLogoCadastrar = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.uSUARIOS_SENHASBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbBloquear = new System.Windows.Forms.ToolStripButton();
            this.tsbEnviarArquivo = new System.Windows.Forms.ToolStripButton();
            this.tsbBaixarArquivo = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcTelaLogin.SuspendLayout();
            this.tbpLoginUsuario.SuspendLayout();
            this.tblTelaLogin.SuspendLayout();
            this.gbTelaLogin.SuspendLayout();
            this.tbpCadastroUsuario.SuspendLayout();
            this.tblCadastro.SuspendLayout();
            this.gbSenhaAdm.SuspendLayout();
            this.gbCadastroUsuario.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONPROJECTSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOS_SENHASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOS_SENHASBindingNavigator)).BeginInit();
            this.uSUARIOS_SENHASBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOS_SENHASDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelaLoginLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCadastrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcTelaLogin
            // 
            this.tbcTelaLogin.Controls.Add(this.tbpLoginUsuario);
            this.tbcTelaLogin.Controls.Add(this.tbpCadastroUsuario);
            this.tbcTelaLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcTelaLogin.Location = new System.Drawing.Point(0, 0);
            this.tbcTelaLogin.Name = "tbcTelaLogin";
            this.tbcTelaLogin.SelectedIndex = 0;
            this.tbcTelaLogin.Size = new System.Drawing.Size(825, 470);
            this.tbcTelaLogin.TabIndex = 0;
            // 
            // tbpLoginUsuario
            // 
            this.tbpLoginUsuario.BackColor = System.Drawing.Color.DimGray;
            this.tbpLoginUsuario.Controls.Add(this.tblTelaLogin);
            this.tbpLoginUsuario.Location = new System.Drawing.Point(4, 27);
            this.tbpLoginUsuario.Name = "tbpLoginUsuario";
            this.tbpLoginUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLoginUsuario.Size = new System.Drawing.Size(817, 439);
            this.tbpLoginUsuario.TabIndex = 0;
            this.tbpLoginUsuario.Text = "Login";
            // 
            // tblTelaLogin
            // 
            this.tblTelaLogin.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblTelaLogin.ColumnCount = 2;
            this.tblTelaLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.65432F));
            this.tblTelaLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.34568F));
            this.tblTelaLogin.Controls.Add(this.pbTelaLoginLogo, 0, 0);
            this.tblTelaLogin.Controls.Add(this.gbTelaLogin, 1, 0);
            this.tblTelaLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTelaLogin.Location = new System.Drawing.Point(3, 3);
            this.tblTelaLogin.Name = "tblTelaLogin";
            this.tblTelaLogin.RowCount = 1;
            this.tblTelaLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblTelaLogin.Size = new System.Drawing.Size(811, 433);
            this.tblTelaLogin.TabIndex = 0;
            // 
            // gbTelaLogin
            // 
            this.gbTelaLogin.BackColor = System.Drawing.Color.DimGray;
            this.gbTelaLogin.Controls.Add(this.pictureBox1);
            this.gbTelaLogin.Controls.Add(this.lblLogarComo);
            this.gbTelaLogin.Controls.Add(this.lblSenha);
            this.gbTelaLogin.Controls.Add(this.lblUsuario);
            this.gbTelaLogin.Controls.Add(this.btnEntrar);
            this.gbTelaLogin.Controls.Add(this.cbLogarComo);
            this.gbTelaLogin.Controls.Add(this.txtSenha);
            this.gbTelaLogin.Controls.Add(this.txtUsuario);
            this.gbTelaLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTelaLogin.ForeColor = System.Drawing.Color.Silver;
            this.gbTelaLogin.Location = new System.Drawing.Point(470, 4);
            this.gbTelaLogin.Name = "gbTelaLogin";
            this.gbTelaLogin.Size = new System.Drawing.Size(337, 425);
            this.gbTelaLogin.TabIndex = 1;
            this.gbTelaLogin.TabStop = false;
            this.gbTelaLogin.Text = "Login de usuário";
            // 
            // lblLogarComo
            // 
            this.lblLogarComo.AutoSize = true;
            this.lblLogarComo.Location = new System.Drawing.Point(27, 288);
            this.lblLogarComo.Name = "lblLogarComo";
            this.lblLogarComo.Size = new System.Drawing.Size(96, 18);
            this.lblLogarComo.TabIndex = 6;
            this.lblLogarComo.Text = "Logar como:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(27, 238);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 18);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(27, 187);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(66, 18);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuário:";
            // 
            // cbLogarComo
            // 
            this.cbLogarComo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLogarComo.FormattingEnabled = true;
            this.cbLogarComo.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Desenvolvedor",
            "Cliente"});
            this.cbLogarComo.Location = new System.Drawing.Point(124, 285);
            this.cbLogarComo.Name = "cbLogarComo";
            this.cbLogarComo.Size = new System.Drawing.Size(189, 26);
            this.cbLogarComo.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(124, 235);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(189, 26);
            this.txtSenha.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(124, 184);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(189, 26);
            this.txtUsuario.TabIndex = 0;
            // 
            // tbpCadastroUsuario
            // 
            this.tbpCadastroUsuario.BackColor = System.Drawing.Color.DimGray;
            this.tbpCadastroUsuario.Controls.Add(this.tblCadastro);
            this.tbpCadastroUsuario.Location = new System.Drawing.Point(4, 27);
            this.tbpCadastroUsuario.Name = "tbpCadastroUsuario";
            this.tbpCadastroUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadastroUsuario.Size = new System.Drawing.Size(817, 439);
            this.tbpCadastroUsuario.TabIndex = 1;
            this.tbpCadastroUsuario.Text = "Cadastro";
            // 
            // tblCadastro
            // 
            this.tblCadastro.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblCadastro.ColumnCount = 1;
            this.tblCadastro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCadastro.Controls.Add(this.gbSenhaAdm, 0, 0);
            this.tblCadastro.Controls.Add(this.gbCadastroUsuario, 0, 1);
            this.tblCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCadastro.Location = new System.Drawing.Point(3, 3);
            this.tblCadastro.Name = "tblCadastro";
            this.tblCadastro.RowCount = 2;
            this.tblCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblCadastro.Size = new System.Drawing.Size(811, 433);
            this.tblCadastro.TabIndex = 0;
            // 
            // gbSenhaAdm
            // 
            this.gbSenhaAdm.Controls.Add(this.btnFinalizar);
            this.gbSenhaAdm.Controls.Add(this.pbLogoCadastrar);
            this.gbSenhaAdm.Controls.Add(this.btnAdm);
            this.gbSenhaAdm.Controls.Add(this.txtSenhaAdm);
            this.gbSenhaAdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSenhaAdm.ForeColor = System.Drawing.Color.Silver;
            this.gbSenhaAdm.Location = new System.Drawing.Point(4, 4);
            this.gbSenhaAdm.Name = "gbSenhaAdm";
            this.gbSenhaAdm.Size = new System.Drawing.Size(803, 101);
            this.gbSenhaAdm.TabIndex = 0;
            this.gbSenhaAdm.TabStop = false;
            this.gbSenhaAdm.Text = "Senha de adminstrador";
            // 
            // btnAdm
            // 
            this.btnAdm.BackColor = System.Drawing.Color.Silver;
            this.btnAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdm.ForeColor = System.Drawing.Color.DimGray;
            this.btnAdm.Location = new System.Drawing.Point(602, 20);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(95, 70);
            this.btnAdm.TabIndex = 1;
            this.btnAdm.Text = "Acessar";
            this.btnAdm.UseVisualStyleBackColor = false;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // txtSenhaAdm
            // 
            this.txtSenhaAdm.Location = new System.Drawing.Point(360, 43);
            this.txtSenhaAdm.Name = "txtSenhaAdm";
            this.txtSenhaAdm.PasswordChar = '*';
            this.txtSenhaAdm.Size = new System.Drawing.Size(236, 26);
            this.txtSenhaAdm.TabIndex = 0;
            // 
            // gbCadastroUsuario
            // 
            this.gbCadastroUsuario.Controls.Add(this.tableLayoutPanel1);
            this.gbCadastroUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCadastroUsuario.ForeColor = System.Drawing.Color.Silver;
            this.gbCadastroUsuario.Location = new System.Drawing.Point(4, 112);
            this.gbCadastroUsuario.Name = "gbCadastroUsuario";
            this.gbCadastroUsuario.Size = new System.Drawing.Size(803, 317);
            this.gbCadastroUsuario.TabIndex = 1;
            this.gbCadastroUsuario.TabStop = false;
            this.gbCadastroUsuario.Text = "Cadastro de novo usuário";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.uSUARIOS_SENHASBindingNavigator, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.uSUARIOS_SENHASDataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(797, 292);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sISCONPROJECTSDataSet
            // 
            this.sISCONPROJECTSDataSet.DataSetName = "SISCONPROJECTSDataSet";
            this.sISCONPROJECTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOS_SENHASBindingSource
            // 
            this.uSUARIOS_SENHASBindingSource.DataMember = "USUARIOS_SENHAS";
            this.uSUARIOS_SENHASBindingSource.DataSource = this.sISCONPROJECTSDataSet;
            // 
            // uSUARIOS_SENHASTableAdapter
            // 
            this.uSUARIOS_SENHASTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DOCUMENTOS_GERAISTableAdapter = null;
            this.tableAdapterManager.EVIDENCIASTableAdapter = null;
            this.tableAdapterManager.LANCAMENTO_HORARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sisconGestão.SISCONPROJECTSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOS_SENHASTableAdapter = this.uSUARIOS_SENHASTableAdapter;
            // 
            // uSUARIOS_SENHASBindingNavigator
            // 
            this.uSUARIOS_SENHASBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uSUARIOS_SENHASBindingNavigator.BindingSource = this.uSUARIOS_SENHASBindingSource;
            this.uSUARIOS_SENHASBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uSUARIOS_SENHASBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uSUARIOS_SENHASBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uSUARIOS_SENHASBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.uSUARIOS_SENHASBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.uSUARIOS_SENHASBindingNavigatorSaveItem,
            this.bindingNavigatorDeleteItem,
            this.tsbEditar,
            this.tsbBloquear,
            this.toolStripSeparator1,
            this.tsbEnviarArquivo,
            this.tsbBaixarArquivo});
            this.uSUARIOS_SENHASBindingNavigator.Location = new System.Drawing.Point(1, 208);
            this.uSUARIOS_SENHASBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uSUARIOS_SENHASBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uSUARIOS_SENHASBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uSUARIOS_SENHASBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uSUARIOS_SENHASBindingNavigator.Name = "uSUARIOS_SENHASBindingNavigator";
            this.uSUARIOS_SENHASBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uSUARIOS_SENHASBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.uSUARIOS_SENHASBindingNavigator.Size = new System.Drawing.Size(795, 83);
            this.uSUARIOS_SENHASBindingNavigator.TabIndex = 1;
            this.uSUARIOS_SENHASBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 83);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 26);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 80);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 83);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 83);
            // 
            // uSUARIOS_SENHASDataGridView
            // 
            this.uSUARIOS_SENHASDataGridView.AutoGenerateColumns = false;
            this.uSUARIOS_SENHASDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.uSUARIOS_SENHASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uSUARIOS_SENHASDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.uSUARIOS_SENHASDataGridView.DataSource = this.uSUARIOS_SENHASBindingSource;
            this.uSUARIOS_SENHASDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uSUARIOS_SENHASDataGridView.Location = new System.Drawing.Point(4, 4);
            this.uSUARIOS_SENHASDataGridView.Name = "uSUARIOS_SENHASDataGridView";
            this.uSUARIOS_SENHASDataGridView.Size = new System.Drawing.Size(789, 200);
            this.uSUARIOS_SENHASDataGridView.TabIndex = 0;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 83);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Silver;
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.DimGray;
            this.btnFinalizar.Location = new System.Drawing.Point(701, 20);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(95, 70);
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // pbTelaLoginLogo
            // 
            this.pbTelaLoginLogo.BackColor = System.Drawing.Color.Black;
            this.pbTelaLoginLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTelaLoginLogo.Image = global::sisconGestão.Properties.Resources.sisconImage;
            this.pbTelaLoginLogo.Location = new System.Drawing.Point(4, 4);
            this.pbTelaLoginLogo.Name = "pbTelaLoginLogo";
            this.pbTelaLoginLogo.Size = new System.Drawing.Size(459, 425);
            this.pbTelaLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTelaLoginLogo.TabIndex = 0;
            this.pbTelaLoginLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sisconGestão.Properties.Resources.conexao;
            this.pictureBox1.Location = new System.Drawing.Point(105, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.LightGray;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.DimGray;
            this.btnEntrar.Image = global::sisconGestão.Properties.Resources.enter;
            this.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrar.Location = new System.Drawing.Point(224, 363);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(107, 56);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pbLogoCadastrar
            // 
            this.pbLogoCadastrar.Image = global::sisconGestão.Properties.Resources.sisconImage;
            this.pbLogoCadastrar.Location = new System.Drawing.Point(6, 20);
            this.pbLogoCadastrar.Name = "pbLogoCadastrar";
            this.pbLogoCadastrar.Size = new System.Drawing.Size(348, 70);
            this.pbLogoCadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoCadastrar.TabIndex = 2;
            this.pbLogoCadastrar.TabStop = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(52, 80);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(52, 80);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(52, 80);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(52, 80);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(52, 80);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(52, 80);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // uSUARIOS_SENHASBindingNavigatorSaveItem
            // 
            this.uSUARIOS_SENHASBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uSUARIOS_SENHASBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uSUARIOS_SENHASBindingNavigatorSaveItem.Image")));
            this.uSUARIOS_SENHASBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uSUARIOS_SENHASBindingNavigatorSaveItem.Name = "uSUARIOS_SENHASBindingNavigatorSaveItem";
            this.uSUARIOS_SENHASBindingNavigatorSaveItem.Size = new System.Drawing.Size(52, 80);
            this.uSUARIOS_SENHASBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.uSUARIOS_SENHASBindingNavigatorSaveItem.Click += new System.EventHandler(this.uSUARIOS_SENHASBindingNavigatorSaveItem_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(52, 80);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbBloquear
            // 
            this.tsbBloquear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBloquear.Image = ((System.Drawing.Image)(resources.GetObject("tsbBloquear.Image")));
            this.tsbBloquear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBloquear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBloquear.Name = "tsbBloquear";
            this.tsbBloquear.Size = new System.Drawing.Size(52, 80);
            this.tsbBloquear.Text = "Bloquear";
            this.tsbBloquear.Click += new System.EventHandler(this.tsbBloquear_Click);
            // 
            // tsbEnviarArquivo
            // 
            this.tsbEnviarArquivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEnviarArquivo.Image = ((System.Drawing.Image)(resources.GetObject("tsbEnviarArquivo.Image")));
            this.tsbEnviarArquivo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEnviarArquivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEnviarArquivo.Name = "tsbEnviarArquivo";
            this.tsbEnviarArquivo.Size = new System.Drawing.Size(52, 80);
            this.tsbEnviarArquivo.Text = "Enviar Arquivo";
            // 
            // tsbBaixarArquivo
            // 
            this.tsbBaixarArquivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBaixarArquivo.Image = ((System.Drawing.Image)(resources.GetObject("tsbBaixarArquivo.Image")));
            this.tsbBaixarArquivo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBaixarArquivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBaixarArquivo.Name = "tsbBaixarArquivo";
            this.tsbBaixarArquivo.Size = new System.Drawing.Size(52, 80);
            this.tsbBaixarArquivo.Text = "Baixar Arquivo";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Usuario";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Usuário";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Senha";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Senha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Competencia";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Competência";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 345;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 470);
            this.Controls.Add(this.tbcTelaLogin);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISCON PROJECTS - Sistema de Controle e Gestão";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcTelaLogin.ResumeLayout(false);
            this.tbpLoginUsuario.ResumeLayout(false);
            this.tblTelaLogin.ResumeLayout(false);
            this.gbTelaLogin.ResumeLayout(false);
            this.gbTelaLogin.PerformLayout();
            this.tbpCadastroUsuario.ResumeLayout(false);
            this.tblCadastro.ResumeLayout(false);
            this.gbSenhaAdm.ResumeLayout(false);
            this.gbSenhaAdm.PerformLayout();
            this.gbCadastroUsuario.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONPROJECTSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOS_SENHASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOS_SENHASBindingNavigator)).EndInit();
            this.uSUARIOS_SENHASBindingNavigator.ResumeLayout(false);
            this.uSUARIOS_SENHASBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOS_SENHASDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelaLoginLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCadastrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcTelaLogin;
        private System.Windows.Forms.TabPage tbpLoginUsuario;
        private System.Windows.Forms.TabPage tbpCadastroUsuario;
        private System.Windows.Forms.TableLayoutPanel tblTelaLogin;
        private System.Windows.Forms.PictureBox pbTelaLoginLogo;
        private System.Windows.Forms.GroupBox gbTelaLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblLogarComo;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.ComboBox cbLogarComo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tblCadastro;
        private System.Windows.Forms.GroupBox gbSenhaAdm;
        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.TextBox txtSenhaAdm;
        private System.Windows.Forms.GroupBox gbCadastroUsuario;
        private System.Windows.Forms.PictureBox pbLogoCadastrar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SISCONPROJECTSDataSet sISCONPROJECTSDataSet;
        private System.Windows.Forms.BindingSource uSUARIOS_SENHASBindingSource;
        private SISCONPROJECTSDataSetTableAdapters.USUARIOS_SENHASTableAdapter uSUARIOS_SENHASTableAdapter;
        private SISCONPROJECTSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uSUARIOS_SENHASBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton uSUARIOS_SENHASBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView uSUARIOS_SENHASDataGridView;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbBloquear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbEnviarArquivo;
        private System.Windows.Forms.ToolStripButton tsbBaixarArquivo;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

