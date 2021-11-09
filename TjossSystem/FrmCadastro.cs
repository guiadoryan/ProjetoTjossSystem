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
    public partial class FrmCadastro : FrmPadrao
    {
        /// <summary>
        /// Objeto que fica os dados do cadastro
        /// </summary>
        CadastroDI objCadastro;

        /// <summary>
        /// DataTable com os endereços
        /// </summary>
        DataTable dttEnderecos;

        /// <summary>
        /// DataTable com os endereços
        /// </summary>
        DataTable dttMedidas;

        /// <summary>
        /// DataTable com os endereços
        /// </summary>
        DataTable dttDefinicao;

        /// <summary>
        /// Lista com os tipos de cadastros
        /// </summary>
        List<TipoCadastroDI> lstTipoCadastroDI;

        /// <summary>
        /// Lista de cidades
        /// </summary>
        List<CidadeDI> lstCidadesDI;

        /// <summary>
        /// Lista de tipos de definições
        /// </summary>
        List<TipoDefinicaoDI> lstTipoDefinicaoDI;

        /// <summary>
        /// Lista com os cadastros registrados.
        /// </summary>
        List<CadastroDI> lstCadastrosDI;

        public FrmCadastro()
        {
            InitializeComponent();

            //Foreach que verifica as colunas da dgv e desativa o SortMode para que o usuario não altere a ordem dos dados.
            //Link do codigo: stackoverflow.com/questions/4502442/how-to-disable-sort-in-datagridview
            foreach (DataGridViewColumn clnColumn in dgvEnderecos.Columns)
            {
                clnColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn clnColumn in dgvMedidas.Columns)
            {
                clnColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn clnColumn in dgvDefinicao.Columns)
            {
                clnColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        /// <summary>
        /// Valida os campos da Tela principal
        /// </summary>
        /// <returns>True se validar com sucesso, false caso o contrario.</returns>
        private bool ValidarCamposDadosBasicos()
        {
            //TO DO: VALIDAR CAMPOS DO CADASTRO
            /*if (!string.IsNullOrEmpty(txtNumeroCadastro.Text) && !int.TryParse(txtNumeroCadastro.Text, out _))
            {
                MessageBox.Show("Número do cadastro invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/
            if (string.IsNullOrEmpty(txtNomeCadastro.Text))
            {
                MessageBox.Show("Nome do cadastro está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtNomeFantasia.Text))
            {
                MessageBox.Show("Nome do cadastro está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtCpfCnpj.Text) || !int.TryParse(txtCpfCnpj.Text, out _))
            {
                MessageBox.Show($"Cpf/Cnpj do cadastro está vazio ou invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtControle.Text) || !int.TryParse(txtControle.Text, out _))
            {
                MessageBox.Show("Número de controle está vazio ou invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Valida os campos aba de medidas
        /// </summary>
        /// <returns>True se validar com sucesso, false caso o contrario.</returns>
        private bool ValidarCamposMedidas()
        {
            if (!string.IsNullOrEmpty(txtAltura.Text) && !decimal.TryParse(txtAltura.Text, out _))
            {
                MessageBox.Show("Valor no campo altura está invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!string.IsNullOrEmpty(txtCintura.Text) && !decimal.TryParse(txtCintura.Text, out _))
            {
                MessageBox.Show("Valor no campo cintura está invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!string.IsNullOrEmpty(txtOmbroAhOmbro.Text) && !decimal.TryParse(txtOmbroAhOmbro.Text, out _))
            {
                MessageBox.Show("Valor no campo Ombro a Ombro está invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!string.IsNullOrEmpty(txtBustoMedida.Text) && !decimal.TryParse(txtBustoMedida.Text, out _))
            {
                MessageBox.Show("Valor no campo Busto está invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida os campos da aba de endereços
        /// </summary>
        /// <returns>True se validar com sucesso, false caso o contrario.</returns>
        private bool ValidarCamposEndereco()
        {
            if (string.IsNullOrEmpty(txtFilial.Text) || !int.TryParse(txtFilial.Text, out _))
            {
                MessageBox.Show("Número da filial invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Endereço está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Bairro está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtNumero.Text) || !int.TryParse(txtNumero.Text, out _))
            {
                MessageBox.Show("Número do endereço invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtComplemento.Text))
            {
                MessageBox.Show("Complemento está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtCepEndereco.Text) || !int.TryParse(txtCepEndereco.Text, out _))
            {
                MessageBox.Show("CEP invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Criando tabelas
        /// </summary>
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

            dttMedidas = new DataTable();
            dttMedidas.Columns.Add("CodigoCadastro");
            dttMedidas.Columns.Add("CodigoMedida");
            dttMedidas.Columns.Add("Altura");
            dttMedidas.Columns.Add("Cintura");
            dttMedidas.Columns.Add("OmbroAhOmbro");
            dttMedidas.Columns.Add("Busto");
            dttMedidas.Columns.Add("ObservacaoMedida");
            dttMedidas.Columns.Add("SituacaoMedida");
            dttMedidas.Columns.Add("DatahAlteracao");
            dttMedidas.Columns.Add("CodigoFuncionario");

            dttDefinicao = new DataTable();
            dttDefinicao.Columns.Add("CodigoCadastro");
            dttDefinicao.Columns.Add("CodigoDefinicao");
            dttDefinicao.Columns.Add("SituacaoDefinicao");
            dttDefinicao.Columns.Add("DatahAlteracao");
            dttDefinicao.Columns.Add("CodigoFuncionario");
        }

        /// <summary>
        /// Limpa os campos da aba de medidas
        /// </summary>
        public void LimparCamposMedida()
        {
            txtCodigoMedida.Clear();
            txtAltura.Clear();
            txtCintura.Clear();
            txtOmbroAhOmbro.Clear();
            txtBustoMedida.Clear();
            txtObservacaoMedida.Clear();
            cboSituacaoMedida.SelectedIndex = 0;
        }

        #region :: Gravar/Buscar/Limpar/Fechar ::

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
                List<MedidaDI> lstMedidaDI = new List<MedidaDI>();
                List<DefinicaoDI> lstDefinicaoDI = new List<DefinicaoDI>();

                if (!ValidarCamposDadosBasicos())
                {
                    return;
                }

                //Passa os dados para a classe data contract.
                objCadastroDI.CodigoCadastro = !string.IsNullOrEmpty(txtNumeroCadastro.Text) ? Convert.ToInt32(txtNumeroCadastro.Text) : 0;
                objCadastroDI.NomeCadastro = txtNomeCadastro.Text;
                objCadastroDI.NomeFantasia = txtNomeFantasia.Text;
                objCadastroDI.CodigoTipoCadastro = (int)cboTipoCadastro.SelectedValue;
                objCadastroDI.CpfCnpj = txtCpfCnpj.Text;
                objCadastroDI.Controle = txtControle.Text;
                objCadastroDI.DatahAlteracao = dtaAtual;
                objCadastroDI.CodigoFuncionario = CodigoFuncionario;

                foreach (DataGridViewRow rowEndereco in dgvEnderecos.Rows)
                {
                    EnderecoDI objEnderecoDI = new EnderecoDI
                    {
                        CodigoCadastro = !string.IsNullOrEmpty(txtNumeroCadastro.Text) ? Convert.ToInt32(txtNumeroCadastro.Text) : 0,
                        CodigoFilial = rowEndereco.Cells[clnCodigoFilialEndereco.Name].Value.ToString(),
                        Endereco = rowEndereco.Cells[clnEndereco.Name].Value.ToString(),
                        Bairro = rowEndereco.Cells[clnBairro.Name].Value.ToString(),
                        NumeroEndereco = Convert.ToInt32(rowEndereco.Cells[clnNumeroEndereco.Name].Value),
                        Complemento = rowEndereco.Cells[clnComplementoEndereco.Name].Value.ToString(),
                        CepEndereco = rowEndereco.Cells[clnCepEndereco.Name].Value.ToString(),
                        SituacaoEndereco = rowEndereco.Cells[clnSituacaoEndereco.Name].Value.ToString(),
                        CodigoCidade = Convert.ToInt32(rowEndereco.Cells[clnCodigoCidade.Name].Value),
                        DatahAlteracao = dtaAtual,
                        CodigoFuncionario = CodigoFuncionario
                    };

                    lstEnderecoDI.Add(objEnderecoDI);
                }

                foreach (DataGridViewRow rowMedida in dgvMedidas.Rows)
                {
                    MedidaDI objMedidaDI = new MedidaDI
                    {
                        CodigoCadastro = !string.IsNullOrEmpty(txtNumeroCadastro.Text) ? Convert.ToInt32(txtNumeroCadastro.Text) : 0,
                        CodigoMedida = !string.IsNullOrEmpty(rowMedida.Cells[clnCodigoMedida.Name].Value.ToString()) ? Convert.ToInt32(rowMedida.Cells[clnCodigoMedida.Name].Value) : 0,
                        Altura = Convert.ToDecimal(rowMedida.Cells[clnAlturaMedida.Name].Value),
                        Cintura = Convert.ToDecimal(rowMedida.Cells[clnCinturaMedida.Name].Value),
                        OmbroAhOmbro = Convert.ToDecimal(rowMedida.Cells[clnOmbroAhOmbro.Name].Value),
                        Busto = Convert.ToDecimal(rowMedida.Cells[clnBustoMedida.Name].Value),
                        ObservacaoMedida = rowMedida.Cells[clnObservacaoMedida.Name].Value.ToString(),
                        SituacaoMedida = rowMedida.Cells[clnSituacaoMedida.Name].Value.ToString(),
                        DatahAlteracao = dtaAtual,
                        CodigoFuncionario = CodigoFuncionario
                    };

                    lstMedidaDI.Add(objMedidaDI);
                }

                foreach (DataGridViewRow rowDefinicao in dgvDefinicao.Rows)
                {
                    DefinicaoDI objDefinicaoDI = new DefinicaoDI
                    {
                        CodigoCadastro = !string.IsNullOrEmpty(txtNumeroCadastro.Text) ? Convert.ToInt32(txtNumeroCadastro.Text) : 0,
                        CodigoDefinicao = Convert.ToInt32(rowDefinicao.Cells[clnCodigoDefinicao.Name].Value),
                        SituacaoDefinicao = rowDefinicao.Cells[clnSituacaoDefinicao.Name].Value.ToString(),
                        DatahAlteracao = dtaAtual,
                        CodigoFuncionario = CodigoFuncionario
                    };

                    lstDefinicaoDI.Add(objDefinicaoDI);
                }

                //Chama o metodo que grava ou altera os dados do cadastro.
                if (!objMetodos.RegistrarCadastro(objCadastroDI, lstEnderecoDI, lstMedidaDI, lstDefinicaoDI, out strErro))
                {
                    MessageBox.Show($"{strErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tsbLimpar.PerformClick();
            }
            catch (Exception pEx)
            {
                MessageBox.Show($"Erro ao gravar!{Environment.NewLine}{pEx.InnerException.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Metodos.Metodos objMetodos = new Metodos.Metodos();

                if (!string.IsNullOrEmpty(txtNumeroCadastro.Text))
                {
                    if (!int.TryParse(txtNumeroCadastro.Text, out _))
                    {
                        MessageBox.Show("Número do cadastro invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

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
                        cboTipoCadastro.SelectedValue = objCadastro.CodigoTipoCadastro;
                        txtCpfCnpj.Text = objCadastro.CpfCnpj;
                        txtControle.Text = objCadastro.Controle;
                        txtDatahAlteracao.Text = $"{objCadastro.DatahAlteracao:dd/MM/yyyy HH:mm:ss}";
                        txtCodigoFuncionario.Text = objCadastro.CodigoFuncionario.ToString();

                        dttEnderecos.Clear();
                        foreach (var objEndereco in objCadastro.EnderecoDI)
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

                        dttMedidas.Clear();
                        foreach (var objMedida in objCadastro.MedidaDI)
                        {
                            dttMedidas.Rows.Add(objMedida.CodigoCadastro,
                                                  objMedida.CodigoMedida,
                                                  objMedida.Altura != null ? Math.Round((decimal)objMedida.Altura, 2) : 0,
                                                  objMedida.Cintura != null ? Math.Round((decimal)objMedida.Cintura, 2) : 0,
                                                  objMedida.OmbroAhOmbro != null ? Math.Round((decimal)objMedida.OmbroAhOmbro, 2) : 0,
                                                  objMedida.Busto != null ? Math.Round((decimal)objMedida.Busto, 2) : 0,
                                                  objMedida.ObservacaoMedida,
                                                  objMedida.SituacaoMedida);
                        }

                        dttDefinicao.Clear();
                        foreach (var objDefinicao in objCadastro.DefinicaoDI)
                        {
                            dttDefinicao.Rows.Add(objDefinicao.CodigoCadastro,
                                                  objDefinicao.CodigoDefinicao,
                                                  objDefinicao.SituacaoDefinicao,
                                                  objDefinicao.DatahAlteracao,
                                                  objDefinicao.CodigoFuncionario);
                        }

                        dgvEnderecos.DataSource = dttEnderecos;
                        dgvMedidas.DataSource = dttMedidas;
                        dgvDefinicao.DataSource = dttDefinicao;
                    }
                }
                else
                {
                    txtNomeCadastro.Focus();
                    grpDadosChave.Enabled = false;
                }
            }
            catch(Exception pE)
            {
                MessageBox.Show($"Erro ao buscar os dados do cadastro!{Environment.NewLine}{pE.InnerException.InnerException}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsbLimpar_Click(object sender, EventArgs e)
        {
            FrmCadastro objNewForm = new FrmCadastro();
            objNewForm.CodigoFuncionario = CodigoFuncionario;
            objNewForm.Show();
            this.Dispose(false);
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region :: Adicionar/Editar/Excluir do Grid ::

        private void blnAdicionarEndereco_Click(object sender, EventArgs e)
        {
            bool blnNovaFilial = true;
            int intFilial = dttEnderecos.Rows.Count;

            if (objCadastro.EnderecoDI == null)
            {
                MessageBox.Show("Para cadastrar os endereços, primeiro tem que fazer o cadastro dos dados basicos e gravar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbcDadosCadastro.SelectTab(tabCadastro);
                return;
            }

            if (!ValidarCamposEndereco())
            {
                return;
            }

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
                if (Convert.ToInt32(cboTipoCadastro.SelectedValue) == 1 && intFilial >= 1)
                {
                    MessageBox.Show("Pessoa fisica só pode ter um endereço cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvEnderecos_SelectionChanged(sender, e);
                    return;
                }
                EnderecoDI objEnderecoDI = new EnderecoDI
                {
                    CodigoCadastro = !string.IsNullOrEmpty(txtNumeroCadastro.Text) ? Convert.ToInt32(txtNumeroCadastro.Text) : 0,
                    CodigoFilial = txtFilial.Text,
                    Endereco = txtEndereco.Text,
                    Bairro = txtBairro.Text,
                    NumeroEndereco = Convert.ToInt32(txtNumero.Text),
                    Complemento = txtComplemento.Text,
                    CepEndereco = txtCepEndereco.Text,
                    SituacaoEndereco = cboSituacaoEndereco.SelectedIndex == 0 ? "A" : "I",
                    CodigoCidade = (int)cboCidade.SelectedValue
                };
                objCadastro.EnderecoDI.Add(objEnderecoDI);
                dgvEnderecos.DataSource = null;
                dgvEnderecos.DataSource = objCadastro.EnderecoDI;
            }   
        }

        private void btnAdicionarDefinicao_Click(object sender, EventArgs e)
        {
            //TO DO: VALIDAR CAMPOS DEFINICAO
            bool blnNovaDefinicao = true;
            if (objCadastro.DefinicaoDI != null)
            {
                foreach (DataGridViewRow rowDefinicao in dgvDefinicao.Rows)
                {
                    if (rowDefinicao.Cells[clnCodigoDefinicao.Name].Value.ToString() == cboCodigoDefinicao.SelectedValue.ToString())
                    {
                        blnNovaDefinicao = false;
                        rowDefinicao.Cells[clnSituacaoDefinicao.Name].Value = cboSituacaoDefinicao.SelectedIndex == 0 ? "A" : "I";
                    }
                }

                if (blnNovaDefinicao)
                {
                    DefinicaoDI objDefinicaoDI = new DefinicaoDI
                    {
                        CodigoCadastro = Convert.ToInt32(txtNumeroCadastro.Text),
                        CodigoDefinicao = (int)cboCodigoDefinicao.SelectedValue,
                        SituacaoDefinicao = cboSituacaoDefinicao.SelectedIndex == 0 ? "A" : "I"
                    };
                    objCadastro.DefinicaoDI.Add(objDefinicaoDI);
                    dgvDefinicao.DataSource = null;
                    dgvDefinicao.DataSource = objCadastro.DefinicaoDI;
                }
            }
            else
            {
                MessageBox.Show("Para cadastrar as definições, primeiro tem que fazer o cadastro dos dados basicos e gravar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbcDadosCadastro.SelectTab(tabCadastro);
            }
        }

        private void btnAdicionarMedida_Click(object sender, EventArgs e)
        {
            //TO DO: FAZER ESSE EVENTO.
            // 1 - Validar campos das medidas.
            // 2 - Validar se chave Medida esta no banco de dados
            //bool blnNovaMedida = true;
            /*foreach (DataGridViewRow rowMedidas in dgvMedidas.Rows)
            {
                if (rowMedidas.Cells[clnCodigoMedida.Name].Value.ToString() == txtCodigoMedida.Text)
                {
                    blnNovaMedida = false;
                    //TO DO: Caso Código Medida for igual a ZERO, atualiza a linha atual (SelectedRow).
                    rowMedidas.Cells[clnCodigoCadastroMedidas.Name].Value = !string.IsNullOrEmpty(txtNumeroCadastro.Text) ? Convert.ToInt32(txtNumeroCadastro.Text) : 0;
                    rowMedidas.Cells[clnCodigoMedida.Name].Value = !string.IsNullOrEmpty(txtCodigoMedida.Text) ? Convert.ToInt32(txtCodigoMedida.Text) : 0;

                    rowMedidas.Cells[clnAlturaMedida.Name].Value = !string.IsNullOrEmpty(txtAltura.Text) ? txtAltura.Text : string.Empty;
                    rowMedidas.Cells[clnCinturaMedida.Name].Value = !string.IsNullOrEmpty(txtCintura.Text) ? txtCintura.Text : string.Empty;
                    rowMedidas.Cells[clnOmbroAhOmbro.Name].Value = !string.IsNullOrEmpty(txtOmbroAhOmbro.Text) ? txtOmbroAhOmbro.Text : string.Empty;
                    rowMedidas.Cells[clnBustoMedida.Name].Value = !string.IsNullOrEmpty(txtBustoMedida.Text) ? txtBustoMedida.Text : string.Empty;
                    rowMedidas.Cells[clnObservacaoMedida.Name].Value = !string.IsNullOrEmpty(txtObservacaoMedida.Text) ? txtObservacaoMedida.Text : string.Empty;
                    rowMedidas.Cells[clnSituacaoMedida.Name].Value = cboSituacaoMedida.SelectedIndex == 0 ? "A" : "I";
                }
            }*/


            if (objCadastro.MedidaDI != null)
            {
                if (!ValidarCamposMedidas())
                {
                    return;
                }
                MedidaDI objMedidaDI = new MedidaDI
                {
                    CodigoCadastro = !string.IsNullOrEmpty(txtNumeroCadastro.Text) ? Convert.ToInt32(txtNumeroCadastro.Text) : 0,
                    CodigoMedida = objCadastro.MedidaDI != null ? objCadastro.MedidaDI.Count + 1 : 1,//!string.IsNullOrEmpty(txtCodigoMedida.Text) ? Convert.ToInt32(txtCodigoMedida.Text) : 0,
                    Altura = !string.IsNullOrEmpty(txtAltura.Text) ? Convert.ToDecimal(txtAltura.Text) : 0,
                    Cintura = !string.IsNullOrEmpty(txtCintura.Text) ? Convert.ToDecimal(txtCintura.Text) : 0,
                    OmbroAhOmbro = !string.IsNullOrEmpty(txtOmbroAhOmbro.Text) ? Convert.ToDecimal(txtOmbroAhOmbro.Text) : 0,
                    Busto = !string.IsNullOrEmpty(txtBustoMedida.Text) ? Convert.ToDecimal(txtBustoMedida.Text) : 0,
                    ObservacaoMedida = !string.IsNullOrEmpty(txtObservacaoMedida.Text) ? txtObservacaoMedida.Text : string.Empty,
                    SituacaoMedida = cboSituacaoMedida.SelectedIndex == 0 ? "A" : "I"
                };
                objCadastro.MedidaDI.Add(objMedidaDI);
                dgvMedidas.DataSource = null;
                dgvMedidas.DataSource = objCadastro.MedidaDI;
            }
            else
            {
                MessageBox.Show("Para cadastrar as medidas, primeiro tem que fazer o cadastro dos dados basicos e gravar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbcDadosCadastro.SelectTab(tabCadastro);
            }
            LimparCamposMedida();
        }

        private void btnEditarLinhaMedida_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowMedidas = dgvMedidas.SelectedRows.Count > 0 ? dgvMedidas.SelectedRows[0] : null;
            if (rowMedidas != null)
            {
                //rowMedidas.Cells[clnCodigoCadastroMedidas.Name].Value = !string.IsNullOrEmpty(txtNumeroCadastro.Text) ? Convert.ToInt32(txtNumeroCadastro.Text) : 0;
                //rowMedidas.Cells[clnCodigoMedida.Name].Value = !string.IsNullOrEmpty(txtCodigoMedida.Text) ? Convert.ToInt32(txtCodigoMedida.Text) : 0;
                if (!ValidarCamposMedidas())
                {
                    return;
                }
                rowMedidas.Cells[clnAlturaMedida.Name].Value = !string.IsNullOrEmpty(txtAltura.Text) ? txtAltura.Text : string.Empty;
                rowMedidas.Cells[clnCinturaMedida.Name].Value = !string.IsNullOrEmpty(txtCintura.Text) ? txtCintura.Text : string.Empty;
                rowMedidas.Cells[clnOmbroAhOmbro.Name].Value = !string.IsNullOrEmpty(txtOmbroAhOmbro.Text) ? txtOmbroAhOmbro.Text : string.Empty;
                rowMedidas.Cells[clnBustoMedida.Name].Value = !string.IsNullOrEmpty(txtBustoMedida.Text) ? txtBustoMedida.Text : string.Empty;
                rowMedidas.Cells[clnObservacaoMedida.Name].Value = !string.IsNullOrEmpty(txtObservacaoMedida.Text) ? txtObservacaoMedida.Text : string.Empty;
                rowMedidas.Cells[clnSituacaoMedida.Name].Value = cboSituacaoMedida.SelectedIndex == 0 ? "A" : "I";
                LimparCamposMedida();
            }
        }

        private void btnExcluirMedida_Click(object sender, EventArgs e)
        {
            Metodos.Metodos objMetodos = new Metodos.Metodos();
            MedidaDI objMedidaDIExcluir = objMetodos.ListarMedidaCadastro(Convert.ToInt32(txtNumeroCadastro.Text), Convert.ToInt32(dgvMedidas.SelectedRows[0].Cells[clnCodigoMedida.Name].Value));
            if (objMedidaDIExcluir == null)
            {
                objCadastro.MedidaDI.RemoveAt(dgvMedidas.SelectedRows[0].Index);
                dgvMedidas.DataSource = null;
                dgvMedidas.DataSource = objCadastro.MedidaDI;
            }
            else
            {
                MessageBox.Show("Não é possivel excluir registros que já foram gravados, caso o registro não sejá mais valido, coloque a situação do registro como INATIVO!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        #endregion

        private void dgvMedidas_Click(object sender, EventArgs e) => dgvMedidas_SelectionChanged(sender, e);

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            dgvEnderecos.AutoGenerateColumns = false;
            dgvDefinicao.AutoGenerateColumns = false;
            dgvMedidas.AutoGenerateColumns = false;
            objCadastro = new CadastroDI();
            CriarDataTables();

            Metodos.Metodos objMetodos = new Metodos.Metodos();
            lstTipoCadastroDI = new List<TipoCadastroDI>();
            lstCidadesDI = new List<CidadeDI>();
            lstTipoDefinicaoDI = new List<TipoDefinicaoDI>();

            //cboTipoCadastro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cboTipoCadastro.AutoCompleteSource = AutoCompleteSource.ListItems;
            //cboNumeroCadastro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cboNumeroCadastro.AutoCompleteSource = AutoCompleteSource.ListItems;

            lstTipoCadastroDI = objMetodos.ConsultarTipoCadastro();
            lstCidadesDI = objMetodos.ConsultarCidades();
            lstTipoDefinicaoDI = objMetodos.ConsultarDefinicoes();
            lstCadastrosDI = objMetodos.ListarCadastros();

            cboTipoCadastro.DataSource = lstTipoCadastroDI;
            cboTipoCadastro.ValueMember = "CodigoTipoCadastro";
            cboTipoCadastro.DisplayMember = "DescricaoTipoCadastro";

            cboCidade.DataSource = lstCidadesDI;
            cboCidade.ValueMember = "CodigoCidade";
            cboCidade.DisplayMember = "DescricaoCidade";

            cboCodigoDefinicao.DataSource = lstTipoDefinicaoDI;
            cboCodigoDefinicao.ValueMember = "CodigoTipoDefinicao";
            cboCodigoDefinicao.DisplayMember = "DescricaoTipoDefinicao";

            cboNumeroCadastro.DataSource = lstCadastrosDI;
            cboNumeroCadastro.ValueMember = "CodigoCadastro";
            cboNumeroCadastro.DisplayMember = "NomeCadastro";

            cboSituacaoDefinicao.SelectedIndex = 0;
            cboSituacaoEndereco.SelectedIndex = 0;
            cboSituacaoMedida.SelectedIndex = 0;
            cboCodigoDefinicao.SelectedIndex = 0;
            cboNumeroCadastro.SelectedIndex = -1;
        }

        #region :: Selection Changed ::

        private void dgvEnderecos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEnderecos.SelectedRows.Count > 0)
            {
                DataGridViewRow rowLinha = dgvEnderecos.SelectedRows[0];

                txtFilial.Text = rowLinha.Cells[clnCodigoFilialEndereco.Name].Value.ToString();
                txtEndereco.Text = rowLinha.Cells[clnEndereco.Name].Value.ToString();
                txtBairro.Text = rowLinha.Cells[clnBairro.Name].Value.ToString();
                txtNumero.Text = rowLinha.Cells[clnNumeroEndereco.Name].Value.ToString();
                txtComplemento.Text = rowLinha.Cells[clnComplementoEndereco.Name].Value.ToString();
                txtCepEndereco.Text = rowLinha.Cells[clnCepEndereco.Name].Value.ToString();
                cboCidade.SelectedValue = Convert.ToInt32(rowLinha.Cells[clnCodigoCidade.Name].Value);
                cboSituacaoEndereco.SelectedIndex = rowLinha.Cells[clnSituacaoEndereco.Name].Value.ToString() == "A" ? 0 : 1;
            }
        }

        private void dgvDefinicao_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDefinicao.SelectedRows.Count > 0)
            {
                DataGridViewRow rowDefinicao = dgvDefinicao.SelectedRows[0];

                cboCodigoDefinicao.SelectedItem = (int)cboCodigoDefinicao.SelectedValue;
                cboSituacaoDefinicao.SelectedIndex = rowDefinicao.Cells[clnSituacaoDefinicao.Name].Value.ToString() == "A" ? 0 : 1;
                txtDatahAlteracaoDefinicao.Text = rowDefinicao.Cells[clnDatahAlteracaoDefinicao.Name].Value.ToString();
                txtCodigoFuncionarioDefinicao.Text = rowDefinicao.Cells[clnCodigoFuncionarioDefinicao.Name].Value.ToString();
            }
        }

        private void dgvMedidas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMedidas.SelectedRows.Count > 0)
            {
                DataGridViewRow rowMedidas = dgvMedidas.SelectedRows[0];

                txtCodigoMedida.Text = rowMedidas.Cells[clnCodigoMedida.Name].Value.ToString() == "0" ? string.Empty : rowMedidas.Cells[clnCodigoMedida.Name].Value.ToString();

                txtAltura.Text = rowMedidas.Cells[clnAlturaMedida.Name].Value.ToString();
                txtCintura.Text = rowMedidas.Cells[clnCinturaMedida.Name].Value.ToString();
                txtOmbroAhOmbro.Text = rowMedidas.Cells[clnOmbroAhOmbro.Name].Value.ToString();
                txtBustoMedida.Text = rowMedidas.Cells[clnBustoMedida.Name].Value.ToString();
                txtObservacaoMedida.Text = rowMedidas.Cells[clnObservacaoMedida.Name].Value.ToString();
                cboSituacaoMedida.SelectedIndex = rowMedidas.Cells[clnSituacaoMedida.Name].Value.ToString() == "A" ? 0 : 1;
            }
        }

        #endregion

        private void FrmCadastro_KeyDown(object sender, KeyEventArgs e)
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

        private void cboNumeroCadastro_TextChanged(object sender, EventArgs e)
        {
            //List<CadastroDI> lstCadastroTemp = lstCadastrosDI.Where(c => );
        }

        /* Valida CPF/CNPJ
        public static bool IsValid(string cpfCnpj)
        {
            return IsCpf(cpfCnpj) || IsCnpj(cpfCnpj);
        }

        private static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        private static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        */
    }
}
