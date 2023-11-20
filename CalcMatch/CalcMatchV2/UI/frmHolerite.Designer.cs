namespace CalcMatchV1.UI.FormsFilho
{
    partial class frmHolerite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHolerite));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlButtonsColaborador = new Panel();
            btnGerarHolerite = new Button();
            btnBuscarColaboradorFiltro = new Button();
            txtBuscarColaborador = new TextBox();
            dataGridView1 = new DataGridView();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1 = new StatusStrip();
            pnlButtonsColaborador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlButtonsColaborador
            // 
            pnlButtonsColaborador.BackColor = SystemColors.Control;
            pnlButtonsColaborador.BackgroundImage = (Image)resources.GetObject("pnlButtonsColaborador.BackgroundImage");
            pnlButtonsColaborador.BackgroundImageLayout = ImageLayout.Zoom;
            pnlButtonsColaborador.Controls.Add(btnGerarHolerite);
            pnlButtonsColaborador.Controls.Add(btnBuscarColaboradorFiltro);
            pnlButtonsColaborador.Controls.Add(txtBuscarColaborador);
            pnlButtonsColaborador.Dock = DockStyle.Left;
            pnlButtonsColaborador.Location = new Point(0, 0);
            pnlButtonsColaborador.Margin = new Padding(4, 3, 4, 3);
            pnlButtonsColaborador.Name = "pnlButtonsColaborador";
            pnlButtonsColaborador.Size = new Size(233, 519);
            pnlButtonsColaborador.TabIndex = 6;
            // 
            // btnGerarHolerite
            // 
            btnGerarHolerite.Cursor = Cursors.Hand;
            btnGerarHolerite.Dock = DockStyle.Bottom;
            btnGerarHolerite.Image = (Image)resources.GetObject("btnGerarHolerite.Image");
            btnGerarHolerite.ImageAlign = ContentAlignment.MiddleLeft;
            btnGerarHolerite.Location = new Point(0, 492);
            btnGerarHolerite.Margin = new Padding(4, 3, 4, 3);
            btnGerarHolerite.Name = "btnGerarHolerite";
            btnGerarHolerite.Size = new Size(233, 27);
            btnGerarHolerite.TabIndex = 3;
            btnGerarHolerite.Text = "Gerar Holerite";
            btnGerarHolerite.UseVisualStyleBackColor = true;
            btnGerarHolerite.Click += btnGerarHolerite_Click;
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
            dataGridView1.Location = new Point(233, 0);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(700, 497);
            dataGridView1.TabIndex = 7;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(233, 497);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(700, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // frmHolerite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(dataGridView1);
            Controls.Add(statusStrip1);
            Controls.Add(pnlButtonsColaborador);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmHolerite";
            Text = "Holerite";
            Load += Holerite_Load;
            pnlButtonsColaborador.ResumeLayout(false);
            pnlButtonsColaborador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlButtonsColaborador;
        private Button btnBuscarColaboradorFiltro;
        private TextBox txtBuscarColaborador;
        public DataGridView dataGridView1;
        private Button btnGerarHolerite;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private StatusStrip statusStrip1;
    }
}