using CalcMatchV1.UI;
using CalcMatchV2.AcessoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMatchV1
{
    internal static class Program
    {
        private static System.Timers.Timer timer;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //objeto Timer com intervalo de (atual está em 30 segundos) /1800000 - 30 minutos
            timer = new System.Timers.Timer(30000);
            timer.Elapsed += AgendaXML; //Associa o evento
            timer.Start(); //Inicia o timer

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenuPrincipal());

        }

        //Verifica o horário, quando atingir o horário alvo ele chama a função responsável por ler os arquivos XML e encerra o temporizador
        private static void AgendaXML(object sender, EventArgs e)
        {
            DateTime alvo = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 44, 0);//Pra testa mudar a hora e o minuto aqui

            if ((DateTime.Now >= alvo) && (DateTime.Now.Minute <= alvo.Minute + 1))
            {
                AppProcessamentoXML.LerXML();
                MessageBox.Show("Arquivos XML lidos e banco atualizado!");
                timer.Dispose();
                timer.Stop();
            }

        }
    }
}
