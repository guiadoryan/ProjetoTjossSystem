
namespace TjossSystem
{
    partial class FrmEntradaSaidaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntradaSaidaEstoque));
            this.tspBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.tsbGravar = new System.Windows.Forms.ToolStripButton();
            this.grpDadosBasicos = new System.Windows.Forms.GroupBox();
            this.cboCodigoTipoEstoque = new System.Windows.Forms.ComboBox();
            this.lblCodigoTipoEstoque = new System.Windows.Forms.Label();
            this.txtQuantidadeMovimentada = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtCodigoItem = new System.Windows.Forms.TextBox();
            this.lblCodigoItem = new System.Windows.Forms.Label();
            this.txtObservacaoMovimento = new System.Windows.Forms.TextBox();
            this.cboTipoMovimento = new System.Windows.Forms.ComboBox();
            this.lblTipoMovimento = new System.Windows.Forms.Label();
            this.lblObservacaoMovimento = new System.Windows.Forms.Label();
            this.tspBotoes.SuspendLayout();
            this.grpDadosBasicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspBotoes
            // 
            this.tspBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFechar,
            this.tsbLimpar,
            this.tsbGravar});
            this.tspBotoes.Location = new System.Drawing.Point(0, 190);
            this.tspBotoes.Name = "tspBotoes";
            this.tspBotoes.Size = new System.Drawing.Size(504, 25);
            this.tspBotoes.TabIndex = 11;
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
            // grpDadosBasicos
            // 
            this.grpDadosBasicos.Controls.Add(this.cboCodigoTipoEstoque);
            this.grpDadosBasicos.Controls.Add(this.lblCodigoTipoEstoque);
            this.grpDadosBasicos.Controls.Add(this.txtQuantidadeMovimentada);
            this.grpDadosBasicos.Controls.Add(this.lblQuantidade);
            this.grpDadosBasicos.Controls.Add(this.txtCodigoItem);
            this.grpDadosBasicos.Controls.Add(this.lblCodigoItem);
            this.grpDadosBasicos.Controls.Add(this.txtObservacaoMovimento);
            this.grpDadosBasicos.Controls.Add(this.cboTipoMovimento);
            this.grpDadosBasicos.Controls.Add(this.lblTipoMovimento);
            this.grpDadosBasicos.Controls.Add(this.lblObservacaoMovimento);
            this.grpDadosBasicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDadosBasicos.Location = new System.Drawing.Point(0, 0);
            this.grpDadosBasicos.Name = "grpDadosBasicos";
            this.grpDadosBasicos.Size = new System.Drawing.Size(504, 190);
            this.grpDadosBasicos.TabIndex = 12;
            this.grpDadosBasicos.TabStop = false;
            // 
            // cboCodigoTipoEstoque
            // 
            this.cboCodigoTipoEstoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoTipoEstoque.FormattingEnabled = true;
            this.cboCodigoTipoEstoque.Location = new System.Drawing.Point(114, 39);
            this.cboCodigoTipoEstoque.Name = "cboCodigoTipoEstoque";
            this.cboCodigoTipoEstoque.Size = new System.Drawing.Size(104, 21);
            this.cboCodigoTipoEstoque.TabIndex = 14;
            // 
            // lblCodigoTipoEstoque
            // 
            this.lblCodigoTipoEstoque.AutoSize = true;
            this.lblCodigoTipoEstoque.Location = new System.Drawing.Point(12, 42);
            this.lblCodigoTipoEstoque.Name = "lblCodigoTipoEstoque";
            this.lblCodigoTipoEstoque.Size = new System.Drawing.Size(73, 13);
            this.lblCodigoTipoEstoque.TabIndex = 13;
            this.lblCodigoTipoEstoque.Text = "Tipo Estoque:";
            // 
            // txtQuantidadeMovimentada
            // 
            this.txtQuantidadeMovimentada.Location = new System.Drawing.Point(114, 66);
            this.txtQuantidadeMovimentada.MaxLength = 15;
            this.txtQuantidadeMovimentada.Name = "txtQuantidadeMovimentada";
            this.txtQuantidadeMovimentada.Size = new System.Drawing.Size(104, 20);
            this.txtQuantidadeMovimentada.TabIndex = 1;
            this.txtQuantidadeMovimentada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidadeMovimentada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeMovimentada_KeyPress);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 69);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 12;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtCodigoItem
            // 
            this.txtCodigoItem.Location = new System.Drawing.Point(114, 13);
            this.txtCodigoItem.MaxLength = 15;
            this.txtCodigoItem.Name = "txtCodigoItem";
            this.txtCodigoItem.Size = new System.Drawing.Size(104, 20);
            this.txtCodigoItem.TabIndex = 0;
            // 
            // lblCodigoItem
            // 
            this.lblCodigoItem.AutoSize = true;
            this.lblCodigoItem.Location = new System.Drawing.Point(12, 16);
            this.lblCodigoItem.Name = "lblCodigoItem";
            this.lblCodigoItem.Size = new System.Drawing.Size(66, 13);
            this.lblCodigoItem.TabIndex = 10;
            this.lblCodigoItem.Text = "Código Item:";
            // 
            // txtObservacaoMovimento
            // 
            this.txtObservacaoMovimento.Location = new System.Drawing.Point(114, 119);
            this.txtObservacaoMovimento.MaxLength = 60;
            this.txtObservacaoMovimento.Name = "txtObservacaoMovimento";
            this.txtObservacaoMovimento.Size = new System.Drawing.Size(309, 20);
            this.txtObservacaoMovimento.TabIndex = 3;
            // 
            // cboTipoMovimento
            // 
            this.cboTipoMovimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMovimento.FormattingEnabled = true;
            this.cboTipoMovimento.Items.AddRange(new object[] {
            "E - Entrada",
            "S - Saida"});
            this.cboTipoMovimento.Location = new System.Drawing.Point(114, 92);
            this.cboTipoMovimento.Name = "cboTipoMovimento";
            this.cboTipoMovimento.Size = new System.Drawing.Size(121, 21);
            this.cboTipoMovimento.TabIndex = 2;
            // 
            // lblTipoMovimento
            // 
            this.lblTipoMovimento.AutoSize = true;
            this.lblTipoMovimento.Location = new System.Drawing.Point(12, 95);
            this.lblTipoMovimento.Name = "lblTipoMovimento";
            this.lblTipoMovimento.Size = new System.Drawing.Size(86, 13);
            this.lblTipoMovimento.TabIndex = 1;
            this.lblTipoMovimento.Text = "Tipo Movimento:";
            // 
            // lblObservacaoMovimento
            // 
            this.lblObservacaoMovimento.AutoSize = true;
            this.lblObservacaoMovimento.Location = new System.Drawing.Point(12, 122);
            this.lblObservacaoMovimento.Name = "lblObservacaoMovimento";
            this.lblObservacaoMovimento.Size = new System.Drawing.Size(68, 13);
            this.lblObservacaoMovimento.TabIndex = 0;
            this.lblObservacaoMovimento.Text = "Observação:";
            // 
            // FrmEntradaSaidaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 215);
            this.Controls.Add(this.grpDadosBasicos);
            this.Controls.Add(this.tspBotoes);
            this.Name = "FrmEntradaSaidaEstoque";
            this.Text = "Entrada e Saida de Estoque";
            this.Load += new System.EventHandler(this.FrmEntradaSaidaEstoque_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEntradaSaidaEstoque_KeyDown);
            this.tspBotoes.ResumeLayout(false);
            this.tspBotoes.PerformLayout();
            this.grpDadosBasicos.ResumeLayout(false);
            this.grpDadosBasicos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspBotoes;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.ToolStripButton tsbLimpar;
        private System.Windows.Forms.ToolStripButton tsbGravar;
        private System.Windows.Forms.GroupBox grpDadosBasicos;
        private System.Windows.Forms.TextBox txtObservacaoMovimento;
        private System.Windows.Forms.ComboBox cboTipoMovimento;
        private System.Windows.Forms.Label lblTipoMovimento;
        private System.Windows.Forms.Label lblObservacaoMovimento;
        private System.Windows.Forms.TextBox txtCodigoItem;
        private System.Windows.Forms.Label lblCodigoItem;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidadeMovimentada;
        private System.Windows.Forms.ComboBox cboCodigoTipoEstoque;
        private System.Windows.Forms.Label lblCodigoTipoEstoque;
    }
}