namespace sisconGestão
{
    partial class frmAguarde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAguarde));
            this.pbxAguarde = new System.Windows.Forms.PictureBox();
            this.pbAguarde = new System.Windows.Forms.ProgressBar();
            this.lblAguarde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAguarde)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxAguarde
            // 
            this.pbxAguarde.Image = global::sisconGestão.Properties.Resources.aguarde;
            this.pbxAguarde.Location = new System.Drawing.Point(518, 12);
            this.pbxAguarde.Name = "pbxAguarde";
            this.pbxAguarde.Size = new System.Drawing.Size(108, 95);
            this.pbxAguarde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAguarde.TabIndex = 0;
            this.pbxAguarde.TabStop = false;
            // 
            // pbAguarde
            // 
            this.pbAguarde.Location = new System.Drawing.Point(0, 113);
            this.pbAguarde.Name = "pbAguarde";
            this.pbAguarde.Size = new System.Drawing.Size(639, 23);
            this.pbAguarde.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbAguarde.TabIndex = 2;
            // 
            // lblAguarde
            // 
            this.lblAguarde.AutoSize = true;
            this.lblAguarde.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAguarde.ForeColor = System.Drawing.Color.Black;
            this.lblAguarde.Location = new System.Drawing.Point(193, 48);
            this.lblAguarde.Name = "lblAguarde";
            this.lblAguarde.Size = new System.Drawing.Size(215, 24);
            this.lblAguarde.TabIndex = 3;
            this.lblAguarde.Text = "Por favor, aguarde...";
            this.lblAguarde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAguarde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 135);
            this.Controls.Add(this.lblAguarde);
            this.Controls.Add(this.pbAguarde);
            this.Controls.Add(this.pbxAguarde);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAguarde";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aguarde";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAguarde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxAguarde;
        private System.Windows.Forms.ProgressBar pbAguarde;
        private System.Windows.Forms.Label lblAguarde;
    }
}