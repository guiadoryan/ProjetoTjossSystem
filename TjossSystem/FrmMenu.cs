using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TjossSystem
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cadastroDePessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro objCadastro = new FrmCadastro();
            objCadastro.Show();
        }

        private void cadastroDePaísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroRegioes objCadastroRegioes = new FrmCadastroRegioes();
            objCadastroRegioes.Show();
        }

        private void cadastroTipoEstoqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroTipoEstoque objCadastroTipoEstoque = new FrmCadastroTipoEstoque();
            objCadastroTipoEstoque.Show();
        }

        private void cadastroTipoItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroTipoItem objCadastroTipoItem = new FrmCadastroTipoItem();
            objCadastroTipoItem.Show();
        }

        private void cadastroDeItensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroItens objCadastroItens = new FrmCadastroItens();
            objCadastroItens.Show();
        }

        private void cadastroDeCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCargos objCadastroCargos = new FrmCadastroCargos();
            objCadastroCargos.Show();
        }

        private void itemEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroItemEstoque objCadastroItemEstoque = new FrmCadastroItemEstoque();
            objCadastroItemEstoque.Show();
        }

        private void itemFormulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroFormulaItem objCadastroFormulaItem = new FrmCadastroFormulaItem();
            objCadastroFormulaItem.Show();
        }
    }
}
