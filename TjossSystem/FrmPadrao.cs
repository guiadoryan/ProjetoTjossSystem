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
        public int CodigoFuncionario { get; set; }

        public FrmPadrao()
        {
            InitializeComponent();
        }
    }
}
