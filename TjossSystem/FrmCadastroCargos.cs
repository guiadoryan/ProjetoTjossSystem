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
    public partial class FrmCadastroCargos : FrmPadrao
    {
        public FrmCadastroCargos()
        {
            InitializeComponent();
        }

        private void tsbGravar_Click(object sender, EventArgs e)
        {
            ModuloUsuarios objMetodosUsuarios = new ModuloUsuarios();
            string strErro = string.Empty;

            //Instancia classe data contract.
            CargoFuncionarioDI objCargoFuncionarioDI = new CargoFuncionarioDI();

            //VALIDAR OS CAMPOS
            if (!string.IsNullOrEmpty(txtCodigoCargo.Text))
            {
                if (!int.TryParse(txtCodigoCargo.Text, out _))
                {
                    MessageBox.Show("Código cargo é invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            //GRAVAR
            objCargoFuncionarioDI.CodigoCargo = !string.IsNullOrEmpty(txtCodigoCargo.Text) ? Convert.ToInt32(txtCodigoCargo.Text) : 0;
            objCargoFuncionarioDI.DescricaoCargo = txtDescricaoCargo.Text;
            objCargoFuncionarioDI.SituacaoCargo = cboSituacaoCargo.SelectedIndex == 0 ? "A" : "I";

            if (!objMetodosUsuarios.RegistrarCargo(objCargoFuncionarioDI, out strErro))
            {
                MessageBox.Show($"{strErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tsbLimpar.PerformClick();
        }

        private void tsbLimpar_Click(object sender, EventArgs e)
        {
            FrmCadastroCargos objNewForm = new FrmCadastroCargos();
            objNewForm.CodigoFuncionario = CodigoFuncionario;
            objNewForm.Show();
            this.Dispose(false);
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarCargo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoCargo.Text))
            {
                if (!int.TryParse(txtCodigoCargo.Text, out _))
                {
                    MessageBox.Show($"Cógido do cargo esta inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ModuloUsuarios objMetodosUsuarios = new ModuloUsuarios();
                //Instancia classe data contract.
                CargoFuncionarioDI objCargoFuncionarioDI = objMetodosUsuarios.ConsultarCargo(Convert.ToInt32(txtCodigoCargo.Text));

                txtDescricaoCargo.Text = objCargoFuncionarioDI.DescricaoCargo;
                cboSituacaoCargo.SelectedIndex = objCargoFuncionarioDI.SituacaoCargo == "A" ? 0 : 1;

                grpDadosBasicos.Enabled = true;
                grpDadosChaveCargo.Enabled = false;
                tsbGravar.Enabled = true;
                txtDescricaoCargo.Focus();
            }
            else
            {
                grpDadosBasicos.Enabled = true;
                grpDadosChaveCargo.Enabled = false;
                tsbGravar.Enabled = true;
                txtDescricaoCargo.Focus();
            }
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

        private void FrmCadastroCargos_Load(object sender, EventArgs e)
        {
            ModuloUsuarios objMetodosUsuarios = new ModuloUsuarios();
            FuncionarioDI objFuncionarioDI = objMetodosUsuarios.ConsultarFuncionario(CodigoFuncionario);
            if (objFuncionarioDI.CodigoCargo > 1)
            {
                MessageBox.Show($"Apenas o Gerente tem permissão para usar essa tela!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            cboSituacaoCargo.SelectedIndex = 0;
        }

        private void txtCodigoCargo_KeyPress(object sender, KeyPressEventArgs e)
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
