using CalcMatchV1.Entities;
using CalcMatchV2.AcessoDados;
using CalcMatchV2.UI;
using CalcMatchV2.UI.FormsFilho;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CalcMatchV1.UI.FormsFilho
{
    public partial class frmAdicionarColaborador : Form
    {

        public frmAdicionarColaborador()
        {

            InitializeComponent();

        }

        private void AdicionarColaborador_Load(object sender, EventArgs e)
        {
            LoadTheme();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            toolStripStatusLabel1.Text = "";
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(System.Windows.Forms.Button))
                {
                    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecundaryColor;
                }
            }

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }




        private void btnAddDependentes_Click(object sender, EventArgs e)
        {

            if (txtCodigoColaborador.Text != string.Empty)
            {
                try
                {
                    using (var form = new frmAdicionarDependente())
                    {
                        form.funcionarioID = Convert.ToInt32(txtCodigoColaborador.Text);


                        toolStrip1.Text = "Adicionando dependente...";
                        int FuncionarioId = Convert.ToInt32(txtCodigoColaborador.Text);

                        form.txtParentesco.Text = txtNomeColaborador.Text;
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            using (var db = new AppDbContext())
                            {

                                Dependente dependente = new Dependente();

                                dependente.Name = form.txtNomeDependete.Text;
                                dependente.Parentesco = form.txtParentesco.Text;
                                dependente.DataNascimento = Convert.ToDateTime(form.dtpNascimento.Text);
                                dependente.Sexo = cbxSexo.Text;
                                dependente.FuncionarioId = FuncionarioId;
                                db.Dependentes.Add(dependente);
                                db.SaveChanges();



                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Você deve cadastrar e salvar um \ncolaborador para adicionar seus dependentes");
            }



        }

        private void btnVisualizarDependente_Click(object sender, EventArgs e)
        {
            if (txtCodigoColaborador.Text != string.Empty)
            {
                using (var form = new frmVisualizarDependentes())
                {
                    form.funcionarioID = Convert.ToInt32(txtCodigoColaborador.Text);
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Você deve cadastrar e salvar um \ncolaborador para visualizar seus dependentes");
            }

        }


    }

}
