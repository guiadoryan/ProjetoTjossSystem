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
        /// <summary>
        /// Classe que contem os metodos executados pelas telas.
        /// </summary>
        Metodos.Metodos objMetodos;
        public FrmMenu()
        {
            InitializeComponent();
            objMetodos = new Metodos.Metodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strErro;
            objMetodos.RegistrarCadastro(1, "Guilherme Adoryan", out strErro);
        }
    }
}
