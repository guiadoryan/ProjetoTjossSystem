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
    public partial class FrmCadastroTipoEstoque : Form
    {
        public FrmCadastroTipoEstoque()
        {
            InitializeComponent();
        }

        private void tsbLimpar_Click(object sender, EventArgs e)
        {
            FrmCadastroTipoEstoque objNewForm = new FrmCadastroTipoEstoque();
            objNewForm.Show();
            this.Dispose(false);
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbGravar_Click(object sender, EventArgs e)
        {
            ModuloDeItens objMetodosItens = new ModuloDeItens();
            string strErro = string.Empty;
            DateTime dtaAtual = DateTime.Now;

            //Instancia classe data contract.
            TipoEstoqueDI objTipoEstoqueDI = new TipoEstoqueDI();

            //VALIDAR OS CAMPOS
            if (!string.IsNullOrEmpty(txtCodigoTipoEstoque.Text))
            {
                if (!int.TryParse(txtCodigoTipoEstoque.Text, out _))
                {
                    MessageBox.Show("Código tipo estoque é invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (string.IsNullOrEmpty(txtDescricaoTipoEstoque.Text))
            {
                MessageBox.Show("Informe a descrição do tipo estoque!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //GRAVAR
            objTipoEstoqueDI.CodigoTipoEstoque = !string.IsNullOrEmpty(txtCodigoTipoEstoque.Text) ? Convert.ToInt32(txtCodigoTipoEstoque.Text) : 0;
            objTipoEstoqueDI.DescricaoTipoEstoque = txtDescricaoTipoEstoque.Text;
            objTipoEstoqueDI.SituacaoTipoEstoque = cboSituacaoTipoEstoque.SelectedIndex == 0 ? "A" : "I";

            if (!objMetodosItens.RegistrarTipoEstoque(objTipoEstoqueDI, out strErro))
            {
                MessageBox.Show($"Excessão ao executar o método RegistrarTipoEstoque!{Environment.NewLine}{strErro}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tsbLimpar.PerformClick();
        }

        private void btnBuscarItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoTipoEstoque.Text))
            {
                if (!int.TryParse(txtCodigoTipoEstoque.Text, out _))
                {
                    MessageBox.Show($"Cógido Tipo Estoque inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ModuloDeItens objMetodosItens = new ModuloDeItens();
                //Instancia classe data contract.
                TipoEstoqueDI objTipoEstoqueDI = objMetodosItens.ConsultarTipoEstoque(Convert.ToInt32(txtCodigoTipoEstoque.Text));

                txtDescricaoTipoEstoque.Text = objTipoEstoqueDI.DescricaoTipoEstoque;
                cboSituacaoTipoEstoque.SelectedIndex = objTipoEstoqueDI.SituacaoTipoEstoque == "A" ? 0 : 1;

                grpDadosBasicos.Enabled = true;
                grpDadosChaveItens.Enabled = false;
                txtDescricaoTipoEstoque.Focus();
            }
            else
            {
                grpDadosBasicos.Enabled = true;
                grpDadosChaveItens.Enabled = false;
                txtDescricaoTipoEstoque.Focus();
            }
        }
    }
}
