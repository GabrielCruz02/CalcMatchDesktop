namespace CalcMatchV1.UI.FormsFilho
{
    partial class frmColaboradores
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColaboradores));
            pnlColaboradores = new Panel();
            pnlColaboradoresInfo = new Panel();
            dataGridView1 = new DataGridView();
            pnlButtonsColaborador = new Panel();
            btnCadastroColaborador = new Button();
            btnExibirColaboradres = new Button();
            btnAlterarColaborador = new Button();
            btnBuscarColaboradorFiltro = new Button();
            txtBuscarColaborador = new TextBox();
            btnExcluirColaborador = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            pnlColaboradores.SuspendLayout();
            pnlColaboradoresInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlButtonsColaborador.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlColaboradores
            // 
            pnlColaboradores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlColaboradores.AutoSize = true;
            pnlColaboradores.BackColor = SystemColors.ControlLight;
            pnlColaboradores.Controls.Add(pnlColaboradoresInfo);
            pnlColaboradores.Controls.Add(pnlButtonsColaborador);
            pnlColaboradores.Controls.Add(statusStrip1);
            pnlColaboradores.Location = new Point(0, 0);
            pnlColaboradores.Margin = new Padding(4, 3, 4, 3);
            pnlColaboradores.Name = "pnlColaboradores";
            pnlColaboradores.Size = new Size(933, 519);
            pnlColaboradores.TabIndex = 0;
            pnlColaboradores.Paint += pnlAviso_Paint;
            // 
            // pnlColaboradoresInfo
            // 
            pnlColaboradoresInfo.Controls.Add(dataGridView1);
            pnlColaboradoresInfo.Dock = DockStyle.Fill;
            pnlColaboradoresInfo.Location = new Point(233, 0);
            pnlColaboradoresInfo.Margin = new Padding(4, 3, 4, 3);
            pnlColaboradoresInfo.Name = "pnlColaboradoresInfo";
            pnlColaboradoresInfo.Size = new Size(700, 497);
            pnlColaboradoresInfo.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(700, 497);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // pnlButtonsColaborador
            // 
            pnlButtonsColaborador.BackColor = SystemColors.Control;
            pnlButtonsColaborador.BackgroundImage = (Image)resources.GetObject("pnlButtonsColaborador.BackgroundImage");
            pnlButtonsColaborador.BackgroundImageLayout = ImageLayout.Zoom;
            pnlButtonsColaborador.Controls.Add(btnCadastroColaborador);
            pnlButtonsColaborador.Controls.Add(btnExibirColaboradres);
            pnlButtonsColaborador.Controls.Add(btnAlterarColaborador);
            pnlButtonsColaborador.Controls.Add(btnBuscarColaboradorFiltro);
            pnlButtonsColaborador.Controls.Add(txtBuscarColaborador);
            pnlButtonsColaborador.Controls.Add(btnExcluirColaborador);
            pnlButtonsColaborador.Dock = DockStyle.Left;
            pnlButtonsColaborador.Location = new Point(0, 0);
            pnlButtonsColaborador.Margin = new Padding(4, 3, 4, 3);
            pnlButtonsColaborador.Name = "pnlButtonsColaborador";
            pnlButtonsColaborador.Size = new Size(233, 497);
            pnlButtonsColaborador.TabIndex = 5;
            // 
            // btnCadastroColaborador
            // 
            btnCadastroColaborador.Cursor = Cursors.Hand;
            btnCadastroColaborador.Dock = DockStyle.Bottom;
            btnCadastroColaborador.Image = (Image)resources.GetObject("btnCadastroColaborador.Image");
            btnCadastroColaborador.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastroColaborador.Location = new Point(0, 389);
            btnCadastroColaborador.Margin = new Padding(4, 3, 4, 3);
            btnCadastroColaborador.Name = "btnCadastroColaborador";
            btnCadastroColaborador.Size = new Size(233, 27);
            btnCadastroColaborador.TabIndex = 4;
            btnCadastroColaborador.Text = "Cadastrar colaborador(a)";
            btnCadastroColaborador.UseVisualStyleBackColor = true;
            btnCadastroColaborador.Click += btnCadastroColaborador_Click;
            // 
            // btnExibirColaboradres
            // 
            btnExibirColaboradres.Cursor = Cursors.Hand;
            btnExibirColaboradres.Dock = DockStyle.Bottom;
            btnExibirColaboradres.Image = (Image)resources.GetObject("btnExibirColaboradres.Image");
            btnExibirColaboradres.ImageAlign = ContentAlignment.MiddleLeft;
            btnExibirColaboradres.Location = new Point(0, 416);
            btnExibirColaboradres.Margin = new Padding(4, 3, 4, 3);
            btnExibirColaboradres.Name = "btnExibirColaboradres";
            btnExibirColaboradres.Size = new Size(233, 27);
            btnExibirColaboradres.TabIndex = 3;
            btnExibirColaboradres.Text = "Exibir todos colaboradores";
            btnExibirColaboradres.UseVisualStyleBackColor = true;
            btnExibirColaboradres.Click += btnExibirColaboradres_Click;
            // 
            // btnAlterarColaborador
            // 
            btnAlterarColaborador.Cursor = Cursors.Hand;
            btnAlterarColaborador.Dock = DockStyle.Bottom;
            btnAlterarColaborador.Image = (Image)resources.GetObject("btnAlterarColaborador.Image");
            btnAlterarColaborador.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlterarColaborador.Location = new Point(0, 443);
            btnAlterarColaborador.Margin = new Padding(4, 3, 4, 3);
            btnAlterarColaborador.Name = "btnAlterarColaborador";
            btnAlterarColaborador.Size = new Size(233, 27);
            btnAlterarColaborador.TabIndex = 5;
            btnAlterarColaborador.Text = "Alterar dados";
            btnAlterarColaborador.UseVisualStyleBackColor = true;
            btnAlterarColaborador.Click += btnAlterarColaborador_Click;
            // 
            // btnBuscarColaboradorFiltro
            // 
            btnBuscarColaboradorFiltro.Cursor = Cursors.Hand;
            btnBuscarColaboradorFiltro.Dock = DockStyle.Top;
            btnBuscarColaboradorFiltro.Image = (Image)resources.GetObject("btnBuscarColaboradorFiltro.Image");
            btnBuscarColaboradorFiltro.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarColaboradorFiltro.Location = new Point(0, 23);
            btnBuscarColaboradorFiltro.Margin = new Padding(4, 3, 4, 3);
            btnBuscarColaboradorFiltro.Name = "btnBuscarColaboradorFiltro";
            btnBuscarColaboradorFiltro.Size = new Size(233, 27);
            btnBuscarColaboradorFiltro.TabIndex = 2;
            btnBuscarColaboradorFiltro.Text = "Buscar";
            btnBuscarColaboradorFiltro.UseVisualStyleBackColor = true;
            btnBuscarColaboradorFiltro.Click += btnBuscarColaboradorFiltro_Click;
            // 
            // txtBuscarColaborador
            // 
            txtBuscarColaborador.Dock = DockStyle.Top;
            txtBuscarColaborador.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarColaborador.ForeColor = SystemColors.MenuText;
            txtBuscarColaborador.Location = new Point(0, 0);
            txtBuscarColaborador.Margin = new Padding(4, 3, 4, 3);
            txtBuscarColaborador.Name = "txtBuscarColaborador";
            txtBuscarColaborador.Size = new Size(233, 23);
            txtBuscarColaborador.TabIndex = 1;
            txtBuscarColaborador.Text = "Buscar Colaborador por CPF";
            // 
            // btnExcluirColaborador
            // 
            btnExcluirColaborador.Cursor = Cursors.Hand;
            btnExcluirColaborador.Dock = DockStyle.Bottom;
            btnExcluirColaborador.Image = (Image)resources.GetObject("btnExcluirColaborador.Image");
            btnExcluirColaborador.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirColaborador.Location = new Point(0, 470);
            btnExcluirColaborador.Margin = new Padding(4, 3, 4, 3);
            btnExcluirColaborador.Name = "btnExcluirColaborador";
            btnExcluirColaborador.Size = new Size(233, 27);
            btnExcluirColaborador.TabIndex = 6;
            btnExcluirColaborador.Text = "Remover colaborador(a)";
            btnExcluirColaborador.UseVisualStyleBackColor = true;
            btnExcluirColaborador.Click += btnExcluirColaborador_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 497);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(933, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Colaboradores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(pnlColaboradores);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Colaboradores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Colaboradores";
            Load += Colaboradores_Load;
            pnlColaboradores.ResumeLayout(false);
            pnlColaboradores.PerformLayout();
            pnlColaboradoresInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlButtonsColaborador.ResumeLayout(false);
            pnlButtonsColaborador.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlColaboradores;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel pnlButtonsColaborador;
        private Panel pnlColaboradoresInfo;
        private Button btnBuscarColaboradorFiltro;
        private TextBox txtBuscarColaborador;
        private Button btnAlterarColaborador;
        public DataGridView dataGridView1;
        private Button btnCadastroColaborador;
        private Button btnExibirColaboradres;
        private Button btnExcluirColaborador;
    }
}