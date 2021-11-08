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
    public partial class FrmCadastroTipoItem : Form
    {
        public FrmCadastroTipoItem()
        {
            InitializeComponent();
        }

        private void FrmCadastroTipoItem_KeyDown(object sender, KeyEventArgs e)
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

        private void btnBuscarItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoTipoItem.Text))
            {
                if (!int.TryParse(txtCodigoTipoItem.Text, out _))
                {
                    MessageBox.Show($"Cógido Tipo Item inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ModuloDeItens objMetodosItens = new ModuloDeItens();
                //Instancia classe data contract.
                TipoItemDI objTipoItemDI = objMetodosItens.ConsultarTipoItem(Convert.ToInt32(txtCodigoTipoItem.Text));

                txtDescricaoTipoItem.Text = objTipoItemDI.DescricaoTipoItem;
                cboSituacaoTipoItem.SelectedIndex = objTipoItemDI.SituacaoTipoItem == "A" ? 0 : 1;

                grpDadosBasicos.Enabled = true;
                grpDadosChaveItens.Enabled = false;
                txtDescricaoTipoItem.Focus();
            }
            else
            {
                grpDadosBasicos.Enabled = true;
                grpDadosChaveItens.Enabled = false;
                txtDescricaoTipoItem.Focus();
            }
        }

        private void tsbGravar_Click(object sender, EventArgs e)
        {
            ModuloDeItens objMetodosItens = new ModuloDeItens();
            string strErro = string.Empty;

            //Instancia classe data contract.
            TipoItemDI objTipoItemDI = new TipoItemDI();

            //VALIDAR OS CAMPOS
            if (!string.IsNullOrEmpty(txtCodigoTipoItem.Text))
            {
                if (!int.TryParse(txtCodigoTipoItem.Text, out _))
                {
                    MessageBox.Show("Código tipo item é invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (string.IsNullOrEmpty(txtDescricaoTipoItem.Text))
            {
                MessageBox.Show("Informe a descrição do tipo item!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //GRAVAR
            objTipoItemDI.CodigoTipoItem = !string.IsNullOrEmpty(txtCodigoTipoItem.Text) ? Convert.ToInt32(txtCodigoTipoItem.Text) : 0;
            objTipoItemDI.DescricaoTipoItem = txtDescricaoTipoItem.Text;
            objTipoItemDI.SituacaoTipoItem = cboSituacaoTipoItem.SelectedIndex == 0 ? "A" : "I";

            if (!objMetodosItens.RegistrarTipoItem(objTipoItemDI, out strErro))
            {
                MessageBox.Show($"Excessão ao executar o método RegistrarTipoItem!{Environment.NewLine}{strErro}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tsbLimpar.PerformClick();
        }

        private void tsbLimpar_Click(object sender, EventArgs e)
        {
            FrmCadastroTipoItem objNewForm = new FrmCadastroTipoItem();
            objNewForm.Show();
            this.Dispose(false);
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
