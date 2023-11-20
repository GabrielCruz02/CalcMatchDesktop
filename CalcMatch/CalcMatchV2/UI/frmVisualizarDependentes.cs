using CalcMatchV1.Entities;
using CalcMatchV2.AcessoDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMatchV2.UI
{
    public partial class frmVisualizarDependentes : Form
    {
        public frmVisualizarDependentes()
        {
            InitializeComponent();

        }

        private void VisualizarDependentes_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                AtualizarDependente(db);

            }
        }

        public int funcionarioID;
        private void AtualizarDependente(AppDbContext db)
        {

            this.Cursor = Cursors.WaitCursor;
            dataGridView1.DataSource = db.Dependentes.
                Where(x => x.FuncionarioId == funcionarioID).ToList();
            this.Cursor = Cursors.Default;
            dataGridView1.Columns.Remove(dataGridView1.Columns["Funcionario"]);
            dataGridView1.Columns.Remove(dataGridView1.Columns["Id"]);

        }

        private void voltarStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}
