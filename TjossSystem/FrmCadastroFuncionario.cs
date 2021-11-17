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
    public partial class FrmCadastroFuncionario : FrmPadrao
    {
        /// <summary>
        /// Lista de cargos
        /// </summary>
        List<CargoFuncionarioDI> lstCargoDI;

        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void FrmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            ModuloUsuarios objUsuario = new ModuloUsuarios();
            FuncionarioDI objFuncionarioDI = objUsuario.ConsultarFuncionario(CodigoFuncionario);
            if (objFuncionarioDI != null && objFuncionarioDI.CodigoCargo > 1)
            {
                MessageBox.Show($"Apenas o Gerente tem permissão para usar essa tela!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            lstCargoDI = new List<CargoFuncionarioDI>();
            lstCargoDI = objUsuario.ListarCargos();
            cboCodigoCargo.DataSource = lstCargoDI;
            cboCodigoCargo.ValueMember = "CodigoCargo";
            cboCodigoCargo.DisplayMember = "DescricaoCargo";
        }

        private void FrmCadastroFuncionario_KeyDown(object sender, KeyEventArgs e)
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

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoFuncionario.Text))
            {
                if (!int.TryParse(txtCodigoFuncionario.Text, out _))
                {
                    MessageBox.Show($"Cógido do funcionario esta inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ModuloUsuarios objMetodosUsuarios = new ModuloUsuarios();
                //Instancia classe data contract.
                FuncionarioDI objFuncionarioDI = objMetodosUsuarios.ConsultarFuncionario(Convert.ToInt32(txtCodigoFuncionario.Text));

                if (objFuncionarioDI != null)
                {
                    txtNomeFuncionario.Text = objFuncionarioDI.Nome;
                    txtCpf.Text = objFuncionarioDI.Cpf;
                    txtControle.Text = objFuncionarioDI.CpfControle;
                    txtDataNascimento.Text = $"{objFuncionarioDI.DataNascimento:d}";
                    txtDataAdmissao.Text = $"{objFuncionarioDI.DataAdmissao:d}";
                    txtDataDesligamento.Text = $"{objFuncionarioDI.DataDesligamento:d}";
                    cboCodigoCargo.SelectedValue = objFuncionarioDI.CodigoCargo;
                }

                grpDadosBasicos.Enabled = true;
                grpDadosChaveCargo.Enabled = false;
                tsbGravar.Enabled = true;
                txtNomeFuncionario.Focus();
            }
            else
            {
                grpDadosBasicos.Enabled = true;
                grpDadosChaveCargo.Enabled = false;
                tsbGravar.Enabled = true;
                txtNomeFuncionario.Focus();
            }
        }

        private void tsbGravar_Click(object sender, EventArgs e)
        {
            ModuloUsuarios objMetodosUsuarios = new ModuloUsuarios();
            string strErro = string.Empty;

            //Instancia classe data contract.
            FuncionarioDI objFuncionarioDI = new FuncionarioDI();

            //VALIDAR OS CAMPOS
            if (!string.IsNullOrEmpty(txtCodigoFuncionario.Text))
            {
                if (!int.TryParse(txtCodigoFuncionario.Text, out _))
                {
                    MessageBox.Show("Código funcionario é invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!DateTime.TryParse(txtDataNascimento.Text, out _))
            {
                MessageBox.Show("Data de nascimento é invalida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!DateTime.TryParse(txtDataAdmissao.Text, out _))
            {
                MessageBox.Show("Data de Admissão é invalida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //GRAVAR
            objFuncionarioDI.CodigoFuncionario = !string.IsNullOrEmpty(txtCodigoFuncionario.Text) ? Convert.ToInt32(txtCodigoFuncionario.Text) : 0;
            objFuncionarioDI.Nome = txtNomeFuncionario.Text;
            objFuncionarioDI.Cpf = txtCpf.Text;
            objFuncionarioDI.CpfControle = txtControle.Text;
            objFuncionarioDI.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
            objFuncionarioDI.DataAdmissao = Convert.ToDateTime(txtDataAdmissao.Text);
            if (!string.IsNullOrEmpty(txtDataDesligamento.Text.Replace("/","").Trim()))
            {
                objFuncionarioDI.DataDesligamento = Convert.ToDateTime(txtDataDesligamento.Text);
            }
            else
            {
                objFuncionarioDI.DataDesligamento = null;
            }
            objFuncionarioDI.CodigoCargo = (int)cboCodigoCargo.SelectedValue;

            if (!objMetodosUsuarios.RegistrarFuncionario(objFuncionarioDI, out strErro))
            {
                MessageBox.Show($"{strErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tsbLimpar.PerformClick();
        }

        private void tsbLimpar_Click(object sender, EventArgs e)
        {
            FrmCadastroFuncionario objNewForm = new FrmCadastroFuncionario();
            objNewForm.CodigoFuncionario = CodigoFuncionario;
            objNewForm.Show();
            this.Dispose(false);
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Números [0,9], Backspace, e decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtControle_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Números [0,9], Backspace, e decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCodigoFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Números [0,9], Backspace, e decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != ','))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
