namespace CalcMatchV1.UI
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            pnlMenu = new Panel();
            btnConfiguracoes = new Button();
            btnHorasFerias = new Button();
            btnHolerite = new Button();
            btnColaboradores = new Button();
            pnlLogo = new Panel();
            lblTitleMenu = new Label();
            pnlTitleBar = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            btnHome = new Button();
            lblTitleHome = new Label();
            pnlDesktopPanel = new Panel();
            ptrLogo = new PictureBox();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            pnlDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptrLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(81, 43, 129);
            pnlMenu.Controls.Add(btnConfiguracoes);
            pnlMenu.Controls.Add(btnHorasFerias);
            pnlMenu.Controls.Add(btnHolerite);
            pnlMenu.Controls.Add(btnColaboradores);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(4, 3, 4, 3);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(257, 590);
            pnlMenu.TabIndex = 0;
            // 
            // btnConfiguracoes
            // 
            btnConfiguracoes.Dock = DockStyle.Top;
            btnConfiguracoes.FlatAppearance.BorderSize = 0;
            btnConfiguracoes.FlatStyle = FlatStyle.Flat;
            btnConfiguracoes.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfiguracoes.ForeColor = Color.Gainsboro;
            btnConfiguracoes.Image = (Image)resources.GetObject("btnConfiguracoes.Image");
            btnConfiguracoes.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracoes.Location = new Point(0, 299);
            btnConfiguracoes.Margin = new Padding(4, 3, 4, 3);
            btnConfiguracoes.Name = "btnConfiguracoes";
            btnConfiguracoes.Padding = new Padding(14, 0, 0, 0);
            btnConfiguracoes.Size = new Size(257, 69);
            btnConfiguracoes.TabIndex = 5;
            btnConfiguracoes.Text = "    Configurações";
            btnConfiguracoes.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracoes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguracoes.UseVisualStyleBackColor = true;
            btnConfiguracoes.Click += btnConfiguracoes_Click;
            // 
            // btnHorasFerias
            // 
            btnHorasFerias.Dock = DockStyle.Top;
            btnHorasFerias.FlatAppearance.BorderSize = 0;
            btnHorasFerias.FlatStyle = FlatStyle.Flat;
            btnHorasFerias.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnHorasFerias.ForeColor = Color.Gainsboro;
            btnHorasFerias.Image = (Image)resources.GetObject("btnHorasFerias.Image");
            btnHorasFerias.ImageAlign = ContentAlignment.MiddleLeft;
            btnHorasFerias.Location = new Point(0, 230);
            btnHorasFerias.Margin = new Padding(4, 3, 4, 3);
            btnHorasFerias.Name = "btnHorasFerias";
            btnHorasFerias.Padding = new Padding(14, 0, 0, 0);
            btnHorasFerias.Size = new Size(257, 69);
            btnHorasFerias.TabIndex = 4;
            btnHorasFerias.Text = "   Horas / Ferias";
            btnHorasFerias.TextAlign = ContentAlignment.MiddleLeft;
            btnHorasFerias.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHorasFerias.UseVisualStyleBackColor = true;
            btnHorasFerias.Click += btnRelatorioGeral_Click;
            // 
            // btnHolerite
            // 
            btnHolerite.Dock = DockStyle.Top;
            btnHolerite.FlatAppearance.BorderSize = 0;
            btnHolerite.FlatStyle = FlatStyle.Flat;
            btnHolerite.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnHolerite.ForeColor = Color.Gainsboro;
            btnHolerite.Image = (Image)resources.GetObject("btnHolerite.Image");
            btnHolerite.ImageAlign = ContentAlignment.MiddleLeft;
            btnHolerite.Location = new Point(0, 161);
            btnHolerite.Margin = new Padding(4, 3, 4, 3);
            btnHolerite.Name = "btnHolerite";
            btnHolerite.Padding = new Padding(14, 0, 0, 0);
            btnHolerite.Size = new Size(257, 69);
            btnHolerite.TabIndex = 3;
            btnHolerite.Text = "Holerite";
            btnHolerite.TextAlign = ContentAlignment.MiddleLeft;
            btnHolerite.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHolerite.UseVisualStyleBackColor = true;
            btnHolerite.Click += btnHolerite_Click;
            // 
            // btnColaboradores
            // 
            btnColaboradores.Dock = DockStyle.Top;
            btnColaboradores.FlatAppearance.BorderSize = 0;
            btnColaboradores.FlatStyle = FlatStyle.Flat;
            btnColaboradores.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnColaboradores.ForeColor = Color.Gainsboro;
            btnColaboradores.Image = (Image)resources.GetObject("btnColaboradores.Image");
            btnColaboradores.ImageAlign = ContentAlignment.MiddleLeft;
            btnColaboradores.Location = new Point(0, 92);
            btnColaboradores.Margin = new Padding(4, 3, 4, 3);
            btnColaboradores.Name = "btnColaboradores";
            btnColaboradores.Padding = new Padding(14, 0, 0, 0);
            btnColaboradores.Size = new Size(257, 69);
            btnColaboradores.TabIndex = 2;
            btnColaboradores.Text = "   Colaboradores";
            btnColaboradores.TextAlign = ContentAlignment.MiddleLeft;
            btnColaboradores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnColaboradores.UseVisualStyleBackColor = true;
            btnColaboradores.Click += btnColaboradores_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(53, 21, 93);
            pnlLogo.Controls.Add(lblTitleMenu);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Margin = new Padding(4, 3, 4, 3);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(257, 92);
            pnlLogo.TabIndex = 1;
            // 
            // lblTitleMenu
            // 
            lblTitleMenu.AutoSize = true;
            lblTitleMenu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleMenu.ForeColor = Color.LightGray;
            lblTitleMenu.Location = new Point(61, 36);
            lblTitleMenu.Margin = new Padding(4, 0, 4, 0);
            lblTitleMenu.Name = "lblTitleMenu";
            lblTitleMenu.Size = new Size(88, 20);
            lblTitleMenu.TabIndex = 0;
            lblTitleMenu.Text = "Calc Match";
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(157, 118, 193);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Controls.Add(btnMaximize);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(btnHome);
            pnlTitleBar.Controls.Add(lblTitleHome);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            pnlTitleBar.ForeColor = Color.White;
            pnlTitleBar.Location = new Point(257, 0);
            pnlTitleBar.Margin = new Padding(4, 3, 4, 3);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(833, 92);
            pnlTitleBar.TabIndex = 1;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(728, 0);
            btnMinimize.Margin = new Padding(4, 3, 4, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(35, 35);
            btnMinimize.TabIndex = 4;
            btnMinimize.Text = "O";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(763, 0);
            btnMaximize.Margin = new Padding(4, 3, 4, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(35, 35);
            btnMaximize.TabIndex = 3;
            btnMaximize.Text = "O";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(798, 0);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.TabIndex = 2;
            btnClose.Text = "O";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Left;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(4, 3, 4, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(88, 92);
            btnHome.TabIndex = 1;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // lblTitleHome
            // 
            lblTitleHome.Anchor = AnchorStyles.None;
            lblTitleHome.AutoSize = true;
            lblTitleHome.Location = new Point(364, 27);
            lblTitleHome.Margin = new Padding(4, 0, 4, 0);
            lblTitleHome.Name = "lblTitleHome";
            lblTitleHome.Size = new Size(77, 30);
            lblTitleHome.TabIndex = 0;
            lblTitleHome.Text = "HOME";
            lblTitleHome.Click += lblTitleHome_Click;
            // 
            // pnlDesktopPanel
            // 
            pnlDesktopPanel.Controls.Add(ptrLogo);
            pnlDesktopPanel.Dock = DockStyle.Fill;
            pnlDesktopPanel.Location = new Point(257, 92);
            pnlDesktopPanel.Margin = new Padding(4, 3, 4, 3);
            pnlDesktopPanel.Name = "pnlDesktopPanel";
            pnlDesktopPanel.Size = new Size(833, 498);
            pnlDesktopPanel.TabIndex = 2;
            pnlDesktopPanel.Paint += pnlDesktopPanel_Paint;
            // 
            // ptrLogo
            // 
            ptrLogo.Anchor = AnchorStyles.None;
            ptrLogo.Image = (Image)resources.GetObject("ptrLogo.Image");
            ptrLogo.Location = new Point(127, -57);
            ptrLogo.Margin = new Padding(4, 3, 4, 3);
            ptrLogo.Name = "ptrLogo";
            ptrLogo.Size = new Size(500, 500);
            ptrLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            ptrLogo.TabIndex = 0;
            ptrLogo.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 590);
            Controls.Add(pnlDesktopPanel);
            Controls.Add(pnlTitleBar);
            Controls.Add(pnlMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1047, 513);
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            pnlDesktopPanel.ResumeLayout(false);
            pnlDesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptrLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlLogo;
        private Button btnColaboradores;
        private Button btnHorasFerias;
        private Button btnHolerite;
        private Panel pnlTitleBar;
        private Label lblTitleHome;
        private Label lblTitleMenu;
        private Button btnConfiguracoes;
        private Panel pnlDesktopPanel;
        private Button btnHome;
        private PictureBox ptrLogo;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
    }
}