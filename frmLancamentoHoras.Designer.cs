namespace sisconGestão
{
    partial class frmLancamentoHoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLancamentoHoras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label lancamentoHorarioIdLabel;
            System.Windows.Forms.Label dataLancamentoLabel;
            System.Windows.Forms.Label tipoLancamentoLabel;
            System.Windows.Forms.Label numeroEvidenciaLabel;
            System.Windows.Forms.Label clienteLancamentoLabel;
            System.Windows.Forms.Label observacaoLancamentoLabel;
            System.Windows.Forms.Label horasLancamentoLabel;
            this.tlpLancamentoHorarios = new System.Windows.Forms.TableLayoutPanel();
            this.tbLancamentoHoras = new System.Windows.Forms.TabControl();
            this.tpCapaLancamento = new System.Windows.Forms.TabPage();
            this.tpDetalhesHoras = new System.Windows.Forms.TabPage();
            this.sISCONPROJECTSDataSet = new sisconGestão.SISCONPROJECTSDataSet();
            this.lANCAMENTO_HORARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lANCAMENTO_HORARIOSTableAdapter = new sisconGestão.SISCONPROJECTSDataSetTableAdapters.LANCAMENTO_HORARIOSTableAdapter();
            this.tableAdapterManager = new sisconGestão.SISCONPROJECTSDataSetTableAdapters.TableAdapterManager();
            this.lANCAMENTO_HORARIOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lANCAMENTO_HORARIOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lancamentoHorarioIdTextBox = new System.Windows.Forms.TextBox();
            this.dataLancamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tipoLancamentoComboBox = new System.Windows.Forms.ComboBox();
            this.numeroEvidenciaTextBox = new System.Windows.Forms.TextBox();
            this.clienteLancamentoTextBox = new System.Windows.Forms.TextBox();
            this.observacaoLancamentoTextBox = new System.Windows.Forms.TextBox();
            this.horasLancamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            lancamentoHorarioIdLabel = new System.Windows.Forms.Label();
            dataLancamentoLabel = new System.Windows.Forms.Label();
            tipoLancamentoLabel = new System.Windows.Forms.Label();
            numeroEvidenciaLabel = new System.Windows.Forms.Label();
            clienteLancamentoLabel = new System.Windows.Forms.Label();
            observacaoLancamentoLabel = new System.Windows.Forms.Label();
            horasLancamentoLabel = new System.Windows.Forms.Label();
            this.tlpLancamentoHorarios.SuspendLayout();
            this.tbLancamentoHoras.SuspendLayout();
            this.tpCapaLancamento.SuspendLayout();
            this.tpDetalhesHoras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONPROJECTSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANCAMENTO_HORARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANCAMENTO_HORARIOSBindingNavigator)).BeginInit();
            this.lANCAMENTO_HORARIOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lANCAMENTO_HORARIOSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpLancamentoHorarios
            // 
            this.tlpLancamentoHorarios.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpLancamentoHorarios.ColumnCount = 1;
            this.tlpLancamentoHorarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLancamentoHorarios.Controls.Add(this.lANCAMENTO_HORARIOSBindingNavigator, 0, 2);
            this.tlpLancamentoHorarios.Controls.Add(this.tbLancamentoHoras, 0, 1);
            this.tlpLancamentoHorarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLancamentoHorarios.Location = new System.Drawing.Point(0, 0);
            this.tlpLancamentoHorarios.Name = "tlpLancamentoHorarios";
            this.tlpLancamentoHorarios.RowCount = 3;
            this.tlpLancamentoHorarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpLancamentoHorarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpLancamentoHorarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpLancamentoHorarios.Size = new System.Drawing.Size(875, 465);
            this.tlpLancamentoHorarios.TabIndex = 0;
            // 
            // tbLancamentoHoras
            // 
            this.tbLancamentoHoras.Controls.Add(this.tpCapaLancamento);
            this.tbLancamentoHoras.Controls.Add(this.tpDetalhesHoras);
            this.tbLancamentoHoras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLancamentoHoras.Location = new System.Drawing.Point(4, 97);
            this.tbLancamentoHoras.Name = "tbLancamentoHoras";
            this.tbLancamentoHoras.SelectedIndex = 0;
            this.tbLancamentoHoras.Size = new System.Drawing.Size(867, 270);
            this.tbLancamentoHoras.TabIndex = 0;
            // 
            // tpCapaLancamento
            // 
            this.tpCapaLancamento.AutoScroll = true;
            this.tpCapaLancamento.Controls.Add(lancamentoHorarioIdLabel);
            this.tpCapaLancamento.Controls.Add(this.lancamentoHorarioIdTextBox);
            this.tpCapaLancamento.Controls.Add(dataLancamentoLabel);
            this.tpCapaLancamento.Controls.Add(this.dataLancamentoDateTimePicker);
            this.tpCapaLancamento.Controls.Add(tipoLancamentoLabel);
            this.tpCapaLancamento.Controls.Add(this.tipoLancamentoComboBox);
            this.tpCapaLancamento.Controls.Add(numeroEvidenciaLabel);
            this.tpCapaLancamento.Controls.Add(this.numeroEvidenciaTextBox);
            this.tpCapaLancamento.Controls.Add(clienteLancamentoLabel);
            this.tpCapaLancamento.Controls.Add(this.clienteLancamentoTextBox);
            this.tpCapaLancamento.Controls.Add(observacaoLancamentoLabel);
            this.tpCapaLancamento.Controls.Add(this.observacaoLancamentoTextBox);
            this.tpCapaLancamento.Controls.Add(horasLancamentoLabel);
            this.tpCapaLancamento.Controls.Add(this.horasLancamentoDateTimePicker);
            this.tpCapaLancamento.Location = new System.Drawing.Point(4, 27);
            this.tpCapaLancamento.Name = "tpCapaLancamento";
            this.tpCapaLancamento.Padding = new System.Windows.Forms.Padding(3);
            this.tpCapaLancamento.Size = new System.Drawing.Size(859, 239);
            this.tpCapaLancamento.TabIndex = 0;
            this.tpCapaLancamento.Text = "Capa Lançamento de Horas";
            this.tpCapaLancamento.UseVisualStyleBackColor = true;
            // 
            // tpDetalhesHoras
            // 
            this.tpDetalhesHoras.AutoScroll = true;
            this.tpDetalhesHoras.Controls.Add(this.lANCAMENTO_HORARIOSDataGridView);
            this.tpDetalhesHoras.Location = new System.Drawing.Point(4, 27);
            this.tpDetalhesHoras.Name = "tpDetalhesHoras";
            this.tpDetalhesHoras.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetalhesHoras.Size = new System.Drawing.Size(859, 239);
            this.tpDetalhesHoras.TabIndex = 1;
            this.tpDetalhesHoras.Text = "Detalhes Lançamento de Horas";
            this.tpDetalhesHoras.UseVisualStyleBackColor = true;
            // 
            // sISCONPROJECTSDataSet
            // 
            this.sISCONPROJECTSDataSet.DataSetName = "SISCONPROJECTSDataSet";
            this.sISCONPROJECTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lANCAMENTO_HORARIOSBindingSource
            // 
            this.lANCAMENTO_HORARIOSBindingSource.DataMember = "LANCAMENTO_HORARIOS";
            this.lANCAMENTO_HORARIOSBindingSource.DataSource = this.sISCONPROJECTSDataSet;
            // 
            // lANCAMENTO_HORARIOSTableAdapter
            // 
            this.lANCAMENTO_HORARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DOCUMENTOS_GERAISTableAdapter = null;
            this.tableAdapterManager.EVIDENCIASTableAdapter = null;
            this.tableAdapterManager.LANCAMENTO_HORARIOSTableAdapter = this.lANCAMENTO_HORARIOSTableAdapter;
            this.tableAdapterManager.UpdateOrder = sisconGestão.SISCONPROJECTSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lANCAMENTO_HORARIOSBindingNavigator
            // 
            this.lANCAMENTO_HORARIOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lANCAMENTO_HORARIOSBindingNavigator.BindingSource = this.lANCAMENTO_HORARIOSBindingSource;
            this.lANCAMENTO_HORARIOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lANCAMENTO_HORARIOSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lANCAMENTO_HORARIOSBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lANCAMENTO_HORARIOSBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.lANCAMENTO_HORARIOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem});
            this.lANCAMENTO_HORARIOSBindingNavigator.Location = new System.Drawing.Point(1, 371);
            this.lANCAMENTO_HORARIOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lANCAMENTO_HORARIOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lANCAMENTO_HORARIOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lANCAMENTO_HORARIOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lANCAMENTO_HORARIOSBindingNavigator.Name = "lANCAMENTO_HORARIOSBindingNavigator";
            this.lANCAMENTO_HORARIOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lANCAMENTO_HORARIOSBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.lANCAMENTO_HORARIOSBindingNavigator.Size = new System.Drawing.Size(873, 93);
            this.lANCAMENTO_HORARIOSBindingNavigator.TabIndex = 1;
            this.lANCAMENTO_HORARIOSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 90);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // lANCAMENTO_HORARIOSBindingNavigatorSaveItem
            // 
            this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lANCAMENTO_HORARIOSBindingNavigatorSaveItem.Image")));
            this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem.Name = "lANCAMENTO_HORARIOSBindingNavigatorSaveItem";
            this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem_Click);
            // 
            // lANCAMENTO_HORARIOSDataGridView
            // 
            this.lANCAMENTO_HORARIOSDataGridView.AllowUserToAddRows = false;
            this.lANCAMENTO_HORARIOSDataGridView.AllowUserToDeleteRows = false;
            this.lANCAMENTO_HORARIOSDataGridView.AutoGenerateColumns = false;
            this.lANCAMENTO_HORARIOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lANCAMENTO_HORARIOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.lANCAMENTO_HORARIOSDataGridView.DataSource = this.lANCAMENTO_HORARIOSBindingSource;
            this.lANCAMENTO_HORARIOSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lANCAMENTO_HORARIOSDataGridView.Location = new System.Drawing.Point(3, 3);
            this.lANCAMENTO_HORARIOSDataGridView.Name = "lANCAMENTO_HORARIOSDataGridView";
            this.lANCAMENTO_HORARIOSDataGridView.ReadOnly = true;
            this.lANCAMENTO_HORARIOSDataGridView.Size = new System.Drawing.Size(853, 233);
            this.lANCAMENTO_HORARIOSDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LancamentoHorarioId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Número Lançamento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 180;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DataLancamento";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn2.HeaderText = "Data Lançamento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TipoLancamento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tipo Lançamento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 180;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NumeroEvidencia";
            this.dataGridViewTextBoxColumn4.HeaderText = "Número Evidência";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 180;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ClienteLancamento";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 180;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ObservacaoLancamento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Observação";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 180;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HorasLancamento";
            dataGridViewCellStyle8.Format = "t";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn7.HeaderText = "Horas Lançamento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 180;
            // 
            // lancamentoHorarioIdLabel
            // 
            lancamentoHorarioIdLabel.AutoSize = true;
            lancamentoHorarioIdLabel.Location = new System.Drawing.Point(109, 9);
            lancamentoHorarioIdLabel.Name = "lancamentoHorarioIdLabel";
            lancamentoHorarioIdLabel.Size = new System.Drawing.Size(170, 18);
            lancamentoHorarioIdLabel.TabIndex = 0;
            lancamentoHorarioIdLabel.Text = "Lancamento Horario Id:";
            // 
            // lancamentoHorarioIdTextBox
            // 
            this.lancamentoHorarioIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lANCAMENTO_HORARIOSBindingSource, "LancamentoHorarioId", true));
            this.lancamentoHorarioIdTextBox.Location = new System.Drawing.Point(302, 6);
            this.lancamentoHorarioIdTextBox.Name = "lancamentoHorarioIdTextBox";
            this.lancamentoHorarioIdTextBox.Size = new System.Drawing.Size(200, 26);
            this.lancamentoHorarioIdTextBox.TabIndex = 1;
            // 
            // dataLancamentoLabel
            // 
            dataLancamentoLabel.AutoSize = true;
            dataLancamentoLabel.Location = new System.Drawing.Point(109, 42);
            dataLancamentoLabel.Name = "dataLancamentoLabel";
            dataLancamentoLabel.Size = new System.Drawing.Size(136, 18);
            dataLancamentoLabel.TabIndex = 2;
            dataLancamentoLabel.Text = "Data Lancamento:";
            // 
            // dataLancamentoDateTimePicker
            // 
            this.dataLancamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lANCAMENTO_HORARIOSBindingSource, "DataLancamento", true));
            this.dataLancamentoDateTimePicker.Location = new System.Drawing.Point(302, 38);
            this.dataLancamentoDateTimePicker.Name = "dataLancamentoDateTimePicker";
            this.dataLancamentoDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dataLancamentoDateTimePicker.TabIndex = 3;
            // 
            // tipoLancamentoLabel
            // 
            tipoLancamentoLabel.AutoSize = true;
            tipoLancamentoLabel.Location = new System.Drawing.Point(109, 73);
            tipoLancamentoLabel.Name = "tipoLancamentoLabel";
            tipoLancamentoLabel.Size = new System.Drawing.Size(132, 18);
            tipoLancamentoLabel.TabIndex = 4;
            tipoLancamentoLabel.Text = "Tipo Lancamento:";
            // 
            // tipoLancamentoComboBox
            // 
            this.tipoLancamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lANCAMENTO_HORARIOSBindingSource, "TipoLancamento", true));
            this.tipoLancamentoComboBox.FormattingEnabled = true;
            this.tipoLancamentoComboBox.Location = new System.Drawing.Point(302, 70);
            this.tipoLancamentoComboBox.Name = "tipoLancamentoComboBox";
            this.tipoLancamentoComboBox.Size = new System.Drawing.Size(200, 26);
            this.tipoLancamentoComboBox.TabIndex = 5;
            // 
            // numeroEvidenciaLabel
            // 
            numeroEvidenciaLabel.AutoSize = true;
            numeroEvidenciaLabel.Location = new System.Drawing.Point(109, 105);
            numeroEvidenciaLabel.Name = "numeroEvidenciaLabel";
            numeroEvidenciaLabel.Size = new System.Drawing.Size(140, 18);
            numeroEvidenciaLabel.TabIndex = 6;
            numeroEvidenciaLabel.Text = "Numero Evidencia:";
            // 
            // numeroEvidenciaTextBox
            // 
            this.numeroEvidenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lANCAMENTO_HORARIOSBindingSource, "NumeroEvidencia", true));
            this.numeroEvidenciaTextBox.Location = new System.Drawing.Point(302, 102);
            this.numeroEvidenciaTextBox.Name = "numeroEvidenciaTextBox";
            this.numeroEvidenciaTextBox.Size = new System.Drawing.Size(200, 26);
            this.numeroEvidenciaTextBox.TabIndex = 7;
            // 
            // clienteLancamentoLabel
            // 
            clienteLancamentoLabel.AutoSize = true;
            clienteLancamentoLabel.Location = new System.Drawing.Point(109, 137);
            clienteLancamentoLabel.Name = "clienteLancamentoLabel";
            clienteLancamentoLabel.Size = new System.Drawing.Size(151, 18);
            clienteLancamentoLabel.TabIndex = 8;
            clienteLancamentoLabel.Text = "Cliente Lancamento:";
            // 
            // clienteLancamentoTextBox
            // 
            this.clienteLancamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lANCAMENTO_HORARIOSBindingSource, "ClienteLancamento", true));
            this.clienteLancamentoTextBox.Location = new System.Drawing.Point(302, 134);
            this.clienteLancamentoTextBox.Name = "clienteLancamentoTextBox";
            this.clienteLancamentoTextBox.Size = new System.Drawing.Size(200, 26);
            this.clienteLancamentoTextBox.TabIndex = 9;
            // 
            // observacaoLancamentoLabel
            // 
            observacaoLancamentoLabel.AutoSize = true;
            observacaoLancamentoLabel.Location = new System.Drawing.Point(109, 169);
            observacaoLancamentoLabel.Name = "observacaoLancamentoLabel";
            observacaoLancamentoLabel.Size = new System.Drawing.Size(187, 18);
            observacaoLancamentoLabel.TabIndex = 10;
            observacaoLancamentoLabel.Text = "Observacao Lancamento:";
            // 
            // observacaoLancamentoTextBox
            // 
            this.observacaoLancamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lANCAMENTO_HORARIOSBindingSource, "ObservacaoLancamento", true));
            this.observacaoLancamentoTextBox.Location = new System.Drawing.Point(302, 166);
            this.observacaoLancamentoTextBox.Name = "observacaoLancamentoTextBox";
            this.observacaoLancamentoTextBox.Size = new System.Drawing.Size(200, 26);
            this.observacaoLancamentoTextBox.TabIndex = 11;
            // 
            // horasLancamentoLabel
            // 
            horasLancamentoLabel.AutoSize = true;
            horasLancamentoLabel.Location = new System.Drawing.Point(109, 202);
            horasLancamentoLabel.Name = "horasLancamentoLabel";
            horasLancamentoLabel.Size = new System.Drawing.Size(144, 18);
            horasLancamentoLabel.TabIndex = 12;
            horasLancamentoLabel.Text = "Horas Lancamento:";
            // 
            // horasLancamentoDateTimePicker
            // 
            this.horasLancamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lANCAMENTO_HORARIOSBindingSource, "HorasLancamento", true));
            this.horasLancamentoDateTimePicker.Location = new System.Drawing.Point(302, 198);
            this.horasLancamentoDateTimePicker.Name = "horasLancamentoDateTimePicker";
            this.horasLancamentoDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.horasLancamentoDateTimePicker.TabIndex = 13;
            // 
            // frmLancamentoHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 465);
            this.Controls.Add(this.tlpLancamentoHorarios);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLancamentoHoras";
            this.Text = "SISCON PROJECTS - Lançamentos de Horas";
            this.Load += new System.EventHandler(this.frmLancamentoHoras_Load);
            this.tlpLancamentoHorarios.ResumeLayout(false);
            this.tlpLancamentoHorarios.PerformLayout();
            this.tbLancamentoHoras.ResumeLayout(false);
            this.tpCapaLancamento.ResumeLayout(false);
            this.tpCapaLancamento.PerformLayout();
            this.tpDetalhesHoras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sISCONPROJECTSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANCAMENTO_HORARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANCAMENTO_HORARIOSBindingNavigator)).EndInit();
            this.lANCAMENTO_HORARIOSBindingNavigator.ResumeLayout(false);
            this.lANCAMENTO_HORARIOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lANCAMENTO_HORARIOSDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpLancamentoHorarios;
        private System.Windows.Forms.TabControl tbLancamentoHoras;
        private System.Windows.Forms.TabPage tpCapaLancamento;
        private System.Windows.Forms.TabPage tpDetalhesHoras;
        private SISCONPROJECTSDataSet sISCONPROJECTSDataSet;
        private System.Windows.Forms.BindingSource lANCAMENTO_HORARIOSBindingSource;
        private SISCONPROJECTSDataSetTableAdapters.LANCAMENTO_HORARIOSTableAdapter lANCAMENTO_HORARIOSTableAdapter;
        private SISCONPROJECTSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lANCAMENTO_HORARIOSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lANCAMENTO_HORARIOSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView lANCAMENTO_HORARIOSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox lancamentoHorarioIdTextBox;
        private System.Windows.Forms.DateTimePicker dataLancamentoDateTimePicker;
        private System.Windows.Forms.ComboBox tipoLancamentoComboBox;
        private System.Windows.Forms.TextBox numeroEvidenciaTextBox;
        private System.Windows.Forms.TextBox clienteLancamentoTextBox;
        private System.Windows.Forms.TextBox observacaoLancamentoTextBox;
        private System.Windows.Forms.DateTimePicker horasLancamentoDateTimePicker;
    }
}