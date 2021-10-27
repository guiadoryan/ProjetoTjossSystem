
namespace TjossSystem
{
    partial class FrmCadastroTipoEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroTipoEstoque));
            this.grpDadosChaveItens = new System.Windows.Forms.GroupBox();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.txtCodigoTipoEstoque = new System.Windows.Forms.TextBox();
            this.lblCodigoTipoEstoque = new System.Windows.Forms.Label();
            this.grpDadosBasicos = new System.Windows.Forms.GroupBox();
            this.tspBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.tsbGravar = new System.Windows.Forms.ToolStripButton();
            this.txtDescricaoTipoEstoque = new System.Windows.Forms.TextBox();
            this.cboSituacaoTipoEstoque = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblDescricaoItem = new System.Windows.Forms.Label();
            this.grpDadosChaveItens.SuspendLayout();
            this.grpDadosBasicos.SuspendLayout();
            this.tspBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosChaveItens
            // 
            this.grpDadosChaveItens.Controls.Add(this.btnBuscarItem);
            this.grpDadosChaveItens.Controls.Add(this.txtCodigoTipoEstoque);
            this.grpDadosChaveItens.Controls.Add(this.lblCodigoTipoEstoque);
            this.grpDadosChaveItens.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDadosChaveItens.Location = new System.Drawing.Point(0, 0);
            this.grpDadosChaveItens.Name = "grpDadosChaveItens";
            this.grpDadosChaveItens.Size = new System.Drawing.Size(428, 67);
            this.grpDadosChaveItens.TabIndex = 1;
            this.grpDadosChaveItens.TabStop = false;
            // 
            // btnBuscarItem
            // 
            this.btnBuscarItem.Location = new System.Drawing.Point(262, 22);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(112, 29);
            this.btnBuscarItem.TabIndex = 2;
            this.btnBuscarItem.Text = "Buscar";
            this.btnBuscarItem.UseVisualStyleBackColor = true;
            this.btnBuscarItem.Click += new System.EventHandler(this.btnBuscarItem_Click);
            // 
            // txtCodigoTipoEstoque
            // 
            this.txtCodigoTipoEstoque.Location = new System.Drawing.Point(127, 27);
            this.txtCodigoTipoEstoque.Name = "txtCodigoTipoEstoque";
            this.txtCodigoTipoEstoque.Size = new System.Drawing.Size(104, 20);
            this.txtCodigoTipoEstoque.TabIndex = 1;
            // 
            // lblCodigoTipoEstoque
            // 
            this.lblCodigoTipoEstoque.AutoSize = true;
            this.lblCodigoTipoEstoque.Location = new System.Drawing.Point(12, 30);
            this.lblCodigoTipoEstoque.Name = "lblCodigoTipoEstoque";
            this.lblCodigoTipoEstoque.Size = new System.Drawing.Size(109, 13);
            this.lblCodigoTipoEstoque.TabIndex = 0;
            this.lblCodigoTipoEstoque.Text = "Código Tipo Estoque:";
            // 
            // grpDadosBasicos
            // 
            this.grpDadosBasicos.Controls.Add(this.tspBotoes);
            this.grpDadosBasicos.Controls.Add(this.txtDescricaoTipoEstoque);
            this.grpDadosBasicos.Controls.Add(this.cboSituacaoTipoEstoque);
            this.grpDadosBasicos.Controls.Add(this.lblSituacao);
            this.grpDadosBasicos.Controls.Add(this.lblDescricaoItem);
            this.grpDadosBasicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDadosBasicos.Enabled = false;
            this.grpDadosBasicos.Location = new System.Drawing.Point(0, 67);
            this.grpDadosBasicos.Name = "grpDadosBasicos";
            this.grpDadosBasicos.Size = new System.Drawing.Size(428, 152);
            this.grpDadosBasicos.TabIndex = 2;
            this.grpDadosBasicos.TabStop = false;
            // 
            // tspBotoes
            // 
            this.tspBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFechar,
            this.tsbLimpar,
            this.tsbGravar});
            this.tspBotoes.Location = new System.Drawing.Point(3, 124);
            this.tspBotoes.Name = "tspBotoes";
            this.tspBotoes.Size = new System.Drawing.Size(422, 25);
            this.tspBotoes.TabIndex = 8;
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
            // txtDescricaoTipoEstoque
            // 
            this.txtDescricaoTipoEstoque.Location = new System.Drawing.Point(114, 13);
            this.txtDescricaoTipoEstoque.Name = "txtDescricaoTipoEstoque";
            this.txtDescricaoTipoEstoque.Size = new System.Drawing.Size(241, 20);
            this.txtDescricaoTipoEstoque.TabIndex = 7;
            // 
            // cboSituacaoTipoEstoque
            // 
            this.cboSituacaoTipoEstoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacaoTipoEstoque.FormattingEnabled = true;
            this.cboSituacaoTipoEstoque.Items.AddRange(new object[] {
            "A - Ativo",
            "I - Inativo"});
            this.cboSituacaoTipoEstoque.Location = new System.Drawing.Point(114, 39);
            this.cboSituacaoTipoEstoque.Name = "cboSituacaoTipoEstoque";
            this.cboSituacaoTipoEstoque.Size = new System.Drawing.Size(121, 21);
            this.cboSituacaoTipoEstoque.TabIndex = 6;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(12, 42);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 2;
            this.lblSituacao.Text = "Situacao:";
            // 
            // lblDescricaoItem
            // 
            this.lblDescricaoItem.AutoSize = true;
            this.lblDescricaoItem.Location = new System.Drawing.Point(12, 16);
            this.lblDescricaoItem.Name = "lblDescricaoItem";
            this.lblDescricaoItem.Size = new System.Drawing.Size(58, 13);
            this.lblDescricaoItem.TabIndex = 0;
            this.lblDescricaoItem.Text = "Descrição:";
            // 
            // FrmCadastroTipoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 219);
            this.Controls.Add(this.grpDadosBasicos);
            this.Controls.Add(this.grpDadosChaveItens);
            this.Name = "FrmCadastroTipoEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroTipoEstoque";
            this.grpDadosChaveItens.ResumeLayout(false);
            this.grpDadosChaveItens.PerformLayout();
            this.grpDadosBasicos.ResumeLayout(false);
            this.grpDadosBasicos.PerformLayout();
            this.tspBotoes.ResumeLayout(false);
            this.tspBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosChaveItens;
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.TextBox txtCodigoTipoEstoque;
        private System.Windows.Forms.Label lblCodigoTipoEstoque;
        private System.Windows.Forms.GroupBox grpDadosBasicos;
        private System.Windows.Forms.TextBox txtDescricaoTipoEstoque;
        private System.Windows.Forms.ComboBox cboSituacaoTipoEstoque;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblDescricaoItem;
        private System.Windows.Forms.ToolStrip tspBotoes;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.ToolStripButton tsbLimpar;
        private System.Windows.Forms.ToolStripButton tsbGravar;
    }
}