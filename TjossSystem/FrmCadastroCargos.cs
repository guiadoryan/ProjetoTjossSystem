using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TjossSystem
{
    public partial class FrmCadastroCargos : Form
    {
        public FrmCadastroCargos()
        {
            InitializeComponent();
        }

        private void tsbGravar_Click(object sender, EventArgs e)
        {

        }

        private void tsbLimpar_Click(object sender, EventArgs e)
        {

        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastroCargos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F9:
                    tsbGravar.PerformClick();
                    break;
                case Keys.F10:
                    tsbLimpar.PerformClick();
                    break;
                case Keys.F12:
                    tsbFechar.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
