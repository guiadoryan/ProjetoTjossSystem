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
    public partial class FrmPadrao : Form
    {
        /// <summary>
        /// Código do funcionario logado no sistema
        /// </summary>
        public int intCodigoFuncionario = 0;

        public FrmPadrao()
        {
            InitializeComponent();
        }

        private void FrmPadrao_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void FrmPadrao_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*foreach (Control ctrControl in this.Controls)
            {
                if (ctrControl is TextBox)
                {
                    TextBox txtCampo = ctrControl as TextBox;
                    if (txtCampo.Tag == "num")
                    {
                        if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ',')
                        {
                            e.Handled = true;
                        }
                    }
                }
            }*/
        }

        private void FrmPadrao_Load(object sender, EventArgs e)
        {

        }
    }
}
