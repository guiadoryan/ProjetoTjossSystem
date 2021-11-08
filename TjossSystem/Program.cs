using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TjossSystem
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string strRetorno = string.Empty;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //TO DO: FAZER VALIDAÇÃO DE LOGIN.
            FrmLogin objLogin = new FrmLogin();
            objLogin.ShowDialog();
            if(objLogin.DialogResult == DialogResult.Yes)
            {
                Application.Run(new FrmMenu());
            }
            else
            {
                MessageBox.Show("Não foi possivel realizar o login, contate o suporte do sistema!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
