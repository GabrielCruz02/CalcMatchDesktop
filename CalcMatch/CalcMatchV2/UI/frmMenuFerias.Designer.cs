namespace CalcMatchV2.UI
{
    partial class frmMenuFerias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuFerias));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlMenu = new Panel();
            btnExibirColaboradores = new Button();
            btnFerias = new Button();
            btnBuscarColaboradorFiltro = new Button();
            txtBuscarColaborador = new TextBox();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            dataGridView1 = new DataGridView();
            pnlMenu.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = SystemColors.ButtonFace;
            pnlMenu.BackgroundImage = (Image)resources.GetObject("pnlMenu.BackgroundImage");
            pnlMenu.BackgroundImageLayout = ImageLayout.Zoom;
            pnlMenu.Controls.Add(btnExibirColaboradores);
            pnlMenu.Controls.Add(btnFerias);
            pnlMenu.Controls.Add(btnBuscarColaboradorFiltro);
            pnlMenu.Controls.Add(txtBuscarColaborador);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(200, 450);
            pnlMenu.TabIndex = 0;
            // 
            // btnExibirColaboradores
            // 
            btnExibirColaboradores.Cursor = Cursors.Hand;
            btnExibirColaboradores.Dock = DockStyle.Top;
            btnExibirColaboradores.Image = (Image)resources.GetObject("btnExibirColaboradores.Image");
            btnExibirColaboradores.ImageAlign = ContentAlignment.MiddleLeft;
            btnExibirColaboradores.Location = new Point(0, 50);
            btnExibirColaboradores.Margin = new Padding(4, 3, 4, 3);
            btnExibirColaboradores.Name = "btnExibirColaboradores";
            btnExibirColaboradores.Size = new Size(200, 27);
            btnExibirColaboradores.TabIndex = 6;
            btnExibirColaboradores.Text = "Exibir  todos colaboradores";
            btnExibirColaboradores.UseVisualStyleBackColor = true;
            btnExibirColaboradores.Click += btnExibirColaboradores_Click;
            // 
            // btnFerias
            // 
            btnFerias.Cursor = Cursors.Hand;
            btnFerias.Dock = DockStyle.Bottom;
            btnFerias.Image = (Image)resources.GetObject("btnFerias.Image");
            btnFerias.ImageAlign = ContentAlignment.MiddleLeft;
            btnFerias.Location = new Point(0, 423);
            btnFerias.Margin = new Padding(4, 3, 4, 3);
            btnFerias.Name = "btnFerias";
            btnFerias.Size = new Size(200, 27);
            btnFerias.TabIndex = 5;
            btnFerias.Text = "Férias";
            btnFerias.UseVisualStyleBackColor = true;
            btnFerias.Click += btnFerias_Click_1;
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
            btnBuscarColaboradorFiltro.Size = new Size(200, 27);
            btnBuscarColaboradorFiltro.TabIndex = 4;
            btnBuscarColaboradorFiltro.Text = "Buscar";
            btnBuscarColaboradorFiltro.UseVisualStyleBackColor = true;
            // 
            // txtBuscarColaborador
            // 
            txtBuscarColaborador.Dock = DockStyle.Top;
            txtBuscarColaborador.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarColaborador.ForeColor = SystemColors.MenuText;
            txtBuscarColaborador.Location = new Point(0, 0);
            txtBuscarColaborador.Margin = new Padding(4, 3, 4, 3);
            txtBuscarColaborador.Name = "txtBuscarColaborador";
            txtBuscarColaborador.Size = new Size(200, 23);
            txtBuscarColaborador.TabIndex = 3;
            txtBuscarColaborador.Text = "Buscar Colaborador por CPF";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ButtonFace;
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(200, 425);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(600, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(86, 22);
            toolStripLabel1.Text = "toolStripLabel1";
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
            dataGridView1.Location = new Point(200, 0);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(600, 425);
            dataGridView1.TabIndex = 5;
            // 
            // frmMenuFerias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Controls.Add(pnlMenu);
            Name = "frmMenuFerias";
            Text = "frmAcompanhamentoFerias";
            Load += frmAcompanhamentoFerias_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMenu;
        private ToolStrip toolStrip1;
        private Button btnBuscarColaboradorFiltro;
        private TextBox txtBuscarColaborador;
        private Button btnFerias;
        private ToolStripLabel toolStripLabel1;
        public DataGridView dataGridView1;
        private Button btnExibirColaboradores;
    }
}