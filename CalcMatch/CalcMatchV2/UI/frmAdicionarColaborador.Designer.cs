namespace CalcMatchV1.UI.FormsFilho
{
    partial class frmAdicionarColaborador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarColaborador));
            pnlTitleBar = new Panel();
            lblTitulo = new Label();
            txtCodigoColaborador = new TextBox();
            txtNomeColaborador = new TextBox();
            txtNomeSocial = new TextBox();
            lblCodigoColaborador = new Label();
            lblDataAdmissao = new Label();
            lblNomeColaborador = new Label();
            lblNomeSocial = new Label();
            txtCpf = new TextBox();
            lblCpf = new Label();
            txtIdentidade = new TextBox();
            lblIdentidade = new Label();
            txtCtps = new TextBox();
            lblCtps = new Label();
            lblDataNasc = new Label();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            lblSexo = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            txtObservacoes = new TextBox();
            lblObservacoes = new Label();
            txtCargo = new TextBox();
            lblCargo = new Label();
            txtSalario = new TextBox();
            lblSalario = new Label();
            cbxSexo = new ComboBox();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            dtpDataAdmissao = new DateTimePicker();
            dtpNascimento = new DateTimePicker();
            cbxSituacao = new ComboBox();
            pnlConteudoAddColaborador = new Panel();
            btnVisualizarDependente = new Button();
            pictureBox1 = new PictureBox();
            toolStrip1 = new ToolStrip();
            salvarToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnCancelar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            btnAddDependentes = new Button();
            lblSituacao = new Label();
            statusStrip1 = new StatusStrip();
            pnlTitleBar.SuspendLayout();
            pnlConteudoAddColaborador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
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
            pnlTitleBar.Size = new Size(684, 63);
            pnlTitleBar.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(213, 15);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(256, 30);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Cadastro de colaborador";
            // 
            // txtCodigoColaborador
            // 
            txtCodigoColaborador.Enabled = false;
            txtCodigoColaborador.HideSelection = false;
            txtCodigoColaborador.Location = new Point(25, 76);
            txtCodigoColaborador.Margin = new Padding(4, 3, 4, 3);
            txtCodigoColaborador.Name = "txtCodigoColaborador";
            txtCodigoColaborador.ReadOnly = true;
            txtCodigoColaborador.Size = new Size(74, 23);
            txtCodigoColaborador.TabIndex = 0;
            // 
            // txtNomeColaborador
            // 
            txtNomeColaborador.Location = new Point(25, 136);
            txtNomeColaborador.Margin = new Padding(4, 3, 4, 3);
            txtNomeColaborador.MaxLength = 60;
            txtNomeColaborador.Name = "txtNomeColaborador";
            txtNomeColaborador.Size = new Size(221, 23);
            txtNomeColaborador.TabIndex = 2;
            // 
            // txtNomeSocial
            // 
            txtNomeSocial.Location = new Point(265, 136);
            txtNomeSocial.Margin = new Padding(4, 3, 4, 3);
            txtNomeSocial.MaxLength = 30;
            txtNomeSocial.Name = "txtNomeSocial";
            txtNomeSocial.Size = new Size(186, 23);
            txtNomeSocial.TabIndex = 3;
            // 
            // lblCodigoColaborador
            // 
            lblCodigoColaborador.AutoSize = true;
            lblCodigoColaborador.Location = new Point(26, 53);
            lblCodigoColaborador.Margin = new Padding(4, 0, 4, 0);
            lblCodigoColaborador.Name = "lblCodigoColaborador";
            lblCodigoColaborador.Size = new Size(46, 15);
            lblCodigoColaborador.TabIndex = 4;
            lblCodigoColaborador.Text = "Código";
            // 
            // lblDataAdmissao
            // 
            lblDataAdmissao.AutoSize = true;
            lblDataAdmissao.Location = new Point(114, 53);
            lblDataAdmissao.Margin = new Padding(4, 0, 4, 0);
            lblDataAdmissao.Name = "lblDataAdmissao";
            lblDataAdmissao.Size = new Size(86, 15);
            lblDataAdmissao.TabIndex = 5;
            lblDataAdmissao.Text = "Data Admissão";
            // 
            // lblNomeColaborador
            // 
            lblNomeColaborador.AutoSize = true;
            lblNomeColaborador.Location = new Point(21, 113);
            lblNomeColaborador.Margin = new Padding(4, 0, 4, 0);
            lblNomeColaborador.Name = "lblNomeColaborador";
            lblNomeColaborador.Size = new Size(40, 15);
            lblNomeColaborador.TabIndex = 6;
            lblNomeColaborador.Text = "Nome";
            // 
            // lblNomeSocial
            // 
            lblNomeSocial.AutoSize = true;
            lblNomeSocial.Location = new Point(262, 113);
            lblNomeSocial.Margin = new Padding(4, 0, 4, 0);
            lblNomeSocial.Name = "lblNomeSocial";
            lblNomeSocial.Size = new Size(73, 15);
            lblNomeSocial.TabIndex = 7;
            lblNomeSocial.Text = "Nome social";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(26, 201);
            txtCpf.Margin = new Padding(4, 3, 4, 3);
            txtCpf.MaxLength = 20;
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(118, 23);
            txtCpf.TabIndex = 4;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(27, 178);
            lblCpf.Margin = new Padding(4, 0, 4, 0);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 12;
            lblCpf.Text = "CPF";
            // 
            // txtIdentidade
            // 
            txtIdentidade.Location = new Point(159, 201);
            txtIdentidade.Margin = new Padding(4, 3, 4, 3);
            txtIdentidade.MaxLength = 20;
            txtIdentidade.Name = "txtIdentidade";
            txtIdentidade.Size = new Size(132, 23);
            txtIdentidade.TabIndex = 5;
            // 
            // lblIdentidade
            // 
            lblIdentidade.AutoSize = true;
            lblIdentidade.Location = new Point(161, 178);
            lblIdentidade.Margin = new Padding(4, 0, 4, 0);
            lblIdentidade.Name = "lblIdentidade";
            lblIdentidade.Size = new Size(80, 15);
            lblIdentidade.TabIndex = 14;
            lblIdentidade.Text = "Registro Geral";
            // 
            // txtCtps
            // 
            txtCtps.Location = new Point(249, 76);
            txtCtps.Margin = new Padding(4, 3, 4, 3);
            txtCtps.MaxLength = 20;
            txtCtps.Name = "txtCtps";
            txtCtps.Size = new Size(131, 23);
            txtCtps.TabIndex = 1;
            // 
            // lblCtps
            // 
            lblCtps.AutoSize = true;
            lblCtps.Location = new Point(250, 53);
            lblCtps.Margin = new Padding(4, 0, 4, 0);
            lblCtps.Name = "lblCtps";
            lblCtps.Size = new Size(34, 15);
            lblCtps.TabIndex = 16;
            lblCtps.Text = "CTPS";
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(306, 178);
            lblDataNasc.Margin = new Padding(4, 0, 4, 0);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(96, 15);
            lblDataNasc.TabIndex = 18;
            lblDataNasc.Text = "Data nascimento";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(25, 264);
            txtEndereco.Margin = new Padding(4, 3, 4, 3);
            txtEndereco.MaxLength = 80;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(264, 23);
            txtEndereco.TabIndex = 7;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(26, 241);
            lblEndereco.Margin = new Padding(4, 0, 4, 0);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(56, 15);
            lblEndereco.TabIndex = 20;
            lblEndereco.Text = "Endereço";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(305, 241);
            lblSexo.Margin = new Padding(4, 0, 4, 0);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(32, 15);
            lblSexo.TabIndex = 25;
            lblSexo.Text = "Sexo";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(26, 325);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.MaxLength = 70;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(264, 23);
            txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(27, 301);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 27;
            lblEmail.Text = "Email";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(305, 325);
            txtTelefone.Margin = new Padding(4, 3, 4, 3);
            txtTelefone.MaxLength = 30;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(146, 23);
            txtTelefone.TabIndex = 10;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(306, 301);
            lblTelefone.Margin = new Padding(4, 0, 4, 0);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 29;
            lblTelefone.Text = "Telefone";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(25, 383);
            txtObservacoes.Margin = new Padding(4, 3, 4, 3);
            txtObservacoes.MaxLength = 200;
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(265, 76);
            txtObservacoes.TabIndex = 11;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Location = new Point(27, 360);
            lblObservacoes.Margin = new Padding(4, 0, 4, 0);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(74, 15);
            lblObservacoes.TabIndex = 31;
            lblObservacoes.Text = "Observações";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(305, 432);
            txtCargo.Margin = new Padding(4, 3, 4, 3);
            txtCargo.MaxLength = 30;
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(146, 23);
            txtCargo.TabIndex = 13;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(307, 409);
            lblCargo.Margin = new Padding(4, 0, 4, 0);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 33;
            lblCargo.Text = "Cargo";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(306, 379);
            txtSalario.Margin = new Padding(4, 3, 4, 3);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(146, 23);
            txtSalario.TabIndex = 12;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(307, 356);
            lblSalario.Margin = new Padding(4, 0, 4, 0);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(119, 15);
            lblSalario.TabIndex = 35;
            lblSalario.Text = "Salario (Valor por HR)";
            // 
            // cbxSexo
            // 
            cbxSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSexo.FormattingEnabled = true;
            cbxSexo.Items.AddRange(new object[] { "Masculino\t", "Feminino" });
            cbxSexo.Location = new Point(304, 264);
            cbxSexo.Margin = new Padding(4, 3, 4, 3);
            cbxSexo.Name = "cbxSexo";
            cbxSexo.Size = new Size(140, 23);
            cbxSexo.TabIndex = 8;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // dtpDataAdmissao
            // 
            dtpDataAdmissao.Format = DateTimePickerFormat.Short;
            dtpDataAdmissao.Location = new Point(117, 76);
            dtpDataAdmissao.Margin = new Padding(4, 3, 4, 3);
            dtpDataAdmissao.Name = "dtpDataAdmissao";
            dtpDataAdmissao.Size = new Size(112, 23);
            dtpDataAdmissao.TabIndex = 40;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(305, 201);
            dtpNascimento.Margin = new Padding(4, 3, 4, 3);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(139, 23);
            dtpNascimento.TabIndex = 6;
            // 
            // cbxSituacao
            // 
            cbxSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSituacao.FormattingEnabled = true;
            cbxSituacao.Items.AddRange(new object[] { "Desligado", "Ativo" });
            cbxSituacao.Location = new Point(495, 273);
            cbxSituacao.Margin = new Padding(4, 3, 4, 3);
            cbxSituacao.Name = "cbxSituacao";
            cbxSituacao.Size = new Size(146, 23);
            cbxSituacao.TabIndex = 14;
            // 
            // pnlConteudoAddColaborador
            // 
            pnlConteudoAddColaborador.Controls.Add(btnVisualizarDependente);
            pnlConteudoAddColaborador.Controls.Add(pictureBox1);
            pnlConteudoAddColaborador.Controls.Add(toolStrip1);
            pnlConteudoAddColaborador.Controls.Add(btnAddDependentes);
            pnlConteudoAddColaborador.Controls.Add(lblSituacao);
            pnlConteudoAddColaborador.Controls.Add(cbxSituacao);
            pnlConteudoAddColaborador.Controls.Add(dtpNascimento);
            pnlConteudoAddColaborador.Controls.Add(dtpDataAdmissao);
            pnlConteudoAddColaborador.Controls.Add(statusStrip1);
            pnlConteudoAddColaborador.Controls.Add(cbxSexo);
            pnlConteudoAddColaborador.Controls.Add(lblSalario);
            pnlConteudoAddColaborador.Controls.Add(txtSalario);
            pnlConteudoAddColaborador.Controls.Add(lblCargo);
            pnlConteudoAddColaborador.Controls.Add(txtCargo);
            pnlConteudoAddColaborador.Controls.Add(lblObservacoes);
            pnlConteudoAddColaborador.Controls.Add(txtObservacoes);
            pnlConteudoAddColaborador.Controls.Add(lblTelefone);
            pnlConteudoAddColaborador.Controls.Add(txtTelefone);
            pnlConteudoAddColaborador.Controls.Add(lblEmail);
            pnlConteudoAddColaborador.Controls.Add(txtEmail);
            pnlConteudoAddColaborador.Controls.Add(lblSexo);
            pnlConteudoAddColaborador.Controls.Add(lblEndereco);
            pnlConteudoAddColaborador.Controls.Add(txtEndereco);
            pnlConteudoAddColaborador.Controls.Add(lblDataNasc);
            pnlConteudoAddColaborador.Controls.Add(lblCtps);
            pnlConteudoAddColaborador.Controls.Add(txtCtps);
            pnlConteudoAddColaborador.Controls.Add(lblIdentidade);
            pnlConteudoAddColaborador.Controls.Add(txtIdentidade);
            pnlConteudoAddColaborador.Controls.Add(lblCpf);
            pnlConteudoAddColaborador.Controls.Add(txtCpf);
            pnlConteudoAddColaborador.Controls.Add(lblNomeSocial);
            pnlConteudoAddColaborador.Controls.Add(lblNomeColaborador);
            pnlConteudoAddColaborador.Controls.Add(lblDataAdmissao);
            pnlConteudoAddColaborador.Controls.Add(lblCodigoColaborador);
            pnlConteudoAddColaborador.Controls.Add(txtNomeSocial);
            pnlConteudoAddColaborador.Controls.Add(txtNomeColaborador);
            pnlConteudoAddColaborador.Controls.Add(txtCodigoColaborador);
            pnlConteudoAddColaborador.Dock = DockStyle.Fill;
            pnlConteudoAddColaborador.Location = new Point(0, 63);
            pnlConteudoAddColaborador.Margin = new Padding(4, 3, 4, 3);
            pnlConteudoAddColaborador.Name = "pnlConteudoAddColaborador";
            pnlConteudoAddColaborador.Size = new Size(684, 504);
            pnlConteudoAddColaborador.TabIndex = 0;
            // 
            // btnVisualizarDependente
            // 
            btnVisualizarDependente.Location = new Point(522, 418);
            btnVisualizarDependente.Name = "btnVisualizarDependente";
            btnVisualizarDependente.Size = new Size(138, 37);
            btnVisualizarDependente.TabIndex = 46;
            btnVisualizarDependente.Text = "Visualizar depedentes";
            btnVisualizarDependente.UseVisualStyleBackColor = true;
            btnVisualizarDependente.Click += btnVisualizarDependente_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(486, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { salvarToolStripButton, toolStripSeparator2, btnCancelar, toolStripSeparator1, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(684, 25);
            toolStrip1.TabIndex = 44;
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
            // btnAddDependentes
            // 
            btnAddDependentes.Location = new Point(522, 375);
            btnAddDependentes.Name = "btnAddDependentes";
            btnAddDependentes.Size = new Size(138, 37);
            btnAddDependentes.TabIndex = 15;
            btnAddDependentes.Text = "Adicionar dependente";
            btnAddDependentes.UseVisualStyleBackColor = true;
            btnAddDependentes.Click += btnAddDependentes_Click;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(496, 247);
            lblSituacao.Margin = new Padding(4, 0, 4, 0);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 43;
            lblSituacao.Text = "Situação";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 482);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(684, 22);
            statusStrip1.TabIndex = 38;
            statusStrip1.Text = "statusStrip1";
            // 
            // frmAdicionarColaborador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 567);
            Controls.Add(pnlConteudoAddColaborador);
            Controls.Add(pnlTitleBar);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmAdicionarColaborador";
            Text = "Adicionar colaborador";
            Load += AdicionarColaborador_Load;
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            pnlConteudoAddColaborador.ResumeLayout(false);
            pnlConteudoAddColaborador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlTitleBar;
        private Label lblTitulo;
        private Label lblCodigoColaborador;
        private Label lblDataAdmissao;
        private Label lblNomeColaborador;
        private Label lblNomeSocial;
        private Label lblCpf;
        private Label lblIdentidade;
        private Label lblCtps;
        private Label lblDataNasc;
        private Label lblEndereco;
        private Label lblSexo;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblObservacoes;
        private Label lblCargo;
        private Label lblSalario;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel pnlConteudoAddColaborador;
        private Label lblSituacao;
        private Button btnAddDependentes;
        public TextBox txtNomeColaborador;
        public TextBox txtNomeSocial;
        public TextBox txtCpf;
        public TextBox txtIdentidade;
        public TextBox txtCtps;
        public TextBox txtEndereco;
        public DateTimePicker dtpDataAdmissao;
        public DateTimePicker dtpNascimento;
        public TextBox txtEmail;
        public TextBox txtTelefone;
        public TextBox txtObservacoes;
        public TextBox txtCargo;
        public TextBox txtSalario;
        public ComboBox cbxSexo;
        public ComboBox cbxSituacao;
        public StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ToolStripButton salvarToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ajudaToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private PictureBox pictureBox1;
        private ToolStripButton btnCancelar;
        private Button btnVisualizarDependente;
        public TextBox txtCodigoColaborador;
    }
}