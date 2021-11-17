
namespace TjossSystem
{
    partial class FrmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuario));
            this.tspBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.tsbGravar = new System.Windows.Forms.ToolStripButton();
            this.grpDadosChaveCargo = new System.Windows.Forms.GroupBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.txtCodigoUsuario = new System.Windows.Forms.TextBox();
            this.lblCodigoUsuario = new System.Windows.Forms.Label();
            this.grpDadosBasicos = new System.Windows.Forms.GroupBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtDatahCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tspBotoes.SuspendLayout();
            this.grpDadosChaveCargo.SuspendLayout();
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
            this.tspBotoes.Location = new System.Drawing.Point(0, 145);
            this.tspBotoes.Name = "tspBotoes";
            this.tspBotoes.Size = new System.Drawing.Size(441, 25);
            this.tspBotoes.TabIndex = 12;
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
            // grpDadosChaveCargo
            // 
            this.grpDadosChaveCargo.Controls.Add(this.btnBuscarUsuario);
            this.grpDadosChaveCargo.Controls.Add(this.txtCodigoUsuario);
            this.grpDadosChaveCargo.Controls.Add(this.lblCodigoUsuario);
            this.grpDadosChaveCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDadosChaveCargo.Location = new System.Drawing.Point(0, 0);
            this.grpDadosChaveCargo.Name = "grpDadosChaveCargo";
            this.grpDadosChaveCargo.Size = new System.Drawing.Size(441, 67);
            this.grpDadosChaveCargo.TabIndex = 13;
            this.grpDadosChaveCargo.TabStop = false;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(245, 22);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(112, 29);
            this.btnBuscarUsuario.TabIndex = 2;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // txtCodigoUsuario
            // 
            this.txtCodigoUsuario.Location = new System.Drawing.Point(119, 27);
            this.txtCodigoUsuario.MaxLength = 15;
            this.txtCodigoUsuario.Name = "txtCodigoUsuario";
            this.txtCodigoUsuario.Size = new System.Drawing.Size(104, 20);
            this.txtCodigoUsuario.TabIndex = 1;
            // 
            // lblCodigoUsuario
            // 
            this.lblCodigoUsuario.AutoSize = true;
            this.lblCodigoUsuario.Location = new System.Drawing.Point(12, 30);
            this.lblCodigoUsuario.Name = "lblCodigoUsuario";
            this.lblCodigoUsuario.Size = new System.Drawing.Size(101, 13);
            this.lblCodigoUsuario.TabIndex = 0;
            this.lblCodigoUsuario.Text = "Código Funcionario:";
            // 
            // grpDadosBasicos
            // 
            this.grpDadosBasicos.Controls.Add(this.lblDataNascimento);
            this.grpDadosBasicos.Controls.Add(this.txtDatahCadastro);
            this.grpDadosBasicos.Controls.Add(this.txtSenha);
            this.grpDadosBasicos.Controls.Add(this.lblSenha);
            this.grpDadosBasicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDadosBasicos.Enabled = false;
            this.grpDadosBasicos.Location = new System.Drawing.Point(0, 67);
            this.grpDadosBasicos.Name = "grpDadosBasicos";
            this.grpDadosBasicos.Size = new System.Drawing.Size(441, 78);
            this.grpDadosBasicos.TabIndex = 14;
            this.grpDadosBasicos.TabStop = false;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(12, 42);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(93, 13);
            this.lblDataNascimento.TabIndex = 16;
            this.lblDataNascimento.Text = "Data do Cadastro:";
            // 
            // txtDatahCadastro
            // 
            this.txtDatahCadastro.Location = new System.Drawing.Point(119, 39);
            this.txtDatahCadastro.Mask = "00/00/0000";
            this.txtDatahCadastro.Name = "txtDatahCadastro";
            this.txtDatahCadastro.Size = new System.Drawing.Size(100, 20);
            this.txtDatahCadastro.TabIndex = 4;
            this.txtDatahCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(119, 13);
            this.txtSenha.MaxLength = 30;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(241, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(12, 16);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha:";
            // 
            // FrmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 170);
            this.Controls.Add(this.grpDadosBasicos);
            this.Controls.Add(this.grpDadosChaveCargo);
            this.Controls.Add(this.tspBotoes);
            this.Name = "FrmCadastroUsuario";
            this.Text = "Cadastro de Usuario";
            this.Load += new System.EventHandler(this.FrmCadastroUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroUsuario_KeyDown);
            this.tspBotoes.ResumeLayout(false);
            this.tspBotoes.PerformLayout();
            this.grpDadosChaveCargo.ResumeLayout(false);
            this.grpDadosChaveCargo.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpDadosChaveCargo;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.TextBox txtCodigoUsuario;
        private System.Windows.Forms.Label lblCodigoUsuario;
        private System.Windows.Forms.GroupBox grpDadosBasicos;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.MaskedTextBox txtDatahCadastro;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
    }
}