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
    public partial class FrmContratoNovo : FrmPadrao
    {
        /// <summary>
        /// Dados do pedido
        /// </summary>
        ContratoDI objContratoDI;

        /// <summary>
        /// Dados dos itens do pedido
        /// </summary>
        DataTable dttItensPedido;

        /// <summary>
        /// Lista com os tipos de Contrato
        /// </summary>
        List<TipoContratoDI> lstTipoContratoDI;

        public FrmContratoNovo(ContratoDI pContratoDI)
        {
            InitializeComponent();
            objContratoDI = pContratoDI != null && pContratoDI.NumeroContrato == 0 ? null : pContratoDI;
        }

        private void blnAdicionarItem_Click(object sender, EventArgs e)
        {
            Metodos.Metodos objMetodos = new Metodos.Metodos();
            ModuloDeItens objModuloItens = new ModuloDeItens();

            decimal decPrecoItem = 0;
            //Validação dos campos, estoque e cadastro/atividade
            if (!string.IsNullOrEmpty(txtCodigoItem.Text))
            {
                if (!int.TryParse(txtCodigoItem.Text, out _))
                {
                    MessageBox.Show($"Código do item está inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Buscar preço do item no banco.
                decPrecoItem = objModuloItens.ConsultarEstoque(Convert.ToInt32(txtCodigoItem.Text), 1).ValorUnitario;
                if (decPrecoItem == 0)
                {
                    MessageBox.Show($"Item não cadastrado no estoque!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show($"Código do item está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(txtSaldoContratado.Text))
            {
                if (!decimal.TryParse(txtSaldoContratado.Text, out _))
                {
                    MessageBox.Show($"Saldo Contratado está inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Convert.ToDecimal(txtSaldoContratado.Text) <= 0)
                {
                    MessageBox.Show($"Saldo Contratado está tem que ser maior que zero!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show($"Saldo Contratado está inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //buscar cadastro para validação de definição.
            List<DefinicaoDI> lstDefinicaoCadastro = objMetodos.ListarDefinicoesCadastro(Convert.ToInt32(txtCodigoCadastro.Text));
            if ((int)cboCodigoTipoContrato.SelectedValue == 1) //Se for pedido de compra, o cadastro tem que ser fornecedor.
            {
                DefinicaoDI objDefinicaoDI = lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 2).FirstOrDefault();
                if (objDefinicaoDI == null || lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 2).FirstOrDefault().CodigoDefinicao != 2)
                {
                    MessageBox.Show($"Cadastro não é um fornecedor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrEmpty(txtValorItem.Text))
                {
                    if (!decimal.TryParse(txtValorItem.Text, out _))
                    {
                        MessageBox.Show($"Valor do item inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show($"Valor do item está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if ((int)cboCodigoTipoContrato.SelectedValue != 1) //Se for venda ou aluguel, pega atividade de cliente.
            {
                DefinicaoDI objDefinicaoDI = lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 2).FirstOrDefault();
                if (objDefinicaoDI == null || lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 1).FirstOrDefault().CodigoDefinicao != 1)
                {
                    MessageBox.Show($"Cadastro não é um cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if ((int)cboCodigoTipoContrato.SelectedValue == 3)
                {
                    decPrecoItem /= 2; //Aluguel é pela metade do preço do item.
                }
            }

            ItensContratoDI objItensContrato = new ItensContratoDI
            {
                NumeroContrato = objContratoDI != null ? objContratoDI.NumeroContrato : 0,
                CodigoTipoContrato = objContratoDI != null ? objContratoDI.CodigoTipoContrato : 0,
                CodigoItem = Convert.ToInt32(txtCodigoItem.Text),
                SaldoContratado = Convert.ToDecimal(txtSaldoContratado.Text),
                SaldoAtual = 0, //Só é baixada quando concluir o pedido.
                ValorItem = (int)cboCodigoTipoContrato.SelectedValue == 1 ? Convert.ToDecimal(txtValorItem.Text) : decPrecoItem
            };

            if (objContratoDI == null)
            {
                objContratoDI = new ContratoDI
                {
                    NumeroContrato = 0,
                    CodigoTipoContrato = (int)cboCodigoTipoContrato.SelectedValue,
                    CodigoCadastro = Convert.ToInt32(txtCodigoCadastro.Text),
                    DataContrato = DateTime.Now.Date,
                    DataVencimento = DateTime.Now.Date.AddDays(30),
                    SituacaoContrato = "A",
                    CodigoVendedor = null,
                    DatahAlteracao = DateTime.Now,
                    CodigoFuncionario = CodigoFuncionario
                };
                objContratoDI.ItensContrato = new List<ItensContratoDI>();
            }

            tsbGravar.Enabled = true;
            objContratoDI.ItensContrato.Add(objItensContrato);
            dgvItensContrato.DataSource = null;
            dgvItensContrato.DataSource = objContratoDI.ItensContrato;
        }

        private void bntEditarItem_Click(object sender, EventArgs e)
        {

        }

        private void tsbGravar_Click(object sender, EventArgs e)
        {
            ModuloContratos objModuloContratos = new ModuloContratos();
            string strErro = string.Empty;

            if (!objModuloContratos.RegistrarContrato(objContratoDI, out strErro))
            {
                MessageBox.Show($"{strErro}!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tsbFechar.PerformClick();
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbLimpar_Click(object sender, EventArgs e)
        {
            FrmContratoNovo objNewForm = new FrmContratoNovo(objContratoDI);
            objNewForm.CodigoFuncionario = CodigoFuncionario;
            objNewForm.Show();
            this.Dispose(false);
        }

        private void FrmContratoNovo_Load(object sender, EventArgs e)
        {
            dgvItensContrato.AutoGenerateColumns = false;
            //CriarDataTables();

            ModuloContratos objModuloContratos = new ModuloContratos();

            List<ItensContratoDI> lstItensContrato = new List<ItensContratoDI>();
            lstTipoContratoDI = new List<TipoContratoDI>();

            lstTipoContratoDI = objModuloContratos.ListarTiposContrato();

            cboCodigoTipoContrato.DataSource = lstTipoContratoDI;
            cboCodigoTipoContrato.ValueMember = "CodigoTipoContrato";
            cboCodigoTipoContrato.DisplayMember = "DescricaoComboBox";

            if (objContratoDI != null)
            {
                objContratoDI.ItensContrato = new List<ItensContratoDI>();
                //Faz o procedimento de edição
                cboCodigoTipoContrato.SelectedValue = objContratoDI.CodigoTipoContrato;
                txtCodigoCadastro.Text = objContratoDI.CodigoCadastro.ToString();
                txtCodigoCadastro.Enabled = false;

                /*if (objPedidoDI.NumeroContrato != null && objPedidoDI.NumeroContrato != 0)
                {
                    txtNumeroContrato.Text = objPedidoDI.NumeroContrato.ToString();
                    cboCodigoTipoContrato.SelectedValue = objPedidoDI.CodigoTipoContrato;
                }*/

                //Buscar informações dos itens.

                lstItensContrato = objModuloContratos.BuscarItensContrato(objContratoDI.NumeroContrato, objContratoDI.CodigoTipoContrato);
                foreach (var objItemContrato in lstItensContrato)
                {
                    ItensContratoDI objItemContratoDI = new ItensContratoDI
                    {
                        NumeroContrato = objItemContrato.NumeroContrato,
                        CodigoTipoContrato = objItemContrato.CodigoTipoContrato,
                        CodigoItem = objItemContrato.CodigoItem,
                        SaldoContratado = objItemContrato.SaldoContratado,
                        SaldoAtual = objItemContrato.SaldoAtual,
                        ValorItem = objItemContrato.ValorItem
                    };

                    objContratoDI.ItensContrato.Add(objItemContratoDI);
                }

                dgvItensContrato.DataSource = null;
                dgvItensContrato.DataSource = objContratoDI.ItensContrato;
            }
        }

        private void grpDadosChaveCargo_Validated(object sender, EventArgs e)
        {
            Metodos.Metodos objMetodos = new Metodos.Metodos();
            decimal decPrecoItem = 0;
            //buscar cadastro para validação de definição.
            if (string.IsNullOrEmpty(txtCodigoCadastro.Text))
            {
                txtCodigoCadastro.Focus();
                return;
            }
            else
            {
                if (int.TryParse(txtCodigoCadastro.Text, out _))
                {
                    MessageBox.Show($"Cadastro Invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoCadastro.Focus();
                    return;
                }
            }
            List<DefinicaoDI> lstDefinicaoCadastro = objMetodos.ListarDefinicoesCadastro(Convert.ToInt32(txtCodigoCadastro.Text));
            if (lstDefinicaoCadastro == null || lstDefinicaoCadastro.Count <= 0)
            {
                MessageBox.Show($"Cadastro não tem nenhuma definição cadastrada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoCadastro.Focus();
                return;
            }
            if ((int)cboCodigoTipoContrato.SelectedValue == 1) //Se for pedido de compra, o cadastro tem que ser fornecedor.
            {
                DefinicaoDI objDefinicaoDI = lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 2).FirstOrDefault();
                if (objDefinicaoDI == null || lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 2).FirstOrDefault().CodigoDefinicao != 2)
                {
                    MessageBox.Show($"Cadastro não é um fornecedor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if ((int)cboCodigoTipoContrato.SelectedValue != 1) //Se for venda ou aluguel, pega atividade de cliente.
            {
                DefinicaoDI objDefinicaoDI = lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 2).FirstOrDefault();
                if (objDefinicaoDI == null || lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 1).FirstOrDefault().CodigoDefinicao != 1)
                {
                    MessageBox.Show($"Cadastro não é um cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if ((int)cboCodigoTipoContrato.SelectedValue == 3)
                {
                    decPrecoItem /= 2; //Aluguel é pela metade do preço do item.
                }
            }
            grpDadosChaveCargo.Enabled = false;
        }

        private void FrmContratoNovo_KeyDown(object sender, KeyEventArgs e)
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
