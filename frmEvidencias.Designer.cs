﻿namespace sisconGestão
{
    partial class frmEvidencias
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
            System.Windows.Forms.Label evidenciasIdLabel;
            System.Windows.Forms.Label nomeEvidenciaLabel;
            System.Windows.Forms.Label descricaoEvidenciaLabel;
            System.Windows.Forms.Label desenvolvedorEvidenciaLabel;
            System.Windows.Forms.Label dataInclusaoLabel;
            System.Windows.Forms.Label tipoDocumentoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvidencias));
            this.tlpEvidencias = new System.Windows.Forms.TableLayoutPanel();
            this.gbPesquisaEvidencia = new System.Windows.Forms.GroupBox();
            this.mkdtxtPesquisaData = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisarEvidencias = new System.Windows.Forms.Button();
            this.rbPesquisaData = new System.Windows.Forms.RadioButton();
            this.rbPesquisaTipo = new System.Windows.Forms.RadioButton();
            this.rbPesquisaNome = new System.Windows.Forms.RadioButton();
            this.txtPesquisaEvidencia = new System.Windows.Forms.TextBox();
            this.eVIDENCIASBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.eVIDENCIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISCONPROJECTSDataSet = new sisconGestão.SISCONPROJECTSDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eVIDENCIASBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbBloquear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEnviar = new System.Windows.Forms.ToolStripButton();
            this.tsbBaixar = new System.Windows.Forms.ToolStripButton();
            this.tbEvidencias = new System.Windows.Forms.TabControl();
            this.tpCapaEvidencia = new System.Windows.Forms.TabPage();
            this.tipoDocumentoComboBox = new System.Windows.Forms.ComboBox();
            this.evidenciasIdTextBox = new System.Windows.Forms.TextBox();
            this.nomeEvidenciaTextBox = new System.Windows.Forms.TextBox();
            this.descricaoEvidenciaTextBox = new System.Windows.Forms.TextBox();
            this.desenvolvedorEvidenciaTextBox = new System.Windows.Forms.TextBox();
            this.dataInclusaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tpDetalhesEvidencia = new System.Windows.Forms.TabPage();
            this.eVIDENCIASDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVIDENCIASTableAdapter = new sisconGestão.SISCONPROJECTSDataSetTableAdapters.EVIDENCIASTableAdapter();
            this.tableAdapterManager = new sisconGestão.SISCONPROJECTSDataSetTableAdapters.TableAdapterManager();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            evidenciasIdLabel = new System.Windows.Forms.Label();
            nomeEvidenciaLabel = new System.Windows.Forms.Label();
            descricaoEvidenciaLabel = new System.Windows.Forms.Label();
            desenvolvedorEvidenciaLabel = new System.Windows.Forms.Label();
            dataInclusaoLabel = new System.Windows.Forms.Label();
            tipoDocumentoLabel = new System.Windows.Forms.Label();
            this.tlpEvidencias.SuspendLayout();
            this.gbPesquisaEvidencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eVIDENCIASBindingNavigator)).BeginInit();
            this.eVIDENCIASBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eVIDENCIASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONPROJECTSDataSet)).BeginInit();
            this.tbEvidencias.SuspendLayout();
            this.tpCapaEvidencia.SuspendLayout();
            this.tpDetalhesEvidencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eVIDENCIASDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // evidenciasIdLabel
            // 
            evidenciasIdLabel.AutoSize = true;
            evidenciasIdLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            evidenciasIdLabel.Location = new System.Drawing.Point(6, 3);
            evidenciasIdLabel.Name = "evidenciasIdLabel";
            evidenciasIdLabel.Size = new System.Drawing.Size(136, 19);
            evidenciasIdLabel.TabIndex = 0;
            evidenciasIdLabel.Text = "Ident. Evidência:";
            // 
            // nomeEvidenciaLabel
            // 
            nomeEvidenciaLabel.AutoSize = true;
            nomeEvidenciaLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeEvidenciaLabel.Location = new System.Drawing.Point(153, 3);
            nomeEvidenciaLabel.Name = "nomeEvidenciaLabel";
            nomeEvidenciaLabel.Size = new System.Drawing.Size(139, 19);
            nomeEvidenciaLabel.TabIndex = 2;
            nomeEvidenciaLabel.Text = "Nome Evidência:";
            // 
            // descricaoEvidenciaLabel
            // 
            descricaoEvidenciaLabel.AutoSize = true;
            descricaoEvidenciaLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoEvidenciaLabel.Location = new System.Drawing.Point(6, 104);
            descricaoEvidenciaLabel.Name = "descricaoEvidenciaLabel";
            descricaoEvidenciaLabel.Size = new System.Drawing.Size(171, 19);
            descricaoEvidenciaLabel.TabIndex = 4;
            descricaoEvidenciaLabel.Text = "Descrição Evidência:";
            // 
            // desenvolvedorEvidenciaLabel
            // 
            desenvolvedorEvidenciaLabel.AutoSize = true;
            desenvolvedorEvidenciaLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            desenvolvedorEvidenciaLabel.Location = new System.Drawing.Point(7, 53);
            desenvolvedorEvidenciaLabel.Name = "desenvolvedorEvidenciaLabel";
            desenvolvedorEvidenciaLabel.Size = new System.Drawing.Size(210, 19);
            desenvolvedorEvidenciaLabel.TabIndex = 6;
            desenvolvedorEvidenciaLabel.Text = "Desenvolvedor Evidência:";
            // 
            // dataInclusaoLabel
            // 
            dataInclusaoLabel.AutoSize = true;
            dataInclusaoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataInclusaoLabel.Location = new System.Drawing.Point(710, 3);
            dataInclusaoLabel.Name = "dataInclusaoLabel";
            dataInclusaoLabel.Size = new System.Drawing.Size(119, 19);
            dataInclusaoLabel.TabIndex = 8;
            dataInclusaoLabel.Text = "Data Inclusão:";
            // 
            // tipoDocumentoLabel
            // 
            tipoDocumentoLabel.AutoSize = true;
            tipoDocumentoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoDocumentoLabel.Location = new System.Drawing.Point(566, 3);
            tipoDocumentoLabel.Name = "tipoDocumentoLabel";
            tipoDocumentoLabel.Size = new System.Drawing.Size(142, 19);
            tipoDocumentoLabel.TabIndex = 12;
            tipoDocumentoLabel.Text = "Tipo Documento:";
            // 
            // tlpEvidencias
            // 
            this.tlpEvidencias.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpEvidencias.ColumnCount = 1;
            this.tlpEvidencias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEvidencias.Controls.Add(this.gbPesquisaEvidencia, 0, 0);
            this.tlpEvidencias.Controls.Add(this.eVIDENCIASBindingNavigator, 0, 2);
            this.tlpEvidencias.Controls.Add(this.tbEvidencias, 0, 1);
            this.tlpEvidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEvidencias.Location = new System.Drawing.Point(0, 0);
            this.tlpEvidencias.Name = "tlpEvidencias";
            this.tlpEvidencias.RowCount = 3;
            this.tlpEvidencias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpEvidencias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpEvidencias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpEvidencias.Size = new System.Drawing.Size(875, 465);
            this.tlpEvidencias.TabIndex = 0;
            // 
            // gbPesquisaEvidencia
            // 
            this.gbPesquisaEvidencia.Controls.Add(this.mkdtxtPesquisaData);
            this.gbPesquisaEvidencia.Controls.Add(this.btnPesquisarEvidencias);
            this.gbPesquisaEvidencia.Controls.Add(this.rbPesquisaData);
            this.gbPesquisaEvidencia.Controls.Add(this.rbPesquisaTipo);
            this.gbPesquisaEvidencia.Controls.Add(this.rbPesquisaNome);
            this.gbPesquisaEvidencia.Controls.Add(this.txtPesquisaEvidencia);
            this.gbPesquisaEvidencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPesquisaEvidencia.Location = new System.Drawing.Point(4, 4);
            this.gbPesquisaEvidencia.Name = "gbPesquisaEvidencia";
            this.gbPesquisaEvidencia.Size = new System.Drawing.Size(867, 86);
            this.gbPesquisaEvidencia.TabIndex = 3;
            this.gbPesquisaEvidencia.TabStop = false;
            this.gbPesquisaEvidencia.Text = "Para realizar a pesquisa";
            // 
            // mkdtxtPesquisaData
            // 
            this.mkdtxtPesquisaData.Location = new System.Drawing.Point(320, 37);
            this.mkdtxtPesquisaData.Mask = "00/00/0000";
            this.mkdtxtPesquisaData.Name = "mkdtxtPesquisaData";
            this.mkdtxtPesquisaData.Size = new System.Drawing.Size(100, 26);
            this.mkdtxtPesquisaData.TabIndex = 10;
            this.mkdtxtPesquisaData.ValidatingType = typeof(System.DateTime);
            // 
            // btnPesquisarEvidencias
            // 
            this.btnPesquisarEvidencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarEvidencias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarEvidencias.Location = new System.Drawing.Point(747, 22);
            this.btnPesquisarEvidencias.Name = "btnPesquisarEvidencias";
            this.btnPesquisarEvidencias.Size = new System.Drawing.Size(114, 55);
            this.btnPesquisarEvidencias.TabIndex = 9;
            this.btnPesquisarEvidencias.Text = "Pesquisar";
            this.btnPesquisarEvidencias.UseVisualStyleBackColor = true;
            this.btnPesquisarEvidencias.Click += new System.EventHandler(this.btnPesquisarEvidencias_Click);
            // 
            // rbPesquisaData
            // 
            this.rbPesquisaData.AutoSize = true;
            this.rbPesquisaData.Location = new System.Drawing.Point(230, 38);
            this.rbPesquisaData.Name = "rbPesquisaData";
            this.rbPesquisaData.Size = new System.Drawing.Size(84, 22);
            this.rbPesquisaData.TabIndex = 8;
            this.rbPesquisaData.TabStop = true;
            this.rbPesquisaData.Text = "por data";
            this.rbPesquisaData.UseVisualStyleBackColor = true;
            this.rbPesquisaData.CheckedChanged += new System.EventHandler(this.rbPesquisaData_CheckedChanged);
            // 
            // rbPesquisaTipo
            // 
            this.rbPesquisaTipo.AutoSize = true;
            this.rbPesquisaTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPesquisaTipo.Location = new System.Drawing.Point(127, 38);
            this.rbPesquisaTipo.Name = "rbPesquisaTipo";
            this.rbPesquisaTipo.Size = new System.Drawing.Size(79, 22);
            this.rbPesquisaTipo.TabIndex = 7;
            this.rbPesquisaTipo.TabStop = true;
            this.rbPesquisaTipo.Text = "por tipo";
            this.rbPesquisaTipo.UseVisualStyleBackColor = true;
            this.rbPesquisaTipo.CheckedChanged += new System.EventHandler(this.rbPesquisaTipo_CheckedChanged);
            // 
            // rbPesquisaNome
            // 
            this.rbPesquisaNome.AutoSize = true;
            this.rbPesquisaNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPesquisaNome.Location = new System.Drawing.Point(6, 38);
            this.rbPesquisaNome.Name = "rbPesquisaNome";
            this.rbPesquisaNome.Size = new System.Drawing.Size(92, 22);
            this.rbPesquisaNome.TabIndex = 6;
            this.rbPesquisaNome.TabStop = true;
            this.rbPesquisaNome.Text = "por nome";
            this.rbPesquisaNome.UseVisualStyleBackColor = true;
            this.rbPesquisaNome.CheckedChanged += new System.EventHandler(this.rbPesquisaNome_CheckedChanged);
            // 
            // txtPesquisaEvidencia
            // 
            this.txtPesquisaEvidencia.Location = new System.Drawing.Point(426, 37);
            this.txtPesquisaEvidencia.Name = "txtPesquisaEvidencia";
            this.txtPesquisaEvidencia.Size = new System.Drawing.Size(315, 26);
            this.txtPesquisaEvidencia.TabIndex = 0;
            // 
            // eVIDENCIASBindingNavigator
            // 
            this.eVIDENCIASBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eVIDENCIASBindingNavigator.BindingSource = this.eVIDENCIASBindingSource;
            this.eVIDENCIASBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eVIDENCIASBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eVIDENCIASBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eVIDENCIASBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.eVIDENCIASBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eVIDENCIASBindingNavigatorSaveItem,
            this.bindingNavigatorDeleteItem,
            this.tsbEditar,
            this.tsbBloquear,
            this.toolStripSeparator1,
            this.tsbEnviar,
            this.tsbBaixar});
            this.eVIDENCIASBindingNavigator.Location = new System.Drawing.Point(1, 371);
            this.eVIDENCIASBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eVIDENCIASBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eVIDENCIASBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eVIDENCIASBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eVIDENCIASBindingNavigator.Name = "eVIDENCIASBindingNavigator";
            this.eVIDENCIASBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eVIDENCIASBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.eVIDENCIASBindingNavigator.Size = new System.Drawing.Size(873, 93);
            this.eVIDENCIASBindingNavigator.TabIndex = 1;
            this.eVIDENCIASBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(52, 90);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // eVIDENCIASBindingSource
            // 
            this.eVIDENCIASBindingSource.DataMember = "EVIDENCIAS";
            this.eVIDENCIASBindingSource.DataSource = this.sISCONPROJECTSDataSet;
            // 
            // sISCONPROJECTSDataSet
            // 
            this.sISCONPROJECTSDataSet.DataSetName = "SISCONPROJECTSDataSet";
            this.sISCONPROJECTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 90);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(52, 90);
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
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(52, 90);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(52, 90);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 93);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 93);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(52, 90);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(52, 90);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 93);
            // 
            // eVIDENCIASBindingNavigatorSaveItem
            // 
            this.eVIDENCIASBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eVIDENCIASBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eVIDENCIASBindingNavigatorSaveItem.Image")));
            this.eVIDENCIASBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eVIDENCIASBindingNavigatorSaveItem.Name = "eVIDENCIASBindingNavigatorSaveItem";
            this.eVIDENCIASBindingNavigatorSaveItem.Size = new System.Drawing.Size(52, 90);
            this.eVIDENCIASBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.eVIDENCIASBindingNavigatorSaveItem.Click += new System.EventHandler(this.eVIDENCIASBindingNavigatorSaveItem_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(52, 90);
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
            this.tsbBloquear.Size = new System.Drawing.Size(52, 90);
            this.tsbBloquear.Text = "Bloquear";
            this.tsbBloquear.Click += new System.EventHandler(this.tsbBloquear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 93);
            // 
            // tsbEnviar
            // 
            this.tsbEnviar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEnviar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEnviar.Image")));
            this.tsbEnviar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEnviar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEnviar.Name = "tsbEnviar";
            this.tsbEnviar.Size = new System.Drawing.Size(52, 90);
            this.tsbEnviar.Text = "Enviar";
            this.tsbEnviar.Click += new System.EventHandler(this.tsbEnviar_Click);
            // 
            // tsbBaixar
            // 
            this.tsbBaixar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBaixar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBaixar.Image")));
            this.tsbBaixar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBaixar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBaixar.Name = "tsbBaixar";
            this.tsbBaixar.Size = new System.Drawing.Size(52, 90);
            this.tsbBaixar.Text = "Baixar";
            this.tsbBaixar.Click += new System.EventHandler(this.tsbBaixar_Click);
            // 
            // tbEvidencias
            // 
            this.tbEvidencias.Controls.Add(this.tpCapaEvidencia);
            this.tbEvidencias.Controls.Add(this.tpDetalhesEvidencia);
            this.tbEvidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEvidencias.Location = new System.Drawing.Point(4, 97);
            this.tbEvidencias.Name = "tbEvidencias";
            this.tbEvidencias.SelectedIndex = 0;
            this.tbEvidencias.Size = new System.Drawing.Size(867, 270);
            this.tbEvidencias.TabIndex = 0;
            // 
            // tpCapaEvidencia
            // 
            this.tpCapaEvidencia.AutoScroll = true;
            this.tpCapaEvidencia.Controls.Add(tipoDocumentoLabel);
            this.tpCapaEvidencia.Controls.Add(this.tipoDocumentoComboBox);
            this.tpCapaEvidencia.Controls.Add(evidenciasIdLabel);
            this.tpCapaEvidencia.Controls.Add(this.evidenciasIdTextBox);
            this.tpCapaEvidencia.Controls.Add(nomeEvidenciaLabel);
            this.tpCapaEvidencia.Controls.Add(this.nomeEvidenciaTextBox);
            this.tpCapaEvidencia.Controls.Add(descricaoEvidenciaLabel);
            this.tpCapaEvidencia.Controls.Add(this.descricaoEvidenciaTextBox);
            this.tpCapaEvidencia.Controls.Add(desenvolvedorEvidenciaLabel);
            this.tpCapaEvidencia.Controls.Add(this.desenvolvedorEvidenciaTextBox);
            this.tpCapaEvidencia.Controls.Add(dataInclusaoLabel);
            this.tpCapaEvidencia.Controls.Add(this.dataInclusaoDateTimePicker);
            this.tpCapaEvidencia.Location = new System.Drawing.Point(4, 27);
            this.tpCapaEvidencia.Name = "tpCapaEvidencia";
            this.tpCapaEvidencia.Padding = new System.Windows.Forms.Padding(3);
            this.tpCapaEvidencia.Size = new System.Drawing.Size(859, 239);
            this.tpCapaEvidencia.TabIndex = 0;
            this.tpCapaEvidencia.Text = "Capa Evidência";
            this.tpCapaEvidencia.UseVisualStyleBackColor = true;
            // 
            // tipoDocumentoComboBox
            // 
            this.tipoDocumentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eVIDENCIASBindingSource, "TipoDocumento", true));
            this.tipoDocumentoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoDocumentoComboBox.FormattingEnabled = true;
            this.tipoDocumentoComboBox.Items.AddRange(new object[] {
            "",
            ".doc",
            ".ppt",
            ".xls",
            ".pdf",
            ".jpg",
            ".png",
            "Outro"});
            this.tipoDocumentoComboBox.Location = new System.Drawing.Point(570, 24);
            this.tipoDocumentoComboBox.Name = "tipoDocumentoComboBox";
            this.tipoDocumentoComboBox.Size = new System.Drawing.Size(138, 26);
            this.tipoDocumentoComboBox.TabIndex = 13;
            // 
            // evidenciasIdTextBox
            // 
            this.evidenciasIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eVIDENCIASBindingSource, "EvidenciasId", true));
            this.evidenciasIdTextBox.Location = new System.Drawing.Point(10, 24);
            this.evidenciasIdTextBox.Name = "evidenciasIdTextBox";
            this.evidenciasIdTextBox.Size = new System.Drawing.Size(141, 26);
            this.evidenciasIdTextBox.TabIndex = 1;
            // 
            // nomeEvidenciaTextBox
            // 
            this.nomeEvidenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eVIDENCIASBindingSource, "NomeEvidencia", true));
            this.nomeEvidenciaTextBox.Location = new System.Drawing.Point(157, 24);
            this.nomeEvidenciaTextBox.Name = "nomeEvidenciaTextBox";
            this.nomeEvidenciaTextBox.Size = new System.Drawing.Size(407, 26);
            this.nomeEvidenciaTextBox.TabIndex = 3;
            // 
            // descricaoEvidenciaTextBox
            // 
            this.descricaoEvidenciaTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.descricaoEvidenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eVIDENCIASBindingSource, "DescricaoEvidencia", true));
            this.descricaoEvidenciaTextBox.Location = new System.Drawing.Point(10, 126);
            this.descricaoEvidenciaTextBox.Multiline = true;
            this.descricaoEvidenciaTextBox.Name = "descricaoEvidenciaTextBox";
            this.descricaoEvidenciaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descricaoEvidenciaTextBox.Size = new System.Drawing.Size(843, 107);
            this.descricaoEvidenciaTextBox.TabIndex = 5;
            // 
            // desenvolvedorEvidenciaTextBox
            // 
            this.desenvolvedorEvidenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eVIDENCIASBindingSource, "DesenvolvedorEvidencia", true));
            this.desenvolvedorEvidenciaTextBox.Location = new System.Drawing.Point(10, 75);
            this.desenvolvedorEvidenciaTextBox.Name = "desenvolvedorEvidenciaTextBox";
            this.desenvolvedorEvidenciaTextBox.Size = new System.Drawing.Size(843, 26);
            this.desenvolvedorEvidenciaTextBox.TabIndex = 7;
            // 
            // dataInclusaoDateTimePicker
            // 
            this.dataInclusaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eVIDENCIASBindingSource, "DataInclusao", true));
            this.dataInclusaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInclusaoDateTimePicker.Location = new System.Drawing.Point(714, 24);
            this.dataInclusaoDateTimePicker.Name = "dataInclusaoDateTimePicker";
            this.dataInclusaoDateTimePicker.Size = new System.Drawing.Size(139, 26);
            this.dataInclusaoDateTimePicker.TabIndex = 9;
            // 
            // tpDetalhesEvidencia
            // 
            this.tpDetalhesEvidencia.AutoScroll = true;
            this.tpDetalhesEvidencia.Controls.Add(this.eVIDENCIASDataGridView);
            this.tpDetalhesEvidencia.Location = new System.Drawing.Point(4, 27);
            this.tpDetalhesEvidencia.Name = "tpDetalhesEvidencia";
            this.tpDetalhesEvidencia.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetalhesEvidencia.Size = new System.Drawing.Size(859, 239);
            this.tpDetalhesEvidencia.TabIndex = 1;
            this.tpDetalhesEvidencia.Text = "Detalhes Evidência";
            this.tpDetalhesEvidencia.UseVisualStyleBackColor = true;
            // 
            // eVIDENCIASDataGridView
            // 
            this.eVIDENCIASDataGridView.AllowUserToAddRows = false;
            this.eVIDENCIASDataGridView.AllowUserToDeleteRows = false;
            this.eVIDENCIASDataGridView.AutoGenerateColumns = false;
            this.eVIDENCIASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eVIDENCIASDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.TipoDocumento,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.eVIDENCIASDataGridView.DataSource = this.eVIDENCIASBindingSource;
            this.eVIDENCIASDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eVIDENCIASDataGridView.Location = new System.Drawing.Point(3, 3);
            this.eVIDENCIASDataGridView.Name = "eVIDENCIASDataGridView";
            this.eVIDENCIASDataGridView.ReadOnly = true;
            this.eVIDENCIASDataGridView.Size = new System.Drawing.Size(853, 233);
            this.eVIDENCIASDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EvidenciasId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Identificação Evidência";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 210;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeEvidencia";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Evidência";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 210;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "TipoDocumento";
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DescricaoEvidencia";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição Evidência";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 210;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DesenvolvedorEvidencia";
            this.dataGridViewTextBoxColumn4.HeaderText = "Incluído Por";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 210;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DataInclusao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data Inclusão";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // eVIDENCIASTableAdapter
            // 
            this.eVIDENCIASTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ARQUIVOS_DOCS_GERAISTableAdapter = null;
            this.tableAdapterManager.ARQUIVOS_EVIDENCIASTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DOCUMENTOS_GERAISTableAdapter = null;
            this.tableAdapterManager.EVIDENCIASTableAdapter = this.eVIDENCIASTableAdapter;
            this.tableAdapterManager.LANCAMENTO_HORARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sisconGestão.SISCONPROJECTSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOS_SENHASTableAdapter = null;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // frmEvidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 465);
            this.Controls.Add(this.tlpEvidencias);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEvidencias";
            this.Text = "SISCON PROJECTS - Documentos de Evidências - Cadastros";
            this.Load += new System.EventHandler(this.frmEvidencias_Load);
            this.tlpEvidencias.ResumeLayout(false);
            this.tlpEvidencias.PerformLayout();
            this.gbPesquisaEvidencia.ResumeLayout(false);
            this.gbPesquisaEvidencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eVIDENCIASBindingNavigator)).EndInit();
            this.eVIDENCIASBindingNavigator.ResumeLayout(false);
            this.eVIDENCIASBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eVIDENCIASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONPROJECTSDataSet)).EndInit();
            this.tbEvidencias.ResumeLayout(false);
            this.tpCapaEvidencia.ResumeLayout(false);
            this.tpCapaEvidencia.PerformLayout();
            this.tpDetalhesEvidencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eVIDENCIASDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEvidencias;
        private System.Windows.Forms.TabControl tbEvidencias;
        private System.Windows.Forms.TabPage tpCapaEvidencia;
        private System.Windows.Forms.TabPage tpDetalhesEvidencia;
        private SISCONPROJECTSDataSet sISCONPROJECTSDataSet;
        private System.Windows.Forms.BindingSource eVIDENCIASBindingSource;
        private SISCONPROJECTSDataSetTableAdapters.EVIDENCIASTableAdapter eVIDENCIASTableAdapter;
        private SISCONPROJECTSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eVIDENCIASBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eVIDENCIASBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView eVIDENCIASDataGridView;
        private System.Windows.Forms.TextBox evidenciasIdTextBox;
        private System.Windows.Forms.TextBox nomeEvidenciaTextBox;
        private System.Windows.Forms.TextBox descricaoEvidenciaTextBox;
        private System.Windows.Forms.TextBox desenvolvedorEvidenciaTextBox;
        private System.Windows.Forms.DateTimePicker dataInclusaoDateTimePicker;
        private System.Windows.Forms.GroupBox gbPesquisaEvidencia;
        private System.Windows.Forms.TextBox txtPesquisaEvidencia;
        private System.Windows.Forms.ComboBox tipoDocumentoComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnPesquisarEvidencias;
        private System.Windows.Forms.RadioButton rbPesquisaData;
        private System.Windows.Forms.RadioButton rbPesquisaTipo;
        private System.Windows.Forms.RadioButton rbPesquisaNome;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbBloquear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbEnviar;
        private System.Windows.Forms.ToolStripButton tsbBaixar;
        private System.Windows.Forms.MaskedTextBox mkdtxtPesquisaData;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}