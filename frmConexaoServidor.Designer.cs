namespace sisconGestão
{
    partial class frmConexaoServidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConexaoServidor));
            this.gbConexaoServidor = new System.Windows.Forms.GroupBox();
            this.txtConexaoServidor = new System.Windows.Forms.TextBox();
            this.btnSalvarConexao = new System.Windows.Forms.Button();
            this.btnLimparConexao = new System.Windows.Forms.Button();
            this.gbConexaoServidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConexaoServidor
            // 
            this.gbConexaoServidor.Controls.Add(this.btnLimparConexao);
            this.gbConexaoServidor.Controls.Add(this.btnSalvarConexao);
            this.gbConexaoServidor.Controls.Add(this.txtConexaoServidor);
            this.gbConexaoServidor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbConexaoServidor.Location = new System.Drawing.Point(0, 0);
            this.gbConexaoServidor.Name = "gbConexaoServidor";
            this.gbConexaoServidor.Size = new System.Drawing.Size(713, 135);
            this.gbConexaoServidor.TabIndex = 0;
            this.gbConexaoServidor.TabStop = false;
            this.gbConexaoServidor.Text = "Escreva a Connection String no campo abaixo, sem as ASPAS (\"\") e clique no botão " +
    "Salvar";
            // 
            // txtConexaoServidor
            // 
            this.txtConexaoServidor.Location = new System.Drawing.Point(6, 42);
            this.txtConexaoServidor.Name = "txtConexaoServidor";
            this.txtConexaoServidor.Size = new System.Drawing.Size(701, 26);
            this.txtConexaoServidor.TabIndex = 0;
            // 
            // btnSalvarConexao
            // 
            this.btnSalvarConexao.BackColor = System.Drawing.Color.MintCream;
            this.btnSalvarConexao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarConexao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarConexao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarConexao.Location = new System.Drawing.Point(505, 74);
            this.btnSalvarConexao.Name = "btnSalvarConexao";
            this.btnSalvarConexao.Size = new System.Drawing.Size(98, 42);
            this.btnSalvarConexao.TabIndex = 1;
            this.btnSalvarConexao.Text = "Salvar";
            this.btnSalvarConexao.UseVisualStyleBackColor = false;
            this.btnSalvarConexao.Click += new System.EventHandler(this.btnSalvarConexao_Click);
            // 
            // btnLimparConexao
            // 
            this.btnLimparConexao.BackColor = System.Drawing.Color.MistyRose;
            this.btnLimparConexao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparConexao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparConexao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparConexao.Location = new System.Drawing.Point(609, 74);
            this.btnLimparConexao.Name = "btnLimparConexao";
            this.btnLimparConexao.Size = new System.Drawing.Size(98, 42);
            this.btnLimparConexao.TabIndex = 2;
            this.btnLimparConexao.Text = "Limpar";
            this.btnLimparConexao.UseVisualStyleBackColor = false;
            this.btnLimparConexao.Click += new System.EventHandler(this.btnLimparConexao_Click);
            // 
            // frmConexaoServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 135);
            this.Controls.Add(this.gbConexaoServidor);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConexaoServidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISCON PROJECTS - Conexão com o Servidor";
            this.gbConexaoServidor.ResumeLayout(false);
            this.gbConexaoServidor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConexaoServidor;
        private System.Windows.Forms.Button btnLimparConexao;
        private System.Windows.Forms.Button btnSalvarConexao;
        private System.Windows.Forms.TextBox txtConexaoServidor;
    }
}