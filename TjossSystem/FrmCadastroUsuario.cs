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
    public partial class FrmCadastroUsuario : FrmPadrao
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            ModuloUsuarios objMetodosUsuarios = new ModuloUsuarios();
            FuncionarioDI objFuncionarioDI = objMetodosUsuarios.ConsultarFuncionario(CodigoFuncionario);
            if (objFuncionarioDI != null && objFuncionarioDI.CodigoCargo > 1)
            {
                MessageBox.Show($"Apenas o Gerente tem permissão para usar essa tela!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void tsbGravar_Click(object sender, EventArgs e)
        {
            ModuloUsuarios objMetodosUsuarios = new ModuloUsuarios();
            string strErro = string.Empty;

            //Instancia classe data contract.
            UsuarioDI objUsuarioDI = new UsuarioDI();

            //VALIDAR OS CAMPOS
            if (!string.IsNullOrEmpty(txtCodigoUsuario.Text))
            {
                if (!int.TryParse(txtCodigoUsuario.Text, out _))
                {
                    MessageBox.Show("Código funcionario é invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Digite uma senha válida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(txtDatahCadastro.Text, out _))
            {
                MessageBox.Show("Data de Cadastro é invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //GRAVAR
            objUsuarioDI.CodigoFuncionario = Convert.ToInt32(txtCodigoUsuario.Text);
            objUsuarioDI.Senha = txtSenha.Text;

            if (!string.IsNullOrEmpty(txtDatahCadastro.Text.Replace("/", "").Trim()))
            {
                objUsuarioDI.DatahCadastro = Convert.ToDateTime(txtDatahCadastro.Text);
            }
            else
            {
                objUsuarioDI.DatahCadastro = DateTime.Now;
            }

            if (!objMetodosUsuarios.RegistrarUsuario(objUsuarioDI, out strErro))
            {
                MessageBox.Show($"{strErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tsbLimpar.PerformClick();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoUsuario.Text))
            {
                if (!int.TryParse(txtCodigoUsuario.Text, out _))
                {
                    MessageBox.Show($"Cógido do funcionario está inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ModuloUsuarios objMetodosUsuarios = new ModuloUsuarios();
                //Instancia classe data contract.
                FuncionarioDI objFuncionarioDI = objMetodosUsuarios.ConsultarFuncionario(Convert.ToInt32(txtCodigoUsuario.Text));

                if (objFuncionarioDI == null)
                {
                    MessageBox.Show($"Funcionario não encontrado nos registros!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UsuarioDI objUsuarioDI = objMetodosUsuarios.ConsultarUsuario(Convert.ToInt32(txtCodigoUsuario.Text));

                if (objUsuarioDI != null)
                {
                    txtSenha.Text = objUsuarioDI.Senha;
                    txtDatahCadastro.Text = $"{objUsuarioDI.DatahCadastro:G}";
                }
                
                grpDadosBasicos.Enabled = true;
                grpDadosChaveCargo.Enabled = false;
                tsbGravar.Enabled = true;
                txtSenha.Focus();
            }
            else
            {
                //Validar se o funcionario existe.
                MessageBox.Show($"Cógido do funcionario está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void tsbLimpar_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario objNewForm = new FrmCadastroUsuario();
            objNewForm.CodigoFuncionario = CodigoFuncionario;
            objNewForm.Show();
            this.Dispose(false);
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
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
