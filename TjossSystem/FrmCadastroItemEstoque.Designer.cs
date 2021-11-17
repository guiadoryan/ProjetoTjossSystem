
namespace TjossSystem
{
    partial class FrmCadastroItemEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroItemEstoque));
            this.grpDadosBasicos = new System.Windows.Forms.GroupBox();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.tspBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.tsbGravar = new System.Windows.Forms.ToolStripButton();
            this.txtQuantidadeDisponivel = new System.Windows.Forms.TextBox();
            this.lblQuantidadeDisponivel = new System.Windows.Forms.Label();
            this.grpDadosChaveItens = new System.Windows.Forms.GroupBox();
            this.cboCodigoTipoEstoque = new System.Windows.Forms.ComboBox();
            this.lblCodigoTipoEstoque = new System.Windows.Forms.Label();
            this.btnBuscarEstoque = new System.Windows.Forms.Button();
            this.txtCodigoItem = new System.Windows.Forms.TextBox();
            this.lblCodigoItem = new System.Windows.Forms.Label();
            this.grpDadosBasicos.SuspendLayout();
            this.tspBotoes.SuspendLayout();
            this.grpDadosChaveItens.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosBasicos
            // 
            this.grpDadosBasicos.Controls.Add(this.txtValorProduto);
            this.grpDadosBasicos.Controls.Add(this.lblValorUnitario);
            this.grpDadosBasicos.Controls.Add(this.tspBotoes);
            this.grpDadosBasicos.Controls.Add(this.txtQuantidadeDisponivel);
            this.grpDadosBasicos.Controls.Add(this.lblQuantidadeDisponivel);
            this.grpDadosBasicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDadosBasicos.Enabled = false;
            this.grpDadosBasicos.Location = new System.Drawing.Point(0, 90);
            this.grpDadosBasicos.Name = "grpDadosBasicos";
            this.grpDadosBasicos.Size = new System.Drawing.Size(478, 125);
            this.grpDadosBasicos.TabIndex = 3;
            this.grpDadosBasicos.TabStop = false;
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Location = new System.Drawing.Point(91, 39);
            this.txtValorProduto.MaxLength = 20;
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(104, 20);
            this.txtValorProduto.TabIndex = 12;
            this.txtValorProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorProduto_KeyPress);
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(12, 42);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(73, 13);
            this.lblValorUnitario.TabIndex = 11;
            this.lblValorUnitario.Text = "Valor Unitário:";
            // 
            // tspBotoes
            // 
            this.tspBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFechar,
            this.tsbLimpar,
            this.tsbGravar});
            this.tspBotoes.Location = new System.Drawing.Point(3, 97);
            this.tspBotoes.Name = "tspBotoes";
            this.tspBotoes.Size = new System.Drawing.Size(472, 25);
            this.tspBotoes.TabIndex = 10;
            this.tspBotoes.Text = "toolStrip1";
            // 
            // tsbFechar
            // 
            this.tsbFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbFechar.Image = ((System.Drawing.Image)(resources.GetObject("tsbFechar.Image")));
            this.tsbFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFechar.Name = "tsbFechar";
            this.tsbFechar.Size = new System.Drawing.Size(75, 22);
            this.tsbFechar.Text = "F12 - Fechar";
            this.tsbFechar.Click += new System.EventHandler(this.tsbFechar_Click);
            // 
            // tsbLimpar
            // 
            this.tsbLimpar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbLimpar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLimpar.Image = ((System.Drawing.Image)(resources.GetObject("tsbLimpar.Image")));
            this.tsbLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLimpar.Name = "tsbLimpar";
            this.tsbLimpar.Size = new System.Drawing.Size(77, 22);
            this.tsbLimpar.Text = "F10 - Limpar";
            this.tsbLimpar.Click += new System.EventHandler(this.tsbLimpar_Click);
            // 
            // tsbGravar
            // 
            this.tsbGravar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbGravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbGravar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGravar.Image")));
            this.tsbGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGravar.Name = "tsbGravar";
            this.tsbGravar.Size = new System.Drawing.Size(68, 22);
            this.tsbGravar.Text = "F9 - Gravar";
            this.tsbGravar.Click += new System.EventHandler(this.tsbGravar_Click);
            // 
            // txtQuantidadeDisponivel
            // 
            this.txtQuantidadeDisponivel.Enabled = false;
            this.txtQuantidadeDisponivel.Location = new System.Drawing.Point(91, 13);
            this.txtQuantidadeDisponivel.MaxLength = 20;
            this.txtQuantidadeDisponivel.Name = "txtQuantidadeDisponivel";
            this.txtQuantidadeDisponivel.Size = new System.Drawing.Size(104, 20);
            this.txtQuantidadeDisponivel.TabIndex = 7;
            this.txtQuantidadeDisponivel.Text = "0.0";
            this.txtQuantidadeDisponivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidadeDisponivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeDisponivel_KeyPress);
            // 
            // lblQuantidadeDisponivel
            // 
            this.lblQuantidadeDisponivel.AutoSize = true;
            this.lblQuantidadeDisponivel.Location = new System.Drawing.Point(12, 16);
            this.lblQuantidadeDisponivel.Name = "lblQuantidadeDisponivel";
            this.lblQuantidadeDisponivel.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidadeDisponivel.TabIndex = 0;
            this.lblQuantidadeDisponivel.Text = "Quantidade:";
            // 
            // grpDadosChaveItens
            // 
            this.grpDadosChaveItens.Controls.Add(this.cboCodigoTipoEstoque);
            this.grpDadosChaveItens.Controls.Add(this.lblCodigoTipoEstoque);
            this.grpDadosChaveItens.Controls.Add(this.btnBuscarEstoque);
            this.grpDadosChaveItens.Controls.Add(this.txtCodigoItem);
            this.grpDadosChaveItens.Controls.Add(this.lblCodigoItem);
            this.grpDadosChaveItens.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDadosChaveItens.Location = new System.Drawing.Point(0, 0);
            this.grpDadosChaveItens.Name = "grpDadosChaveItens";
            this.grpDadosChaveItens.Size = new System.Drawing.Size(478, 90);
            this.grpDadosChaveItens.TabIndex = 2;
            this.grpDadosChaveItens.TabStop = false;
            // 
            // cboCodigoTipoEstoque
            // 
            this.cboCodigoTipoEstoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoTipoEstoque.FormattingEnabled = true;
            this.cboCodigoTipoEstoque.Location = new System.Drawing.Point(91, 53);
            this.cboCodigoTipoEstoque.Name = "cboCodigoTipoEstoque";
            this.cboCodigoTipoEstoque.Size = new System.Drawing.Size(104, 21);
            this.cboCodigoTipoEstoque.TabIndex = 7;
            // 
            // lblCodigoTipoEstoque
            // 
            this.lblCodigoTipoEstoque.AutoSize = true;
            this.lblCodigoTipoEstoque.Location = new System.Drawing.Point(12, 56);
            this.lblCodigoTipoEstoque.Name = "lblCodigoTipoEstoque";
            this.lblCodigoTipoEstoque.Size = new System.Drawing.Size(73, 13);
            this.lblCodigoTipoEstoque.TabIndex = 6;
            this.lblCodigoTipoEstoque.Text = "Tipo Estoque:";
            // 
            // btnBuscarEstoque
            // 
            this.btnBuscarEstoque.Location = new System.Drawing.Point(218, 27);
            this.btnBuscarEstoque.Name = "btnBuscarEstoque";
            this.btnBuscarEstoque.Size = new System.Drawing.Size(112, 29);
            this.btnBuscarEstoque.TabIndex = 2;
            this.btnBuscarEstoque.Text = "Buscar";
            this.btnBuscarEstoque.UseVisualStyleBackColor = true;
            this.btnBuscarEstoque.Click += new System.EventHandler(this.btnBuscarEstoque_Click);
            // 
            // txtCodigoItem
            // 
            this.txtCodigoItem.Location = new System.Drawing.Point(91, 27);
            this.txtCodigoItem.MaxLength = 15;
            this.txtCodigoItem.Name = "txtCodigoItem";
            this.txtCodigoItem.Size = new System.Drawing.Size(104, 20);
            this.txtCodigoItem.TabIndex = 1;
            this.txtCodigoItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoItem_KeyPress);
            // 
            // lblCodigoItem
            // 
            this.lblCodigoItem.AutoSize = true;
            this.lblCodigoItem.Location = new System.Drawing.Point(12, 30);
            this.lblCodigoItem.Name = "lblCodigoItem";
            this.lblCodigoItem.Size = new System.Drawing.Size(66, 13);
            this.lblCodigoItem.TabIndex = 0;
            this.lblCodigoItem.Text = "Código Item:";
            // 
            // FrmCadastroItemEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 215);
            this.Controls.Add(this.grpDadosBasicos);
            this.Controls.Add(this.grpDadosChaveItens);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroItemEstoque";
            this.Text = "Cadastro de Estoque";
            this.Load += new System.EventHandler(this.FrmCadastroItemEstoque_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroItemEstoque_KeyDown);
            this.grpDadosBasicos.ResumeLayout(false);
            this.grpDadosBasicos.PerformLayout();
            this.tspBotoes.ResumeLayout(false);
            this.tspBotoes.PerformLayout();
            this.grpDadosChaveItens.ResumeLayout(false);
            this.grpDadosChaveItens.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosBasicos;
        private System.Windows.Forms.ToolStrip tspBotoes;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.ToolStripButton tsbLimpar;
        private System.Windows.Forms.ToolStripButton tsbGravar;
        private System.Windows.Forms.TextBox txtQuantidadeDisponivel;
        private System.Windows.Forms.Label lblQuantidadeDisponivel;
        private System.Windows.Forms.GroupBox grpDadosChaveItens;
        private System.Windows.Forms.Button btnBuscarEstoque;
        private System.Windows.Forms.TextBox txtCodigoItem;
        private System.Windows.Forms.Label lblCodigoItem;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.ComboBox cboCodigoTipoEstoque;
        private System.Windows.Forms.Label lblCodigoTipoEstoque;
    }
}