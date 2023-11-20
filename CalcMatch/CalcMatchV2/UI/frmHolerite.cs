using CalcMatchV1.Entities;
using CalcMatchV2.AcessoDados;
using CalcMatchV2.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CalcMatchV1.UI.FormsFilho
{
    public partial class frmHolerite : Form
    {
        public frmHolerite()
        {
            InitializeComponent();
            LoadTheme();

        }

        private void Holerite_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Empty;
            using (var db = new AppDbContext())
            {
                AtualizarColaboradores(db);
            }

        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecundaryColor;
                }
            }

        }
        private void AtualizarColaboradores(AppDbContext db)
        {
            this.Cursor = Cursors.WaitCursor;
            dataGridView1.DataSource = db.Funcionarios.ToList();
            this.Cursor = Cursors.Default;
            dataGridView1.Columns.Remove(dataGridView1.Columns["Observacoes"]);
            dataGridView1.Columns.Remove(dataGridView1.Columns["dependentes"]);
        }

        private void btnBuscarColaboradorFiltro_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                this.Cursor = Cursors.WaitCursor;
                dataGridView1.DataSource = db.Funcionarios.
                    Where(x => x.Cpf == txtBuscarColaborador.Text).ToList();
                dataGridView1.Columns.Remove(dataGridView1.Columns["Observacoes"]);
                dataGridView1.Columns.Remove(dataGridView1.Columns["dependentes"]);
                this.Cursor = Cursors.Default;
                toolStripStatusLabel1.Text = "Pronto!";

            }
        }

        private void btnGerarHolerite_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = null;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    using (var db = new AppDbContext())
                    {
                        linhaSelecionada = dataGridView1.SelectedRows[0];
                        Funcionario funcionario = linhaSelecionada.DataBoundItem as Funcionario;

                        var listaDependenes = db.Dependentes.
                            Where(x => x.FuncionarioId == funcionario.Id).ToList();

                        funcionario.dependentes = listaDependenes;


                        Holerite.GerarHolerite(funcionario);
                        toolStripStatusLabel1.Text = "Holerite gerado!";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    toolStripStatusLabel1.Text = "Erro ao tentar gerar o holerite!";
                }



            }
        }
    }
}
