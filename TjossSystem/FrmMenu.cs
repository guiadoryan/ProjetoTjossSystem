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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cadastroDePessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro objCadastro = new FrmCadastro();
            objCadastro.Show();
        }
    }
}
