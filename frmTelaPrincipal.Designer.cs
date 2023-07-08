namespace sisconGestão
{
    partial class frmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.tlpTelaPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnLancamentoHoras = new System.Windows.Forms.Button();
            this.btnEvidencias = new System.Windows.Forms.Button();
            this.btnDocsGerais = new System.Windows.Forms.Button();
            this.gbDadosTelaPrincipal = new System.Windows.Forms.GroupBox();
            this.tlpSejaBemVindo = new System.Windows.Forms.TableLayoutPanel();
            this.pbSejaBemVindo = new System.Windows.Forms.PictureBox();
            this.lblHoraDia = new System.Windows.Forms.Label();
            this.lblLogadoComo = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.tlpTelaPrincipal.SuspendLayout();
            this.tlpBotoes.SuspendLayout();
            this.gbDadosTelaPrincipal.SuspendLayout();
            this.tlpSejaBemVindo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSejaBemVindo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpTelaPrincipal
            // 
            this.tlpTelaPrincipal.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpTelaPrincipal.ColumnCount = 1;
            this.tlpTelaPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTelaPrincipal.Controls.Add(this.tlpBotoes, 0, 1);
            this.tlpTelaPrincipal.Controls.Add(this.gbDadosTelaPrincipal, 0, 0);
            this.tlpTelaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTelaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpTelaPrincipal.Name = "tlpTelaPrincipal";
            this.tlpTelaPrincipal.RowCount = 2;
            this.tlpTelaPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTelaPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpTelaPrincipal.Size = new System.Drawing.Size(1284, 737);
            this.tlpTelaPrincipal.TabIndex = 0;
            // 
            // tlpBotoes
            // 
            this.tlpBotoes.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpBotoes.ColumnCount = 3;
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpBotoes.Controls.Add(this.btnLancamentoHoras, 2, 0);
            this.tlpBotoes.Controls.Add(this.btnEvidencias, 1, 0);
            this.tlpBotoes.Controls.Add(this.btnDocsGerais, 0, 0);
            this.tlpBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotoes.Location = new System.Drawing.Point(4, 188);
            this.tlpBotoes.Name = "tlpBotoes";
            this.tlpBotoes.RowCount = 1;
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotoes.Size = new System.Drawing.Size(1276, 545);
            this.tlpBotoes.TabIndex = 0;
            // 
            // btnLancamentoHoras
            // 
            this.btnLancamentoHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLancamentoHoras.BackColor = System.Drawing.Color.LightGray;
            this.btnLancamentoHoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLancamentoHoras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLancamentoHoras.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancamentoHoras.ForeColor = System.Drawing.Color.DimGray;
            this.btnLancamentoHoras.Image = global::sisconGestão.Properties.Resources.lancarHoras;
            this.btnLancamentoHoras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLancamentoHoras.Location = new System.Drawing.Point(852, 150);
            this.btnLancamentoHoras.Name = "btnLancamentoHoras";
            this.btnLancamentoHoras.Size = new System.Drawing.Size(420, 244);
            this.btnLancamentoHoras.TabIndex = 2;
            this.btnLancamentoHoras.Text = "Lançamento de Horas";
            this.btnLancamentoHoras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLancamentoHoras.UseVisualStyleBackColor = false;
            this.btnLancamentoHoras.Click += new System.EventHandler(this.btnLancamentoHoras_Click);
            // 
            // btnEvidencias
            // 
            this.btnEvidencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEvidencias.BackColor = System.Drawing.Color.LightGray;
            this.btnEvidencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvidencias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEvidencias.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvidencias.ForeColor = System.Drawing.Color.DimGray;
            this.btnEvidencias.Image = global::sisconGestão.Properties.Resources.evidencias;
            this.btnEvidencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvidencias.Location = new System.Drawing.Point(428, 150);
            this.btnEvidencias.Name = "btnEvidencias";
            this.btnEvidencias.Size = new System.Drawing.Size(417, 244);
            this.btnEvidencias.TabIndex = 1;
            this.btnEvidencias.Text = "Evidências";
            this.btnEvidencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEvidencias.UseVisualStyleBackColor = false;
            this.btnEvidencias.Click += new System.EventHandler(this.btnEvidencias_Click);
            // 
            // btnDocsGerais
            // 
            this.btnDocsGerais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDocsGerais.BackColor = System.Drawing.Color.LightGray;
            this.btnDocsGerais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocsGerais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDocsGerais.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocsGerais.ForeColor = System.Drawing.Color.DimGray;
            this.btnDocsGerais.Image = global::sisconGestão.Properties.Resources.documentosGerais;
            this.btnDocsGerais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocsGerais.Location = new System.Drawing.Point(4, 150);
            this.btnDocsGerais.Name = "btnDocsGerais";
            this.btnDocsGerais.Size = new System.Drawing.Size(417, 244);
            this.btnDocsGerais.TabIndex = 0;
            this.btnDocsGerais.Text = "Documentos Gerais";
            this.btnDocsGerais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDocsGerais.UseVisualStyleBackColor = false;
            this.btnDocsGerais.Click += new System.EventHandler(this.btnDocsGerais_Click);
            // 
            // gbDadosTelaPrincipal
            // 
            this.gbDadosTelaPrincipal.Controls.Add(this.tlpSejaBemVindo);
            this.gbDadosTelaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDadosTelaPrincipal.ForeColor = System.Drawing.Color.Silver;
            this.gbDadosTelaPrincipal.Location = new System.Drawing.Point(4, 4);
            this.gbDadosTelaPrincipal.Name = "gbDadosTelaPrincipal";
            this.gbDadosTelaPrincipal.Size = new System.Drawing.Size(1276, 177);
            this.gbDadosTelaPrincipal.TabIndex = 1;
            this.gbDadosTelaPrincipal.TabStop = false;
            this.gbDadosTelaPrincipal.Text = "Seja bem-vindo ao SISCON PROJECTS!";
            // 
            // tlpSejaBemVindo
            // 
            this.tlpSejaBemVindo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpSejaBemVindo.ColumnCount = 3;
            this.tlpSejaBemVindo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpSejaBemVindo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpSejaBemVindo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpSejaBemVindo.Controls.Add(this.lblLogadoComo, 0, 0);
            this.tlpSejaBemVindo.Controls.Add(this.pbSejaBemVindo, 1, 0);
            this.tlpSejaBemVindo.Controls.Add(this.lblHoraDia, 2, 0);
            this.tlpSejaBemVindo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSejaBemVindo.Location = new System.Drawing.Point(3, 22);
            this.tlpSejaBemVindo.Name = "tlpSejaBemVindo";
            this.tlpSejaBemVindo.RowCount = 1;
            this.tlpSejaBemVindo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSejaBemVindo.Size = new System.Drawing.Size(1270, 152);
            this.tlpSejaBemVindo.TabIndex = 0;
            // 
            // pbSejaBemVindo
            // 
            this.pbSejaBemVindo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSejaBemVindo.Image = global::sisconGestão.Properties.Resources.sisconImage;
            this.pbSejaBemVindo.Location = new System.Drawing.Point(426, 4);
            this.pbSejaBemVindo.Name = "pbSejaBemVindo";
            this.pbSejaBemVindo.Size = new System.Drawing.Size(415, 144);
            this.pbSejaBemVindo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSejaBemVindo.TabIndex = 0;
            this.pbSejaBemVindo.TabStop = false;
            // 
            // lblHoraDia
            // 
            this.lblHoraDia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoraDia.AutoSize = true;
            this.lblHoraDia.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraDia.ForeColor = System.Drawing.Color.White;
            this.lblHoraDia.Location = new System.Drawing.Point(848, 1);
            this.lblHoraDia.Name = "lblHoraDia";
            this.lblHoraDia.Size = new System.Drawing.Size(418, 150);
            this.lblHoraDia.TabIndex = 1;
            this.lblHoraDia.Text = "label2";
            this.lblHoraDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogadoComo
            // 
            this.lblLogadoComo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogadoComo.AutoSize = true;
            this.lblLogadoComo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogadoComo.ForeColor = System.Drawing.Color.White;
            this.lblLogadoComo.Location = new System.Drawing.Point(4, 1);
            this.lblLogadoComo.Name = "lblLogadoComo";
            this.lblLogadoComo.Size = new System.Drawing.Size(415, 150);
            this.lblLogadoComo.TabIndex = 2;
            this.lblLogadoComo.Text = "label1";
            this.lblLogadoComo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1284, 737);
            this.Controls.Add(this.tlpTelaPrincipal);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISCON PROJECTS - Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTelaPrincipal_FormClosing);
            this.tlpTelaPrincipal.ResumeLayout(false);
            this.tlpBotoes.ResumeLayout(false);
            this.gbDadosTelaPrincipal.ResumeLayout(false);
            this.tlpSejaBemVindo.ResumeLayout(false);
            this.tlpSejaBemVindo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSejaBemVindo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTelaPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpBotoes;
        private System.Windows.Forms.Button btnLancamentoHoras;
        private System.Windows.Forms.Button btnEvidencias;
        private System.Windows.Forms.Button btnDocsGerais;
        private System.Windows.Forms.GroupBox gbDadosTelaPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpSejaBemVindo;
        private System.Windows.Forms.PictureBox pbSejaBemVindo;
        private System.Windows.Forms.Label lblHoraDia;
        private System.Windows.Forms.Label lblLogadoComo;
        private System.Windows.Forms.Timer Timer;
    }
}