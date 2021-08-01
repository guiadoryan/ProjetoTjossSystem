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
        List<TipoCadastroDI> lstTipoCadastroDI;

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void tsbGravar_Click(object sender, EventArgs e)
        {
            try
            {
                Metodos.Metodos objMetodos = new Metodos.Metodos();
                string strErro = string.Empty;

                //Instancia classe data contract.
                CadastroDI objCadastroDI = new CadastroDI();

                //Passa os dados para a classe data contract.

                //Chama o metodo que grava ou altera os dados do cadastro.
                if (!objMetodos.RegistrarCadastro(!string.IsNullOrEmpty(txtNumeroCadastro.Text) ? Convert.ToInt32(txtNumeroCadastro.Text) : 0, txtNomeCadastro.Text, txtNomeFantasia.Text,
                    (int)cboTipoCadastro.SelectedValue, 
                    Convert.ToInt32(txtCpfCnpj.Text), Convert.ToInt32(txtControle.Text), out strErro))
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
            if (!string.IsNullOrEmpty(txtNumeroCadastro.Text) && !int.TryParse(txtNumeroCadastro.Text, out _))
            {
                MessageBox.Show("Número do cadastro invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Metodos.Metodos objMetodos = new Metodos.Metodos();
            CadastroDI objCadastro = objMetodos.ConsultarCadastro(Convert.ToInt32(txtNumeroCadastro.Text));

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
                dgvEnderecos.DataSource = objCadastro.EnderecosDI;
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
            DataTable dttEnderecos = new DataTable();
            dttEnderecos.Rows.Add(txtFilial.Text, txtEndereco.Text, txtBairro.Text, txtNumero.Text, txtComplemento.Text);
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            DataTable temp = new DataTable();
            Metodos.Metodos objMetodos = new Metodos.Metodos();
            lstTipoCadastroDI = new List<TipoCadastroDI>();

            //cboTipoCadastro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cboTipoCadastro.AutoCompleteSource = AutoCompleteSource.ListItems;

            lstTipoCadastroDI = objMetodos.ConsultarTipoCadastro();

            cboTipoCadastro.DataSource = lstTipoCadastroDI;
            cboTipoCadastro.ValueMember = "CodigoTipoCadastro";
            cboTipoCadastro.DisplayMember = "DescricaoTipoCadastro";
        }
    }
}
