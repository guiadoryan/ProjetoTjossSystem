
namespace TjossSystem
{
    partial class FrmCadastroCargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroCargos));
            this.grpDadosBasicos = new System.Windows.Forms.GroupBox();
            this.tspBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.tsbGravar = new System.Windows.Forms.ToolStripButton();
            this.txtDescricaoCargo = new System.Windows.Forms.TextBox();
            this.cboSituacaoCargo = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblDescricaoItem = new System.Windows.Forms.Label();
            this.grpDadosChaveCargo = new System.Windows.Forms.GroupBox();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.txtCodigoCargo = new System.Windows.Forms.TextBox();
            this.lblCodigoCargo = new System.Windows.Forms.Label();
            this.grpDadosBasicos.SuspendLayout();
            this.tspBotoes.SuspendLayout();
            this.grpDadosChaveCargo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosBasicos
            // 
            this.grpDadosBasicos.Controls.Add(this.tspBotoes);
            this.grpDadosBasicos.Controls.Add(this.txtDescricaoCargo);
            this.grpDadosBasicos.Controls.Add(this.cboSituacaoCargo);
            this.grpDadosBasicos.Controls.Add(this.lblSituacao);
            this.grpDadosBasicos.Controls.Add(this.lblDescricaoItem);
            this.grpDadosBasicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDadosBasicos.Location = new System.Drawing.Point(0, 67);
            this.grpDadosBasicos.Name = "grpDadosBasicos";
            this.grpDadosBasicos.Size = new System.Drawing.Size(414, 123);
            this.grpDadosBasicos.TabIndex = 3;
            this.grpDadosBasicos.TabStop = false;
            // 
            // tspBotoes
            // 
            this.tspBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFechar,
            this.tsbLimpar,
            this.tsbGravar});
            this.tspBotoes.Location = new System.Drawing.Point(3, 95);
            this.tspBotoes.Name = "tspBotoes";
            this.tspBotoes.Size = new System.Drawing.Size(408, 25);
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
            // txtDescricaoCargo
            // 
            this.txtDescricaoCargo.Location = new System.Drawing.Point(92, 13);
            this.txtDescricaoCargo.MaxLength = 80;
            this.txtDescricaoCargo.Name = "txtDescricaoCargo";
            this.txtDescricaoCargo.Size = new System.Drawing.Size(241, 20);
            this.txtDescricaoCargo.TabIndex = 7;
            // 
            // cboSituacaoCargo
            // 
            this.cboSituacaoCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacaoCargo.FormattingEnabled = true;
            this.cboSituacaoCargo.Items.AddRange(new object[] {
            "A - Ativo",
            "I - Inativo"});
            this.cboSituacaoCargo.Location = new System.Drawing.Point(92, 39);
            this.cboSituacaoCargo.Name = "cboSituacaoCargo";
            this.cboSituacaoCargo.Size = new System.Drawing.Size(121, 21);
            this.cboSituacaoCargo.TabIndex = 6;
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
            // grpDadosChaveCargo
            // 
            this.grpDadosChaveCargo.Controls.Add(this.btnBuscarItem);
            this.grpDadosChaveCargo.Controls.Add(this.txtCodigoCargo);
            this.grpDadosChaveCargo.Controls.Add(this.lblCodigoCargo);
            this.grpDadosChaveCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDadosChaveCargo.Location = new System.Drawing.Point(0, 0);
            this.grpDadosChaveCargo.Name = "grpDadosChaveCargo";
            this.grpDadosChaveCargo.Size = new System.Drawing.Size(414, 67);
            this.grpDadosChaveCargo.TabIndex = 2;
            this.grpDadosChaveCargo.TabStop = false;
            // 
            // btnBuscarItem
            // 
            this.btnBuscarItem.Location = new System.Drawing.Point(245, 22);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(112, 29);
            this.btnBuscarItem.TabIndex = 2;
            this.btnBuscarItem.Text = "Buscar";
            this.btnBuscarItem.UseVisualStyleBackColor = true;
            this.btnBuscarItem.Click += new System.EventHandler(this.btnBuscarItem_Click);
            // 
            // txtCodigoCargo
            // 
            this.txtCodigoCargo.Location = new System.Drawing.Point(92, 27);
            this.txtCodigoCargo.MaxLength = 15;
            this.txtCodigoCargo.Name = "txtCodigoCargo";
            this.txtCodigoCargo.Size = new System.Drawing.Size(104, 20);
            this.txtCodigoCargo.TabIndex = 1;
            // 
            // lblCodigoCargo
            // 
            this.lblCodigoCargo.AutoSize = true;
            this.lblCodigoCargo.Location = new System.Drawing.Point(12, 30);
            this.lblCodigoCargo.Name = "lblCodigoCargo";
            this.lblCodigoCargo.Size = new System.Drawing.Size(74, 13);
            this.lblCodigoCargo.TabIndex = 0;
            this.lblCodigoCargo.Text = "Código Cargo:";
            // 
            // FrmCadastroCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 190);
            this.Controls.Add(this.grpDadosBasicos);
            this.Controls.Add(this.grpDadosChaveCargo);
            this.KeyPreview = true;
            this.Name = "FrmCadastroCargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cargos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroCargos_KeyDown);
            this.grpDadosBasicos.ResumeLayout(false);
            this.grpDadosBasicos.PerformLayout();
            this.tspBotoes.ResumeLayout(false);
            this.tspBotoes.PerformLayout();
            this.grpDadosChaveCargo.ResumeLayout(false);
            this.grpDadosChaveCargo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosBasicos;
        private System.Windows.Forms.ToolStrip tspBotoes;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.ToolStripButton tsbLimpar;
        private System.Windows.Forms.ToolStripButton tsbGravar;
        private System.Windows.Forms.TextBox txtDescricaoCargo;
        private System.Windows.Forms.ComboBox cboSituacaoCargo;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblDescricaoItem;
        private System.Windows.Forms.GroupBox grpDadosChaveCargo;
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.TextBox txtCodigoCargo;
        private System.Windows.Forms.Label lblCodigoCargo;
    }
}