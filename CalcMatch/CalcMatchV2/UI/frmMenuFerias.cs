using CalcMatchV1.Entities;
using CalcMatchV1.UI.FormsFilho;
using CalcMatchV2.AcessoDados;
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

namespace CalcMatchV2.UI
{
    public partial class frmMenuFerias : Form
    {
        public frmMenuFerias()
        {
            InitializeComponent();
        }

        private void frmAcompanhamentoFerias_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "";
        }

        private void AtualizarColaboradores(AppDbContext db)
        {
            this.Cursor = Cursors.WaitCursor;
            dataGridView1.DataSource = db.Funcionarios.ToList();
            this.Cursor = Cursors.Default;
            dataGridView1.Columns.Remove(dataGridView1.Columns["DataAdmissao"]);
            dataGridView1.Columns.Remove(dataGridView1.Columns["NomeSocial"]);
            dataGridView1.Columns.Remove(dataGridView1.Columns["Nascimento"]);
            dataGridView1.Columns.Remove(dataGridView1.Columns["Sexo"]);
            dataGridView1.Columns.Remove(dataGridView1.Columns["RegistroGeral"]);
            dataGridView1.Columns.Remove(dataGridView1.Columns["Telefone"]);
            dataGridView1.Columns.Remove(dataGridView1.Columns["Email"]);
            dataGridView1.Columns.Remove(dataGridView1.Columns["Endereco"]);
            dataGridView1.Columns.Remove(dataGridView1.Columns["ValorHora"]);
            dataGridView1.Columns.Remove(dataGridView1.Columns["HorasTrabalhadas"]);
            dataGridView1.Columns.Remove(dataGridView1.Columns["Observacoes"]);
            dataGridView1.Columns.Remove(dataGridView1.Columns["dependentes"]);
            dataGridView1.Columns.Remove(dataGridView1.Columns["Cpf"]);
            dataGridView1.Columns.Remove(dataGridView1.Columns["Ctps"]);
            dataGridView1.Columns.Remove(dataGridView1.Columns["Situacao"]);
        }

        private void btnExibirColaboradores_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                AtualizarColaboradores(db);
                toolStripLabel1.Text = "Pronto!";
            }
        }

        private void btnFerias_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = null;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                linhaSelecionada = dataGridView1.SelectedRows[0];
                Funcionario funcionario = linhaSelecionada.DataBoundItem as Funcionario;

                using (var form = new frmAcompanhamentoFerias())
                {
                    form.txtCodigoColaborador.Text = Convert.ToString(funcionario.Id);
                    form.txtNomeColaborador.Text = funcionario.Nome;
                    form.txtInicioPeriodoAquisitivo.Text = Convert.ToString(funcionario.DataAdmissao);
                    form.txtTerminoPeriodoAquisitivo.Text = Convert.ToString(funcionario.DataAdmissao.AddYears(1));

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        using (var db = new AppDbContext())
                        {
                            funcionario.InicioFerias = Convert.ToDateTime(form.dtpInicioFerias.Text);
                            funcionario.TerminoFerias = Convert.ToDateTime(form.dtpTerminoFerias.Text);
                            db.Entry(funcionario).State = EntityState.Modified;
                            db.SaveChanges();
                            form.Close();
                            AtualizarColaboradores(db);
                            toolStripLabel1.Text = "Férias Atualiada!";
                        }
                    }
                    else
                    {
                        form.Close();
                        toolStripLabel1.Text = "Nenhuma modificação adicionada!";
                    }
                }
            }

        }
    }
}
