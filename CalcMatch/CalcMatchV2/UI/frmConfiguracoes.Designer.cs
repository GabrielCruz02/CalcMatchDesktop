namespace CalcMatchV1.UI.FormsFilho
{
    partial class frmConfiguracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracoes));
            this.pnlAviso = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptrAviso = new System.Windows.Forms.PictureBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.pnlAviso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAviso)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAviso
            // 
            this.pnlAviso.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAviso.Controls.Add(this.pictureBox1);
            this.pnlAviso.Controls.Add(this.ptrAviso);
            this.pnlAviso.Controls.Add(this.lblAviso);
            this.pnlAviso.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAviso.Location = new System.Drawing.Point(0, 0);
            this.pnlAviso.Name = "pnlAviso";
            this.pnlAviso.Size = new System.Drawing.Size(800, 451);
            this.pnlAviso.TabIndex = 1;
            this.pnlAviso.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAviso_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ptrAviso
            // 
            this.ptrAviso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptrAviso.Image = ((System.Drawing.Image)(resources.GetObject("ptrAviso.Image")));
            this.ptrAviso.Location = new System.Drawing.Point(556, 205);
            this.ptrAviso.Name = "ptrAviso";
            this.ptrAviso.Size = new System.Drawing.Size(100, 50);
            this.ptrAviso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrAviso.TabIndex = 1;
            this.ptrAviso.TabStop = false;
            // 
            // lblAviso
            // 
            this.lblAviso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAviso.Location = new System.Drawing.Point(252, 205);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(298, 40);
            this.lblAviso.TabIndex = 0;
            this.lblAviso.Text = "Está pagina está fora do ar no momento!\r\nContate o suporte da sua aplicação!";
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAviso);
            this.Name = "Configuracoes";
            this.Text = "Configurações";
            this.pnlAviso.ResumeLayout(false);
            this.pnlAviso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAviso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAviso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptrAviso;
        private System.Windows.Forms.Label lblAviso;
    }
}