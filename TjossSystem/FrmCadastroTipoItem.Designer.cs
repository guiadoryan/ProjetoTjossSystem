
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblDescricaoItem = new System.Windows.Forms.Label();
            this.grpDadosChaveItens = new System.Windows.Forms.GroupBox();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCodigoTipoItem = new System.Windows.Forms.Label();
            this.tspBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.tsbGravar = new System.Windows.Forms.ToolStripButton();
            this.grpDadosBasicos.SuspendLayout();
            this.grpDadosChaveItens.SuspendLayout();
            this.tspBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosBasicos
            // 
            this.grpDadosBasicos.Controls.Add(this.tspBotoes);
            this.grpDadosBasicos.Controls.Add(this.textBox2);
            this.grpDadosBasicos.Controls.Add(this.comboBox2);
            this.grpDadosBasicos.Controls.Add(this.lblSituacao);
            this.grpDadosBasicos.Controls.Add(this.lblDescricaoItem);
            this.grpDadosBasicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDadosBasicos.Location = new System.Drawing.Point(0, 67);
            this.grpDadosBasicos.Name = "grpDadosBasicos";
            this.grpDadosBasicos.Size = new System.Drawing.Size(438, 143);
            this.grpDadosBasicos.TabIndex = 4;
            this.grpDadosBasicos.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 20);
            this.textBox2.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(114, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
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
            // grpDadosChaveItens
            // 
            this.grpDadosChaveItens.Controls.Add(this.btnBuscarItem);
            this.grpDadosChaveItens.Controls.Add(this.textBox1);
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 1;
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
            // 
            // FrmCadastroTipoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 210);
            this.Controls.Add(this.grpDadosBasicos);
            this.Controls.Add(this.grpDadosChaveItens);
            this.Name = "FrmCadastroTipoItem";
            this.Text = "FrmCadastroTipoItem";
            this.grpDadosBasicos.ResumeLayout(false);
            this.grpDadosBasicos.PerformLayout();
            this.grpDadosChaveItens.ResumeLayout(false);
            this.grpDadosChaveItens.PerformLayout();
            this.tspBotoes.ResumeLayout(false);
            this.tspBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosBasicos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblDescricaoItem;
        private System.Windows.Forms.GroupBox grpDadosChaveItens;
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCodigoTipoItem;
        private System.Windows.Forms.ToolStrip tspBotoes;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.ToolStripButton tsbLimpar;
        private System.Windows.Forms.ToolStripButton tsbGravar;
    }
}