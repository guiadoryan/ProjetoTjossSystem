
namespace TjossSystem
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDePessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipContrato = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipRelCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tipRelFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tipRelEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.tipEstoqueMovimento = new System.Windows.Forms.ToolStripMenuItem();
            this.parematrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDePaísToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeItensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroTipoEstoqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroTipoItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFormulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipEntradaSaidaEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.contratosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.parematrosToolStripMenuItem,
            this.itensToolStripMenuItem,
            this.funcionariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDePessoaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDePessoaToolStripMenuItem
            // 
            this.cadastroDePessoaToolStripMenuItem.Name = "cadastroDePessoaToolStripMenuItem";
            this.cadastroDePessoaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.cadastroDePessoaToolStripMenuItem.Text = "Cadastro de pessoa";
            this.cadastroDePessoaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDePessoaToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipPedido});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // tipPedido
            // 
            this.tipPedido.Name = "tipPedido";
            this.tipPedido.Size = new System.Drawing.Size(111, 22);
            this.tipPedido.Text = "Pedido";
            this.tipPedido.Click += new System.EventHandler(this.tipPedido_Click);
            // 
            // contratosToolStripMenuItem
            // 
            this.contratosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipContrato});
            this.contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            this.contratosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.contratosToolStripMenuItem.Text = "Contratos";
            // 
            // tipContrato
            // 
            this.tipContrato.Name = "tipContrato";
            this.tipContrato.Size = new System.Drawing.Size(126, 22);
            this.tipContrato.Text = "Contratos";
            this.tipContrato.Click += new System.EventHandler(this.tipContrato_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipRelCadastro,
            this.tipRelFuncionarios,
            this.tipRelEstoque,
            this.tipEstoqueMovimento,
            this.pedidosToolStripMenuItem1});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // tipRelCadastro
            // 
            this.tipRelCadastro.Name = "tipRelCadastro";
            this.tipRelCadastro.Size = new System.Drawing.Size(181, 22);
            this.tipRelCadastro.Text = "Cadastro";
            this.tipRelCadastro.Click += new System.EventHandler(this.tipRelCadastro_Click);
            // 
            // tipRelFuncionarios
            // 
            this.tipRelFuncionarios.Name = "tipRelFuncionarios";
            this.tipRelFuncionarios.Size = new System.Drawing.Size(181, 22);
            this.tipRelFuncionarios.Text = "Funcionarios";
            this.tipRelFuncionarios.Click += new System.EventHandler(this.tipRelFuncionarios_Click);
            // 
            // tipRelEstoque
            // 
            this.tipRelEstoque.Name = "tipRelEstoque";
            this.tipRelEstoque.Size = new System.Drawing.Size(181, 22);
            this.tipRelEstoque.Text = "Estoque";
            this.tipRelEstoque.Click += new System.EventHandler(this.tipRelEstoque_Click);
            // 
            // tipEstoqueMovimento
            // 
            this.tipEstoqueMovimento.Name = "tipEstoqueMovimento";
            this.tipEstoqueMovimento.Size = new System.Drawing.Size(181, 22);
            this.tipEstoqueMovimento.Text = "Estoque Movimento";
            this.tipEstoqueMovimento.Click += new System.EventHandler(this.tipEstoqueMovimento_Click);
            // 
            // parematrosToolStripMenuItem
            // 
            this.parematrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDePaísToolStripMenuItem});
            this.parematrosToolStripMenuItem.Name = "parematrosToolStripMenuItem";
            this.parematrosToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.parematrosToolStripMenuItem.Text = "Parematros";
            // 
            // cadastroDePaísToolStripMenuItem
            // 
            this.cadastroDePaísToolStripMenuItem.Name = "cadastroDePaísToolStripMenuItem";
            this.cadastroDePaísToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cadastroDePaísToolStripMenuItem.Text = "Cadastro de Regiões";
            this.cadastroDePaísToolStripMenuItem.Click += new System.EventHandler(this.cadastroDePaísToolStripMenuItem_Click);
            // 
            // itensToolStripMenuItem
            // 
            this.itensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeItensToolStripMenuItem,
            this.cadastroTipoEstoqToolStripMenuItem,
            this.cadastroTipoItemToolStripMenuItem,
            this.itemEstoqueToolStripMenuItem,
            this.itemFormulaToolStripMenuItem,
            this.tipEntradaSaidaEstoque});
            this.itensToolStripMenuItem.Name = "itensToolStripMenuItem";
            this.itensToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.itensToolStripMenuItem.Text = "Itens";
            // 
            // cadastroDeItensToolStripMenuItem
            // 
            this.cadastroDeItensToolStripMenuItem.Name = "cadastroDeItensToolStripMenuItem";
            this.cadastroDeItensToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.cadastroDeItensToolStripMenuItem.Text = "Cadastro de itens";
            this.cadastroDeItensToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeItensToolStripMenuItem_Click);
            // 
            // cadastroTipoEstoqToolStripMenuItem
            // 
            this.cadastroTipoEstoqToolStripMenuItem.Name = "cadastroTipoEstoqToolStripMenuItem";
            this.cadastroTipoEstoqToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.cadastroTipoEstoqToolStripMenuItem.Text = "Cadastro Tipo Estoque";
            this.cadastroTipoEstoqToolStripMenuItem.Click += new System.EventHandler(this.cadastroTipoEstoqToolStripMenuItem_Click);
            // 
            // cadastroTipoItemToolStripMenuItem
            // 
            this.cadastroTipoItemToolStripMenuItem.Name = "cadastroTipoItemToolStripMenuItem";
            this.cadastroTipoItemToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.cadastroTipoItemToolStripMenuItem.Text = "Cadastro Tipo Item";
            this.cadastroTipoItemToolStripMenuItem.Click += new System.EventHandler(this.cadastroTipoItemToolStripMenuItem_Click);
            // 
            // itemEstoqueToolStripMenuItem
            // 
            this.itemEstoqueToolStripMenuItem.Name = "itemEstoqueToolStripMenuItem";
            this.itemEstoqueToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.itemEstoqueToolStripMenuItem.Text = "Item Estoque";
            this.itemEstoqueToolStripMenuItem.Click += new System.EventHandler(this.itemEstoqueToolStripMenuItem_Click);
            // 
            // itemFormulaToolStripMenuItem
            // 
            this.itemFormulaToolStripMenuItem.Name = "itemFormulaToolStripMenuItem";
            this.itemFormulaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.itemFormulaToolStripMenuItem.Text = "Item Formula";
            this.itemFormulaToolStripMenuItem.Click += new System.EventHandler(this.itemFormulaToolStripMenuItem_Click);
            // 
            // tipEntradaSaidaEstoque
            // 
            this.tipEntradaSaidaEstoque.Name = "tipEntradaSaidaEstoque";
            this.tipEntradaSaidaEstoque.Size = new System.Drawing.Size(199, 22);
            this.tipEntradaSaidaEstoque.Text = "Entrada e Saida Estoque";
            this.tipEntradaSaidaEstoque.Click += new System.EventHandler(this.tipEntradaSaidaEstoque_Click);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeFuncionariosToolStripMenuItem,
            this.cadastroDeCargosToolStripMenuItem,
            this.cadastroDeUsuariosToolStripMenuItem});
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            // 
            // cadastroDeFuncionariosToolStripMenuItem
            // 
            this.cadastroDeFuncionariosToolStripMenuItem.Name = "cadastroDeFuncionariosToolStripMenuItem";
            this.cadastroDeFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.cadastroDeFuncionariosToolStripMenuItem.Text = "Cadastro de Funcionarios";
            this.cadastroDeFuncionariosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFuncionariosToolStripMenuItem_Click);
            // 
            // cadastroDeCargosToolStripMenuItem
            // 
            this.cadastroDeCargosToolStripMenuItem.Name = "cadastroDeCargosToolStripMenuItem";
            this.cadastroDeCargosToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.cadastroDeCargosToolStripMenuItem.Text = "Cadastro de Cargos";
            this.cadastroDeCargosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCargosToolStripMenuItem_Click);
            // 
            // cadastroDeUsuariosToolStripMenuItem
            // 
            this.cadastroDeUsuariosToolStripMenuItem.Name = "cadastroDeUsuariosToolStripMenuItem";
            this.cadastroDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.cadastroDeUsuariosToolStripMenuItem.Text = "Cadastro de Usuarios";
            this.cadastroDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeUsuariosToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem1
            // 
            this.pedidosToolStripMenuItem1.Name = "pedidosToolStripMenuItem1";
            this.pedidosToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.pedidosToolStripMenuItem1.Text = "Pedidos";
            this.pedidosToolStripMenuItem1.Click += new System.EventHandler(this.pedidosToolStripMenuItem1_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMenu";
            this.Text = "Tjoss System V1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDePessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipPedido;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parematrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDePaísToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeItensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroTipoEstoqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroTipoItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemFormulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFuncionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipEntradaSaidaEstoque;
        private System.Windows.Forms.ToolStripMenuItem contratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipContrato;
        private System.Windows.Forms.ToolStripMenuItem tipRelCadastro;
        private System.Windows.Forms.ToolStripMenuItem tipRelFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem tipRelEstoque;
        private System.Windows.Forms.ToolStripMenuItem tipEstoqueMovimento;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem1;
    }
}

