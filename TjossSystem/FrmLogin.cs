using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TjossSystem.Metodos;

namespace TjossSystem
{
    public partial class FrmLogin : FrmPadrao
    {
        /// <summary>
        /// Código do cargo
        /// </summary>
        public int intCargo = 0;

        /// <summary>
        /// Código do funcionario
        /// </summary>
        public int intCodigoFuncionario = 0;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        public void Login()
        {
            ModuloUsuarios objUsuarios = new ModuloUsuarios();
            string strErro = string.Empty;

            if(!int.TryParse(txtUsuario.Text, out _))
            {
                MessageBox.Show("Usuario inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtSenha.Text.Trim()))
            {
                MessageBox.Show("Informe a Senha corretamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!objUsuarios.ValidarUsuario(Convert.ToInt32(txtUsuario.Text), txtSenha.Text, ref intCargo, out strErro))
            {
                MessageBox.Show($"{strErro}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            intCodigoFuncionario = Convert.ToInt32(txtUsuario.Text);
            this.DialogResult = DialogResult.Yes;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
