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
    public partial class FrmCadastroRegioes : Form
    {
        /// <summary>
        /// Objeto com os dados da cidade
        /// </summary>
        CidadeDI objCidadeDI;

        /// <summary>
        /// Objeto com os dados do estado
        /// </summary>
        EstadoDI objEstadoDI;

        /// <summary>
        /// Lista com os estados registrados
        /// </summary>
        List<EstadoDI> lstEstadosDI;

        /// <summary>
        /// Lista com os paises registrados
        /// </summary>
        List<PaisDI> lstPaisesDI;

        public FrmCadastroRegioes()
        {
            InitializeComponent();
        }

        private void blnBuscarCidade_Click(object sender, EventArgs e)
        {
            CadastroRegioes objRegioes = new CadastroRegioes();
            if (!string.IsNullOrEmpty(txtCodigoCidade.Text))
            {
                objCidadeDI = objRegioes.ConsultarCidade(Convert.ToInt32(txtCodigoCidade.Text));
                if (objCidadeDI.CodigoCidade == 0)
                {
                    MessageBox.Show($"Cidade não encontrada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    txtNomeCidade.Text = objCidadeDI.DescricaoCidade;
                    txtSiglaCidade.Text = objCidadeDI.SiglaCidade;
                    cboCodigoEstado.SelectedValue = objCidadeDI.CodigoEstadoCit;
                    txtNomeCidade.Focus();
                    grpDadosChaveCidade.Enabled = false;
                    grpDadosCidade.Enabled = true;
                }
            }
            else
            {
                txtNomeCidade.Focus();
                grpDadosChaveCidade.Enabled = false;
                grpDadosCidade.Enabled = true;
            }
        }

        private void btnBuscarEstado_Click(object sender, EventArgs e)
        {
            CadastroRegioes objRegioes = new CadastroRegioes();
            if (!string.IsNullOrEmpty(txtCodigoEstado.Text))
            {
                objEstadoDI = objRegioes.ConsultarEstado(Convert.ToInt32(txtCodigoEstado.Text));
                if (objEstadoDI.CodigoEstado == 0)
                {
                    MessageBox.Show($"Estado não encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    txtNomeEstado.Text = objEstadoDI.DescricaoEstado;
                    txtSiglaEstado.Text = objEstadoDI.SiglaEstado;
                    cboCodigoPais.SelectedValue = objEstadoDI.CodigoPaisEst;
                    txtNomeCidade.Focus();
                    grpDadosChaveEstado.Enabled = false;
                    grpDadosBasicosEstado.Enabled = true;
                }
            }
            else
            {
                txtNomeCidade.Focus();
                grpDadosChaveEstado.Enabled = false;
                grpDadosBasicosEstado.Enabled = true;
            }
        }

        private void btnGravarAtualizarCidade_Click(object sender, EventArgs e)
        {
            CadastroRegioes objRegioes = new CadastroRegioes();
            string strErro = string.Empty;

            if (string.IsNullOrEmpty(txtNomeCidade.Text))
            {
                MessageBox.Show($"Nome da cidade é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtSiglaCidade.Text))
            {
                MessageBox.Show($"Sigla da cidade é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objCidadeDI = new CidadeDI
            {
                CodigoCidade = !string.IsNullOrEmpty(txtCodigoCidade.Text) ? Convert.ToInt32(txtCodigoCidade.Text) : 0,
                DescricaoCidade = txtNomeCidade.Text,
                SiglaCidade = txtSiglaCidade.Text,
                CodigoEstadoCit = (int)cboCodigoEstado.SelectedValue
            };

            if (!objRegioes.RegistrarCidade(objCidadeDI, out strErro))
            {
                MessageBox.Show($"{strErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ReiniciarTela();
        }

        private void btnGravarAtualizarEstado_Click(object sender, EventArgs e)
        {
            CadastroRegioes objRegioes = new CadastroRegioes();
            string strErro = string.Empty;

            if (string.IsNullOrEmpty(txtNomeEstado.Text))
            {
                MessageBox.Show($"Nome do estado é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtSiglaEstado.Text))
            {
                MessageBox.Show($"Sigla do estado é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objEstadoDI = new EstadoDI
            {
                CodigoEstado = !string.IsNullOrEmpty(txtCodigoEstado.Text) ? Convert.ToInt32(txtCodigoEstado.Text) : 0,
                DescricaoEstado = txtNomeEstado.Text,
                SiglaEstado = txtSiglaEstado.Text,
                CodigoPaisEst = (int)cboCodigoPais.SelectedValue
            };

            if (!objRegioes.RegistrarEstado(objEstadoDI, out strErro))
            {
                MessageBox.Show($"{strErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ReiniciarTela();
        }

        private void btnLimparCidade_Click(object sender, EventArgs e)
        {
            txtCodigoCidade.Clear();
            txtNomeCidade.Clear();
            txtSiglaCidade.Clear();
            cboCodigoEstado.SelectedIndex = -1;
            grpDadosChaveCidade.Enabled = true;
            txtCodigoCidade.Focus();
            grpDadosCidade.Enabled = false;
        }

        private void btnLimparEstado_Click(object sender, EventArgs e)
        {
            txtCodigoEstado.Clear();
            txtNomeEstado.Clear();
            txtSiglaEstado.Clear();
            cboCodigoPais.SelectedIndex = -1;
            grpDadosChaveEstado.Enabled = true;
            txtCodigoEstado.Focus();
            grpDadosBasicosEstado.Enabled = false;
        }

        private void FrmCadastroRegioes_Load(object sender, EventArgs e)
        {
            Metodos.Metodos objMetodos = new Metodos.Metodos();
            lstEstadosDI = new List<EstadoDI>();
            lstPaisesDI = new List<PaisDI>();

            lstEstadosDI = objMetodos.ConsultarEstados();
            lstPaisesDI = objMetodos.ConsultarPaises();

            cboCodigoEstado.DataSource = lstEstadosDI;
            cboCodigoEstado.ValueMember = "CodigoEstado";
            cboCodigoEstado.DisplayMember = "DescricaoEstado";

            cboCodigoPais.DataSource = lstPaisesDI;
            cboCodigoPais.ValueMember = "CodigoPais";
            cboCodigoPais.DisplayMember = "DescricaoPais";

            cboCodigoEstado.SelectedIndex = -1;
            cboCodigoPais.SelectedIndex = -1;
        }

        /// <summary>
        /// Método que Reinicia a tela
        /// </summary>
        private void ReiniciarTela()
        {
            FrmCadastroRegioes objNewForm = new FrmCadastroRegioes();
            objNewForm.Show();
            this.Dispose(false);
        }
    }
}
