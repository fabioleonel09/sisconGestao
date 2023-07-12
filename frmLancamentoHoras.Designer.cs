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
            System.Windows.Forms.Label lancamentoHorarioIdLabel;
            System.Windows.Forms.Label dataLancamentoLabel;
            System.Windows.Forms.Label tipoLancamentoLabel;
            System.Windows.Forms.Label numeroEvidenciaLabel;
            System.Windows.Forms.Label clienteLancamentoLabel;
            System.Windows.Forms.Label observacaoLancamentoLabel;
            System.Windows.Forms.Label horasLancamentoLabel;
            System.Windows.Forms.Label nomeDesenvolvedorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLancamentoHoras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpLancamentoHorarios = new System.Windows.Forms.TableLayoutPanel();
            this.lANCAMENTO_HORARIOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbBloquear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEnviar = new System.Windows.Forms.ToolStripButton();
            this.tsbBaixar = new System.Windows.Forms.ToolStripButton();
            this.tbLancamentoHoras = new System.Windows.Forms.TabControl();
            this.tpCapaLancamento = new System.Windows.Forms.TabPage();
            this.nomeDesenvolvedorTextBox = new System.Windows.Forms.TextBox();
            this.lancamentoHorarioIdTextBox = new System.Windows.Forms.TextBox();
            this.dataLancamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tipoLancamentoComboBox = new System.Windows.Forms.ComboBox();
            this.numeroEvidenciaTextBox = new System.Windows.Forms.TextBox();
            this.clienteLancamentoTextBox = new System.Windows.Forms.TextBox();
            this.observacaoLancamentoTextBox = new System.Windows.Forms.TextBox();
            this.horasLancamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tpDetalhesHoras = new System.Windows.Forms.TabPage();
            this.lANCAMENTO_HORARIOSDataGridView = new System.Windows.Forms.DataGridView();
            this.nomeDesenvolvedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbRealizaPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisarLancamentos = new System.Windows.Forms.Button();
            this.rbPesquisaData = new System.Windows.Forms.RadioButton();
            this.rbPesquisaTipo = new System.Windows.Forms.RadioButton();
            this.rbPesquisaNome = new System.Windows.Forms.RadioButton();
            this.txtPesquisaHorarios = new System.Windows.Forms.TextBox();
            this.mkdtxtDataLancamento = new System.Windows.Forms.MaskedTextBox();
            this.lANCAMENTO_HORARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISCONPROJECTSDataSet = new sisconGestão.SISCONPROJECTSDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lANCAMENTO_HORARIOSTableAdapter = new sisconGestão.SISCONPROJECTSDataSetTableAdapters.LANCAMENTO_HORARIOSTableAdapter();
            this.tableAdapterManager = new sisconGestão.SISCONPROJECTSDataSetTableAdapters.TableAdapterManager();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImprimirApontamentoHoras = new System.Windows.Forms.ToolStripButton();
            lancamentoHorarioIdLabel = new System.Windows.Forms.Label();
            dataLancamentoLabel = new System.Windows.Forms.Label();
            tipoLancamentoLabel = new System.Windows.Forms.Label();
            numeroEvidenciaLabel = new System.Windows.Forms.Label();
            clienteLancamentoLabel = new System.Windows.Forms.Label();
            observacaoLancamentoLabel = new System.Windows.Forms.Label();
            horasLancamentoLabel = new System.Windows.Forms.Label();
            nomeDesenvolvedorLabel = new System.Windows.Forms.Label();
            this.tlpLancamentoHorarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lANCAMENTO_HORARIOSBindingNavigator)).BeginInit();
            this.lANCAMENTO_HORARIOSBindingNavigator.SuspendLayout();
            this.tbLancamentoHoras.SuspendLayout();
            this.tpCapaLancamento.SuspendLayout();
            this.tpDetalhesHoras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lANCAMENTO_HORARIOSDataGridView)).BeginInit();
            this.gbRealizaPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lANCAMENTO_HORARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONPROJECTSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lancamentoHorarioIdLabel
            // 
            lancamentoHorarioIdLabel.AutoSize = true;
            lancamentoHorarioIdLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lancamentoHorarioIdLabel.Location = new System.Drawing.Point(6, 3);
            lancamentoHorarioIdLabel.Name = "lancamentoHorarioIdLabel";
            lancamentoHorarioIdLabel.Size = new System.Drawing.Size(156, 19);
            lancamentoHorarioIdLabel.TabIndex = 0;
            lancamentoHorarioIdLabel.Text = "Ident. Lançamento:";
            // 
            // dataLancamentoLabel
            // 
            dataLancamentoLabel.AutoSize = true;
            dataLancamentoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataLancamentoLabel.Location = new System.Drawing.Point(629, 54);
            dataLancamentoLabel.Name = "dataLancamentoLabel";
            dataLancamentoLabel.Size = new System.Drawing.Size(149, 19);
            dataLancamentoLabel.TabIndex = 2;
            dataLancamentoLabel.Text = "Data Lançamento:";
            // 
            // tipoLancamentoLabel
            // 
            tipoLancamentoLabel.AutoSize = true;
            tipoLancamentoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoLancamentoLabel.Location = new System.Drawing.Point(504, 3);
            tipoLancamentoLabel.Name = "tipoLancamentoLabel";
            tipoLancamentoLabel.Size = new System.Drawing.Size(148, 19);
            tipoLancamentoLabel.TabIndex = 4;
            tipoLancamentoLabel.Text = "Tipo Lançamento:";
            // 
            // numeroEvidenciaLabel
            // 
            numeroEvidenciaLabel.AutoSize = true;
            numeroEvidenciaLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroEvidenciaLabel.Location = new System.Drawing.Point(168, 3);
            numeroEvidenciaLabel.Name = "numeroEvidenciaLabel";
            numeroEvidenciaLabel.Size = new System.Drawing.Size(155, 19);
            numeroEvidenciaLabel.TabIndex = 6;
            numeroEvidenciaLabel.Text = "Número Evidência:";
            // 
            // clienteLancamentoLabel
            // 
            clienteLancamentoLabel.AutoSize = true;
            clienteLancamentoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clienteLancamentoLabel.Location = new System.Drawing.Point(329, 3);
            clienteLancamentoLabel.Name = "clienteLancamentoLabel";
            clienteLancamentoLabel.Size = new System.Drawing.Size(167, 19);
            clienteLancamentoLabel.TabIndex = 8;
            clienteLancamentoLabel.Text = "Cliente Lançamento:";
            // 
            // observacaoLancamentoLabel
            // 
            observacaoLancamentoLabel.AutoSize = true;
            observacaoLancamentoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            observacaoLancamentoLabel.Location = new System.Drawing.Point(6, 105);
            observacaoLancamentoLabel.Name = "observacaoLancamentoLabel";
            observacaoLancamentoLabel.Size = new System.Drawing.Size(107, 19);
            observacaoLancamentoLabel.TabIndex = 10;
            observacaoLancamentoLabel.Text = "Observação:";
            // 
            // horasLancamentoLabel
            // 
            horasLancamentoLabel.AutoSize = true;
            horasLancamentoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horasLancamentoLabel.Location = new System.Drawing.Point(780, 54);
            horasLancamentoLabel.Name = "horasLancamentoLabel";
            horasLancamentoLabel.Size = new System.Drawing.Size(46, 19);
            horasLancamentoLabel.TabIndex = 12;
            horasLancamentoLabel.Text = "Qtd.:";
            // 
            // nomeDesenvolvedorLabel
            // 
            nomeDesenvolvedorLabel.AutoSize = true;
            nomeDesenvolvedorLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeDesenvolvedorLabel.Location = new System.Drawing.Point(6, 54);
            nomeDesenvolvedorLabel.Name = "nomeDesenvolvedorLabel";
            nomeDesenvolvedorLabel.Size = new System.Drawing.Size(204, 19);
            nomeDesenvolvedorLabel.TabIndex = 14;
            nomeDesenvolvedorLabel.Text = "Nome do Desenvolvedor:";
            // 
            // tlpLancamentoHorarios
            // 
            this.tlpLancamentoHorarios.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpLancamentoHorarios.ColumnCount = 1;
            this.tlpLancamentoHorarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLancamentoHorarios.Controls.Add(this.lANCAMENTO_HORARIOSBindingNavigator, 0, 2);
            this.tlpLancamentoHorarios.Controls.Add(this.tbLancamentoHoras, 0, 1);
            this.tlpLancamentoHorarios.Controls.Add(this.gbRealizaPesquisa, 0, 0);
            this.tlpLancamentoHorarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLancamentoHorarios.Location = new System.Drawing.Point(0, 0);
            this.tlpLancamentoHorarios.Name = "tlpLancamentoHorarios";
            this.tlpLancamentoHorarios.RowCount = 3;
            this.tlpLancamentoHorarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpLancamentoHorarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpLancamentoHorarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpLancamentoHorarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLancamentoHorarios.Size = new System.Drawing.Size(875, 465);
            this.tlpLancamentoHorarios.TabIndex = 0;
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
            this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem,
            this.bindingNavigatorDeleteItem,
            this.tsbEditar,
            this.tsbBloquear,
            this.toolStripSeparator1,
            this.tsbEnviar,
            this.tsbBaixar,
            this.toolStripSeparator2,
            this.tsbImprimirApontamentoHoras});
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
            // lANCAMENTO_HORARIOSBindingNavigatorSaveItem
            // 
            this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lANCAMENTO_HORARIOSBindingNavigatorSaveItem.Image")));
            this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem.Name = "lANCAMENTO_HORARIOSBindingNavigatorSaveItem";
            this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(52, 90);
            this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.lANCAMENTO_HORARIOSBindingNavigatorSaveItem_Click);
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
            this.tpCapaLancamento.Controls.Add(nomeDesenvolvedorLabel);
            this.tpCapaLancamento.Controls.Add(this.nomeDesenvolvedorTextBox);
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
            // nomeDesenvolvedorTextBox
            // 
            this.nomeDesenvolvedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lANCAMENTO_HORARIOSBindingSource, "nomeDesenvolvedor", true));
            this.nomeDesenvolvedorTextBox.Location = new System.Drawing.Point(10, 76);
            this.nomeDesenvolvedorTextBox.Name = "nomeDesenvolvedorTextBox";
            this.nomeDesenvolvedorTextBox.Size = new System.Drawing.Size(617, 26);
            this.nomeDesenvolvedorTextBox.TabIndex = 15;
            // 
            // lancamentoHorarioIdTextBox
            // 
            this.lancamentoHorarioIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lANCAMENTO_HORARIOSBindingSource, "LancamentoHorarioId", true));
            this.lancamentoHorarioIdTextBox.Location = new System.Drawing.Point(10, 25);
            this.lancamentoHorarioIdTextBox.Name = "lancamentoHorarioIdTextBox";
            this.lancamentoHorarioIdTextBox.Size = new System.Drawing.Size(152, 26);
            this.lancamentoHorarioIdTextBox.TabIndex = 1;
            // 
            // dataLancamentoDateTimePicker
            // 
            this.dataLancamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lANCAMENTO_HORARIOSBindingSource, "DataLancamento", true));
            this.dataLancamentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataLancamentoDateTimePicker.Location = new System.Drawing.Point(633, 76);
            this.dataLancamentoDateTimePicker.Name = "dataLancamentoDateTimePicker";
            this.dataLancamentoDateTimePicker.Size = new System.Drawing.Size(145, 26);
            this.dataLancamentoDateTimePicker.TabIndex = 3;
            // 
            // tipoLancamentoComboBox
            // 
            this.tipoLancamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lANCAMENTO_HORARIOSBindingSource, "TipoLancamento", true));
            this.tipoLancamentoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoLancamentoComboBox.FormattingEnabled = true;
            this.tipoLancamentoComboBox.Items.AddRange(new object[] {
            "",
            "Análise de código",
            "Análise de sistemas",
            "Análise de testes",
            "Apoio interno",
            "Configuração ambiente",
            "Documentação",
            "Horas de indisponibilidade",
            "Outros",
            "Reunião",
            "Programação"});
            this.tipoLancamentoComboBox.Location = new System.Drawing.Point(508, 25);
            this.tipoLancamentoComboBox.Name = "tipoLancamentoComboBox";
            this.tipoLancamentoComboBox.Size = new System.Drawing.Size(345, 26);
            this.tipoLancamentoComboBox.TabIndex = 5;
            // 
            // numeroEvidenciaTextBox
            // 
            this.numeroEvidenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lANCAMENTO_HORARIOSBindingSource, "NumeroEvidencia", true));
            this.numeroEvidenciaTextBox.Location = new System.Drawing.Point(172, 25);
            this.numeroEvidenciaTextBox.Name = "numeroEvidenciaTextBox";
            this.numeroEvidenciaTextBox.Size = new System.Drawing.Size(151, 26);
            this.numeroEvidenciaTextBox.TabIndex = 7;
            // 
            // clienteLancamentoTextBox
            // 
            this.clienteLancamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lANCAMENTO_HORARIOSBindingSource, "ClienteLancamento", true));
            this.clienteLancamentoTextBox.Location = new System.Drawing.Point(329, 25);
            this.clienteLancamentoTextBox.Name = "clienteLancamentoTextBox";
            this.clienteLancamentoTextBox.Size = new System.Drawing.Size(173, 26);
            this.clienteLancamentoTextBox.TabIndex = 9;
            // 
            // observacaoLancamentoTextBox
            // 
            this.observacaoLancamentoTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.observacaoLancamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lANCAMENTO_HORARIOSBindingSource, "ObservacaoLancamento", true));
            this.observacaoLancamentoTextBox.Location = new System.Drawing.Point(10, 127);
            this.observacaoLancamentoTextBox.Multiline = true;
            this.observacaoLancamentoTextBox.Name = "observacaoLancamentoTextBox";
            this.observacaoLancamentoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacaoLancamentoTextBox.Size = new System.Drawing.Size(843, 106);
            this.observacaoLancamentoTextBox.TabIndex = 11;
            // 
            // horasLancamentoDateTimePicker
            // 
            this.horasLancamentoDateTimePicker.CustomFormat = "HH:mm";
            this.horasLancamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lANCAMENTO_HORARIOSBindingSource, "HorasLancamento", true));
            this.horasLancamentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horasLancamentoDateTimePicker.Location = new System.Drawing.Point(784, 76);
            this.horasLancamentoDateTimePicker.Name = "horasLancamentoDateTimePicker";
            this.horasLancamentoDateTimePicker.Size = new System.Drawing.Size(69, 26);
            this.horasLancamentoDateTimePicker.TabIndex = 13;
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
            this.nomeDesenvolvedor,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.lANCAMENTO_HORARIOSDataGridView.DataSource = this.lANCAMENTO_HORARIOSBindingSource;
            this.lANCAMENTO_HORARIOSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lANCAMENTO_HORARIOSDataGridView.Location = new System.Drawing.Point(3, 3);
            this.lANCAMENTO_HORARIOSDataGridView.Name = "lANCAMENTO_HORARIOSDataGridView";
            this.lANCAMENTO_HORARIOSDataGridView.ReadOnly = true;
            this.lANCAMENTO_HORARIOSDataGridView.Size = new System.Drawing.Size(853, 238);
            this.lANCAMENTO_HORARIOSDataGridView.TabIndex = 0;
            // 
            // nomeDesenvolvedor
            // 
            this.nomeDesenvolvedor.DataPropertyName = "nomeDesenvolvedor";
            this.nomeDesenvolvedor.HeaderText = "Nome do Desenvolvedor";
            this.nomeDesenvolvedor.Name = "nomeDesenvolvedor";
            this.nomeDesenvolvedor.ReadOnly = true;
            this.nomeDesenvolvedor.Width = 300;
            // 
            // gbRealizaPesquisa
            // 
            this.gbRealizaPesquisa.Controls.Add(this.mkdtxtDataLancamento);
            this.gbRealizaPesquisa.Controls.Add(this.btnPesquisarLancamentos);
            this.gbRealizaPesquisa.Controls.Add(this.rbPesquisaData);
            this.gbRealizaPesquisa.Controls.Add(this.rbPesquisaTipo);
            this.gbRealizaPesquisa.Controls.Add(this.rbPesquisaNome);
            this.gbRealizaPesquisa.Controls.Add(this.txtPesquisaHorarios);
            this.gbRealizaPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRealizaPesquisa.Location = new System.Drawing.Point(4, 4);
            this.gbRealizaPesquisa.Name = "gbRealizaPesquisa";
            this.gbRealizaPesquisa.Size = new System.Drawing.Size(867, 86);
            this.gbRealizaPesquisa.TabIndex = 2;
            this.gbRealizaPesquisa.TabStop = false;
            this.gbRealizaPesquisa.Text = "Para realizar a pesquisa";
            // 
            // btnPesquisarLancamentos
            // 
            this.btnPesquisarLancamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarLancamentos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarLancamentos.Location = new System.Drawing.Point(747, 25);
            this.btnPesquisarLancamentos.Name = "btnPesquisarLancamentos";
            this.btnPesquisarLancamentos.Size = new System.Drawing.Size(114, 55);
            this.btnPesquisarLancamentos.TabIndex = 10;
            this.btnPesquisarLancamentos.Text = "Pesquisar";
            this.btnPesquisarLancamentos.UseVisualStyleBackColor = true;
            this.btnPesquisarLancamentos.Click += new System.EventHandler(this.btnPesquisarLancamentos_Click);
            // 
            // rbPesquisaData
            // 
            this.rbPesquisaData.AutoSize = true;
            this.rbPesquisaData.Location = new System.Drawing.Point(230, 41);
            this.rbPesquisaData.Name = "rbPesquisaData";
            this.rbPesquisaData.Size = new System.Drawing.Size(84, 22);
            this.rbPesquisaData.TabIndex = 9;
            this.rbPesquisaData.TabStop = true;
            this.rbPesquisaData.Text = "por data";
            this.rbPesquisaData.UseVisualStyleBackColor = true;
            this.rbPesquisaData.CheckedChanged += new System.EventHandler(this.rbPesquisaData_CheckedChanged);
            // 
            // rbPesquisaTipo
            // 
            this.rbPesquisaTipo.AutoSize = true;
            this.rbPesquisaTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPesquisaTipo.Location = new System.Drawing.Point(127, 41);
            this.rbPesquisaTipo.Name = "rbPesquisaTipo";
            this.rbPesquisaTipo.Size = new System.Drawing.Size(79, 22);
            this.rbPesquisaTipo.TabIndex = 8;
            this.rbPesquisaTipo.TabStop = true;
            this.rbPesquisaTipo.Text = "por tipo";
            this.rbPesquisaTipo.UseVisualStyleBackColor = true;
            this.rbPesquisaTipo.CheckedChanged += new System.EventHandler(this.rbPesquisaTipo_CheckedChanged);
            // 
            // rbPesquisaNome
            // 
            this.rbPesquisaNome.AutoSize = true;
            this.rbPesquisaNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPesquisaNome.Location = new System.Drawing.Point(6, 41);
            this.rbPesquisaNome.Name = "rbPesquisaNome";
            this.rbPesquisaNome.Size = new System.Drawing.Size(92, 22);
            this.rbPesquisaNome.TabIndex = 7;
            this.rbPesquisaNome.TabStop = true;
            this.rbPesquisaNome.Text = "por nome";
            this.rbPesquisaNome.UseVisualStyleBackColor = true;
            this.rbPesquisaNome.CheckedChanged += new System.EventHandler(this.rbPesquisaNome_CheckedChanged);
            // 
            // txtPesquisaHorarios
            // 
            this.txtPesquisaHorarios.Location = new System.Drawing.Point(426, 40);
            this.txtPesquisaHorarios.Name = "txtPesquisaHorarios";
            this.txtPesquisaHorarios.Size = new System.Drawing.Size(315, 26);
            this.txtPesquisaHorarios.TabIndex = 6;
            // 
            // mkdtxtDataLancamento
            // 
            this.mkdtxtDataLancamento.Location = new System.Drawing.Point(320, 40);
            this.mkdtxtDataLancamento.Mask = "00/00/0000";
            this.mkdtxtDataLancamento.Name = "mkdtxtDataLancamento";
            this.mkdtxtDataLancamento.Size = new System.Drawing.Size(100, 26);
            this.mkdtxtDataLancamento.TabIndex = 11;
            this.mkdtxtDataLancamento.ValidatingType = typeof(System.DateTime);
            // 
            // lANCAMENTO_HORARIOSBindingSource
            // 
            this.lANCAMENTO_HORARIOSBindingSource.DataMember = "LANCAMENTO_HORARIOS";
            this.lANCAMENTO_HORARIOSBindingSource.DataSource = this.sISCONPROJECTSDataSet;
            // 
            // sISCONPROJECTSDataSet
            // 
            this.sISCONPROJECTSDataSet.DataSetName = "SISCONPROJECTSDataSet";
            this.sISCONPROJECTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn7.HeaderText = "Horas Lançamento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 180;
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
            this.tableAdapterManager.USUARIOS_SENHASTableAdapter = null;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 93);
            // 
            // tsbImprimirApontamentoHoras
            // 
            this.tsbImprimirApontamentoHoras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImprimirApontamentoHoras.Image = ((System.Drawing.Image)(resources.GetObject("tsbImprimirApontamentoHoras.Image")));
            this.tsbImprimirApontamentoHoras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbImprimirApontamentoHoras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImprimirApontamentoHoras.Name = "tsbImprimirApontamentoHoras";
            this.tsbImprimirApontamentoHoras.Size = new System.Drawing.Size(52, 90);
            this.tsbImprimirApontamentoHoras.Text = "Imprimir Apontamento de Horas";
            this.tsbImprimirApontamentoHoras.Click += new System.EventHandler(this.tsbImprimirApontamentoHoras_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.lANCAMENTO_HORARIOSBindingNavigator)).EndInit();
            this.lANCAMENTO_HORARIOSBindingNavigator.ResumeLayout(false);
            this.lANCAMENTO_HORARIOSBindingNavigator.PerformLayout();
            this.tbLancamentoHoras.ResumeLayout(false);
            this.tpCapaLancamento.ResumeLayout(false);
            this.tpCapaLancamento.PerformLayout();
            this.tpDetalhesHoras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lANCAMENTO_HORARIOSDataGridView)).EndInit();
            this.gbRealizaPesquisa.ResumeLayout(false);
            this.gbRealizaPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lANCAMENTO_HORARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONPROJECTSDataSet)).EndInit();
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
        private System.Windows.Forms.TextBox lancamentoHorarioIdTextBox;
        private System.Windows.Forms.DateTimePicker dataLancamentoDateTimePicker;
        private System.Windows.Forms.ComboBox tipoLancamentoComboBox;
        private System.Windows.Forms.TextBox numeroEvidenciaTextBox;
        private System.Windows.Forms.TextBox clienteLancamentoTextBox;
        private System.Windows.Forms.TextBox observacaoLancamentoTextBox;
        private System.Windows.Forms.DateTimePicker horasLancamentoDateTimePicker;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbBloquear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbEnviar;
        private System.Windows.Forms.ToolStripButton tsbBaixar;
        private System.Windows.Forms.TextBox nomeDesenvolvedorTextBox;
        private System.Windows.Forms.GroupBox gbRealizaPesquisa;
        private System.Windows.Forms.Button btnPesquisarLancamentos;
        private System.Windows.Forms.RadioButton rbPesquisaData;
        private System.Windows.Forms.RadioButton rbPesquisaTipo;
        private System.Windows.Forms.RadioButton rbPesquisaNome;
        private System.Windows.Forms.TextBox txtPesquisaHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDesenvolvedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.MaskedTextBox mkdtxtDataLancamento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbImprimirApontamentoHoras;
    }
}