using CalcMatchV1.Entities;
using CalcMatchV2.AcessoDados;
using CalcMatchV2.UI;
using MessageUtils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMatchV1.UI.FormsFilho
{
    public partial class frmColaboradores : Form
    {
        public frmColaboradores()
        {
            InitializeComponent();
            LoadTheme();
            Util.txtLimpaCampo(txtBuscarColaborador);
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

        AppDbContext AppDbContext;
        private void Colaboradores_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            using (var db = new AppDbContext())
            {
                AtualizarColaboradores(db);
                toolStripStatusLabel1.Text = "Pronto!";
            }


        }

        private void pnlAviso_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnAlterarColaborador_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = null;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                linhaSelecionada = dataGridView1.SelectedRows[0];
                Funcionario funcionario = linhaSelecionada.DataBoundItem as Funcionario;
                
                using (var form = new frmAdicionarColaborador())
                {
                   
                    form.Text = "Alterando dados do(a) colaborador(a)...";
                    toolStripStatusLabel1.Text = "Alterando dados do(a) colaborador(a)...";
                    form.statusStrip1.Text = "Alterando dados do(a) colaborador(a)...";
                    form.txtCodigoColaborador.Text = Convert.ToString(funcionario.Id);
                    form.dtpDataAdmissao.Text = Convert.ToString(funcionario.DataAdmissao);
                    form.txtCtps.Text = funcionario.Ctps;
                    form.txtNomeColaborador.Text = funcionario.Nome;
                    form.txtNomeSocial.Text = funcionario.NomeSocial;
                    form.txtCpf.Text = funcionario.Cpf;
                    form.txtIdentidade.Text = funcionario.RegistroGeral;
                    form.dtpNascimento.Text = Convert.ToString(funcionario.Nascimento);
                    form.txtEndereco.Text = funcionario.Endereco;
                    form.cbxSexo.Text = funcionario.Sexo;
                    form.txtEmail.Text = funcionario.Email;
                    form.txtTelefone.Text = funcionario.Telefone;
                    form.txtCargo.Text = funcionario.Cargo;
                    form.txtSalario.Text = Convert.ToString(funcionario.ValorHora);
                    form.txtObservacoes.Text = funcionario.Observacoes;
                    form.cbxSituacao.Text = funcionario.Situacao;

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (var db = new AppDbContext())
                            {

                                funcionario.DataAdmissao = Convert.ToDateTime(form.dtpDataAdmissao.Text);
                                funcionario.Ctps = form.txtCtps.Text;
                                funcionario.Nome = form.txtNomeColaborador.Text;
                                funcionario.NomeSocial = form.txtNomeSocial.Text;
                                funcionario.Cpf = form.txtCpf.Text;
                                funcionario.RegistroGeral = form.txtIdentidade.Text;
                                funcionario.Nascimento = Convert.ToDateTime(form.dtpNascimento.Text);
                                funcionario.Endereco = form.txtEndereco.Text;
                                funcionario.Sexo = form.cbxSexo.Text;
                                funcionario.Email = form.txtEmail.Text;
                                funcionario.Telefone = form.txtTelefone.Text;
                                funcionario.Cargo = form.txtCargo.Text;
                                funcionario.ValorHora = Convert.ToDouble(form.txtSalario.Text);
                                funcionario.Observacoes = form.txtObservacoes.Text;
                                funcionario.Situacao = form.cbxSituacao.Text;
                                db.Entry(funcionario).State = EntityState.Modified;
                                db.SaveChanges();
                                form.Close();
                                AtualizarColaboradores(db);
                                toolStripStatusLabel1.Text = "Colaborador(a) Atualiado(a)!";
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            this.Hide();
                        }
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Nenhuma modificação foi Adicionada!";
                    }
                }
            }
        }

        private void btnCadastroColaborador_Click(object sender, EventArgs e)
        {
            using (var form = new frmAdicionarColaborador())
            {
                form.Text = "Cadastrando Colaborador(a)...";
                toolStripStatusLabel1.Text = "Cadastrando Colaborador(a)...";
                form.statusStrip1.Text = "Cadastrando Colaborador(a)...";
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var db = new AppDbContext())
                        {

                            Funcionario funcionario = new Funcionario();

                            funcionario.DataAdmissao = Convert.ToDateTime(form.dtpDataAdmissao.Text);
                            funcionario.Ctps = form.txtCtps.Text;
                            funcionario.Nome = form.txtNomeColaborador.Text;
                            funcionario.NomeSocial = form.txtNomeSocial.Text;
                            funcionario.Cpf = form.txtCpf.Text;
                            funcionario.RegistroGeral = form.txtIdentidade.Text;
                            funcionario.Nascimento = Convert.ToDateTime(form.dtpNascimento.Text);
                            funcionario.Endereco = form.txtEndereco.Text;
                            funcionario.Sexo = form.cbxSexo.Text;
                            funcionario.Email = form.txtEmail.Text;
                            funcionario.Telefone = form.txtTelefone.Text;
                            funcionario.Cargo = form.txtCargo.Text;
                            funcionario.ValorHora = Convert.ToDouble(form.txtSalario.Text);
                            funcionario.Observacoes = form.txtObservacoes.Text;
                            funcionario.Situacao = form.cbxSituacao.Text;
                            db.Funcionarios.Add(funcionario);
                            db.SaveChanges();
                            form.Close();
                            AtualizarColaboradores(db);

                            toolStripStatusLabel1.Text = "Colaborador(a) Adicionado(a)!";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        this.Hide();
                    }

                }
                else
                {
                    toolStripStatusLabel1.Text = "Nenhum(a) colaborador(a) foi Adicionado(a)!";
                }
            }
        }

        private void btnExibirColaboradres_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                AtualizarColaboradores(db);
                toolStripStatusLabel1.Text = "Pronto!";
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterarColaborador_Click(null, null);
        }

        private void btnExcluirColaborador_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = null;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                linhaSelecionada = dataGridView1.SelectedRows[0];
                Funcionario funcionario = linhaSelecionada.DataBoundItem as Funcionario;
                if (SimpleMessage.Confirm(
                    "Deseja realmente excluir o colaborador(a) selecionado?",
                    "Exclusão de colaborador")) ;
                {
                    using (var db = new AppDbContext())
                    {
                        db.Funcionarios.Attach(funcionario);
                        db.Entry(funcionario).State = EntityState.Deleted;
                        db.SaveChanges();
                        AtualizarColaboradores(db);
                        SimpleMessage.Inform("Colaborador(a) excluído com sucesso.", "Informação");
                    }
                }

            }

        }
    }

}

