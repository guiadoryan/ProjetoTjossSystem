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
    public partial class FrmCadastroFormulaItem : FrmPadrao
    {
        public FrmCadastroFormulaItem()
        {
            InitializeComponent();
        }

        private void FrmCadastroFormulaItem_KeyDown(object sender, KeyEventArgs e)
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
            if (!string.IsNullOrEmpty(txtCodigoItem.Text))
            {
                if (!int.TryParse(txtCodigoItem.Text, out _))
                {
                    MessageBox.Show($"Cógido Item inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ModuloDeItens objMetodosItens = new ModuloDeItens();
                //Instancia classe data contract.
                FormulaItemDI objTipoItemDI = objMetodosItens.ConsultarFormula(Convert.ToInt32(txtCodigoItem.Text));

                txtObservacaoFormula.Text = objTipoItemDI.ObservacaoFormula;

                grpDadosBasicos.Enabled = true;
                grpDadosChaveItens.Enabled = false;
                txtObservacaoFormula.Focus();
            }
            else
            {
                //Precisa ter o item cadastrado antes
                MessageBox.Show("Código item está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void tsbGravar_Click(object sender, EventArgs e)
        {
            ModuloDeItens objMetodosItens = new ModuloDeItens();
            string strErro = string.Empty;

            //Instancia classe data contract.
            FormulaItemDI objFormulaItemDI = new FormulaItemDI();

            //VALIDAR OS CAMPOS
            if (!string.IsNullOrEmpty(txtCodigoItem.Text))
            {
                if (!int.TryParse(txtCodigoItem.Text, out _))
                {
                    MessageBox.Show("Código item é invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                //Precisa ter o item cadastrado antes
                MessageBox.Show("Código item está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //GRAVAR
            objFormulaItemDI.CodigoItem = Convert.ToInt32(txtCodigoItem.Text);
            objFormulaItemDI.NumeroSequencia = 1;
            objFormulaItemDI.ObservacaoFormula = txtObservacaoFormula.Text;

            if (!objMetodosItens.RegistrarFormulaItem(objFormulaItemDI, out strErro))
            {
                MessageBox.Show($"Excessão ao executar o método RegistrarFormulaItem!{Environment.NewLine}{strErro}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tsbLimpar.PerformClick();
        }

        private void tsbLimpar_Click(object sender, EventArgs e)
        {
            FrmCadastroFormulaItem objNewForm = new FrmCadastroFormulaItem();
            objNewForm.Show();
            this.Dispose(false);
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
