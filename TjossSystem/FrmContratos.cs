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
    public partial class FrmContratos : FrmPadrao
    {
        /// <summary>
        /// Objeto de dados do contrato
        /// </summary>
        ContratoDI objContratoDI;

        /// <summary>
        /// Data table com dados do contrato
        /// </summary>
        DataTable dttContratos;

        /// <summary>
        /// Lista de tipos de contratos
        /// </summary>
        List<TipoContratoDI> lstTipoContratoDI;

        public FrmContratos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Criando tabelas
        /// </summary>
        private void CriarDataTables()
        {
            dttContratos = new DataTable();
            dttContratos.Columns.Add("NumeroContrato");
            dttContratos.Columns.Add("CodigoTipoContrato");
            dttContratos.Columns.Add("CodigoCadastro");
            dttContratos.Columns.Add("DataContrato");
            dttContratos.Columns.Add("DataVencimento");
            dttContratos.Columns.Add("SituacaoContrato");
            dttContratos.Columns.Add("CodigoVendedor");
            dttContratos.Columns.Add("DatahAlteracao");
            dttContratos.Columns.Add("CodigoFuncionario");
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbLimpar_Click(object sender, EventArgs e)
        {
            FrmContratos objNewForm = new FrmContratos();
            objNewForm.CodigoFuncionario = CodigoFuncionario;
            objNewForm.Show();
            this.Dispose(false);
        }

        private void FrmContratos_Load(object sender, EventArgs e)
        {
            dgvContratos.AutoGenerateColumns = false;
            CriarDataTables();

            ModuloContratos objModuloContratos = new ModuloContratos();

            lstTipoContratoDI = new List<TipoContratoDI>();

            lstTipoContratoDI = objModuloContratos.ListarTiposContrato();

            cboCodigoTipoContrato.DataSource = lstTipoContratoDI;
            cboCodigoTipoContrato.ValueMember = "CodigoTipoContrato";
            cboCodigoTipoContrato.DisplayMember = "DescricaoComboBox";
        }

        private void btnFiltrarContratos_Click(object sender, EventArgs e)
        {
            ModuloContratos objMetodosContratos = new ModuloContratos();

            //validar os campos da tela
            if (!string.IsNullOrEmpty(txtCodigoCadastro.Text))
            {
                if (!int.TryParse(txtCodigoCadastro.Text, out _))
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

            if (!string.IsNullOrEmpty(txtNumeroContrato.Text))
            {
                if (!decimal.TryParse(txtNumeroContrato.Text, out _))
                {
                    MessageBox.Show($"Número do contrato está inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                txtNumeroContrato.Text = "0";
            }

            List<ContratoDI> lstContratosDI = objMetodosContratos.ListarContratos(Convert.ToInt32(txtNumeroContrato.Text),
                                                                         (int)cboCodigoTipoContrato.SelectedValue,
                                                                         Convert.ToInt32(txtCodigoCadastro.Text));

            dttContratos.Clear();
            foreach (var objContrato in lstContratosDI)
            {
                dttContratos.Rows.Add(objContrato.NumeroContrato,
                                      objContrato.CodigoTipoContrato,
                                      objContrato.CodigoCadastro,
                                      objContrato.DataContrato,
                                      objContrato.DataVencimento,
                                      objContrato.SituacaoContrato,
                                      objContrato.CodigoVendedor,
                                      objContrato.DatahAlteracao,
                                      objContrato.CodigoFuncionario);
            }

            dgvContratos.DataSource = dttContratos;
            txtNumeroContrato.Clear();
            txtCodigoCadastro.Clear();
        }

        private void dgvContratos_DoubleClick(object sender, EventArgs e)
        {
            //Passa os dados do pedido para tela que adiciona itens;
            if (dgvContratos.SelectedRows.Count == 1)
            {
                DataGridViewRow rowLinha = dgvContratos.SelectedRows[0];
                objContratoDI = new ContratoDI
                {
                    NumeroContrato = Convert.ToInt32(rowLinha.Cells[clnNumeroContrato.Name].Value),
                    CodigoTipoContrato = Convert.ToInt32(rowLinha.Cells[clnCodigoTipoContrato.Name].Value),
                    CodigoCadastro = Convert.ToInt32(rowLinha.Cells[clnCodigoCadastro.Name].Value),
                    DataContrato = Convert.ToDateTime(rowLinha.Cells[clnDataContrato.Name].Value),
                    DataVencimento = Convert.ToDateTime(rowLinha.Cells[clnDataVencimento.Name].Value),
                    SituacaoContrato = rowLinha.Cells[clnSituacaoContrato.Name].Value.ToString(),
                    DatahAlteracao = Convert.ToDateTime(rowLinha.Cells[clnDatahAlteracao.Name].Value),
                    CodigoFuncionario = Convert.ToInt32(rowLinha.Cells[clnCodigoFuncionario.Name].Value)
                };

                FrmContratoNovo objContratoNovo = new FrmContratoNovo(objContratoDI);
                objContratoNovo.CodigoFuncionario = CodigoFuncionario;
                objContratoNovo.Show();
            }
        }

        private void blnNovoContrato_Click(object sender, EventArgs e)
        {
            FrmContratoNovo objContratoNovo = new FrmContratoNovo(null);
            objContratoNovo.CodigoFuncionario = CodigoFuncionario;
            objContratoNovo.Show();
        }

        private void btnFecharContrato_Click(object sender, EventArgs e)
        {
            //Fecha Contrato.
            if (dgvContratos.SelectedRows.Count == 1)
            {
                ModuloContratos objMetodosContrato = new ModuloContratos();
                string strErro = string.Empty;
                DataGridViewRow rowLinha = dgvContratos.SelectedRows[0];
                objContratoDI = new ContratoDI
                {
                    NumeroContrato = Convert.ToInt32(rowLinha.Cells[clnNumeroContrato.Name].Value),
                    CodigoTipoContrato = Convert.ToInt32(rowLinha.Cells[clnCodigoTipoContrato.Name].Value),
                    SituacaoContrato = "F", //Status de cancelado
                    CodigoCadastro = Convert.ToInt32(rowLinha.Cells[clnCodigoCadastro.Name].Value),
                    DatahAlteracao = DateTime.Now,
                    CodigoFuncionario = CodigoFuncionario
                };

                if (!objMetodosContrato.FecharContrato(objContratoDI, out strErro))
                {
                    MessageBox.Show($"{strErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tsbLimpar.PerformClick();
            }
        }

        private void btnCancelarContrato_Click(object sender, EventArgs e)
        {
            //Apenas cancela o Contrato.
            if (dgvContratos.SelectedRows.Count == 1)
            {
                ModuloContratos objMetodosContratos = new ModuloContratos();
                string strErro = string.Empty;
                DataGridViewRow rowLinha = dgvContratos.SelectedRows[0];
                objContratoDI = new ContratoDI
                {
                    NumeroContrato = Convert.ToInt32(rowLinha.Cells[clnNumeroContrato.Name].Value),
                    CodigoTipoContrato = Convert.ToInt32(rowLinha.Cells[clnCodigoTipoContrato.Name].Value),
                    SituacaoContrato = "C", //Status de cancelado
                    CodigoCadastro = Convert.ToInt32(rowLinha.Cells[clnCodigoCadastro.Name].Value),
                    DatahAlteracao = DateTime.Now,
                    CodigoFuncionario = CodigoFuncionario
                };

                if (!objMetodosContratos.CancelarContrato(objContratoDI, out strErro))
                {
                    MessageBox.Show($"{strErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tsbLimpar.PerformClick();
            }
        }

        private void FrmContratos_KeyDown(object sender, KeyEventArgs e)
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
