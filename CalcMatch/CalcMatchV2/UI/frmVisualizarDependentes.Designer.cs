namespace CalcMatchV2.UI
{
    partial class frmVisualizarDependentes
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizarDependentes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStrip2 = new ToolStrip();
            toolStrip1 = new ToolStrip();
            excluirStripButton1 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            voltarStripButton1 = new ToolStripButton();
            pnlTitleBar = new Panel();
            lblTitulo = new Label();
            appDbContextBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            toolStrip1.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.Bottom;
            toolStrip2.Location = new Point(0, 379);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(499, 25);
            toolStrip2.TabIndex = 46;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { excluirStripButton1, toolStripSeparator3, voltarStripButton1 });
            toolStrip1.Location = new Point(0, 63);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(499, 25);
            toolStrip1.TabIndex = 48;
            toolStrip1.Text = "toolStrip1";
            // 
            // excluirStripButton1
            // 
            excluirStripButton1.Image = (Image)resources.GetObject("excluirStripButton1.Image");
            excluirStripButton1.ImageTransparentColor = Color.Magenta;
            excluirStripButton1.Name = "excluirStripButton1";
            excluirStripButton1.Size = new Size(62, 22);
            excluirStripButton1.Text = "&Excluir";
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
            pnlTitleBar.TabIndex = 47;
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
            // appDbContextBindingSource
            // 
            appDbContextBindingSource.DataSource = typeof(AcessoDados.AppDbContext);
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
            dataGridView1.Location = new Point(0, 88);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(499, 291);
            dataGridView1.TabIndex = 49;
            // 
            // VisualizarDependentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 404);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Controls.Add(pnlTitleBar);
            Name = "VisualizarDependentes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VisualizarDependentes";
            Load += VisualizarDependentes_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip2;
        private ToolStrip toolStrip1;
        private ToolStripButton excluirStripButton1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton voltarStripButton1;
        private Panel pnlTitleBar;
        private Label lblTitulo;
        private BindingSource appDbContextBindingSource;
        public DataGridView dataGridView1;
    }
}