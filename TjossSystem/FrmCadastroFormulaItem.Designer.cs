
namespace TjossSystem
{
    partial class FrmCadastroFormulaItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroFormulaItem));
            this.grpDadosChaveItens = new System.Windows.Forms.GroupBox();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.txtCodigoItem = new System.Windows.Forms.TextBox();
            this.lblCodigoItem = new System.Windows.Forms.Label();
            this.grpDadosBasicos = new System.Windows.Forms.GroupBox();
            this.txtObservacaoFormula = new System.Windows.Forms.RichTextBox();
            this.tspBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.tsbGravar = new System.Windows.Forms.ToolStripButton();
            this.lblObservacaoFormula = new System.Windows.Forms.Label();
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
            this.grpDadosChaveItens.Size = new System.Drawing.Size(421, 67);
            this.grpDadosChaveItens.TabIndex = 4;
            this.grpDadosChaveItens.TabStop = false;
            // 
            // btnBuscarItem
            // 
            this.btnBuscarItem.Location = new System.Drawing.Point(203, 22);
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
            this.grpDadosBasicos.Controls.Add(this.txtObservacaoFormula);
            this.grpDadosBasicos.Controls.Add(this.lblObservacaoFormula);
            this.grpDadosBasicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDadosBasicos.Enabled = false;
            this.grpDadosBasicos.Location = new System.Drawing.Point(0, 67);
            this.grpDadosBasicos.Name = "grpDadosBasicos";
            this.grpDadosBasicos.Size = new System.Drawing.Size(421, 142);
            this.grpDadosBasicos.TabIndex = 5;
            this.grpDadosBasicos.TabStop = false;
            // 
            // txtObservacaoFormula
            // 
            this.txtObservacaoFormula.Location = new System.Drawing.Point(84, 16);
            this.txtObservacaoFormula.MaxLength = 200;
            this.txtObservacaoFormula.Name = "txtObservacaoFormula";
            this.txtObservacaoFormula.Size = new System.Drawing.Size(241, 42);
            this.txtObservacaoFormula.TabIndex = 9;
            this.txtObservacaoFormula.Text = "";
            // 
            // tspBotoes
            // 
            this.tspBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFechar,
            this.tsbLimpar,
            this.tsbGravar});
            this.tspBotoes.Location = new System.Drawing.Point(0, 184);
            this.tspBotoes.Name = "tspBotoes";
            this.tspBotoes.Size = new System.Drawing.Size(421, 25);
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
            // lblObservacaoFormula
            // 
            this.lblObservacaoFormula.AutoSize = true;
            this.lblObservacaoFormula.Location = new System.Drawing.Point(12, 16);
            this.lblObservacaoFormula.Name = "lblObservacaoFormula";
            this.lblObservacaoFormula.Size = new System.Drawing.Size(58, 13);
            this.lblObservacaoFormula.TabIndex = 0;
            this.lblObservacaoFormula.Text = "Descrição:";
            // 
            // FrmCadastroFormulaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 209);
            this.Controls.Add(this.tspBotoes);
            this.Controls.Add(this.grpDadosBasicos);
            this.Controls.Add(this.grpDadosChaveItens);
            this.Name = "FrmCadastroFormulaItem";
            this.Text = "Cadastro de Formulas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroFormulaItem_KeyDown);
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
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.TextBox txtCodigoItem;
        private System.Windows.Forms.Label lblCodigoItem;
        private System.Windows.Forms.GroupBox grpDadosBasicos;
        private System.Windows.Forms.ToolStrip tspBotoes;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.ToolStripButton tsbLimpar;
        private System.Windows.Forms.ToolStripButton tsbGravar;
        private System.Windows.Forms.Label lblObservacaoFormula;
        private System.Windows.Forms.RichTextBox txtObservacaoFormula;
    }
}