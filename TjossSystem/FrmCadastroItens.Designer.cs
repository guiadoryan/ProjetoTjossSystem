
namespace TjossSystem
{
    partial class FrmCadastroItens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroItens));
            this.grpDadosChaveItens = new System.Windows.Forms.GroupBox();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.txtCodigoItem = new System.Windows.Forms.TextBox();
            this.lblCodigoItem = new System.Windows.Forms.Label();
            this.grpDadosBasicos = new System.Windows.Forms.GroupBox();
            this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.txtDatahAlteracao = new System.Windows.Forms.TextBox();
            this.txtDescricaoItem = new System.Windows.Forms.TextBox();
            this.cboSituacaoItem = new System.Windows.Forms.ComboBox();
            this.cboCodigoTipoItem = new System.Windows.Forms.ComboBox();
            this.lblCodigoFuncionario = new System.Windows.Forms.Label();
            this.lblDatahAlteracao = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblCodigoTipoItem = new System.Windows.Forms.Label();
            this.lblDescricaoItem = new System.Windows.Forms.Label();
            this.tspBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.tsbGravar = new System.Windows.Forms.ToolStripButton();
            this.grpDadosChaveItens.SuspendLayout();
            this.grpDadosBasicos.SuspendLayout();
            this.tspBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosChaveItens
            // 
            this.grpDadosChaveItens.Controls.Add(this.btnBuscarItem);
            this.grpDadosChaveItens.Controls.Add(this.txtCodigoItem);
            this.grpDadosChaveItens.Controls.Add(this.lblCodigoItem);
            this.grpDadosChaveItens.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDadosChaveItens.Location = new System.Drawing.Point(0, 0);
            this.grpDadosChaveItens.Name = "grpDadosChaveItens";
            this.grpDadosChaveItens.Size = new System.Drawing.Size(484, 67);
            this.grpDadosChaveItens.TabIndex = 0;
            this.grpDadosChaveItens.TabStop = false;
            // 
            // btnBuscarItem
            // 
            this.btnBuscarItem.Location = new System.Drawing.Point(219, 22);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(112, 29);
            this.btnBuscarItem.TabIndex = 2;
            this.btnBuscarItem.Text = "Buscar";
            this.btnBuscarItem.UseVisualStyleBackColor = true;
            this.btnBuscarItem.Click += new System.EventHandler(this.btnBuscarItem_Click);
            // 
            // txtCodigoItem
            // 
            this.txtCodigoItem.Location = new System.Drawing.Point(84, 27);
            this.txtCodigoItem.MaxLength = 15;
            this.txtCodigoItem.Name = "txtCodigoItem";
            this.txtCodigoItem.Size = new System.Drawing.Size(104, 20);
            this.txtCodigoItem.TabIndex = 1;
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
            // grpDadosBasicos
            // 
            this.grpDadosBasicos.Controls.Add(this.txtCodigoFuncionario);
            this.grpDadosBasicos.Controls.Add(this.txtDatahAlteracao);
            this.grpDadosBasicos.Controls.Add(this.txtDescricaoItem);
            this.grpDadosBasicos.Controls.Add(this.cboSituacaoItem);
            this.grpDadosBasicos.Controls.Add(this.cboCodigoTipoItem);
            this.grpDadosBasicos.Controls.Add(this.lblCodigoFuncionario);
            this.grpDadosBasicos.Controls.Add(this.lblDatahAlteracao);
            this.grpDadosBasicos.Controls.Add(this.lblSituacao);
            this.grpDadosBasicos.Controls.Add(this.lblCodigoTipoItem);
            this.grpDadosBasicos.Controls.Add(this.lblDescricaoItem);
            this.grpDadosBasicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDadosBasicos.Enabled = false;
            this.grpDadosBasicos.Location = new System.Drawing.Point(0, 67);
            this.grpDadosBasicos.Name = "grpDadosBasicos";
            this.grpDadosBasicos.Size = new System.Drawing.Size(484, 200);
            this.grpDadosBasicos.TabIndex = 1;
            this.grpDadosBasicos.TabStop = false;
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Enabled = false;
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(114, 119);
            this.txtCodigoFuncionario.MaxLength = 20;
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoFuncionario.TabIndex = 9;
            // 
            // txtDatahAlteracao
            // 
            this.txtDatahAlteracao.Enabled = false;
            this.txtDatahAlteracao.Location = new System.Drawing.Point(114, 93);
            this.txtDatahAlteracao.MaxLength = 60;
            this.txtDatahAlteracao.Name = "txtDatahAlteracao";
            this.txtDatahAlteracao.Size = new System.Drawing.Size(241, 20);
            this.txtDatahAlteracao.TabIndex = 8;
            // 
            // txtDescricaoItem
            // 
            this.txtDescricaoItem.Location = new System.Drawing.Point(114, 13);
            this.txtDescricaoItem.MaxLength = 80;
            this.txtDescricaoItem.Name = "txtDescricaoItem";
            this.txtDescricaoItem.Size = new System.Drawing.Size(241, 20);
            this.txtDescricaoItem.TabIndex = 7;
            // 
            // cboSituacaoItem
            // 
            this.cboSituacaoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacaoItem.FormattingEnabled = true;
            this.cboSituacaoItem.Items.AddRange(new object[] {
            "A - Ativo",
            "I - Inativo"});
            this.cboSituacaoItem.Location = new System.Drawing.Point(114, 66);
            this.cboSituacaoItem.Name = "cboSituacaoItem";
            this.cboSituacaoItem.Size = new System.Drawing.Size(121, 21);
            this.cboSituacaoItem.TabIndex = 6;
            // 
            // cboCodigoTipoItem
            // 
            this.cboCodigoTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoTipoItem.FormattingEnabled = true;
            this.cboCodigoTipoItem.Location = new System.Drawing.Point(114, 39);
            this.cboCodigoTipoItem.Name = "cboCodigoTipoItem";
            this.cboCodigoTipoItem.Size = new System.Drawing.Size(121, 21);
            this.cboCodigoTipoItem.TabIndex = 5;
            // 
            // lblCodigoFuncionario
            // 
            this.lblCodigoFuncionario.AutoSize = true;
            this.lblCodigoFuncionario.Location = new System.Drawing.Point(12, 122);
            this.lblCodigoFuncionario.Name = "lblCodigoFuncionario";
            this.lblCodigoFuncionario.Size = new System.Drawing.Size(65, 13);
            this.lblCodigoFuncionario.TabIndex = 4;
            this.lblCodigoFuncionario.Text = "Funcionario:";
            // 
            // lblDatahAlteracao
            // 
            this.lblDatahAlteracao.AutoSize = true;
            this.lblDatahAlteracao.Location = new System.Drawing.Point(12, 96);
            this.lblDatahAlteracao.Name = "lblDatahAlteracao";
            this.lblDatahAlteracao.Size = new System.Drawing.Size(96, 13);
            this.lblDatahAlteracao.TabIndex = 3;
            this.lblDatahAlteracao.Text = "Data de Alteração:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(12, 69);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 2;
            this.lblSituacao.Text = "Situacao:";
            // 
            // lblCodigoTipoItem
            // 
            this.lblCodigoTipoItem.AutoSize = true;
            this.lblCodigoTipoItem.Location = new System.Drawing.Point(12, 42);
            this.lblCodigoTipoItem.Name = "lblCodigoTipoItem";
            this.lblCodigoTipoItem.Size = new System.Drawing.Size(54, 13);
            this.lblCodigoTipoItem.TabIndex = 1;
            this.lblCodigoTipoItem.Text = "Tipo Item:";
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
            // tspBotoes
            // 
            this.tspBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFechar,
            this.tsbLimpar,
            this.tsbGravar});
            this.tspBotoes.Location = new System.Drawing.Point(0, 242);
            this.tspBotoes.Name = "tspBotoes";
            this.tspBotoes.Size = new System.Drawing.Size(484, 25);
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
            this.tsbGravar.Enabled = false;
            this.tsbGravar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGravar.Image")));
            this.tsbGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGravar.Name = "tsbGravar";
            this.tsbGravar.Size = new System.Drawing.Size(68, 22);
            this.tsbGravar.Text = "F9 - Gravar";
            this.tsbGravar.Click += new System.EventHandler(this.tsbGravar_Click);
            // 
            // FrmCadastroItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 267);
            this.Controls.Add(this.tspBotoes);
            this.Controls.Add(this.grpDadosBasicos);
            this.Controls.Add(this.grpDadosChaveItens);
            this.Name = "FrmCadastroItens";
            this.Text = "Cadastro de Itens";
            this.Load += new System.EventHandler(this.FrmCadastroItens_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroItens_KeyDown);
            this.grpDadosChaveItens.ResumeLayout(false);
            this.grpDadosChaveItens.PerformLayout();
            this.grpDadosBasicos.ResumeLayout(false);
            this.grpDadosBasicos.PerformLayout();
            this.tspBotoes.ResumeLayout(false);
            this.tspBotoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosChaveItens;
        private System.Windows.Forms.GroupBox grpDadosBasicos;
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.TextBox txtCodigoItem;
        private System.Windows.Forms.Label lblCodigoItem;
        private System.Windows.Forms.TextBox txtCodigoFuncionario;
        private System.Windows.Forms.TextBox txtDatahAlteracao;
        private System.Windows.Forms.TextBox txtDescricaoItem;
        private System.Windows.Forms.ComboBox cboSituacaoItem;
        private System.Windows.Forms.ComboBox cboCodigoTipoItem;
        private System.Windows.Forms.Label lblCodigoFuncionario;
        private System.Windows.Forms.Label lblDatahAlteracao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblCodigoTipoItem;
        private System.Windows.Forms.Label lblDescricaoItem;
        private System.Windows.Forms.ToolStrip tspBotoes;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.ToolStripButton tsbLimpar;
        private System.Windows.Forms.ToolStripButton tsbGravar;
    }
}