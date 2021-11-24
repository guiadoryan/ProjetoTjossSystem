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
    public partial class FrmPedidoNovo : FrmPadrao
    {
        /// <summary>
        /// Dados do pedido
        /// </summary>
        PedidoDI objPedidoDI;

        /// <summary>
        /// Dados dos itens do pedido
        /// </summary>
        DataTable dttItensPedido;

        /// <summary>
        /// Lista com os tipos de Pedido
        /// </summary>
        List<TipoPedidoDI> lstTipoPedidoDI;

        /// <summary>
        /// Lista com os tipos de Contrato
        /// </summary>
        List<TipoContratoDI> lstTipoContratoDI;

        public FrmPedidoNovo(PedidoDI pPedidoDI)
        {
            InitializeComponent();
            objPedidoDI = pPedidoDI != null && pPedidoDI.NumeroPedido == 0 ? null : pPedidoDI;
        }

        /// <summary>
        /// Criando tabelas
        /// </summary>
        private void CriarDataTables()
        {
            dttItensPedido = new DataTable();
            dttItensPedido.Columns.Add("NumeroPedido");
            dttItensPedido.Columns.Add("CodigoTipoPedido");
            dttItensPedido.Columns.Add("CodigoItem");
            dttItensPedido.Columns.Add("QuantidadeSolicitada");
            dttItensPedido.Columns.Add("QuantidadeBaixada");
            dttItensPedido.Columns.Add("ValorUnitario");
            dttItensPedido.Columns.Add("ValorTotalItem");
            dttItensPedido.Columns.Add("CodigoCadastro");
            dttItensPedido.Columns.Add("CodigoMedida");
        }

        private void blnAdicionarItem_Click(object sender, EventArgs e)
        {
            Metodos.Metodos objMetodos = new Metodos.Metodos();
            ModuloDeItens objModuloItens = new ModuloDeItens();
            ModuloPedidos objModuloPedidos = new ModuloPedidos();
            ModuloContratos objModuloContratos = new ModuloContratos();

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
                if(decPrecoItem == 0)
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

            if (!string.IsNullOrEmpty(txtQuantidadeSolicitada.Text))
            {
                if (!decimal.TryParse(txtQuantidadeSolicitada.Text, out _))
                {
                    MessageBox.Show($"Quantidade solicitada está inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Convert.ToDecimal(txtQuantidadeSolicitada.Text) <= 0)
                {
                    MessageBox.Show($"Quantidade solicitada está tem que ser maior que zero!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show($"Quantidade solicitada está inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(txtCodigoCadastroMedida.Text) && !string.IsNullOrEmpty(txtCodigoMedida.Text))
            {
                if (!int.TryParse(txtCodigoCadastroMedida.Text, out _))
                {
                    MessageBox.Show($"Código do cadastro de medida está inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(txtCodigoMedida.Text, out _))
                {
                    MessageBox.Show($"Código medida está inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!string.IsNullOrEmpty(txtNumeroContrato.Text))
            {
                if (!int.TryParse(txtNumeroContrato.Text, out _))
                {
                    MessageBox.Show($"Número do contrato está inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ItensContratoDI objItemContrato = objModuloContratos.BuscarItemDoContrato(Convert.ToInt32(txtNumeroContrato.Text), (int)cboCodigoTipoContrato.SelectedValue, Convert.ToInt32(txtCodigoItem.Text));
                if (objItemContrato == null)
                {
                    MessageBox.Show($"Item não encontrado no contrato informado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            //buscar cadastro para validação de definição.
            List<DefinicaoDI> lstDefinicaoCadastro = objMetodos.ListarDefinicoesCadastro(Convert.ToInt32(txtCodigoCadastro.Text));
            if ((int)cboCodigoTipoPedido.SelectedValue == 1) //Se for pedido de compra, o cadastro tem que ser fornecedor.
            {
                DefinicaoDI objDefinicaoDI = lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 2).FirstOrDefault();
                if (objDefinicaoDI == null || lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 2).FirstOrDefault().CodigoDefinicao != 2)
                {
                    MessageBox.Show($"Cadastro não é um fornecedor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrEmpty(txtValorUnitario.Text))
                {
                    if (!decimal.TryParse(txtValorUnitario.Text, out _))
                    {
                        MessageBox.Show($"Valor unitário inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show($"Valor unitário está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            } else if ((int)cboCodigoTipoPedido.SelectedValue != 1) //Se for venda ou aluguel, pega atividade de cliente.
            {
                DefinicaoDI objDefinicaoDI = lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 2).FirstOrDefault();
                if (objDefinicaoDI == null || lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 1).FirstOrDefault().CodigoDefinicao != 1)
                {
                    MessageBox.Show($"Cadastro não é um cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if ((int)cboCodigoTipoPedido.SelectedValue == 3)
                {
                    decPrecoItem /= 2; //Aluguel é pela metade do preço do item.
                }
            }

            ItensPedidoDI objItensPedido = new ItensPedidoDI
            {
                NumeroPedido = objPedidoDI != null ? objPedidoDI.NumeroPedido : 0,
                CodigoTipoPedido = objPedidoDI != null ? objPedidoDI.CodigoTipoPedido : 0,
                CodigoItem = Convert.ToInt32(txtCodigoItem.Text),
                QuantidadeSolicitada = Convert.ToDecimal(txtQuantidadeSolicitada.Text),
                QuantidadeBaixada = 0, //Só é baixada quando concluir o pedido.
                ValorUnitario = (int)cboCodigoTipoPedido.SelectedValue == 1 ? Convert.ToDecimal(txtValorUnitario.Text) : decPrecoItem,
                ValorTotalItem = (int)cboCodigoTipoPedido.SelectedValue == 1 ? Convert.ToDecimal(txtValorUnitario.Text) * Convert.ToDecimal(txtQuantidadeSolicitada.Text) : decPrecoItem * Convert.ToDecimal(txtQuantidadeSolicitada.Text),
                CodigoCadastro = !string.IsNullOrEmpty(txtCodigoCadastroMedida.Text) ? Convert.ToInt32(txtCodigoCadastroMedida.Text) : 0,
                CodigoMedida = !string.IsNullOrEmpty(txtCodigoMedida.Text) ? Convert.ToInt32(txtCodigoMedida.Text) : 0,
            };

            if (objPedidoDI == null)
            {
                objPedidoDI = new PedidoDI
                {
                    NumeroPedido = 0,
                    CodigoTipoPedido = (int)cboCodigoTipoPedido.SelectedValue,
                    CodigoCadastro = Convert.ToInt32(txtCodigoCadastro.Text),
                    SituacaoPedido = "A",
                    ValorTotalPedido = (int)cboCodigoTipoPedido.SelectedValue == 1 ? Convert.ToDecimal(txtValorUnitario.Text) * Convert.ToDecimal(txtQuantidadeSolicitada.Text) : decPrecoItem * Convert.ToDecimal(txtQuantidadeSolicitada.Text),//decPrecoItem * Convert.ToDecimal(txtQuantidadeSolicitada.Text),
                    NumeroContrato = !string.IsNullOrEmpty(txtNumeroContrato.Text) ? Convert.ToInt32(txtNumeroContrato.Text) : 0,
                    CodigoTipoContrato = !string.IsNullOrEmpty(txtNumeroContrato.Text) ? (int)cboCodigoTipoContrato.SelectedValue : 0,
                };
                objPedidoDI.ItensPedido = new List<ItensPedidoDI>();
            }

            tsbGravar.Enabled = true;
            objPedidoDI.ItensPedido.Add(objItensPedido);
            dgvItensPedido.DataSource = null;
            dgvItensPedido.DataSource = objPedidoDI.ItensPedido;
        }

        private void bntEditarItem_Click(object sender, EventArgs e)
        {
            /*DataGridViewRow rowItemPedido = dgvItensPedido.SelectedRows.Count > 0 ? dgvItensPedido.SelectedRows[0] : null;
            if (rowItemPedido != null)
            {
                Metodos.Metodos objMetodos = new Metodos.Metodos();
                ModuloDeItens objModuloItens = new ModuloDeItens();
                ModuloPedidos objModuloPedidos = new ModuloPedidos();
                ModuloContratos objModuloContratos = new ModuloContratos();

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

                if (!string.IsNullOrEmpty(txtQuantidadeSolicitada.Text))
                {
                    if (!decimal.TryParse(txtQuantidadeSolicitada.Text, out _))
                    {
                        MessageBox.Show($"Quantidade solicitada está inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (Convert.ToDecimal(txtQuantidadeSolicitada.Text) <= 0)
                    {
                        MessageBox.Show($"Quantidade solicitada está tem que ser maior que zero!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show($"Quantidade solicitada está inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrEmpty(txtCodigoCadastroMedida.Text) && !string.IsNullOrEmpty(txtCodigoMedida.Text))
                {
                    if (!int.TryParse(txtCodigoCadastroMedida.Text, out _))
                    {
                        MessageBox.Show($"Código do cadastro de medida está inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!int.TryParse(txtCodigoMedida.Text, out _))
                    {
                        MessageBox.Show($"Código medida está inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (!string.IsNullOrEmpty(txtNumeroContrato.Text))
                {
                    if (!int.TryParse(txtNumeroContrato.Text, out _))
                    {
                        MessageBox.Show($"Número do contrato está inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ItensContratoDI objItemContrato = objModuloContratos.BuscarItemDoContrato(Convert.ToInt32(txtNumeroContrato.Text), (int)cboCodigoTipoContrato.SelectedValue, Convert.ToInt32(txtCodigoItem.Text));
                    if (objItemContrato == null)
                    {
                        MessageBox.Show($"Item não encontrado no contrato informado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                //buscar cadastro para validação de definição.
                List<DefinicaoDI> lstDefinicaoCadastro = objMetodos.ListarDefinicoesCadastro(Convert.ToInt32(txtCodigoCadastro.Text));
                if ((int)cboCodigoTipoPedido.SelectedValue == 1) //Se for pedido de compra, o cadastro tem que ser fornecedor.
                {
                    DefinicaoDI objDefinicaoDI = lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 2).FirstOrDefault();
                    if (objDefinicaoDI == null || lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 2).FirstOrDefault().CodigoDefinicao != 2)
                    {
                        MessageBox.Show($"Cadastro não é um fornecedor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!string.IsNullOrEmpty(txtValorUnitario.Text))
                    {
                        if (!decimal.TryParse(txtValorUnitario.Text, out _))
                        {
                            MessageBox.Show($"Valor unitário inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Valor unitário está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if ((int)cboCodigoTipoPedido.SelectedValue != 1) //Se for venda ou aluguel, pega atividade de cliente.
                {
                    DefinicaoDI objDefinicaoDI = lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 2).FirstOrDefault();
                    if (objDefinicaoDI == null || lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 1).FirstOrDefault().CodigoDefinicao != 1)
                    {
                        MessageBox.Show($"Cadastro não é um cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if ((int)cboCodigoTipoPedido.SelectedValue == 3)
                    {
                        decPrecoItem /= 2; //Aluguel é pela metade do preço do item.
                    }
                }

                rowItemPedido.Cells[clnValorUnitario.Name].Value = !string.IsNullOrEmpty(txtAltura.Text) ? txtAltura.Text : string.Empty;
                rowItemPedido.Cells[clnCinturaMedida.Name].Value = !string.IsNullOrEmpty(txtCintura.Text) ? txtCintura.Text : string.Empty;
                rowItemPedido.Cells[clnOmbroAhOmbro.Name].Value = !string.IsNullOrEmpty(txtOmbroAhOmbro.Text) ? txtOmbroAhOmbro.Text : string.Empty;
                rowItemPedido.Cells[clnBustoMedida.Name].Value = !string.IsNullOrEmpty(txtBustoMedida.Text) ? txtBustoMedida.Text : string.Empty;
                rowItemPedido.Cells[clnObservacaoMedida.Name].Value = !string.IsNullOrEmpty(txtObservacaoMedida.Text) ? txtObservacaoMedida.Text : string.Empty;
                rowItemPedido.Cells[clnSituacaoMedida.Name].Value = cboSituacaoMedida.SelectedIndex == 0 ? "A" : "I";
            }*/
        }

        private void tsbGravar_Click(object sender, EventArgs e)
        {
            ModuloPedidos objModuloPedidos = new ModuloPedidos();
            string strErro = string.Empty;

            if (!objModuloPedidos.RegistrarPedido(objPedidoDI, out strErro))
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
            FrmPedidoNovo objNewForm = new FrmPedidoNovo(objPedidoDI);
            objNewForm.CodigoFuncionario = CodigoFuncionario;
            objNewForm.Show();
            this.Dispose(false);
        }

        private void FrmPedidoNovo_Load(object sender, EventArgs e)
        {
            dgvItensPedido.AutoGenerateColumns = false;
            CriarDataTables();

            ModuloPedidos objModuloPedidos = new ModuloPedidos();
            ModuloContratos objModuloContratos = new ModuloContratos();

            List<ItensPedidoDI> lstItensPedido = new List<ItensPedidoDI>();
            lstTipoContratoDI = new List<TipoContratoDI>();
            lstTipoPedidoDI = new List<TipoPedidoDI>();

            lstTipoContratoDI = objModuloContratos.ListarTiposContrato();
            lstTipoPedidoDI = objModuloPedidos.ListarTiposPedido();

            cboCodigoTipoContrato.DataSource = lstTipoContratoDI;
            cboCodigoTipoContrato.ValueMember = "CodigoTipoContrato";
            cboCodigoTipoContrato.DisplayMember = "DescricaoComboBox";

            cboCodigoTipoPedido.DataSource = lstTipoPedidoDI;
            cboCodigoTipoPedido.ValueMember = "CodigoTipoPedido";
            cboCodigoTipoPedido.DisplayMember = "DescricaoComboBox";

            if (objPedidoDI != null)
            {
                objPedidoDI.ItensPedido = new List<ItensPedidoDI>();
                //Faz o procedimento de edição
                cboCodigoTipoPedido.SelectedValue = objPedidoDI.CodigoTipoPedido;
                txtCodigoCadastro.Text = objPedidoDI.CodigoCadastro.ToString();
                cboCodigoTipoPedido.Enabled = false;
                txtCodigoCadastro.Enabled = false;

                if (objPedidoDI.NumeroContrato != null && objPedidoDI.NumeroContrato != 0)
                {
                    txtNumeroContrato.Text = objPedidoDI.NumeroContrato.ToString();
                    cboCodigoTipoContrato.SelectedValue = objPedidoDI.CodigoTipoContrato;
                }

                //Buscar informações dos itens.

                lstItensPedido = objModuloPedidos.BuscarItensPedido(objPedidoDI.NumeroPedido, objPedidoDI.CodigoTipoPedido);
                dttItensPedido.Clear();
                foreach (var objItemPedido in lstItensPedido)
                {
                    ItensPedidoDI objItemPedidoDI = new ItensPedidoDI 
                    {
                        NumeroPedido = objItemPedido.NumeroPedido,
                        CodigoTipoPedido = objItemPedido.CodigoTipoPedido,
                        CodigoItem = objItemPedido.CodigoItem,
                        QuantidadeSolicitada = objItemPedido.QuantidadeSolicitada,
                        QuantidadeBaixada = objItemPedido.QuantidadeBaixada,
                        ValorUnitario = objItemPedido.ValorUnitario,
                        ValorTotalItem = objItemPedido.ValorTotalItem,
                        CodigoCadastro = objItemPedido.CodigoCadastro,
                        CodigoMedida = objItemPedido.CodigoMedida
                    };

                    objPedidoDI.ItensPedido.Add(objItemPedidoDI);
                    /*dttItensPedido.Rows.Add(objItemPedido.NumeroPedido,
                                            objItemPedido.CodigoTipoPedido,
                                            objItemPedido.CodigoItem,
                                            objItemPedido.QuantidadeSolicitada,
                                            objItemPedido.QuantidadeBaixada,
                                            objItemPedido.ValorUnitario,
                                            objItemPedido.ValorTotalItem,
                                            objItemPedido.CodigoCadastro,
                                            objItemPedido.CodigoMedida);*/
                }

                dgvItensPedido.DataSource = null;
                dgvItensPedido.DataSource = objPedidoDI.ItensPedido;
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
                if (!int.TryParse(txtCodigoCadastro.Text, out _))
                {
                    MessageBox.Show($"Cadastro Invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoCadastro.Focus();
                    return;
                }
            }
            List<DefinicaoDI> lstDefinicaoCadastro = objMetodos.ListarDefinicoesCadastro(Convert.ToInt32(txtCodigoCadastro.Text));
            if ((int)cboCodigoTipoPedido.SelectedValue == 1) //Se for pedido de compra, o cadastro tem que ser fornecedor.
            {
                DefinicaoDI objDefinicaoDI = lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 2).FirstOrDefault();
                if (objDefinicaoDI == null || lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 2).FirstOrDefault().CodigoDefinicao != 2)
                {
                    MessageBox.Show($"Cadastro não é um fornecedor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if ((int)cboCodigoTipoPedido.SelectedValue != 1) //Se for venda ou aluguel, pega atividade de cliente.
            {
                DefinicaoDI objDefinicaoDI = lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 2).FirstOrDefault();
                if (objDefinicaoDI == null || lstDefinicaoCadastro.Where(c => c.CodigoDefinicao == 1).FirstOrDefault().CodigoDefinicao != 1)
                {
                    MessageBox.Show($"Cadastro não é um cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if ((int)cboCodigoTipoPedido.SelectedValue == 3)
                {
                    decPrecoItem /= 2; //Aluguel é pela metade do preço do item.
                }
            }
            grpDadosChaveCargo.Enabled = false;
        }

        private void FrmPedidoNovo_KeyDown(object sender, KeyEventArgs e)
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

        private void FrmPedidoNovo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
