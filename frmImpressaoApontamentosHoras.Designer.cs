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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImpressaoApontamentosHoras));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rpvApontamentosHoras = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbPesquisaDatas = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.rpvApontamentosHoras.LocalReport.ReportEmbeddedResource = "sisconGestão.ImprenssaoApontamentoHoras.rdlc";
            this.rpvApontamentosHoras.Location = new System.Drawing.Point(4, 105);
            this.rpvApontamentosHoras.Name = "rpvApontamentosHoras";
            this.rpvApontamentosHoras.ServerReport.BearerToken = null;
            this.rpvApontamentosHoras.Size = new System.Drawing.Size(758, 395);
            this.rpvApontamentosHoras.TabIndex = 0;
            // 
            // gbPesquisaDatas
            // 
            this.gbPesquisaDatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPesquisaDatas.Location = new System.Drawing.Point(4, 4);
            this.gbPesquisaDatas.Name = "gbPesquisaDatas";
            this.gbPesquisaDatas.Size = new System.Drawing.Size(758, 94);
            this.gbPesquisaDatas.TabIndex = 1;
            this.gbPesquisaDatas.TabStop = false;
            this.gbPesquisaDatas.Text = "Pequise o intervalo entre datas";
            // 
            // frmImpressaoApontamentosHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 504);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmImpressaoApontamentosHoras";
            this.Text = "Relatório de Apontamento de Horas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmImpressaoApontamentosHoras_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvApontamentosHoras;
        private System.Windows.Forms.GroupBox gbPesquisaDatas;
    }
}