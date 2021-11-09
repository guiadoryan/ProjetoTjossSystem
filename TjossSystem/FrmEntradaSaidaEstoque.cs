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
    public partial class FrmEntradaSaidaEstoque : FrmPadrao
    {
        /// <summary>
        /// Lista de tipos de estoque
        /// </summary>
        List<TipoEstoqueDI> lstTipoEstoque;

        public FrmEntradaSaidaEstoque()
        {
            InitializeComponent();
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbLimpar_Click(object sender, EventArgs e)
        {
            FrmEntradaSaidaEstoque objNewForm = new FrmEntradaSaidaEstoque();
            objNewForm.CodigoFuncionario = CodigoFuncionario;
            objNewForm.Show();
            this.Dispose(false);
        }

        private void tsbGravar_Click(object sender, EventArgs e)
        {
            MovimentacaoEstoque objMovimentacao = new MovimentacaoEstoque();
            MovimentacaoEstoqueDI objMovimentacaoEstoqueDI;

            string strErro = string.Empty;

            if (!int.TryParse(txtCodigoItem.Text, out _))
            {
                MessageBox.Show($"Código do item inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtQuantidadeMovimentada.Text, out _))
            {
                MessageBox.Show($"Quantidade está inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtObservacaoMovimento.Text.Length <= 10)
            {
                MessageBox.Show($"Observação tem que ter 10 caracteres!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboTipoMovimento.SelectedIndex > 0)
            {
                MessageBox.Show($"Selecione um tipo de movimento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objMovimentacaoEstoqueDI = new MovimentacaoEstoqueDI
            {
                CodigoItem = Convert.ToInt32(txtCodigoItem.Text),
                CodigoTipoEstoque = (int)cboCodigoTipoEstoque.SelectedValue,
                TipoMovimento = cboTipoMovimento.SelectedIndex == 0 ? "E" : "S",
                QuantidadeMovimentada = Convert.ToDecimal(txtQuantidadeMovimentada.Text),
                DatahMovimento = DateTime.Now,
                CodigoFuncionario = CodigoFuncionario,
                NumeroPedido = null,
                CodigoTipoPedido = null,
                ObservacaoMovimento = $"{(cboTipoMovimento.SelectedIndex == 0 ? "Entrada Manual." : "Saida Manual.")} {txtObservacaoMovimento.Text}"
            };

            if (!objMovimentacao.RegistrarMovimentacaoEstoque(objMovimentacaoEstoqueDI, out strErro))
            {
                MessageBox.Show($"{strErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tsbLimpar.PerformClick();
        }

        private void FrmEntradaSaidaEstoque_Load(object sender, EventArgs e)
        {
            ModuloDeItens objModuloDeItens = new ModuloDeItens();
            lstTipoEstoque = new List<TipoEstoqueDI>();

            lstTipoEstoque = objModuloDeItens.BuscarTiposEstoques();

            cboCodigoTipoEstoque.DataSource = lstTipoEstoque;
            cboCodigoTipoEstoque.ValueMember = "CodigoTipoEstoque";
            cboCodigoTipoEstoque.DisplayMember = "DescricaoComboBox";

            cboCodigoTipoEstoque.SelectedIndex = 0;
        }

        private void FrmEntradaSaidaEstoque_KeyDown(object sender, KeyEventArgs e)
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

        private void txtQuantidadeMovimentada_KeyPress(object sender, KeyPressEventArgs e)
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
                    e.Handled = true;
            }
        }
    }
}
