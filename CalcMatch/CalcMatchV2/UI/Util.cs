using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMatchV1.UI
{
    public static class Util 
    {
        //Evento que limpa o texto de descrição do campo ao clicar para evitar do usuário ter de apagar a descrição e só então conseguir escrever o seu texto, caso ele clique fora do campo a descrição é adicionada de volta.

        public static void txtLimpaCampo(TextBox txtBox)
        {
            string descricao = txtBox.Text;

            txtBox.Enter += (sender, e) =>
            {
                if (txtBox.Text == descricao)
                {
                    txtBox.Text = "";
                    txtBox.ForeColor = System.Drawing.SystemColors.WindowText;
                }

            };

            txtBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBox.Text))
                {
                    txtBox.Text = descricao;
                    txtBox.ForeColor = System.Drawing.SystemColors.GrayText;
                }
            };
        }
    }
}
