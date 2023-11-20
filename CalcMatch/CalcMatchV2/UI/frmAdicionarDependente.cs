using CalcMatchV1;
using CalcMatchV1.Entities;
using CalcMatchV2.AcessoDados;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMatchV2.UI.FormsFilho
{
    public partial class frmAdicionarDependente : Form
    {

        public frmAdicionarDependente()
        {
            InitializeComponent();

        }

        private void ListDependentes_Load(object sender, EventArgs e)
        {


            this.Text = string.Empty;
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            toolStrip1.Text = "";
        }

        public int funcionarioID;
        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
                
        }

        private void excluirStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void voltarStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pnlConteudoDependentes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
