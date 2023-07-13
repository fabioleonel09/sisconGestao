namespace sisconGestão
{
    partial class frmImpressaoApontamentosHoras
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImpressaoApontamentosHoras));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rpvApontamentosHoras = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbPesquisaDatas = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblAte = new System.Windows.Forms.Label();
            this.mkdtxtAte = new System.Windows.Forms.MaskedTextBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblNomedesenvolvedor = new System.Windows.Forms.Label();
            this.mkdtxtDe = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeDesenvolvedor = new System.Windows.Forms.TextBox();
            this.sISCONPROJECTSDataSet = new sisconGestão.SISCONPROJECTSDataSet();
            this.sISCONPROJECTSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lANCAMENTOHORARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lANCAMENTO_HORARIOSTableAdapter = new sisconGestão.SISCONPROJECTSDataSetTableAdapters.LANCAMENTO_HORARIOSTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbPesquisaDatas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONPROJECTSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONPROJECTSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANCAMENTOHORARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.rpvApontamentosHoras, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbPesquisaDatas, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 504);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rpvApontamentosHoras
            // 
            this.rpvApontamentosHoras.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.lANCAMENTOHORARIOSBindingSource;
            this.rpvApontamentosHoras.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvApontamentosHoras.LocalReport.ReportEmbeddedResource = "sisconGestão.ImprenssaoApontamentoHoras.rdlc";
            this.rpvApontamentosHoras.Location = new System.Drawing.Point(4, 105);
            this.rpvApontamentosHoras.Name = "rpvApontamentosHoras";
            this.rpvApontamentosHoras.ServerReport.BearerToken = null;
            this.rpvApontamentosHoras.Size = new System.Drawing.Size(758, 395);
            this.rpvApontamentosHoras.TabIndex = 0;
            // 
            // gbPesquisaDatas
            // 
            this.gbPesquisaDatas.Controls.Add(this.btnPesquisar);
            this.gbPesquisaDatas.Controls.Add(this.lblAte);
            this.gbPesquisaDatas.Controls.Add(this.mkdtxtAte);
            this.gbPesquisaDatas.Controls.Add(this.lblDe);
            this.gbPesquisaDatas.Controls.Add(this.lblNomedesenvolvedor);
            this.gbPesquisaDatas.Controls.Add(this.mkdtxtDe);
            this.gbPesquisaDatas.Controls.Add(this.txtNomeDesenvolvedor);
            this.gbPesquisaDatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPesquisaDatas.Location = new System.Drawing.Point(4, 4);
            this.gbPesquisaDatas.Name = "gbPesquisaDatas";
            this.gbPesquisaDatas.Size = new System.Drawing.Size(758, 94);
            this.gbPesquisaDatas.TabIndex = 1;
            this.gbPesquisaDatas.TabStop = false;
            this.gbPesquisaDatas.Text = "Pequise o intervalo entre datas";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(559, 41);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(103, 47);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAte.Location = new System.Drawing.Point(449, 41);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(40, 19);
            this.lblAte.TabIndex = 5;
            this.lblAte.Text = "Até:";
            // 
            // mkdtxtAte
            // 
            this.mkdtxtAte.Location = new System.Drawing.Point(452, 62);
            this.mkdtxtAte.Mask = "00/00/0000";
            this.mkdtxtAte.Name = "mkdtxtAte";
            this.mkdtxtAte.Size = new System.Drawing.Size(100, 26);
            this.mkdtxtAte.TabIndex = 4;
            this.mkdtxtAte.ValidatingType = typeof(System.DateTime);
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(343, 41);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(36, 19);
            this.lblDe.TabIndex = 3;
            this.lblDe.Text = "De:";
            // 
            // lblNomedesenvolvedor
            // 
            this.lblNomedesenvolvedor.AutoSize = true;
            this.lblNomedesenvolvedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomedesenvolvedor.Location = new System.Drawing.Point(79, 41);
            this.lblNomedesenvolvedor.Name = "lblNomedesenvolvedor";
            this.lblNomedesenvolvedor.Size = new System.Drawing.Size(202, 19);
            this.lblNomedesenvolvedor.TabIndex = 2;
            this.lblNomedesenvolvedor.Text = "Nome do desenvolvedor:";
            // 
            // mkdtxtDe
            // 
            this.mkdtxtDe.Location = new System.Drawing.Point(346, 62);
            this.mkdtxtDe.Mask = "00/00/0000";
            this.mkdtxtDe.Name = "mkdtxtDe";
            this.mkdtxtDe.Size = new System.Drawing.Size(100, 26);
            this.mkdtxtDe.TabIndex = 1;
            this.mkdtxtDe.ValidatingType = typeof(System.DateTime);
            // 
            // txtNomeDesenvolvedor
            // 
            this.txtNomeDesenvolvedor.Enabled = false;
            this.txtNomeDesenvolvedor.Location = new System.Drawing.Point(81, 62);
            this.txtNomeDesenvolvedor.Name = "txtNomeDesenvolvedor";
            this.txtNomeDesenvolvedor.Size = new System.Drawing.Size(258, 26);
            this.txtNomeDesenvolvedor.TabIndex = 0;
            // 
            // sISCONPROJECTSDataSet
            // 
            this.sISCONPROJECTSDataSet.DataSetName = "SISCONPROJECTSDataSet";
            this.sISCONPROJECTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sISCONPROJECTSDataSetBindingSource
            // 
            this.sISCONPROJECTSDataSetBindingSource.DataSource = this.sISCONPROJECTSDataSet;
            this.sISCONPROJECTSDataSetBindingSource.Position = 0;
            // 
            // lANCAMENTOHORARIOSBindingSource
            // 
            this.lANCAMENTOHORARIOSBindingSource.DataMember = "LANCAMENTO_HORARIOS";
            this.lANCAMENTOHORARIOSBindingSource.DataSource = this.sISCONPROJECTSDataSetBindingSource;
            // 
            // lANCAMENTO_HORARIOSTableAdapter
            // 
            this.lANCAMENTO_HORARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // frmImpressaoApontamentosHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 504);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmImpressaoApontamentosHoras";
            this.Text = "Relatório de Apontamento de Horas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmImpressaoApontamentosHoras_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbPesquisaDatas.ResumeLayout(false);
            this.gbPesquisaDatas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONPROJECTSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONPROJECTSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANCAMENTOHORARIOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvApontamentosHoras;
        private System.Windows.Forms.GroupBox gbPesquisaDatas;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblNomedesenvolvedor;
        private System.Windows.Forms.MaskedTextBox mkdtxtDe;
        private System.Windows.Forms.TextBox txtNomeDesenvolvedor;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.MaskedTextBox mkdtxtAte;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.BindingSource sISCONPROJECTSDataSetBindingSource;
        private SISCONPROJECTSDataSet sISCONPROJECTSDataSet;
        private System.Windows.Forms.BindingSource lANCAMENTOHORARIOSBindingSource;
        private SISCONPROJECTSDataSetTableAdapters.LANCAMENTO_HORARIOSTableAdapter lANCAMENTO_HORARIOSTableAdapter;
    }
}