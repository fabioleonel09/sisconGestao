namespace sisconGestão
{
    partial class frmArquivosEvidencias
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
            System.Windows.Forms.Label nomeEvidenciaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArquivosEvidencias));
            this.tlpArquivosEvidencias = new System.Windows.Forms.TableLayoutPanel();
            this.gbArquivosEvidencias = new System.Windows.Forms.GroupBox();
            this.aRQUIVOS_EVIDENCIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISCONPROJECTSDataSet = new sisconGestão.SISCONPROJECTSDataSet();
            this.lblNomePesquisa = new System.Windows.Forms.Label();
            this.nomeEvidenciaTextBox = new System.Windows.Forms.TextBox();
            this.txtPesquisaNomeArquivoEvidencias = new System.Windows.Forms.TextBox();
            this.tlpAcoesGeraisEvidencias = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAcoesBotoesEvidencias = new System.Windows.Forms.TableLayoutPanel();
            this.btnAbrirArquivoEvidencias = new System.Windows.Forms.Button();
            this.btnSalvarArquivoEvidencias = new System.Windows.Forms.Button();
            this.btnApagaArquivoEvidencias = new System.Windows.Forms.Button();
            this.btnPesquisarArquivosEvidencias = new System.Windows.Forms.Button();
            this.dgvArquivosEvidencias = new System.Windows.Forms.DataGridView();
            this.aRQUIVOS_EVIDENCIASTableAdapter = new sisconGestão.SISCONPROJECTSDataSetTableAdapters.ARQUIVOS_EVIDENCIASTableAdapter();
            this.tableAdapterManager = new sisconGestão.SISCONPROJECTSDataSetTableAdapters.TableAdapterManager();
            this.aRQUIVOS_EVIDENCIASbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            nomeEvidenciaLabel = new System.Windows.Forms.Label();
            this.tlpArquivosEvidencias.SuspendLayout();
            this.gbArquivosEvidencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aRQUIVOS_EVIDENCIASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONPROJECTSDataSet)).BeginInit();
            this.tlpAcoesGeraisEvidencias.SuspendLayout();
            this.tlpAcoesBotoesEvidencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivosEvidencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRQUIVOS_EVIDENCIASbindingNavigator)).BeginInit();
            this.aRQUIVOS_EVIDENCIASbindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeEvidenciaLabel
            // 
            nomeEvidenciaLabel.AutoSize = true;
            nomeEvidenciaLabel.Enabled = false;
            nomeEvidenciaLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeEvidenciaLabel.Location = new System.Drawing.Point(8, 22);
            nomeEvidenciaLabel.Name = "nomeEvidenciaLabel";
            nomeEvidenciaLabel.Size = new System.Drawing.Size(139, 19);
            nomeEvidenciaLabel.TabIndex = 5;
            nomeEvidenciaLabel.Text = "Nome Evidencia:";
            // 
            // tlpArquivosEvidencias
            // 
            this.tlpArquivosEvidencias.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpArquivosEvidencias.ColumnCount = 1;
            this.tlpArquivosEvidencias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpArquivosEvidencias.Controls.Add(this.gbArquivosEvidencias, 0, 1);
            this.tlpArquivosEvidencias.Controls.Add(this.dgvArquivosEvidencias, 0, 0);
            this.tlpArquivosEvidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpArquivosEvidencias.Location = new System.Drawing.Point(0, 0);
            this.tlpArquivosEvidencias.Name = "tlpArquivosEvidencias";
            this.tlpArquivosEvidencias.RowCount = 2;
            this.tlpArquivosEvidencias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.99029F));
            this.tlpArquivosEvidencias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.00971F));
            this.tlpArquivosEvidencias.Size = new System.Drawing.Size(453, 516);
            this.tlpArquivosEvidencias.TabIndex = 1;
            // 
            // gbArquivosEvidencias
            // 
            this.gbArquivosEvidencias.Controls.Add(this.aRQUIVOS_EVIDENCIASbindingNavigator);
            this.gbArquivosEvidencias.Controls.Add(this.lblNomePesquisa);
            this.gbArquivosEvidencias.Controls.Add(nomeEvidenciaLabel);
            this.gbArquivosEvidencias.Controls.Add(this.nomeEvidenciaTextBox);
            this.gbArquivosEvidencias.Controls.Add(this.txtPesquisaNomeArquivoEvidencias);
            this.gbArquivosEvidencias.Controls.Add(this.tlpAcoesGeraisEvidencias);
            this.gbArquivosEvidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbArquivosEvidencias.Location = new System.Drawing.Point(4, 246);
            this.gbArquivosEvidencias.Name = "gbArquivosEvidencias";
            this.gbArquivosEvidencias.Size = new System.Drawing.Size(445, 266);
            this.gbArquivosEvidencias.TabIndex = 0;
            this.gbArquivosEvidencias.TabStop = false;
            this.gbArquivosEvidencias.Text = "Ações";
            // 
            // aRQUIVOS_EVIDENCIASBindingSource
            // 
            this.aRQUIVOS_EVIDENCIASBindingSource.DataMember = "ARQUIVOS_EVIDENCIAS";
            this.aRQUIVOS_EVIDENCIASBindingSource.DataSource = this.sISCONPROJECTSDataSet;
            // 
            // sISCONPROJECTSDataSet
            // 
            this.sISCONPROJECTSDataSet.DataSetName = "SISCONPROJECTSDataSet";
            this.sISCONPROJECTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblNomePesquisa
            // 
            this.lblNomePesquisa.AutoSize = true;
            this.lblNomePesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePesquisa.Location = new System.Drawing.Point(8, 77);
            this.lblNomePesquisa.Name = "lblNomePesquisa";
            this.lblNomePesquisa.Size = new System.Drawing.Size(173, 19);
            this.lblNomePesquisa.TabIndex = 8;
            this.lblNomePesquisa.Text = "Nome para Pesquisa:";
            // 
            // nomeEvidenciaTextBox
            // 
            this.nomeEvidenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRQUIVOS_EVIDENCIASBindingSource, "NomeEvidencia", true));
            this.nomeEvidenciaTextBox.Enabled = false;
            this.nomeEvidenciaTextBox.Location = new System.Drawing.Point(11, 43);
            this.nomeEvidenciaTextBox.Name = "nomeEvidenciaTextBox";
            this.nomeEvidenciaTextBox.Size = new System.Drawing.Size(185, 26);
            this.nomeEvidenciaTextBox.TabIndex = 6;
            // 
            // txtPesquisaNomeArquivoEvidencias
            // 
            this.txtPesquisaNomeArquivoEvidencias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisaNomeArquivoEvidencias.Enabled = false;
            this.txtPesquisaNomeArquivoEvidencias.Location = new System.Drawing.Point(11, 99);
            this.txtPesquisaNomeArquivoEvidencias.Name = "txtPesquisaNomeArquivoEvidencias";
            this.txtPesquisaNomeArquivoEvidencias.Size = new System.Drawing.Size(422, 26);
            this.txtPesquisaNomeArquivoEvidencias.TabIndex = 3;
            // 
            // tlpAcoesGeraisEvidencias
            // 
            this.tlpAcoesGeraisEvidencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAcoesGeraisEvidencias.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpAcoesGeraisEvidencias.ColumnCount = 1;
            this.tlpAcoesGeraisEvidencias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAcoesGeraisEvidencias.Controls.Add(this.tlpAcoesBotoesEvidencias, 0, 0);
            this.tlpAcoesGeraisEvidencias.Location = new System.Drawing.Point(3, 131);
            this.tlpAcoesGeraisEvidencias.Name = "tlpAcoesGeraisEvidencias";
            this.tlpAcoesGeraisEvidencias.RowCount = 1;
            this.tlpAcoesGeraisEvidencias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpAcoesGeraisEvidencias.Size = new System.Drawing.Size(439, 132);
            this.tlpAcoesGeraisEvidencias.TabIndex = 0;
            // 
            // tlpAcoesBotoesEvidencias
            // 
            this.tlpAcoesBotoesEvidencias.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpAcoesBotoesEvidencias.ColumnCount = 2;
            this.tlpAcoesBotoesEvidencias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAcoesBotoesEvidencias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAcoesBotoesEvidencias.Controls.Add(this.btnAbrirArquivoEvidencias, 1, 1);
            this.tlpAcoesBotoesEvidencias.Controls.Add(this.btnSalvarArquivoEvidencias, 0, 1);
            this.tlpAcoesBotoesEvidencias.Controls.Add(this.btnApagaArquivoEvidencias, 1, 0);
            this.tlpAcoesBotoesEvidencias.Controls.Add(this.btnPesquisarArquivosEvidencias, 0, 0);
            this.tlpAcoesBotoesEvidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAcoesBotoesEvidencias.Location = new System.Drawing.Point(4, 4);
            this.tlpAcoesBotoesEvidencias.Name = "tlpAcoesBotoesEvidencias";
            this.tlpAcoesBotoesEvidencias.RowCount = 2;
            this.tlpAcoesBotoesEvidencias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAcoesBotoesEvidencias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAcoesBotoesEvidencias.Size = new System.Drawing.Size(431, 124);
            this.tlpAcoesBotoesEvidencias.TabIndex = 3;
            // 
            // btnAbrirArquivoEvidencias
            // 
            this.btnAbrirArquivoEvidencias.BackColor = System.Drawing.SystemColors.Info;
            this.btnAbrirArquivoEvidencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirArquivoEvidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbrirArquivoEvidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirArquivoEvidencias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirArquivoEvidencias.Image = global::sisconGestão.Properties.Resources.DocumentosEvidencias;
            this.btnAbrirArquivoEvidencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirArquivoEvidencias.Location = new System.Drawing.Point(219, 65);
            this.btnAbrirArquivoEvidencias.Name = "btnAbrirArquivoEvidencias";
            this.btnAbrirArquivoEvidencias.Size = new System.Drawing.Size(208, 55);
            this.btnAbrirArquivoEvidencias.TabIndex = 6;
            this.btnAbrirArquivoEvidencias.Text = "Abrir";
            this.btnAbrirArquivoEvidencias.UseVisualStyleBackColor = false;
            this.btnAbrirArquivoEvidencias.Click += new System.EventHandler(this.btnAbrirArquivoEvidencias_Click);
            // 
            // btnSalvarArquivoEvidencias
            // 
            this.btnSalvarArquivoEvidencias.BackColor = System.Drawing.Color.Honeydew;
            this.btnSalvarArquivoEvidencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarArquivoEvidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalvarArquivoEvidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarArquivoEvidencias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarArquivoEvidencias.Image = global::sisconGestão.Properties.Resources.SalvaDocumentosEvidencias;
            this.btnSalvarArquivoEvidencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarArquivoEvidencias.Location = new System.Drawing.Point(4, 65);
            this.btnSalvarArquivoEvidencias.Name = "btnSalvarArquivoEvidencias";
            this.btnSalvarArquivoEvidencias.Size = new System.Drawing.Size(208, 55);
            this.btnSalvarArquivoEvidencias.TabIndex = 5;
            this.btnSalvarArquivoEvidencias.Text = "Salvar";
            this.btnSalvarArquivoEvidencias.UseVisualStyleBackColor = false;
            this.btnSalvarArquivoEvidencias.Click += new System.EventHandler(this.btnSalvarArquivoEvidencias_Click);
            // 
            // btnApagaArquivoEvidencias
            // 
            this.btnApagaArquivoEvidencias.BackColor = System.Drawing.Color.MistyRose;
            this.btnApagaArquivoEvidencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagaArquivoEvidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApagaArquivoEvidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagaArquivoEvidencias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagaArquivoEvidencias.Image = global::sisconGestão.Properties.Resources.ApagaDocumentoEvidencia;
            this.btnApagaArquivoEvidencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagaArquivoEvidencias.Location = new System.Drawing.Point(219, 4);
            this.btnApagaArquivoEvidencias.Name = "btnApagaArquivoEvidencias";
            this.btnApagaArquivoEvidencias.Size = new System.Drawing.Size(208, 54);
            this.btnApagaArquivoEvidencias.TabIndex = 4;
            this.btnApagaArquivoEvidencias.Text = "Limpar";
            this.btnApagaArquivoEvidencias.UseVisualStyleBackColor = false;
            this.btnApagaArquivoEvidencias.Click += new System.EventHandler(this.btnApagaArquivoEvidencias_Click);
            // 
            // btnPesquisarArquivosEvidencias
            // 
            this.btnPesquisarArquivosEvidencias.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPesquisarArquivosEvidencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarArquivosEvidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisarArquivosEvidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarArquivosEvidencias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarArquivosEvidencias.Image = global::sisconGestão.Properties.Resources.buscarusuario;
            this.btnPesquisarArquivosEvidencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarArquivosEvidencias.Location = new System.Drawing.Point(4, 4);
            this.btnPesquisarArquivosEvidencias.Name = "btnPesquisarArquivosEvidencias";
            this.btnPesquisarArquivosEvidencias.Size = new System.Drawing.Size(208, 54);
            this.btnPesquisarArquivosEvidencias.TabIndex = 0;
            this.btnPesquisarArquivosEvidencias.Text = "Pesquisar";
            this.btnPesquisarArquivosEvidencias.UseVisualStyleBackColor = false;
            this.btnPesquisarArquivosEvidencias.Click += new System.EventHandler(this.btnPesquisarArquivosEvidencias_Click);
            // 
            // dgvArquivosEvidencias
            // 
            this.dgvArquivosEvidencias.AllowUserToAddRows = false;
            this.dgvArquivosEvidencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvArquivosEvidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArquivosEvidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArquivosEvidencias.Location = new System.Drawing.Point(4, 4);
            this.dgvArquivosEvidencias.Name = "dgvArquivosEvidencias";
            this.dgvArquivosEvidencias.ReadOnly = true;
            this.dgvArquivosEvidencias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvArquivosEvidencias.Size = new System.Drawing.Size(445, 235);
            this.dgvArquivosEvidencias.TabIndex = 1;
            // 
            // aRQUIVOS_EVIDENCIASTableAdapter
            // 
            this.aRQUIVOS_EVIDENCIASTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ARQUIVOS_DOCS_GERAISTableAdapter = null;
            this.tableAdapterManager.ARQUIVOS_EVIDENCIASTableAdapter = this.aRQUIVOS_EVIDENCIASTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DOCUMENTOS_GERAISTableAdapter = null;
            this.tableAdapterManager.EVIDENCIASTableAdapter = null;
            this.tableAdapterManager.LANCAMENTO_HORARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sisconGestão.SISCONPROJECTSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOS_SENHASTableAdapter = null;
            // 
            // aRQUIVOS_EVIDENCIASbindingNavigator
            // 
            this.aRQUIVOS_EVIDENCIASbindingNavigator.AddNewItem = null;
            this.aRQUIVOS_EVIDENCIASbindingNavigator.BindingSource = this.aRQUIVOS_EVIDENCIASBindingSource;
            this.aRQUIVOS_EVIDENCIASbindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aRQUIVOS_EVIDENCIASbindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aRQUIVOS_EVIDENCIASbindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.aRQUIVOS_EVIDENCIASbindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.aRQUIVOS_EVIDENCIASbindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aRQUIVOS_EVIDENCIASbindingNavigator.Location = new System.Drawing.Point(204, 43);
            this.aRQUIVOS_EVIDENCIASbindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aRQUIVOS_EVIDENCIASbindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aRQUIVOS_EVIDENCIASbindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aRQUIVOS_EVIDENCIASbindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aRQUIVOS_EVIDENCIASbindingNavigator.Name = "aRQUIVOS_EVIDENCIASbindingNavigator";
            this.aRQUIVOS_EVIDENCIASbindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aRQUIVOS_EVIDENCIASbindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.aRQUIVOS_EVIDENCIASbindingNavigator.Size = new System.Drawing.Size(268, 26);
            this.aRQUIVOS_EVIDENCIASbindingNavigator.TabIndex = 9;
            this.aRQUIVOS_EVIDENCIASbindingNavigator.Text = "bindingNavigator1";
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
            // frmArquivosEvidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 516);
            this.Controls.Add(this.tlpArquivosEvidencias);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmArquivosEvidencias";
            this.Text = "Evidências - Janela de Arquivos";
            this.Load += new System.EventHandler(this.frmArquivosEvidencias_Load);
            this.tlpArquivosEvidencias.ResumeLayout(false);
            this.gbArquivosEvidencias.ResumeLayout(false);
            this.gbArquivosEvidencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aRQUIVOS_EVIDENCIASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONPROJECTSDataSet)).EndInit();
            this.tlpAcoesGeraisEvidencias.ResumeLayout(false);
            this.tlpAcoesBotoesEvidencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivosEvidencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRQUIVOS_EVIDENCIASbindingNavigator)).EndInit();
            this.aRQUIVOS_EVIDENCIASbindingNavigator.ResumeLayout(false);
            this.aRQUIVOS_EVIDENCIASbindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpArquivosEvidencias;
        private System.Windows.Forms.GroupBox gbArquivosEvidencias;
        private System.Windows.Forms.TextBox txtPesquisaNomeArquivoEvidencias;
        private System.Windows.Forms.TableLayoutPanel tlpAcoesGeraisEvidencias;
        private System.Windows.Forms.TableLayoutPanel tlpAcoesBotoesEvidencias;
        private System.Windows.Forms.Button btnAbrirArquivoEvidencias;
        private System.Windows.Forms.Button btnSalvarArquivoEvidencias;
        private System.Windows.Forms.Button btnApagaArquivoEvidencias;
        private System.Windows.Forms.Button btnPesquisarArquivosEvidencias;
        private System.Windows.Forms.DataGridView dgvArquivosEvidencias;
        private SISCONPROJECTSDataSet sISCONPROJECTSDataSet;
        private System.Windows.Forms.BindingSource aRQUIVOS_EVIDENCIASBindingSource;
        private SISCONPROJECTSDataSetTableAdapters.ARQUIVOS_EVIDENCIASTableAdapter aRQUIVOS_EVIDENCIASTableAdapter;
        private SISCONPROJECTSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nomeEvidenciaTextBox;
        private System.Windows.Forms.Label lblNomePesquisa;
        private System.Windows.Forms.BindingNavigator aRQUIVOS_EVIDENCIASbindingNavigator;
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
    }
}