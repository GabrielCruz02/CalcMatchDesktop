namespace CalcMatchV2.UI
{
    partial class frmAcompanhamentoFerias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcompanhamentoFerias));
            toolStrip2 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            pnlTituloFerias = new Panel();
            lblTitulo = new Label();
            toolStrip1 = new ToolStrip();
            salvarToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnCancelar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            pnlConteudoFerias = new Panel();
            pictureBox1 = new PictureBox();
            lblTerminoFerias = new Label();
            lblInicoFerias = new Label();
            dtpTerminoFerias = new DateTimePicker();
            txtTerminoPeriodoAquisitivo = new TextBox();
            lblPeriodoAquisitivo = new Label();
            txtInicioPeriodoAquisitivo = new TextBox();
            dtpInicioFerias = new DateTimePicker();
            lblNomeColaborador = new Label();
            lblPeriodoFerias = new Label();
            lblCodigoColaborador = new Label();
            txtNomeColaborador = new TextBox();
            txtCodigoColaborador = new TextBox();
            toolStrip2.SuspendLayout();
            pnlTituloFerias.SuspendLayout();
            toolStrip1.SuspendLayout();
            pnlConteudoFerias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.Bottom;
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip2.Location = new Point(0, 289);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(674, 25);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(86, 22);
            toolStripLabel1.Text = "toolStripLabel1";
            // 
            // pnlTituloFerias
            // 
            pnlTituloFerias.BackColor = Color.FromArgb(157, 118, 193);
            pnlTituloFerias.Controls.Add(lblTitulo);
            pnlTituloFerias.Dock = DockStyle.Top;
            pnlTituloFerias.Location = new Point(0, 0);
            pnlTituloFerias.Name = "pnlTituloFerias";
            pnlTituloFerias.Size = new Size(674, 53);
            pnlTituloFerias.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(210, 9);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(256, 30);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Acompanhamento férias";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { salvarToolStripButton, toolStripSeparator2, btnCancelar, toolStripSeparator1, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 53);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(674, 25);
            toolStrip1.TabIndex = 46;
            toolStrip1.Text = "toolStrip1";
            // 
            // salvarToolStripButton
            // 
            salvarToolStripButton.Image = (Image)resources.GetObject("salvarToolStripButton.Image");
            salvarToolStripButton.ImageTransparentColor = Color.Magenta;
            salvarToolStripButton.Name = "salvarToolStripButton";
            salvarToolStripButton.Size = new Size(58, 22);
            salvarToolStripButton.Text = "&Salvar";
            salvarToolStripButton.Click += salvarToolStripButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageTransparentColor = Color.Magenta;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(73, 22);
            btnCancelar.Text = "&Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // ajudaToolStripButton
            // 
            ajudaToolStripButton.Image = (Image)resources.GetObject("ajudaToolStripButton.Image");
            ajudaToolStripButton.ImageTransparentColor = Color.Magenta;
            ajudaToolStripButton.Name = "ajudaToolStripButton";
            ajudaToolStripButton.Size = new Size(58, 22);
            ajudaToolStripButton.Text = "&Ajuda";
            // 
            // pnlConteudoFerias
            // 
            pnlConteudoFerias.BackColor = SystemColors.ControlLightLight;
            pnlConteudoFerias.Controls.Add(pictureBox1);
            pnlConteudoFerias.Controls.Add(lblTerminoFerias);
            pnlConteudoFerias.Controls.Add(lblInicoFerias);
            pnlConteudoFerias.Controls.Add(dtpTerminoFerias);
            pnlConteudoFerias.Controls.Add(txtTerminoPeriodoAquisitivo);
            pnlConteudoFerias.Controls.Add(lblPeriodoAquisitivo);
            pnlConteudoFerias.Controls.Add(txtInicioPeriodoAquisitivo);
            pnlConteudoFerias.Controls.Add(dtpInicioFerias);
            pnlConteudoFerias.Controls.Add(lblNomeColaborador);
            pnlConteudoFerias.Controls.Add(lblPeriodoFerias);
            pnlConteudoFerias.Controls.Add(lblCodigoColaborador);
            pnlConteudoFerias.Controls.Add(txtNomeColaborador);
            pnlConteudoFerias.Controls.Add(txtCodigoColaborador);
            pnlConteudoFerias.Dock = DockStyle.Fill;
            pnlConteudoFerias.Location = new Point(0, 78);
            pnlConteudoFerias.Name = "pnlConteudoFerias";
            pnlConteudoFerias.Size = new Size(674, 211);
            pnlConteudoFerias.TabIndex = 47;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(591, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // lblTerminoFerias
            // 
            lblTerminoFerias.AutoSize = true;
            lblTerminoFerias.Location = new Point(518, 137);
            lblTerminoFerias.Margin = new Padding(4, 0, 4, 0);
            lblTerminoFerias.Name = "lblTerminoFerias";
            lblTerminoFerias.Size = new Size(50, 15);
            lblTerminoFerias.TabIndex = 52;
            lblTerminoFerias.Text = "Termino";
            // 
            // lblInicoFerias
            // 
            lblInicoFerias.AutoSize = true;
            lblInicoFerias.Location = new Point(385, 137);
            lblInicoFerias.Margin = new Padding(4, 0, 4, 0);
            lblInicoFerias.Name = "lblInicoFerias";
            lblInicoFerias.Size = new Size(36, 15);
            lblInicoFerias.TabIndex = 51;
            lblInicoFerias.Text = "Inicio";
            // 
            // dtpTerminoFerias
            // 
            dtpTerminoFerias.Format = DateTimePickerFormat.Short;
            dtpTerminoFerias.Location = new Point(518, 155);
            dtpTerminoFerias.Margin = new Padding(4, 3, 4, 3);
            dtpTerminoFerias.Name = "dtpTerminoFerias";
            dtpTerminoFerias.Size = new Size(112, 23);
            dtpTerminoFerias.TabIndex = 50;
            // 
            // txtTerminoPeriodoAquisitivo
            // 
            txtTerminoPeriodoAquisitivo.Location = new Point(170, 155);
            txtTerminoPeriodoAquisitivo.Margin = new Padding(4, 3, 4, 3);
            txtTerminoPeriodoAquisitivo.MaxLength = 10;
            txtTerminoPeriodoAquisitivo.Name = "txtTerminoPeriodoAquisitivo";
            txtTerminoPeriodoAquisitivo.ReadOnly = true;
            txtTerminoPeriodoAquisitivo.Size = new Size(130, 23);
            txtTerminoPeriodoAquisitivo.TabIndex = 49;
            // 
            // lblPeriodoAquisitivo
            // 
            lblPeriodoAquisitivo.AutoSize = true;
            lblPeriodoAquisitivo.Location = new Point(28, 132);
            lblPeriodoAquisitivo.Margin = new Padding(4, 0, 4, 0);
            lblPeriodoAquisitivo.Name = "lblPeriodoAquisitivo";
            lblPeriodoAquisitivo.Size = new Size(102, 15);
            lblPeriodoAquisitivo.TabIndex = 48;
            lblPeriodoAquisitivo.Text = "Periodo aquisitivo";
            // 
            // txtInicioPeriodoAquisitivo
            // 
            txtInicioPeriodoAquisitivo.Location = new Point(32, 155);
            txtInicioPeriodoAquisitivo.Margin = new Padding(4, 3, 4, 3);
            txtInicioPeriodoAquisitivo.MaxLength = 10;
            txtInicioPeriodoAquisitivo.Name = "txtInicioPeriodoAquisitivo";
            txtInicioPeriodoAquisitivo.ReadOnly = true;
            txtInicioPeriodoAquisitivo.Size = new Size(130, 23);
            txtInicioPeriodoAquisitivo.TabIndex = 47;
            // 
            // dtpInicioFerias
            // 
            dtpInicioFerias.Format = DateTimePickerFormat.Short;
            dtpInicioFerias.Location = new Point(385, 155);
            dtpInicioFerias.Margin = new Padding(4, 3, 4, 3);
            dtpInicioFerias.Name = "dtpInicioFerias";
            dtpInicioFerias.Size = new Size(112, 23);
            dtpInicioFerias.TabIndex = 46;
            // 
            // lblNomeColaborador
            // 
            lblNomeColaborador.AutoSize = true;
            lblNomeColaborador.Location = new Point(122, 64);
            lblNomeColaborador.Margin = new Padding(4, 0, 4, 0);
            lblNomeColaborador.Name = "lblNomeColaborador";
            lblNomeColaborador.Size = new Size(40, 15);
            lblNomeColaborador.TabIndex = 45;
            lblNomeColaborador.Text = "Nome";
            // 
            // lblPeriodoFerias
            // 
            lblPeriodoFerias.AutoSize = true;
            lblPeriodoFerias.Location = new Point(385, 109);
            lblPeriodoFerias.Margin = new Padding(4, 0, 4, 0);
            lblPeriodoFerias.Name = "lblPeriodoFerias";
            lblPeriodoFerias.Size = new Size(81, 15);
            lblPeriodoFerias.TabIndex = 44;
            lblPeriodoFerias.Text = "Periodo Férias";
            // 
            // lblCodigoColaborador
            // 
            lblCodigoColaborador.AutoSize = true;
            lblCodigoColaborador.Location = new Point(33, 64);
            lblCodigoColaborador.Margin = new Padding(4, 0, 4, 0);
            lblCodigoColaborador.Name = "lblCodigoColaborador";
            lblCodigoColaborador.Size = new Size(46, 15);
            lblCodigoColaborador.TabIndex = 43;
            lblCodigoColaborador.Text = "Código";
            // 
            // txtNomeColaborador
            // 
            txtNomeColaborador.Location = new Point(126, 87);
            txtNomeColaborador.Margin = new Padding(4, 3, 4, 3);
            txtNomeColaborador.MaxLength = 60;
            txtNomeColaborador.Name = "txtNomeColaborador";
            txtNomeColaborador.ReadOnly = true;
            txtNomeColaborador.Size = new Size(221, 23);
            txtNomeColaborador.TabIndex = 42;
            // 
            // txtCodigoColaborador
            // 
            txtCodigoColaborador.Enabled = false;
            txtCodigoColaborador.HideSelection = false;
            txtCodigoColaborador.Location = new Point(32, 87);
            txtCodigoColaborador.Margin = new Padding(4, 3, 4, 3);
            txtCodigoColaborador.Name = "txtCodigoColaborador";
            txtCodigoColaborador.ReadOnly = true;
            txtCodigoColaborador.Size = new Size(74, 23);
            txtCodigoColaborador.TabIndex = 41;
            // 
            // frmAcompanhamentoFerias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 314);
            Controls.Add(pnlConteudoFerias);
            Controls.Add(toolStrip1);
            Controls.Add(pnlTituloFerias);
            Controls.Add(toolStrip2);
            MaximizeBox = false;
            Name = "frmAcompanhamentoFerias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAcompanhamentoFerias";
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            pnlTituloFerias.ResumeLayout(false);
            pnlTituloFerias.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pnlConteudoFerias.ResumeLayout(false);
            pnlConteudoFerias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip2;
        private ToolStripLabel toolStripLabel1;
        private Panel pnlTituloFerias;
        private ToolStrip toolStrip1;
        private ToolStripButton salvarToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnCancelar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ajudaToolStripButton;
        private Panel pnlConteudoFerias;
        private Label lblTitulo;
        private Label lblNomeColaborador;
        private Label lblCodigoColaborador;
        public TextBox txtNomeColaborador;
        public TextBox txtCodigoColaborador;
        private Label lblTerminoFerias;
        private Label lblInicoFerias;
        public DateTimePicker dtpTerminoFerias;
        public TextBox txtTerminoPeriodoAquisitivo;
        private Label lblPeriodoAquisitivo;
        public TextBox txtInicioPeriodoAquisitivo;
        public DateTimePicker dtpInicioFerias;
        private Label lblPeriodoFerias;
        private PictureBox pictureBox1;
    }
}