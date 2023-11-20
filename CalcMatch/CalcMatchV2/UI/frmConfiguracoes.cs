using CalcMatchV2.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMatchV1.UI.FormsFilho
{
    public partial class frmConfiguracoes : Form
    {
        public frmConfiguracoes()
        {
            InitializeComponent();
            
        }

        private void Configuracoes_Load(object sender, EventArgs e)
        {
            LoadTheme();
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

        private void pnlAviso_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
