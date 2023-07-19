namespace sisconGestão
{
    partial class frmDocumentosGerais
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
            System.Windows.Forms.Label documentosGeraisIdLabel;
            System.Windows.Forms.Label nomeDocumentoLabel;
            System.Windows.Forms.Label descricaoDocumentoLabel;
            System.Windows.Forms.Label dataInclusaoLabel;
            System.Windows.Forms.Label tipoDocumentoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentosGerais));
            this.tlpDocumentosGerais = new System.Windows.Forms.TableLayoutPanel();
            this.dOCUMENTOS_GERAISBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.dOCUMENTOS_GERAISBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.dOCUMENTOS_GERAISBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbBloquear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEnviar = new System.Windows.Forms.ToolStripButton();
            this.tsbBaixar = new System.Windows.Forms.ToolStripButton();
            this.tbDocumentosGerais = new System.Windows.Forms.TabControl();
            this.tpCapa = new System.Windows.Forms.TabPage();
            this.tipoDocumentoComboBox = new System.Windows.Forms.ComboBox();
            this.documentosGeraisIdTextBox = new System.Windows.Forms.TextBox();
            this.nomeDocumentoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoDocumentoTextBox = new System.Windows.Forms.TextBox();
            this.dataInclusaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tpDetalhes = new System.Windows.Forms.TabPage();
            this.dOCUMENTOS_GERAISDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArquivoSalvo = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbPesquisaDocumento = new System.Windows.Forms.GroupBox();
            this.mkdtxtPesquisaData = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisarDocsGerais = new System.Windows.Forms.Button();
            this.rbPesquisaData = new System.Windows.Forms.RadioButton();
            this.rbPesquisaTipo = new System.Windows.Forms.RadioButton();
            this.rbPesquisaNome = new System.Windows.Forms.RadioButton();
            this.txtPesquisaDocumento = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dOCUMENTOS_GERAISTableAdapter = new sisconGestão.SISCONPROJECTSDataSetTableAdapters.DOCUMENTOS_GERAISTableAdapter();
            this.tableAdapterManager = new sisconGestão.SISCONPROJECTSDataSetTableAdapters.TableAdapterManager();
            documentosGeraisIdLabel = new System.Windows.Forms.Label();
            nomeDocumentoLabel = new System.Windows.Forms.Label();
            descricaoDocumentoLabel = new System.Windows.Forms.Label();
            dataInclusaoLabel = new System.Windows.Forms.Label();
            tipoDocumentoLabel = new System.Windows.Forms.Label();
            this.tlpDocumentosGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCUMENTOS_GERAISBindingNavigator)).BeginInit();
            this.dOCUMENTOS_GERAISBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCUMENTOS_GERAISBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONPROJECTSDataSet)).BeginInit();
            this.tbDocumentosGerais.SuspendLayout();
            this.tpCapa.SuspendLayout();
            this.tpDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCUMENTOS_GERAISDataGridView)).BeginInit();
            this.gbPesquisaDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // documentosGeraisIdLabel
            // 
            documentosGeraisIdLabel.AutoSize = true;
            documentosGeraisIdLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            documentosGeraisIdLabel.Location = new System.Drawing.Point(6, 3);
            documentosGeraisIdLabel.Name = "documentosGeraisIdLabel";
            documentosGeraisIdLabel.Size = new System.Drawing.Size(158, 19);
            documentosGeraisIdLabel.TabIndex = 0;
            documentosGeraisIdLabel.Text = "Ident. Docs. Gerais:";
            // 
            // nomeDocumentoLabel
            // 
            nomeDocumentoLabel.AutoSize = true;
            nomeDocumentoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeDocumentoLabel.Location = new System.Drawing.Point(166, 3);
            nomeDocumentoLabel.Name = "nomeDocumentoLabel";
            nomeDocumentoLabel.Size = new System.Drawing.Size(153, 19);
            nomeDocumentoLabel.TabIndex = 2;
            nomeDocumentoLabel.Text = "Nome Documento:";
            // 
            // descricaoDocumentoLabel
            // 
            descricaoDocumentoLabel.AutoSize = true;
            descricaoDocumentoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoDocumentoLabel.Location = new System.Drawing.Point(7, 53);
            descricaoDocumentoLabel.Name = "descricaoDocumentoLabel";
            descricaoDocumentoLabel.Size = new System.Drawing.Size(185, 19);
            descricaoDocumentoLabel.TabIndex = 4;
            descricaoDocumentoLabel.Text = "Descrição Documento:";
            // 
            // dataInclusaoLabel
            // 
            dataInclusaoLabel.AutoSize = true;
            dataInclusaoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataInclusaoLabel.Location = new System.Drawing.Point(520, 4);
            dataInclusaoLabel.Name = "dataInclusaoLabel";
            dataInclusaoLabel.Size = new System.Drawing.Size(119, 19);
            dataInclusaoLabel.TabIndex = 6;
            dataInclusaoLabel.Text = "Data Inclusão:";
            // 
            // tipoDocumentoLabel
            // 
            tipoDocumentoLabel.AutoSize = true;
            tipoDocumentoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoDocumentoLabel.Location = new System.Drawing.Point(372, 3);
            tipoDocumentoLabel.Name = "tipoDocumentoLabel";
            tipoDocumentoLabel.Size = new System.Drawing.Size(142, 19);
            tipoDocumentoLabel.TabIndex = 10;
            tipoDocumentoLabel.Text = "Tipo Documento:";
            // 
            // tlpDocumentosGerais
            // 
            this.tlpDocumentosGerais.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpDocumentosGerais.ColumnCount = 1;
            this.tlpDocumentosGerais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDocumentosGerais.Controls.Add(this.dOCUMENTOS_GERAISBindingNavigator, 0, 2);
            this.tlpDocumentosGerais.Controls.Add(this.tbDocumentosGerais, 0, 1);
            this.tlpDocumentosGerais.Controls.Add(this.gbPesquisaDocumento, 0, 0);
            this.tlpDocumentosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDocumentosGerais.Location = new System.Drawing.Point(0, 0);
            this.tlpDocumentosGerais.Name = "tlpDocumentosGerais";
            this.tlpDocumentosGerais.RowCount = 3;
            this.tlpDocumentosGerais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDocumentosGerais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpDocumentosGerais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDocumentosGerais.Size = new System.Drawing.Size(875, 465);
            this.tlpDocumentosGerais.TabIndex = 0;
            // 
            // dOCUMENTOS_GERAISBindingNavigator
            // 
            this.dOCUMENTOS_GERAISBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dOCUMENTOS_GERAISBindingNavigator.BindingSource = this.dOCUMENTOS_GERAISBindingSource;
            this.dOCUMENTOS_GERAISBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dOCUMENTOS_GERAISBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dOCUMENTOS_GERAISBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dOCUMENTOS_GERAISBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.dOCUMENTOS_GERAISBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dOCUMENTOS_GERAISBindingNavigatorSaveItem,
            this.bindingNavigatorDeleteItem,
            this.tsbEditar,
            this.tsbBloquear,
            this.toolStripSeparator1,
            this.tsbEnviar,
            this.tsbBaixar});
            this.dOCUMENTOS_GERAISBindingNavigator.Location = new System.Drawing.Point(1, 371);
            this.dOCUMENTOS_GERAISBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dOCUMENTOS_GERAISBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dOCUMENTOS_GERAISBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dOCUMENTOS_GERAISBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dOCUMENTOS_GERAISBindingNavigator.Name = "dOCUMENTOS_GERAISBindingNavigator";
            this.dOCUMENTOS_GERAISBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dOCUMENTOS_GERAISBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.dOCUMENTOS_GERAISBindingNavigator.Size = new System.Drawing.Size(873, 93);
            this.dOCUMENTOS_GERAISBindingNavigator.TabIndex = 1;
            this.dOCUMENTOS_GERAISBindingNavigator.Text = "bindingNavigator1";
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
            // dOCUMENTOS_GERAISBindingSource
            // 
            this.dOCUMENTOS_GERAISBindingSource.DataMember = "DOCUMENTOS_GERAIS";
            this.dOCUMENTOS_GERAISBindingSource.DataSource = this.sISCONPROJECTSDataSet;
            // 
            // sISCONPROJECTSDataSet
            // 
            this.sISCONPROJECTSDataSet.DataSetName = "SISCONPROJECTSDataSet";
            this.sISCONPROJECTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 90);
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
            // dOCUMENTOS_GERAISBindingNavigatorSaveItem
            // 
            this.dOCUMENTOS_GERAISBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dOCUMENTOS_GERAISBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dOCUMENTOS_GERAISBindingNavigatorSaveItem.Image")));
            this.dOCUMENTOS_GERAISBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dOCUMENTOS_GERAISBindingNavigatorSaveItem.Name = "dOCUMENTOS_GERAISBindingNavigatorSaveItem";
            this.dOCUMENTOS_GERAISBindingNavigatorSaveItem.Size = new System.Drawing.Size(52, 90);
            this.dOCUMENTOS_GERAISBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.dOCUMENTOS_GERAISBindingNavigatorSaveItem.Click += new System.EventHandler(this.dOCUMENTOS_GERAISBindingNavigatorSaveItem_Click);
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
            // tbDocumentosGerais
            // 
            this.tbDocumentosGerais.Controls.Add(this.tpCapa);
            this.tbDocumentosGerais.Controls.Add(this.tpDetalhes);
            this.tbDocumentosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDocumentosGerais.Location = new System.Drawing.Point(4, 97);
            this.tbDocumentosGerais.Name = "tbDocumentosGerais";
            this.tbDocumentosGerais.SelectedIndex = 0;
            this.tbDocumentosGerais.Size = new System.Drawing.Size(867, 270);
            this.tbDocumentosGerais.TabIndex = 0;
            // 
            // tpCapa
            // 
            this.tpCapa.AutoScroll = true;
            this.tpCapa.Controls.Add(tipoDocumentoLabel);
            this.tpCapa.Controls.Add(this.tipoDocumentoComboBox);
            this.tpCapa.Controls.Add(documentosGeraisIdLabel);
            this.tpCapa.Controls.Add(this.documentosGeraisIdTextBox);
            this.tpCapa.Controls.Add(nomeDocumentoLabel);
            this.tpCapa.Controls.Add(this.nomeDocumentoTextBox);
            this.tpCapa.Controls.Add(descricaoDocumentoLabel);
            this.tpCapa.Controls.Add(this.descricaoDocumentoTextBox);
            this.tpCapa.Controls.Add(dataInclusaoLabel);
            this.tpCapa.Controls.Add(this.dataInclusaoDateTimePicker);
            this.tpCapa.Location = new System.Drawing.Point(4, 27);
            this.tpCapa.Name = "tpCapa";
            this.tpCapa.Padding = new System.Windows.Forms.Padding(3);
            this.tpCapa.Size = new System.Drawing.Size(859, 239);
            this.tpCapa.TabIndex = 0;
            this.tpCapa.Text = "Capa Documentos Gerais";
            this.tpCapa.UseVisualStyleBackColor = true;
            // 
            // tipoDocumentoComboBox
            // 
            this.tipoDocumentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCUMENTOS_GERAISBindingSource, "TipoDocumento", true));
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
            this.tipoDocumentoComboBox.Location = new System.Drawing.Point(376, 24);
            this.tipoDocumentoComboBox.Name = "tipoDocumentoComboBox";
            this.tipoDocumentoComboBox.Size = new System.Drawing.Size(138, 26);
            this.tipoDocumentoComboBox.TabIndex = 11;
            // 
            // documentosGeraisIdTextBox
            // 
            this.documentosGeraisIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCUMENTOS_GERAISBindingSource, "DocumentosGeraisId", true));
            this.documentosGeraisIdTextBox.Enabled = false;
            this.documentosGeraisIdTextBox.Location = new System.Drawing.Point(10, 24);
            this.documentosGeraisIdTextBox.Name = "documentosGeraisIdTextBox";
            this.documentosGeraisIdTextBox.Size = new System.Drawing.Size(154, 26);
            this.documentosGeraisIdTextBox.TabIndex = 1;
            // 
            // nomeDocumentoTextBox
            // 
            this.nomeDocumentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCUMENTOS_GERAISBindingSource, "NomeDocumento", true));
            this.nomeDocumentoTextBox.Location = new System.Drawing.Point(170, 24);
            this.nomeDocumentoTextBox.Name = "nomeDocumentoTextBox";
            this.nomeDocumentoTextBox.Size = new System.Drawing.Size(200, 26);
            this.nomeDocumentoTextBox.TabIndex = 3;
            // 
            // descricaoDocumentoTextBox
            // 
            this.descricaoDocumentoTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.descricaoDocumentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCUMENTOS_GERAISBindingSource, "DescricaoDocumento", true));
            this.descricaoDocumentoTextBox.Location = new System.Drawing.Point(10, 75);
            this.descricaoDocumentoTextBox.Multiline = true;
            this.descricaoDocumentoTextBox.Name = "descricaoDocumentoTextBox";
            this.descricaoDocumentoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descricaoDocumentoTextBox.Size = new System.Drawing.Size(843, 158);
            this.descricaoDocumentoTextBox.TabIndex = 5;
            // 
            // dataInclusaoDateTimePicker
            // 
            this.dataInclusaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dOCUMENTOS_GERAISBindingSource, "DataInclusao", true));
            this.dataInclusaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInclusaoDateTimePicker.Location = new System.Drawing.Point(520, 24);
            this.dataInclusaoDateTimePicker.Name = "dataInclusaoDateTimePicker";
            this.dataInclusaoDateTimePicker.Size = new System.Drawing.Size(154, 26);
            this.dataInclusaoDateTimePicker.TabIndex = 7;
            // 
            // tpDetalhes
            // 
            this.tpDetalhes.AutoScroll = true;
            this.tpDetalhes.Controls.Add(this.dOCUMENTOS_GERAISDataGridView);
            this.tpDetalhes.Location = new System.Drawing.Point(4, 27);
            this.tpDetalhes.Name = "tpDetalhes";
            this.tpDetalhes.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetalhes.Size = new System.Drawing.Size(859, 239);
            this.tpDetalhes.TabIndex = 1;
            this.tpDetalhes.Text = "Detalhes Documentos Gerais";
            this.tpDetalhes.UseVisualStyleBackColor = true;
            // 
            // dOCUMENTOS_GERAISDataGridView
            // 
            this.dOCUMENTOS_GERAISDataGridView.AllowUserToAddRows = false;
            this.dOCUMENTOS_GERAISDataGridView.AllowUserToDeleteRows = false;
            this.dOCUMENTOS_GERAISDataGridView.AutoGenerateColumns = false;
            this.dOCUMENTOS_GERAISDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dOCUMENTOS_GERAISDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.TipoDocumento,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.ArquivoSalvo});
            this.dOCUMENTOS_GERAISDataGridView.DataSource = this.dOCUMENTOS_GERAISBindingSource;
            this.dOCUMENTOS_GERAISDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dOCUMENTOS_GERAISDataGridView.Location = new System.Drawing.Point(3, 3);
            this.dOCUMENTOS_GERAISDataGridView.Name = "dOCUMENTOS_GERAISDataGridView";
            this.dOCUMENTOS_GERAISDataGridView.ReadOnly = true;
            this.dOCUMENTOS_GERAISDataGridView.Size = new System.Drawing.Size(853, 233);
            this.dOCUMENTOS_GERAISDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DocumentosGeraisId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Identificação Documento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 205;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeDocumento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Documento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 160;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DescricaoDocumento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição Documento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 195;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataInclusao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data Inclusão";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // ArquivoSalvo
            // 
            this.ArquivoSalvo.DataPropertyName = "ArquivoSalvo";
            this.ArquivoSalvo.HeaderText = "Arquivo Salvo (Binário)";
            this.ArquivoSalvo.Name = "ArquivoSalvo";
            this.ArquivoSalvo.ReadOnly = true;
            this.ArquivoSalvo.Width = 300;
            // 
            // gbPesquisaDocumento
            // 
            this.gbPesquisaDocumento.Controls.Add(this.mkdtxtPesquisaData);
            this.gbPesquisaDocumento.Controls.Add(this.btnPesquisarDocsGerais);
            this.gbPesquisaDocumento.Controls.Add(this.rbPesquisaData);
            this.gbPesquisaDocumento.Controls.Add(this.rbPesquisaTipo);
            this.gbPesquisaDocumento.Controls.Add(this.rbPesquisaNome);
            this.gbPesquisaDocumento.Controls.Add(this.txtPesquisaDocumento);
            this.gbPesquisaDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPesquisaDocumento.Location = new System.Drawing.Point(4, 4);
            this.gbPesquisaDocumento.Name = "gbPesquisaDocumento";
            this.gbPesquisaDocumento.Size = new System.Drawing.Size(867, 86);
            this.gbPesquisaDocumento.TabIndex = 2;
            this.gbPesquisaDocumento.TabStop = false;
            this.gbPesquisaDocumento.Text = "Para realizar a pesquisa";
            // 
            // mkdtxtPesquisaData
            // 
            this.mkdtxtPesquisaData.Location = new System.Drawing.Point(320, 34);
            this.mkdtxtPesquisaData.Mask = "00/00/0000";
            this.mkdtxtPesquisaData.Name = "mkdtxtPesquisaData";
            this.mkdtxtPesquisaData.Size = new System.Drawing.Size(108, 26);
            this.mkdtxtPesquisaData.TabIndex = 5;
            this.mkdtxtPesquisaData.ValidatingType = typeof(System.DateTime);
            // 
            // btnPesquisarDocsGerais
            // 
            this.btnPesquisarDocsGerais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarDocsGerais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarDocsGerais.Location = new System.Drawing.Point(747, 19);
            this.btnPesquisarDocsGerais.Name = "btnPesquisarDocsGerais";
            this.btnPesquisarDocsGerais.Size = new System.Drawing.Size(114, 55);
            this.btnPesquisarDocsGerais.TabIndex = 4;
            this.btnPesquisarDocsGerais.Text = "Pesquisar";
            this.btnPesquisarDocsGerais.UseVisualStyleBackColor = true;
            this.btnPesquisarDocsGerais.Click += new System.EventHandler(this.btnPesquisarDocsGerais_Click);
            // 
            // rbPesquisaData
            // 
            this.rbPesquisaData.AutoSize = true;
            this.rbPesquisaData.Location = new System.Drawing.Point(230, 35);
            this.rbPesquisaData.Name = "rbPesquisaData";
            this.rbPesquisaData.Size = new System.Drawing.Size(84, 22);
            this.rbPesquisaData.TabIndex = 3;
            this.rbPesquisaData.TabStop = true;
            this.rbPesquisaData.Text = "por data";
            this.rbPesquisaData.UseVisualStyleBackColor = true;
            this.rbPesquisaData.CheckedChanged += new System.EventHandler(this.rbPesquisaData_CheckedChanged);
            // 
            // rbPesquisaTipo
            // 
            this.rbPesquisaTipo.AutoSize = true;
            this.rbPesquisaTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPesquisaTipo.Location = new System.Drawing.Point(127, 35);
            this.rbPesquisaTipo.Name = "rbPesquisaTipo";
            this.rbPesquisaTipo.Size = new System.Drawing.Size(79, 22);
            this.rbPesquisaTipo.TabIndex = 2;
            this.rbPesquisaTipo.TabStop = true;
            this.rbPesquisaTipo.Text = "por tipo";
            this.rbPesquisaTipo.UseVisualStyleBackColor = true;
            this.rbPesquisaTipo.CheckedChanged += new System.EventHandler(this.rbPesquisaTipo_CheckedChanged);
            // 
            // rbPesquisaNome
            // 
            this.rbPesquisaNome.AutoSize = true;
            this.rbPesquisaNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPesquisaNome.Location = new System.Drawing.Point(6, 35);
            this.rbPesquisaNome.Name = "rbPesquisaNome";
            this.rbPesquisaNome.Size = new System.Drawing.Size(92, 22);
            this.rbPesquisaNome.TabIndex = 1;
            this.rbPesquisaNome.TabStop = true;
            this.rbPesquisaNome.Text = "por nome";
            this.rbPesquisaNome.UseVisualStyleBackColor = true;
            this.rbPesquisaNome.CheckedChanged += new System.EventHandler(this.rbPesquisaNome_CheckedChanged);
            // 
            // txtPesquisaDocumento
            // 
            this.txtPesquisaDocumento.Location = new System.Drawing.Point(434, 34);
            this.txtPesquisaDocumento.Name = "txtPesquisaDocumento";
            this.txtPesquisaDocumento.Size = new System.Drawing.Size(307, 26);
            this.txtPesquisaDocumento.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // dOCUMENTOS_GERAISTableAdapter
            // 
            this.dOCUMENTOS_GERAISTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ARQUIVOS_DOCS_GERAISTableAdapter = null;
            this.tableAdapterManager.ARQUIVOS_EVIDENCIASTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DOCUMENTOS_GERAISTableAdapter = this.dOCUMENTOS_GERAISTableAdapter;
            this.tableAdapterManager.EVIDENCIASTableAdapter = null;
            this.tableAdapterManager.LANCAMENTO_HORARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sisconGestão.SISCONPROJECTSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOS_SENHASTableAdapter = null;
            // 
            // frmDocumentosGerais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 465);
            this.Controls.Add(this.tlpDocumentosGerais);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDocumentosGerais";
            this.Text = "SISCON PROJECTS - Documentos Gerais - Cadastros";
            this.Load += new System.EventHandler(this.frmDocumentosGerais_Load);
            this.tlpDocumentosGerais.ResumeLayout(false);
            this.tlpDocumentosGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCUMENTOS_GERAISBindingNavigator)).EndInit();
            this.dOCUMENTOS_GERAISBindingNavigator.ResumeLayout(false);
            this.dOCUMENTOS_GERAISBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCUMENTOS_GERAISBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONPROJECTSDataSet)).EndInit();
            this.tbDocumentosGerais.ResumeLayout(false);
            this.tpCapa.ResumeLayout(false);
            this.tpCapa.PerformLayout();
            this.tpDetalhes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dOCUMENTOS_GERAISDataGridView)).EndInit();
            this.gbPesquisaDocumento.ResumeLayout(false);
            this.gbPesquisaDocumento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDocumentosGerais;
        private System.Windows.Forms.TabControl tbDocumentosGerais;
        private System.Windows.Forms.TabPage tpCapa;
        private System.Windows.Forms.TabPage tpDetalhes;
        private SISCONPROJECTSDataSet sISCONPROJECTSDataSet;
        private System.Windows.Forms.BindingSource dOCUMENTOS_GERAISBindingSource;
        private SISCONPROJECTSDataSetTableAdapters.DOCUMENTOS_GERAISTableAdapter dOCUMENTOS_GERAISTableAdapter;
        private SISCONPROJECTSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dOCUMENTOS_GERAISBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dOCUMENTOS_GERAISBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox documentosGeraisIdTextBox;
        private System.Windows.Forms.TextBox nomeDocumentoTextBox;
        private System.Windows.Forms.TextBox descricaoDocumentoTextBox;
        private System.Windows.Forms.DateTimePicker dataInclusaoDateTimePicker;
        private System.Windows.Forms.GroupBox gbPesquisaDocumento;
        private System.Windows.Forms.TextBox txtPesquisaDocumento;
        private System.Windows.Forms.ComboBox tipoDocumentoComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbBloquear;
        private System.Windows.Forms.ToolStripButton tsbEnviar;
        private System.Windows.Forms.ToolStripButton tsbBaixar;
        private System.Windows.Forms.Button btnPesquisarDocsGerais;
        private System.Windows.Forms.RadioButton rbPesquisaData;
        private System.Windows.Forms.RadioButton rbPesquisaTipo;
        private System.Windows.Forms.RadioButton rbPesquisaNome;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dOCUMENTOS_GERAISDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn ArquivoSalvo;
        private System.Windows.Forms.MaskedTextBox mkdtxtPesquisaData;
    }
}