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
    public partial class FrmCadastro : Form
    {
        CadastroDI objCadastro;

        List<TipoCadastroDI> lstTipoCadastroDI;

        List<CidadeDI> lstCidadesDI;

        DataTable dttEnderecos;

        const int FUNCIONARIO = 1;

        public FrmCadastro()
        {
            InitializeComponent();

            //Foreach que verifica as colunas da dgv e desativa o SortMode para que o usuario não altere a ordem dos dados.
            //Link do codigo: stackoverflow.com/questions/4502442/how-to-disable-sort-in-datagridview
            foreach (DataGridViewColumn clnColumn in dgvEnderecos.Columns)
            {
                clnColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            /*foreach (DataGridViewColumn clnColumn in dgvDadosDiagnostico.Columns)
            {
                clnColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }*/
        }

        private void tsbGravar_Click(object sender, EventArgs e)
        {
            try
            {
                Metodos.Metodos objMetodos = new Metodos.Metodos();
                string strErro = string.Empty;
                DateTime dtaAtual = DateTime.Now;

                //Instancia classe data contract.
                CadastroDI objCadastroDI = new CadastroDI();
                List<EnderecoDI> lstEnderecoDI = new List<EnderecoDI>();

                //Passa os dados para a classe data contract.
                objCadastroDI.CodigoCadastro = !string.IsNullOrEmpty(txtNumeroCadastro.Text) ? Convert.ToInt32(txtNumeroCadastro.Text) : 0;
                objCadastroDI.NomeCadastro = txtNomeCadastro.Text;
                objCadastroDI.NomeFantasia = txtNomeFantasia.Text;
                objCadastroDI.CodigoTipoCadastro = (int)cboTipoCadastro.SelectedValue;
                objCadastroDI.CpfCnpj = txtCpfCnpj.Text;
                objCadastroDI.Controle = txtControle.Text;
                objCadastroDI.DatahAlteracao = dtaAtual;
                objCadastroDI.CodigoFuncionario = FUNCIONARIO;

                foreach (DataGridViewRow rowEndereco in dgvEnderecos.Rows)
                {
                    EnderecoDI objEnderecoDI = new EnderecoDI 
                    { 
                        CodigoCadastro = !string.IsNullOrEmpty(txtNumeroCadastro.Text) ? Convert.ToInt32(txtNumeroCadastro.Text) : 0,
                        CodigoFilial = Convert.ToInt32(rowEndereco.Cells[clnCodigoFilialEndereco.Name].Value),
                        Endereco = rowEndereco.Cells[clnEndereco.Name].Value.ToString(),
                        Bairro = rowEndereco.Cells[clnBairro.Name].Value.ToString(),
                        NumeroEndereco = Convert.ToInt32(rowEndereco.Cells[clnNumeroEndereco.Name].Value),
                        Complemento = rowEndereco.Cells[clnComplementoEndereco.Name].Value.ToString(),
                        CepEndereco = rowEndereco.Cells[clnCepEndereco.Name].Value.ToString(),
                        SituacaoEndereco = rowEndereco.Cells[clnSituacaoEndereco.Name].Value.ToString(),
                        CodigoCidade = Convert.ToInt32(rowEndereco.Cells[clnCodigoCidade.Name].Value),
                        DatahAlteracao = dtaAtual,
                        CodigoFuncionario = FUNCIONARIO
                    };

                    lstEnderecoDI.Add(objEnderecoDI);
                }

                //Chama o metodo que grava ou altera os dados do cadastro.
                if (!objMetodos.RegistrarCadastro(objCadastroDI, lstEnderecoDI, out strErro))
                {
                    MessageBox.Show($"{strErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch(Exception pEx)
            {
                MessageBox.Show($"Erro ao gravar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ValidarCamposTela()
        {
            if (!string.IsNullOrEmpty(txtNumeroCadastro.Text) && !int.TryParse(txtNumeroCadastro.Text, out _))
            {
                MessageBox.Show("Número do cadastro invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtNumeroCadastro_Leave(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeroCadastro.Text, out _))
            {
                MessageBox.Show("Número do cadastro invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Metodos.Metodos objMetodos = new Metodos.Metodos();

            if (!string.IsNullOrEmpty(txtNumeroCadastro.Text))
            {
                objCadastro = objMetodos.ConsultarCadastro(Convert.ToInt32(txtNumeroCadastro.Text));
                if (objCadastro.CodigoCadastro == 0)
                {
                    MessageBox.Show("Cadastro não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    txtNomeCadastro.Text = objCadastro.NomeCadastro;
                    txtNomeFantasia.Text = objCadastro.NomeFantasia;
                    txtCodigoTipoCadastro.Text = objCadastro.CodigoTipoCadastro.ToString();
                    cboTipoCadastro.SelectedValue = objCadastro.CodigoTipoCadastro;
                    txtCpfCnpj.Text = objCadastro.CpfCnpj;
                    txtControle.Text = objCadastro.Controle;
                    txtDatahAlteracao.Text = $"{objCadastro.DatahAlteracao:dd/MM/yyyy HH:mm:ss}";
                    txtCodigoFuncionario.Text = objCadastro.CodigoFuncionario.ToString();

                    dttEnderecos.Clear();
                    foreach (var objEndereco in objCadastro.EnderecosDI)
                    {
                        dttEnderecos.Rows.Add(objEndereco.CodigoCadastro,
                                              objEndereco.CodigoFilial,
                                              objEndereco.Endereco,
                                              objEndereco.Bairro,
                                              objEndereco.NumeroEndereco,
                                              objEndereco.Complemento,
                                              objEndereco.CepEndereco,
                                              objEndereco.SituacaoEndereco,
                                              objEndereco.CodigoCidade,
                                              objEndereco.DatahAlteracao,
                                              objEndereco.CodigoFuncionario);
                    }
                    //dttEnderecos.Rows.Add(objCadastro.EnderecosDI);
                    dgvEnderecos.DataSource = dttEnderecos;
                }
            }
            else
            {
                txtNomeCadastro.Focus();
                grpDadosChave.Enabled = false;
            }
        }

        private void tsbLimpar_Click(object sender, EventArgs e)
        {
            FrmCadastro objNewForm = new FrmCadastro();
            objNewForm.Show();
            this.Dispose(false);
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void blnAdicionarEndereco_Click(object sender, EventArgs e)
        {
            bool blnNovaFilial = true;
            int intFilial = dttEnderecos.Rows.Count;

            if (string.IsNullOrEmpty(txtFilial.Text) || !int.TryParse(txtFilial.Text, out _))
            {
                MessageBox.Show("Número da filial invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Endereço está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Bairro está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtNumero.Text) || !int.TryParse(txtNumero.Text, out _))
            {
                MessageBox.Show("Número do endereço invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtComplemento.Text))
            {
                MessageBox.Show("Complemento está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtCepEndereco.Text) || !int.TryParse(txtCepEndereco.Text, out _))
            {
                MessageBox.Show("CEP invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            /*if (!string.IsNullOrEmpty(situacao.Text) || !int.TryParse(txtFilial.Text, out _))
            {
                MessageBox.Show("Número da filial invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/
            foreach (DataGridViewRow rowEndereco in dgvEnderecos.Rows)
            {
                if (rowEndereco.Cells[clnCodigoFilialEndereco.Name].Value.ToString() == txtFilial.Text)
                {
                    blnNovaFilial = false;
                    rowEndereco.Cells[clnCodigoFilialEndereco.Name].Value = txtFilial.Text;
                    rowEndereco.Cells[clnEndereco.Name].Value = txtEndereco.Text;
                    rowEndereco.Cells[clnBairro.Name].Value = txtBairro.Text;
                    rowEndereco.Cells[clnNumeroEndereco.Name].Value = txtNumero.Text;
                    rowEndereco.Cells[clnComplementoEndereco.Name].Value = txtComplemento.Text;
                    rowEndereco.Cells[clnCepEndereco.Name].Value = txtCepEndereco.Text;
                    rowEndereco.Cells[clnSituacaoEndereco.Name].Value = cboSituacaoEndereco.SelectedIndex == 0 ? "A" : "I";
                    rowEndereco.Cells[clnCodigoCidade.Name].Value = cboCidade.SelectedValue;
                }
            }

            if (blnNovaFilial)
            {
                EnderecoDI objEnderecoDI = new EnderecoDI
                {
                    CodigoCadastro = Convert.ToInt32(txtNumeroCadastro.Text),
                    CodigoFilial = Convert.ToInt32(txtFilial.Text),
                    Endereco = txtEndereco.Text,
                    Bairro = txtBairro.Text,
                    NumeroEndereco = Convert.ToInt32(txtNumero.Text),
                    Complemento = txtComplemento.Text,
                    CepEndereco = txtCepEndereco.Text,
                    SituacaoEndereco = cboSituacaoEndereco.SelectedIndex == 0 ? "A" : "I",
                    CodigoCidade = (int)cboCidade.SelectedValue
                };
                /*txtNumeroCadastro.Text,
                                  intFilial.ToString(),
                                  txtEndereco.Text,
                                  txtBairro.Text,
                                  txtNumero.Text,
                                  txtComplemento.Text,
                                  txtCepEndereco.Text,
                                  cboSituacaoEndereco.SelectedIndex == 0 ? "A" : "I",
                                  cboCidade.SelectedValue);*/
                objCadastro.EnderecosDI.Add(objEnderecoDI);
                dgvEnderecos.DataSource = null;
                dgvEnderecos.DataSource = objCadastro.EnderecosDI;
            }
            else
            {

            }    
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            dgvEnderecos.AutoGenerateColumns = false;
            CriarDataTables();

            Metodos.Metodos objMetodos = new Metodos.Metodos();
            lstTipoCadastroDI = new List<TipoCadastroDI>();
            lstCidadesDI = new List<CidadeDI>();

            //cboTipoCadastro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cboTipoCadastro.AutoCompleteSource = AutoCompleteSource.ListItems;

            lstTipoCadastroDI = objMetodos.ConsultarTipoCadastro();
            lstCidadesDI = objMetodos.ConsultarCidades();

            cboTipoCadastro.DataSource = lstTipoCadastroDI;
            cboTipoCadastro.ValueMember = "CodigoTipoCadastro";
            cboTipoCadastro.DisplayMember = "DescricaoTipoCadastro";

            cboCidade.DataSource = lstCidadesDI;
            cboCidade.ValueMember = "CodigoCidade";
            cboCidade.DisplayMember = "DescricaoCidade";
        }

        private void CriarDataTables()
        {
            dttEnderecos = new DataTable();
            dttEnderecos.Columns.Add("CodigoCadastro");
            dttEnderecos.Columns.Add("CodigoFilial");
            dttEnderecos.Columns.Add("Endereco");
            dttEnderecos.Columns.Add("Bairro");
            dttEnderecos.Columns.Add("NumeroEndereco");
            dttEnderecos.Columns.Add("Complemento");
            dttEnderecos.Columns.Add("CepEndereco");
            dttEnderecos.Columns.Add("SituacaoEndereco");
            dttEnderecos.Columns.Add("CodigoCidade");
            dttEnderecos.Columns.Add("DatahAlteracao");
            dttEnderecos.Columns.Add("CodigoFuncionario");
        }

        private void FrmCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if ((e.KeyChar == (char)Keys.Enter))
            {
                //Verifica se é TextBox Multiline, se não for muda o foco para o proximo controle
                if (!((sender as Form).ActiveControl is TextBoxBase) ||
                    ((sender as Form).ActiveControl is TextBoxBase &&
                    !((sender as Form).ActiveControl as TextBoxBase).Multiline))
                {
                    //Obs.: A mudança de campos não funcionará para formulário que contem SplitContainer.
                    ProcessTabKey(true);
                }
            }*/

            if (sender is TextBoxBase)
            {
                //ComponentEnable(pSender, e);

                if ((sender as TextBoxBase).Multiline)
                {
                    (sender as TextBoxBase).Text = (sender as TextBoxBase).Text.Trim().Replace("  ", " ");
                }
            }
        }
    }
}
