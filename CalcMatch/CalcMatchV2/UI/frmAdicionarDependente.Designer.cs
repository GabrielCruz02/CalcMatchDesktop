namespace CalcMatchV2.UI.FormsFilho
{
    partial class frmAdicionarDependente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarDependente));
            pnlTitleBar = new Panel();
            lblTitulo = new Label();
            toolStrip1 = new ToolStrip();
            salvarToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            excluirStripButton1 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            voltarStripButton1 = new ToolStripButton();
            pnlConteudoDependentes = new Panel();
            pictureBox1 = new PictureBox();
            dtpNascimento = new DateTimePicker();
            cbxSexo = new ComboBox();
            lblSexo = new Label();
            lblDataNasc = new Label();
            lblParentesco = new Label();
            txtParentesco = new TextBox();
            lblNomeDependente = new Label();
            txtNomeDependete = new TextBox();
            toolStrip2 = new ToolStrip();
            pnlTitleBar.SuspendLayout();
            toolStrip1.SuspendLayout();
            pnlConteudoDependentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(157, 118, 193);
            pnlTitleBar.Controls.Add(lblTitulo);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            pnlTitleBar.ForeColor = Color.White;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Margin = new Padding(4, 3, 4, 3);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(499, 63);
            pnlTitleBar.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(177, 9);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(146, 30);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Dependentes";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { salvarToolStripButton, toolStripSeparator2, excluirStripButton1, toolStripSeparator3, voltarStripButton1 });
            toolStrip1.Location = new Point(0, 63);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(499, 25);
            toolStrip1.TabIndex = 45;
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
            // excluirStripButton1
            // 
            excluirStripButton1.Image = (Image)resources.GetObject("excluirStripButton1.Image");
            excluirStripButton1.ImageTransparentColor = Color.Magenta;
            excluirStripButton1.Name = "excluirStripButton1";
            excluirStripButton1.Size = new Size(62, 22);
            excluirStripButton1.Text = "&Excluir";
            excluirStripButton1.Click += excluirStripButton1_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // voltarStripButton1
            // 
            voltarStripButton1.Image = (Image)resources.GetObject("voltarStripButton1.Image");
            voltarStripButton1.ImageTransparentColor = Color.Magenta;
            voltarStripButton1.Name = "voltarStripButton1";
            voltarStripButton1.Size = new Size(160, 22);
            voltarStripButton1.Text = "&Voltar para o colaborador";
            voltarStripButton1.Click += voltarStripButton1_Click;
            // 
            // pnlConteudoDependentes
            // 
            pnlConteudoDependentes.Controls.Add(pictureBox1);
            pnlConteudoDependentes.Controls.Add(dtpNascimento);
            pnlConteudoDependentes.Controls.Add(cbxSexo);
            pnlConteudoDependentes.Controls.Add(lblSexo);
            pnlConteudoDependentes.Controls.Add(lblDataNasc);
            pnlConteudoDependentes.Controls.Add(lblParentesco);
            pnlConteudoDependentes.Controls.Add(txtParentesco);
            pnlConteudoDependentes.Controls.Add(lblNomeDependente);
            pnlConteudoDependentes.Controls.Add(txtNomeDependete);
            pnlConteudoDependentes.Controls.Add(toolStrip2);
            pnlConteudoDependentes.Dock = DockStyle.Fill;
            pnlConteudoDependentes.Location = new Point(0, 88);
            pnlConteudoDependentes.Name = "pnlConteudoDependentes";
            pnlConteudoDependentes.Size = new Size(499, 316);
            pnlConteudoDependentes.TabIndex = 46;
            pnlConteudoDependentes.Paint += pnlConteudoDependentes_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(318, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(40, 174);
            dtpNascimento.Margin = new Padding(4, 3, 4, 3);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(139, 23);
            dtpNascimento.TabIndex = 42;
            // 
            // cbxSexo
            // 
            cbxSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSexo.FormattingEnabled = true;
            cbxSexo.Items.AddRange(new object[] { "Masculino\t", "Feminino" });
            cbxSexo.Location = new Point(39, 237);
            cbxSexo.Margin = new Padding(4, 3, 4, 3);
            cbxSexo.Name = "cbxSexo";
            cbxSexo.Size = new Size(140, 23);
            cbxSexo.TabIndex = 43;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(40, 214);
            lblSexo.Margin = new Padding(4, 0, 4, 0);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(32, 15);
            lblSexo.TabIndex = 45;
            lblSexo.Text = "Sexo";
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(41, 151);
            lblDataNasc.Margin = new Padding(4, 0, 4, 0);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(96, 15);
            lblDataNasc.TabIndex = 44;
            lblDataNasc.Text = "Data nascimento";
            // 
            // lblParentesco
            // 
            lblParentesco.AutoSize = true;
            lblParentesco.Location = new Point(36, 91);
            lblParentesco.Margin = new Padding(4, 0, 4, 0);
            lblParentesco.Name = "lblParentesco";
            lblParentesco.Size = new Size(65, 15);
            lblParentesco.TabIndex = 41;
            lblParentesco.Text = "Parentesco";
            // 
            // txtParentesco
            // 
            txtParentesco.Location = new Point(40, 114);
            txtParentesco.Margin = new Padding(4, 3, 4, 3);
            txtParentesco.MaxLength = 60;
            txtParentesco.Name = "txtParentesco";
            txtParentesco.Size = new Size(221, 23);
            txtParentesco.TabIndex = 40;
            // 
            // lblNomeDependente
            // 
            lblNomeDependente.AutoSize = true;
            lblNomeDependente.Location = new Point(36, 28);
            lblNomeDependente.Margin = new Padding(4, 0, 4, 0);
            lblNomeDependente.Name = "lblNomeDependente";
            lblNomeDependente.Size = new Size(40, 15);
            lblNomeDependente.TabIndex = 39;
            lblNomeDependente.Text = "Nome";
            // 
            // txtNomeDependete
            // 
            txtNomeDependete.Location = new Point(40, 51);
            txtNomeDependete.Margin = new Padding(4, 3, 4, 3);
            txtNomeDependete.MaxLength = 60;
            txtNomeDependete.Name = "txtNomeDependete";
            txtNomeDependete.Size = new Size(221, 23);
            txtNomeDependete.TabIndex = 38;
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.Bottom;
            toolStrip2.Location = new Point(0, 291);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(499, 25);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // AdicionarDependente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 404);
            Controls.Add(pnlConteudoDependentes);
            Controls.Add(toolStrip1);
            Controls.Add(pnlTitleBar);
            MaximizeBox = false;
            Name = "AdicionarDependente";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar dependente";
            Load += ListDependentes_Load;
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pnlConteudoDependentes.ResumeLayout(false);
            pnlConteudoDependentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitleBar;
        private Label lblTitulo;
        private ToolStrip toolStrip1;
        private ToolStripButton salvarToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton excluirStripButton1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton voltarStripButton1;
        private Panel pnlConteudoDependentes;
        private ToolStrip toolStrip2;
        public DateTimePicker dtpNascimento;
        public ComboBox cbxSexo;
        private Label lblSexo;
        private Label lblDataNasc;
        private Label lblParentesco;
        public TextBox txtParentesco;
        private Label lblNomeDependente;
        public TextBox txtNomeDependete;
        private PictureBox pictureBox1;
    }
}