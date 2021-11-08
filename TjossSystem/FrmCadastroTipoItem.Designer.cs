
namespace TjossSystem
{
    partial class FrmCadastroTipoItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroTipoItem));
            this.grpDadosBasicos = new System.Windows.Forms.GroupBox();
            this.tspBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.tsbGravar = new System.Windows.Forms.ToolStripButton();
            this.txtDescricaoTipoItem = new System.Windows.Forms.TextBox();
            this.cboSituacaoTipoItem = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblDescricaoTipoItem = new System.Windows.Forms.Label();
            this.grpDadosChaveItens = new System.Windows.Forms.GroupBox();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.txtCodigoTipoItem = new System.Windows.Forms.TextBox();
            this.lblCodigoTipoItem = new System.Windows.Forms.Label();
            this.grpDadosBasicos.SuspendLayout();
            this.tspBotoes.SuspendLayout();
            this.grpDadosChaveItens.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosBasicos
            // 
            this.grpDadosBasicos.Controls.Add(this.tspBotoes);
            this.grpDadosBasicos.Controls.Add(this.txtDescricaoTipoItem);
            this.grpDadosBasicos.Controls.Add(this.cboSituacaoTipoItem);
            this.grpDadosBasicos.Controls.Add(this.lblSituacao);
            this.grpDadosBasicos.Controls.Add(this.lblDescricaoTipoItem);
            this.grpDadosBasicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDadosBasicos.Location = new System.Drawing.Point(0, 67);
            this.grpDadosBasicos.Name = "grpDadosBasicos";
            this.grpDadosBasicos.Size = new System.Drawing.Size(438, 143);
            this.grpDadosBasicos.TabIndex = 4;
            this.grpDadosBasicos.TabStop = false;
            // 
            // tspBotoes
            // 
            this.tspBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFechar,
            this.tsbLimpar,
            this.tsbGravar});
            this.tspBotoes.Location = new System.Drawing.Point(3, 115);
            this.tspBotoes.Name = "tspBotoes";
            this.tspBotoes.Size = new System.Drawing.Size(432, 25);
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
            // txtDescricaoTipoItem
            // 
            this.txtDescricaoTipoItem.Location = new System.Drawing.Point(114, 13);
            this.txtDescricaoTipoItem.Name = "txtDescricaoTipoItem";
            this.txtDescricaoTipoItem.Size = new System.Drawing.Size(241, 20);
            this.txtDescricaoTipoItem.TabIndex = 7;
            // 
            // cboSituacaoTipoItem
            // 
            this.cboSituacaoTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacaoTipoItem.FormattingEnabled = true;
            this.cboSituacaoTipoItem.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cboSituacaoTipoItem.Location = new System.Drawing.Point(114, 39);
            this.cboSituacaoTipoItem.Name = "cboSituacaoTipoItem";
            this.cboSituacaoTipoItem.Size = new System.Drawing.Size(121, 21);
            this.cboSituacaoTipoItem.TabIndex = 6;
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
            // lblDescricaoTipoItem
            // 
            this.lblDescricaoTipoItem.AutoSize = true;
            this.lblDescricaoTipoItem.Location = new System.Drawing.Point(12, 16);
            this.lblDescricaoTipoItem.Name = "lblDescricaoTipoItem";
            this.lblDescricaoTipoItem.Size = new System.Drawing.Size(58, 13);
            this.lblDescricaoTipoItem.TabIndex = 0;
            this.lblDescricaoTipoItem.Text = "Descrição:";
            // 
            // grpDadosChaveItens
            // 
            this.grpDadosChaveItens.Controls.Add(this.btnBuscarItem);
            this.grpDadosChaveItens.Controls.Add(this.txtCodigoTipoItem);
            this.grpDadosChaveItens.Controls.Add(this.lblCodigoTipoItem);
            this.grpDadosChaveItens.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDadosChaveItens.Location = new System.Drawing.Point(0, 0);
            this.grpDadosChaveItens.Name = "grpDadosChaveItens";
            this.grpDadosChaveItens.Size = new System.Drawing.Size(438, 67);
            this.grpDadosChaveItens.TabIndex = 3;
            this.grpDadosChaveItens.TabStop = false;
            // 
            // btnBuscarItem
            // 
            this.btnBuscarItem.Location = new System.Drawing.Point(243, 22);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(112, 29);
            this.btnBuscarItem.TabIndex = 2;
            this.btnBuscarItem.Text = "Buscar";
            this.btnBuscarItem.UseVisualStyleBackColor = true;
            this.btnBuscarItem.Click += new System.EventHandler(this.btnBuscarItem_Click);
            // 
            // txtCodigoTipoItem
            // 
            this.txtCodigoTipoItem.Location = new System.Drawing.Point(114, 27);
            this.txtCodigoTipoItem.Name = "txtCodigoTipoItem";
            this.txtCodigoTipoItem.Size = new System.Drawing.Size(104, 20);
            this.txtCodigoTipoItem.TabIndex = 1;
            // 
            // lblCodigoTipoItem
            // 
            this.lblCodigoTipoItem.AutoSize = true;
            this.lblCodigoTipoItem.Location = new System.Drawing.Point(12, 30);
            this.lblCodigoTipoItem.Name = "lblCodigoTipoItem";
            this.lblCodigoTipoItem.Size = new System.Drawing.Size(90, 13);
            this.lblCodigoTipoItem.TabIndex = 0;
            this.lblCodigoTipoItem.Text = "Código Tipo Item:";
            // 
            // FrmCadastroTipoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 210);
            this.Controls.Add(this.grpDadosBasicos);
            this.Controls.Add(this.grpDadosChaveItens);
            this.KeyPreview = true;
            this.Name = "FrmCadastroTipoItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Tipo Item";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroTipoItem_KeyDown);
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
        private System.Windows.Forms.TextBox txtDescricaoTipoItem;
        private System.Windows.Forms.ComboBox cboSituacaoTipoItem;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblDescricaoTipoItem;
        private System.Windows.Forms.GroupBox grpDadosChaveItens;
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.TextBox txtCodigoTipoItem;
        private System.Windows.Forms.Label lblCodigoTipoItem;
        private System.Windows.Forms.ToolStrip tspBotoes;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.ToolStripButton tsbLimpar;
        private System.Windows.Forms.ToolStripButton tsbGravar;
    }
}