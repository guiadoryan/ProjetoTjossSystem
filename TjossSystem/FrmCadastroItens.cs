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
    public partial class FrmCadastroItens : FrmPadrao
    {
        /// <summary>
        /// Lista de tipo itens
        /// </summary>
        List<TipoItemDI> lstTipoItemDI;

        public FrmCadastroItens()
        {
            InitializeComponent();
        }

        private void tsbGravar_Click(object sender, EventArgs e)
        {
            ModuloDeItens objMetodosItens = new ModuloDeItens();
            string strErro = string.Empty;
            DateTime dtaAtual = DateTime.Now;

            //Instancia classe data contract.
            ItemDI objItemDI = new ItemDI();

            //VALIDAR OS CAMPOS
            if (!string.IsNullOrEmpty(txtCodigoItem.Text))
            {
                if (!int.TryParse(txtCodigoItem.Text, out _))
                {
                    MessageBox.Show("Código item é invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (string.IsNullOrEmpty(txtDescricaoItem.Text))
            {
                MessageBox.Show("Informe a descrição do item!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //GRAVAR
            objItemDI.CodigoItem = !string.IsNullOrEmpty(txtCodigoItem.Text) ? Convert.ToInt32(txtCodigoItem.Text) : 0;
            objItemDI.DescricaoItens = txtDescricaoItem.Text;
            objItemDI.CodigoTipoItem = (int)cboCodigoTipoItem.SelectedValue;
            objItemDI.SituacaoItem = cboSituacaoItem.SelectedIndex == 0 ? "A" : "I";
            objItemDI.DatahAlteracao = dtaAtual;
            objItemDI.CodigoFuncionario = CodigoFuncionario;

            if (!objMetodosItens.RegistrarItem(objItemDI, out strErro))
            {
                MessageBox.Show($"Excessão ao executar o método RegistrarItem!{Environment.NewLine}{strErro}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tsbLimpar.PerformClick();
        }

        private void tsbLimpar_Click(object sender, EventArgs e)
        {
            FrmCadastroItens objNewForm = new FrmCadastroItens();
            objNewForm.CodigoFuncionario = CodigoFuncionario;
            objNewForm.Show();
            this.Dispose(false);
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoItem.Text))
            {
                if (!int.TryParse(txtCodigoItem.Text, out _))
                {
                    MessageBox.Show($"Cógido Tipo Estoque inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ModuloDeItens objMetodosItens = new ModuloDeItens();
                //Instancia classe data contract.
                ItemDI objItemDI = objMetodosItens.ConsultarItem(Convert.ToInt32(txtCodigoItem.Text));

                if (objItemDI != null)
                {
                    txtDescricaoItem.Text = objItemDI.DescricaoItens;
                    cboCodigoTipoItem.SelectedValue = objItemDI.CodigoTipoItem;
                    cboSituacaoItem.SelectedIndex = objItemDI.SituacaoItem == "A" ? 0 : 1;
                    txtDatahAlteracao.Text = $"{objItemDI.DatahAlteracao:dd/MM/yyyy HH:mm:ss}";
                    txtCodigoFuncionario.Text = objItemDI.CodigoFuncionario.ToString();
                }

                grpDadosBasicos.Enabled = true;
                grpDadosChaveItens.Enabled = false;
                tsbGravar.Enabled = true;
                txtDescricaoItem.Focus();
            }
            else
            {
                grpDadosBasicos.Enabled = true;
                grpDadosChaveItens.Enabled = false;
                tsbGravar.Enabled = true;
                txtDescricaoItem.Focus();
            }
        }

        private void FrmCadastroItens_Load(object sender, EventArgs e)
        {
            ModuloDeItens objModuloDeItens = new ModuloDeItens();
            lstTipoItemDI = new List<TipoItemDI>();

            lstTipoItemDI = objModuloDeItens.BuscarTiposItens();

            cboCodigoTipoItem.DataSource = lstTipoItemDI;
            cboCodigoTipoItem.ValueMember = "CodigoTipoItem";
            cboCodigoTipoItem.DisplayMember = "DescricaoComboBox";

            cboCodigoTipoItem.SelectedIndex = 0;
            cboSituacaoItem.SelectedIndex = 0;
        }

        private void FrmCadastroItens_KeyDown(object sender, KeyEventArgs e)
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
