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
    public partial class FrmCadastroItemEstoque : FrmPadrao
    {
        /// <summary>
        /// Lista de tipos de estoque
        /// </summary>
        List<TipoEstoqueDI> lstTipoEstoque;

        public FrmCadastroItemEstoque()
        {
            InitializeComponent();
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbLimpar_Click(object sender, EventArgs e)
        {
            FrmCadastroItemEstoque objNewForm = new FrmCadastroItemEstoque();
            objNewForm.Show();
            this.Dispose(false);
        }

        private void btnBuscarEstoque_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoItem.Text))
            {
                if (!int.TryParse(txtCodigoItem.Text, out _))
                {
                    MessageBox.Show($"Cógido do item esta inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ModuloDeItens objMetodosItens = new ModuloDeItens();
                //Instancia classe data contract.
                EstoqueItemDI objEstoqueItemDI = objMetodosItens.ConsultarEstoque(Convert.ToInt32(txtCodigoItem.Text), (int)cboCodigoTipoEstoque.SelectedValue);

                txtQuantidadeDisponivel.Text = objEstoqueItemDI.Quantidade.ToString();
                txtValorProduto.Text = objEstoqueItemDI.ValorUnitario.ToString();

                grpDadosBasicos.Enabled = true;
                grpDadosChaveItens.Enabled = false;
                txtValorProduto.Focus();
            }
            else
            {
                //Precisa ter o item cadastrado antes
                MessageBox.Show("Código item está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void tsbGravar_Click(object sender, EventArgs e)
        {
            ModuloDeItens objMetodosItens = new ModuloDeItens();
            string strErro = string.Empty;

            //Instancia classe data contract.
            EstoqueItemDI objEstoqueItemDI = new EstoqueItemDI();

            //VALIDAR OS CAMPOS
            if (!string.IsNullOrEmpty(txtCodigoItem.Text))
            {
                if (!int.TryParse(txtCodigoItem.Text, out _))
                {
                    MessageBox.Show("Código item é invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                //Precisa ter o item cadastrado antes
                MessageBox.Show("Código item está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Verificar se o item existe

            if (!decimal.TryParse(txtValorProduto.Text, out _))
            {
                MessageBox.Show("Valor do produto inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //GRAVAR
            objEstoqueItemDI.CodigoItem = Convert.ToInt32(txtCodigoItem.Text);
            objEstoqueItemDI.CodigoTipoEstoque = (int)cboCodigoTipoEstoque.SelectedValue;
            objEstoqueItemDI.ValorUnitario = Convert.ToDecimal(txtValorProduto.Text);

            if (!objMetodosItens.RegistrarEstoque(objEstoqueItemDI, out strErro))
            {
                MessageBox.Show($"Excessão ao executar o método RegistrarItem!{Environment.NewLine}{strErro}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tsbLimpar.PerformClick();
        }

        private void FrmCadastroItemEstoque_KeyDown(object sender, KeyEventArgs e)
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

        private void FrmCadastroItemEstoque_Load(object sender, EventArgs e)
        {
            ModuloDeItens objModuloDeItens = new ModuloDeItens();
            lstTipoEstoque = new List<TipoEstoqueDI>();

            lstTipoEstoque = objModuloDeItens.BuscarTiposEstoques();

            cboCodigoTipoEstoque.DataSource = lstTipoEstoque;
            cboCodigoTipoEstoque.ValueMember = "CodigoTipoEstoque";
            cboCodigoTipoEstoque.DisplayMember = "DescricaoComboBox";

            cboCodigoTipoEstoque.SelectedIndex = 0;
        }

        private void txtQuantidadeDisponivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ',')
            {
                e.Handled = true;
            }
        }

        private void txtValorProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Números [0,9], Backspace, e decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != ','))
            {
                e.Handled = true;
                return;
            }

            // Verifica se contém apenas uma vírgula
            if (e.KeyChar == ',')
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtCodigoItem_KeyPress(object sender, KeyPressEventArgs e)
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
