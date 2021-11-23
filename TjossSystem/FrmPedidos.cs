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
    public partial class FrmPedidos : FrmPadrao
    {
        PedidoDI objPedidoDI;
        ItensPedidoDI objItensPedido;

        DataTable dttPedidos;
        DataTable dttItensPedido;

        List<TipoPedidoDI> lstTipoPedidoDI;
        List<TipoContratoDI> lstTipoContratoDI;

        public FrmPedidos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Criando tabelas
        /// </summary>
        private void CriarDataTables()
        {
            dttPedidos = new DataTable();
            dttPedidos.Columns.Add("NumeroPedido");
            dttPedidos.Columns.Add("CodigoTipoPedido");
            dttPedidos.Columns.Add("CodigoCadastro");
            dttPedidos.Columns.Add("SituacaoPedido");
            dttPedidos.Columns.Add("DataConclusao");
            dttPedidos.Columns.Add("NumeroContrato");
            dttPedidos.Columns.Add("CodigoTipoContrato");
            dttPedidos.Columns.Add("ValorTotalPedido");
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            dgvPedidos.AutoGenerateColumns = false;
            CriarDataTables();

            ModuloPedidos objModuloPedidos = new ModuloPedidos();
            ModuloContratos objModuloContratos = new ModuloContratos();

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
        }

        private void tsbGravar_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarPrePedido_Click(object sender, EventArgs e)
        {
            //evento para testes.
            ModuloPedidos objMetodosPedidos = new ModuloPedidos();
            string strErro = string.Empty;
            PedidoDI objPedidoDI = new PedidoDI 
            { 
                CodigoCadastro = 2,
                CodigoTipoPedido = 1,
                SituacaoPedido = "A",
                ValorTotalPedido = 0
            };



            if(!objMetodosPedidos.RegistrarPedido(objPedidoDI, out strErro))
            {
                MessageBox.Show($"{strErro}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnFiltrarPedidos_Click(object sender, EventArgs e)
        {
            ModuloPedidos objMetodosPedidos = new ModuloPedidos();

            //validar os campos da tela
            if (!string.IsNullOrEmpty(txtCodigoCadastro.Text))
            {
                if(!int.TryParse(txtCodigoCadastro.Text, out _))
                {
                    MessageBox.Show($"Código do cadastro está inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                //campo vazio.
                txtCodigoCadastro.Text = "0";
            }

            if (!string.IsNullOrEmpty(txtNumeroPedido.Text))
            {
                if (!decimal.TryParse(txtNumeroPedido.Text, out _))
                {
                    MessageBox.Show($"Número do pedido está inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                txtNumeroPedido.Text = "0";
            }

            List<PedidoDI> lstPedidosDI = objMetodosPedidos.ListarPedidos(Convert.ToInt32(txtNumeroPedido.Text), 
                                                                         (int)cboCodigoTipoPedido.SelectedValue, 
                                                                         Convert.ToInt32(txtCodigoCadastro.Text));

            dttPedidos.Clear();
            foreach (var objPedido in lstPedidosDI)
            {
                dttPedidos.Rows.Add(objPedido.NumeroPedido,
                                    objPedido.CodigoTipoPedido,
                                    objPedido.CodigoCadastro,
                                    objPedido.SituacaoPedido,
                                    objPedido.DataConclusao,
                                    objPedido.NumeroContrato,
                                    objPedido.CodigoTipoContrato,
                                    objPedido.ValorTotalPedido.ToString("N2"));
            }

            dgvPedidos.DataSource = dttPedidos;
            txtNumeroPedido.Clear();
            txtCodigoCadastro.Clear();
        }

        private void dgvPedidos_DoubleClick(object sender, EventArgs e)
        {
            //Passa os dados do pedido para tela que adiciona itens;
            if (dgvPedidos.SelectedRows.Count == 1)
            {
                DataGridViewRow rowLinha = dgvPedidos.SelectedRows[0];
                objPedidoDI = new PedidoDI
                {
                    NumeroPedido = Convert.ToInt32(rowLinha.Cells[clnNumeroPedido.Name].Value),
                    CodigoTipoPedido = Convert.ToInt32(rowLinha.Cells[clnCodigoTipoPedido.Name].Value),
                    SituacaoPedido = rowLinha.Cells[clnSituacaoPedido.Name].Value.ToString(),
                    CodigoCadastro = Convert.ToInt32(rowLinha.Cells[clnCodigoCadastro.Name].Value),
                    ValorTotalPedido = Math.Round(Convert.ToDecimal(rowLinha.Cells[clnValorTotalPedido.Name].Value), 2),
                    NumeroContrato = !string.IsNullOrEmpty(rowLinha.Cells[clnNumeroContrato.Name].Value.ToString())  ? Convert.ToInt32(rowLinha.Cells[clnNumeroContrato.Name].Value) : 0,
                    CodigoTipoContrato = !string.IsNullOrEmpty(rowLinha.Cells[clnCodigoTipoContrato.Name].Value.ToString()) ? Convert.ToInt32(rowLinha.Cells[clnCodigoTipoContrato.Name].Value) : 0
                };

                FrmPedidoNovo objPedidosNovo = new FrmPedidoNovo(objPedidoDI);
                objPedidosNovo.CodigoFuncionario = CodigoFuncionario;
                objPedidosNovo.Show();
            }
        }

        private void blnNovoPedido_Click(object sender, EventArgs e)
        {
            FrmPedidoNovo objPedidosNovo = new FrmPedidoNovo(null);
            objPedidosNovo.CodigoFuncionario = CodigoFuncionario;
            objPedidosNovo.Show();
        }

        private void btnFecharPedido_Click(object sender, EventArgs e)
        {
            //Fecha pedido e movimenta estoque.
            if (dgvPedidos.SelectedRows.Count == 1)
            {
                ModuloPedidos objMetodosPedidos = new ModuloPedidos();
                string strErro = string.Empty;
                DataGridViewRow rowLinha = dgvPedidos.SelectedRows[0];
                objPedidoDI = new PedidoDI
                {
                    NumeroPedido = Convert.ToInt32(rowLinha.Cells[clnNumeroPedido.Name].Value),
                    CodigoTipoPedido = Convert.ToInt32(rowLinha.Cells[clnCodigoTipoPedido.Name].Value),
                    SituacaoPedido = "F", //Status de cancelado
                    CodigoCadastro = Convert.ToInt32(rowLinha.Cells[clnCodigoCadastro.Name].Value),
                    NumeroContrato = rowLinha.Cells[clnNumeroContrato.Name].Value != null ? (int?)rowLinha.Cells[clnNumeroContrato.Name].Value : null,
                    CodigoTipoContrato = rowLinha.Cells[clnNumeroContrato.Name].Value != null ? (int?)rowLinha.Cells[clnCodigoTipoContrato.Name].Value : null
                };

                if (!objMetodosPedidos.FecharPedido(objPedidoDI, CodigoFuncionario, out strErro))
                {
                    MessageBox.Show($"{strErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tsbLimpar.PerformClick();
            }
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            //Apenas cancela o Pedido.
            if (dgvPedidos.SelectedRows.Count == 1)
            {
                ModuloPedidos objMetodosPedidos = new ModuloPedidos();
                string strErro = string.Empty;
                DataGridViewRow rowLinha = dgvPedidos.SelectedRows[0];
                objPedidoDI = new PedidoDI
                {
                    NumeroPedido = Convert.ToInt32(rowLinha.Cells[clnNumeroPedido.Name].Value),
                    CodigoTipoPedido = Convert.ToInt32(rowLinha.Cells[clnCodigoTipoPedido.Name].Value),
                    SituacaoPedido = "C", //Status de cancelado
                    CodigoCadastro = Convert.ToInt32(rowLinha.Cells[clnCodigoCadastro.Name].Value),
                };

                if (!objMetodosPedidos.CancelarPedido(objPedidoDI, out strErro))
                {
                    MessageBox.Show($"{strErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tsbLimpar.PerformClick();
            }
        }

        private void tsbLimpar_Click(object sender, EventArgs e)
        {
            FrmPedidos objNewForm = new FrmPedidos();
            objNewForm.CodigoFuncionario = CodigoFuncionario;
            objNewForm.Show();
            this.Dispose(false);
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPedidos_KeyDown(object sender, KeyEventArgs e)
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
