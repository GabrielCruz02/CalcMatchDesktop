using CalcMatchV1.UI.FormsFilho;
using CalcMatchV2.AcessoDados;
using CalcMatchV2.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMatchV1.UI
{
    public partial class frmMenuPrincipal : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Contructor
        public frmMenuPrincipal()
        {
            InitializeComponent();
            random = new Random();
            btnHome.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnlTitleBar.BackColor = color;
                    pnlLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecundaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnHome.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(81, 43, 129);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktopPanel.Controls.Add(childForm);
            this.pnlDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleHome.Text = childForm.Text;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsFilho.frmColaboradores(), sender);

        }

        private void btnHolerite_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsFilho.frmHolerite(), sender);
        }

        private void btnRelatorioGeral_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmApontamentos(), sender);
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmConfiguracoes(), sender);
        }

        private void lblTitleHome_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitleHome.Text = "HOME";
            pnlTitleBar.BackColor = Color.FromArgb(157, 118, 193);
            pnlLogo.BackColor = Color.FromArgb(53, 21, 93);
            currentButton = null;
            btnHome.Visible = false;
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
