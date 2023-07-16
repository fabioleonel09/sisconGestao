namespace sisconGestão
{
    partial class frmArquivosDocsGerais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeDocGeralLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArquivosDocsGerais));
            this.tlpArquivosDocsGerais = new System.Windows.Forms.TableLayoutPanel();
            this.aRQUIVOS_DOCS_GERAISBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISCONPROJECTSDataSet = new sisconGestão.SISCONPROJECTSDataSet();
            this.dgvArquivosDosGerais = new System.Windows.Forms.DataGridView();
            this.aRQUIVOS_DOCS_GERAISTableAdapter = new sisconGestão.SISCONPROJECTSDataSetTableAdapters.ARQUIVOS_DOCS_GERAISTableAdapter();
            this.tableAdapterManager = new sisconGestão.SISCONPROJECTSDataSetTableAdapters.TableAdapterManager();
            this.tlpAcoesGeraisDocsGerais = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAcoesBotoesDocsGerais = new System.Windows.Forms.TableLayoutPanel();
            this.btnPesquisarArquivosDocsGerais = new System.Windows.Forms.Button();
            this.btnApagaArquivoDocsGerais = new System.Windows.Forms.Button();
            this.btnSalvarArquivoDocsGerais = new System.Windows.Forms.Button();
            this.btnAbrirArquivoDocsGerais = new System.Windows.Forms.Button();
            this.txtPesquisaNomeArquivoDocsGerais = new System.Windows.Forms.TextBox();
            this.nomeDocGeralTextBox = new System.Windows.Forms.TextBox();
            this.lblNomePesquisa = new System.Windows.Forms.Label();
            this.gbArquivosDocsGerais = new System.Windows.Forms.GroupBox();
            this.aRQUIVOS_DOCS_GERAISbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            nomeDocGeralLabel = new System.Windows.Forms.Label();
            this.tlpArquivosDocsGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aRQUIVOS_DOCS_GERAISBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONPROJECTSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivosDosGerais)).BeginInit();
            this.tlpAcoesGeraisDocsGerais.SuspendLayout();
            this.tlpAcoesBotoesDocsGerais.SuspendLayout();
            this.gbArquivosDocsGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aRQUIVOS_DOCS_GERAISbindingNavigator)).BeginInit();
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpArquivosDocsGerais
            // 
            this.tlpArquivosDocsGerais.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpArquivosDocsGerais.ColumnCount = 1;
            this.tlpArquivosDocsGerais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpArquivosDocsGerais.Controls.Add(this.gbArquivosDocsGerais, 0, 1);
            this.tlpArquivosDocsGerais.Controls.Add(this.dgvArquivosDosGerais, 0, 0);
            this.tlpArquivosDocsGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpArquivosDocsGerais.Location = new System.Drawing.Point(0, 0);
            this.tlpArquivosDocsGerais.Name = "tlpArquivosDocsGerais";
            this.tlpArquivosDocsGerais.RowCount = 2;
            this.tlpArquivosDocsGerais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.79612F));
            this.tlpArquivosDocsGerais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.20388F));
            this.tlpArquivosDocsGerais.Size = new System.Drawing.Size(453, 516);
            this.tlpArquivosDocsGerais.TabIndex = 0;
            // 
            // aRQUIVOS_DOCS_GERAISBindingSource
            // 
            this.aRQUIVOS_DOCS_GERAISBindingSource.DataMember = "ARQUIVOS_DOCS_GERAIS";
            this.aRQUIVOS_DOCS_GERAISBindingSource.DataSource = this.sISCONPROJECTSDataSet;
            // 
            // sISCONPROJECTSDataSet
            // 
            this.sISCONPROJECTSDataSet.DataSetName = "SISCONPROJECTSDataSet";
            this.sISCONPROJECTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvArquivosDosGerais
            // 
            this.dgvArquivosDosGerais.AllowUserToAddRows = false;
            this.dgvArquivosDosGerais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvArquivosDosGerais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArquivosDosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArquivosDosGerais.Location = new System.Drawing.Point(4, 4);
            this.dgvArquivosDosGerais.Name = "dgvArquivosDosGerais";
            this.dgvArquivosDosGerais.ReadOnly = true;
            this.dgvArquivosDosGerais.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvArquivosDosGerais.Size = new System.Drawing.Size(445, 234);
            this.dgvArquivosDosGerais.TabIndex = 1;
            // 
            // aRQUIVOS_DOCS_GERAISTableAdapter
            // 
            this.aRQUIVOS_DOCS_GERAISTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ARQUIVOS_DOCS_GERAISTableAdapter = this.aRQUIVOS_DOCS_GERAISTableAdapter;
            this.tableAdapterManager.ARQUIVOS_EVIDENCIASTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DOCUMENTOS_GERAISTableAdapter = null;
            this.tableAdapterManager.EVIDENCIASTableAdapter = null;
            this.tableAdapterManager.LANCAMENTO_HORARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sisconGestão.SISCONPROJECTSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOS_SENHASTableAdapter = null;
            // 
            // tlpAcoesGeraisDocsGerais
            // 
            this.tlpAcoesGeraisDocsGerais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAcoesGeraisDocsGerais.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpAcoesGeraisDocsGerais.ColumnCount = 1;
            this.tlpAcoesGeraisDocsGerais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAcoesGeraisDocsGerais.Controls.Add(this.tlpAcoesBotoesDocsGerais, 0, 0);
            this.tlpAcoesGeraisDocsGerais.Location = new System.Drawing.Point(3, 132);
            this.tlpAcoesGeraisDocsGerais.Name = "tlpAcoesGeraisDocsGerais";
            this.tlpAcoesGeraisDocsGerais.RowCount = 1;
            this.tlpAcoesGeraisDocsGerais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpAcoesGeraisDocsGerais.Size = new System.Drawing.Size(439, 132);
            this.tlpAcoesGeraisDocsGerais.TabIndex = 0;
            // 
            // tlpAcoesBotoesDocsGerais
            // 
            this.tlpAcoesBotoesDocsGerais.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpAcoesBotoesDocsGerais.ColumnCount = 2;
            this.tlpAcoesBotoesDocsGerais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAcoesBotoesDocsGerais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAcoesBotoesDocsGerais.Controls.Add(this.btnAbrirArquivoDocsGerais, 1, 1);
            this.tlpAcoesBotoesDocsGerais.Controls.Add(this.btnSalvarArquivoDocsGerais, 0, 1);
            this.tlpAcoesBotoesDocsGerais.Controls.Add(this.btnApagaArquivoDocsGerais, 1, 0);
            this.tlpAcoesBotoesDocsGerais.Controls.Add(this.btnPesquisarArquivosDocsGerais, 0, 0);
            this.tlpAcoesBotoesDocsGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAcoesBotoesDocsGerais.Location = new System.Drawing.Point(4, 4);
            this.tlpAcoesBotoesDocsGerais.Name = "tlpAcoesBotoesDocsGerais";
            this.tlpAcoesBotoesDocsGerais.RowCount = 2;
            this.tlpAcoesBotoesDocsGerais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAcoesBotoesDocsGerais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAcoesBotoesDocsGerais.Size = new System.Drawing.Size(431, 124);
            this.tlpAcoesBotoesDocsGerais.TabIndex = 3;
            // 
            // btnPesquisarArquivosDocsGerais
            // 
            this.btnPesquisarArquivosDocsGerais.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPesquisarArquivosDocsGerais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarArquivosDocsGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisarArquivosDocsGerais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarArquivosDocsGerais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarArquivosDocsGerais.Image = global::sisconGestão.Properties.Resources.buscarusuario;
            this.btnPesquisarArquivosDocsGerais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarArquivosDocsGerais.Location = new System.Drawing.Point(4, 4);
            this.btnPesquisarArquivosDocsGerais.Name = "btnPesquisarArquivosDocsGerais";
            this.btnPesquisarArquivosDocsGerais.Size = new System.Drawing.Size(208, 54);
            this.btnPesquisarArquivosDocsGerais.TabIndex = 0;
            this.btnPesquisarArquivosDocsGerais.Text = "Pesquisar";
            this.btnPesquisarArquivosDocsGerais.UseVisualStyleBackColor = false;
            this.btnPesquisarArquivosDocsGerais.Click += new System.EventHandler(this.btnPesquisarArquivosDocsGerais_Click);
            // 
            // btnApagaArquivoDocsGerais
            // 
            this.btnApagaArquivoDocsGerais.BackColor = System.Drawing.Color.MistyRose;
            this.btnApagaArquivoDocsGerais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagaArquivoDocsGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApagaArquivoDocsGerais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagaArquivoDocsGerais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagaArquivoDocsGerais.Image = global::sisconGestão.Properties.Resources.ApagaDocumentoEvidencia;
            this.btnApagaArquivoDocsGerais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagaArquivoDocsGerais.Location = new System.Drawing.Point(219, 4);
            this.btnApagaArquivoDocsGerais.Name = "btnApagaArquivoDocsGerais";
            this.btnApagaArquivoDocsGerais.Size = new System.Drawing.Size(208, 54);
            this.btnApagaArquivoDocsGerais.TabIndex = 4;
            this.btnApagaArquivoDocsGerais.Text = "Limpar";
            this.btnApagaArquivoDocsGerais.UseVisualStyleBackColor = false;
            this.btnApagaArquivoDocsGerais.Click += new System.EventHandler(this.btnApagaArquivoDocsGerais_Click);
            // 
            // btnSalvarArquivoDocsGerais
            // 
            this.btnSalvarArquivoDocsGerais.BackColor = System.Drawing.Color.Honeydew;
            this.btnSalvarArquivoDocsGerais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarArquivoDocsGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalvarArquivoDocsGerais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarArquivoDocsGerais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarArquivoDocsGerais.Image = global::sisconGestão.Properties.Resources.SalvaDocumentosEvidencias;
            this.btnSalvarArquivoDocsGerais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarArquivoDocsGerais.Location = new System.Drawing.Point(4, 65);
            this.btnSalvarArquivoDocsGerais.Name = "btnSalvarArquivoDocsGerais";
            this.btnSalvarArquivoDocsGerais.Size = new System.Drawing.Size(208, 55);
            this.btnSalvarArquivoDocsGerais.TabIndex = 5;
            this.btnSalvarArquivoDocsGerais.Text = "Salvar";
            this.btnSalvarArquivoDocsGerais.UseVisualStyleBackColor = false;
            this.btnSalvarArquivoDocsGerais.Click += new System.EventHandler(this.btnSalvarArquivoDocsGerais_Click);
            // 
            // btnAbrirArquivoDocsGerais
            // 
            this.btnAbrirArquivoDocsGerais.BackColor = System.Drawing.SystemColors.Info;
            this.btnAbrirArquivoDocsGerais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirArquivoDocsGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbrirArquivoDocsGerais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirArquivoDocsGerais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirArquivoDocsGerais.Image = global::sisconGestão.Properties.Resources.DocumentosEvidencias;
            this.btnAbrirArquivoDocsGerais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirArquivoDocsGerais.Location = new System.Drawing.Point(219, 65);
            this.btnAbrirArquivoDocsGerais.Name = "btnAbrirArquivoDocsGerais";
            this.btnAbrirArquivoDocsGerais.Size = new System.Drawing.Size(208, 55);
            this.btnAbrirArquivoDocsGerais.TabIndex = 6;
            this.btnAbrirArquivoDocsGerais.Text = "Abrir";
            this.btnAbrirArquivoDocsGerais.UseVisualStyleBackColor = false;
            this.btnAbrirArquivoDocsGerais.Click += new System.EventHandler(this.btnAbrirArquivoDocsGerais_Click);
            // 
            // txtPesquisaNomeArquivoDocsGerais
            // 
            this.txtPesquisaNomeArquivoDocsGerais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisaNomeArquivoDocsGerais.Enabled = false;
            this.txtPesquisaNomeArquivoDocsGerais.Location = new System.Drawing.Point(11, 100);
            this.txtPesquisaNomeArquivoDocsGerais.Name = "txtPesquisaNomeArquivoDocsGerais";
            this.txtPesquisaNomeArquivoDocsGerais.Size = new System.Drawing.Size(423, 26);
            this.txtPesquisaNomeArquivoDocsGerais.TabIndex = 3;
            // 
            // nomeDocGeralTextBox
            // 
            this.nomeDocGeralTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRQUIVOS_DOCS_GERAISBindingSource, "NomeDocGeral", true));
            this.nomeDocGeralTextBox.Enabled = false;
            this.nomeDocGeralTextBox.Location = new System.Drawing.Point(11, 40);
            this.nomeDocGeralTextBox.Name = "nomeDocGeralTextBox";
            this.nomeDocGeralTextBox.Size = new System.Drawing.Size(185, 26);
            this.nomeDocGeralTextBox.TabIndex = 6;
            // 
            // nomeDocGeralLabel
            // 
            nomeDocGeralLabel.AutoSize = true;
            nomeDocGeralLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeDocGeralLabel.Location = new System.Drawing.Point(8, 19);
            nomeDocGeralLabel.Name = "nomeDocGeralLabel";
            nomeDocGeralLabel.Size = new System.Drawing.Size(197, 19);
            nomeDocGeralLabel.TabIndex = 5;
            nomeDocGeralLabel.Text = "Nome Documento Geral:";
            // 
            // lblNomePesquisa
            // 
            this.lblNomePesquisa.AutoSize = true;
            this.lblNomePesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePesquisa.Location = new System.Drawing.Point(9, 79);
            this.lblNomePesquisa.Name = "lblNomePesquisa";
            this.lblNomePesquisa.Size = new System.Drawing.Size(173, 19);
            this.lblNomePesquisa.TabIndex = 7;
            this.lblNomePesquisa.Text = "Nome para Pesquisa:";
            // 
            // gbArquivosDocsGerais
            // 
            this.gbArquivosDocsGerais.Controls.Add(this.aRQUIVOS_DOCS_GERAISbindingNavigator);
            this.gbArquivosDocsGerais.Controls.Add(this.lblNomePesquisa);
            this.gbArquivosDocsGerais.Controls.Add(nomeDocGeralLabel);
            this.gbArquivosDocsGerais.Controls.Add(this.nomeDocGeralTextBox);
            this.gbArquivosDocsGerais.Controls.Add(this.txtPesquisaNomeArquivoDocsGerais);
            this.gbArquivosDocsGerais.Controls.Add(this.tlpAcoesGeraisDocsGerais);
            this.gbArquivosDocsGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbArquivosDocsGerais.Location = new System.Drawing.Point(4, 245);
            this.gbArquivosDocsGerais.Name = "gbArquivosDocsGerais";
            this.gbArquivosDocsGerais.Size = new System.Drawing.Size(445, 267);
            this.gbArquivosDocsGerais.TabIndex = 0;
            this.gbArquivosDocsGerais.TabStop = false;
            this.gbArquivosDocsGerais.Text = "Ações";
            // 
            // aRQUIVOS_DOCS_GERAISbindingNavigator
            // 
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.AddNewItem = null;
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.BindingSource = this.aRQUIVOS_DOCS_GERAISBindingSource;
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem});
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.Location = new System.Drawing.Point(204, 40);
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.Name = "aRQUIVOS_DOCS_GERAISbindingNavigator";
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.Size = new System.Drawing.Size(237, 26);
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.TabIndex = 8;
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.Text = "bindingNavigator";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 26);
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
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 23);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // frmArquivosDocsGerais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 516);
            this.Controls.Add(this.tlpArquivosDocsGerais);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmArquivosDocsGerais";
            this.Text = "Documentos Gerais - Janela de Arquivos";
            this.Load += new System.EventHandler(this.frmArquivosDocsGerais_Load);
            this.tlpArquivosDocsGerais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aRQUIVOS_DOCS_GERAISBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONPROJECTSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivosDosGerais)).EndInit();
            this.tlpAcoesGeraisDocsGerais.ResumeLayout(false);
            this.tlpAcoesBotoesDocsGerais.ResumeLayout(false);
            this.gbArquivosDocsGerais.ResumeLayout(false);
            this.gbArquivosDocsGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aRQUIVOS_DOCS_GERAISbindingNavigator)).EndInit();
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.ResumeLayout(false);
            this.aRQUIVOS_DOCS_GERAISbindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpArquivosDocsGerais;
        private System.Windows.Forms.DataGridView dgvArquivosDosGerais;
        private SISCONPROJECTSDataSet sISCONPROJECTSDataSet;
        private System.Windows.Forms.BindingSource aRQUIVOS_DOCS_GERAISBindingSource;
        private SISCONPROJECTSDataSetTableAdapters.ARQUIVOS_DOCS_GERAISTableAdapter aRQUIVOS_DOCS_GERAISTableAdapter;
        private SISCONPROJECTSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox gbArquivosDocsGerais;
        private System.Windows.Forms.BindingNavigator aRQUIVOS_DOCS_GERAISbindingNavigator;
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
        private System.Windows.Forms.Label lblNomePesquisa;
        private System.Windows.Forms.TextBox nomeDocGeralTextBox;
        private System.Windows.Forms.TextBox txtPesquisaNomeArquivoDocsGerais;
        private System.Windows.Forms.TableLayoutPanel tlpAcoesGeraisDocsGerais;
        private System.Windows.Forms.TableLayoutPanel tlpAcoesBotoesDocsGerais;
        private System.Windows.Forms.Button btnAbrirArquivoDocsGerais;
        private System.Windows.Forms.Button btnSalvarArquivoDocsGerais;
        private System.Windows.Forms.Button btnApagaArquivoDocsGerais;
        private System.Windows.Forms.Button btnPesquisarArquivosDocsGerais;
    }
}