namespace CalcMatchV1.UI.FormsFilho
{
    partial class frmApontamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApontamentos));
            statusStrip1 = new StatusStrip();
            pnlConteudoRelatorio = new Panel();
            btnFerias = new Button();
            btnApontamentoHoras = new Button();
            pnlConteudoRelatorio.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 497);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(933, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // pnlConteudoRelatorio
            // 
            pnlConteudoRelatorio.Controls.Add(btnFerias);
            pnlConteudoRelatorio.Controls.Add(btnApontamentoHoras);
            pnlConteudoRelatorio.Dock = DockStyle.Fill;
            pnlConteudoRelatorio.Location = new Point(0, 0);
            pnlConteudoRelatorio.Name = "pnlConteudoRelatorio";
            pnlConteudoRelatorio.Size = new Size(933, 497);
            pnlConteudoRelatorio.TabIndex = 1;
            // 
            // btnFerias
            // 
            btnFerias.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFerias.Image = (Image)resources.GetObject("btnFerias.Image");
            btnFerias.Location = new Point(578, 143);
            btnFerias.Name = "btnFerias";
            btnFerias.Size = new Size(170, 200);
            btnFerias.TabIndex = 1;
            btnFerias.Text = "Acompanhamento de ferias";
            btnFerias.TextAlign = ContentAlignment.BottomCenter;
            btnFerias.TextImageRelation = TextImageRelation.ImageAboveText;
            btnFerias.UseVisualStyleBackColor = true;
            btnFerias.Click += btnFerias_Click;
            // 
            // btnApontamentoHoras
            // 
            btnApontamentoHoras.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnApontamentoHoras.Image = (Image)resources.GetObject("btnApontamentoHoras.Image");
            btnApontamentoHoras.ImageAlign = ContentAlignment.BottomCenter;
            btnApontamentoHoras.Location = new Point(189, 143);
            btnApontamentoHoras.Name = "btnApontamentoHoras";
            btnApontamentoHoras.Size = new Size(170, 200);
            btnApontamentoHoras.TabIndex = 0;
            btnApontamentoHoras.Text = "Apontamento de \r\nhoras";
            btnApontamentoHoras.TextImageRelation = TextImageRelation.ImageAboveText;
            btnApontamentoHoras.UseVisualStyleBackColor = true;
            btnApontamentoHoras.Click += btnApontamentoHoras_Click;
            // 
            // frmDashboardFolha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(pnlConteudoRelatorio);
            Controls.Add(statusStrip1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDashboardFolha";
            Text = "Relatorio";
            pnlConteudoRelatorio.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private Panel pnlConteudoRelatorio;
        private Button btnFerias;
        private Button btnApontamentoHoras;
    }
}