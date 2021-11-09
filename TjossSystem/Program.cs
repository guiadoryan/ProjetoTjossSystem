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
            FrmLogin objLogin = new FrmLogin();
            objLogin.ShowDialog();
            int intFuncionario = objLogin.intCodigoFuncionario;
            if(objLogin.DialogResult == DialogResult.Yes)
            {
                Application.Run(new FrmMenu(ref intFuncionario));
            }
        }
    }
}
