
namespace TjossSystem
{
    partial class FrmCadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroFuncionario));
            this.tspBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.tsbGravar = new System.Windows.Forms.ToolStripButton();
            this.grpDadosChaveCargo = new System.Windows.Forms.GroupBox();
            this.btnBuscarFuncionario = new System.Windows.Forms.Button();
            this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.lblCodigoFuncionario = new System.Windows.Forms.Label();
            this.grpDadosBasicos = new System.Windows.Forms.GroupBox();
            this.lblCodigoCargo = new System.Windows.Forms.Label();
            this.lblDataDesligamento = new System.Windows.Forms.Label();
            this.lblDataAdmissao = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.cboCodigoCargo = new System.Windows.Forms.ComboBox();
            this.txtDataDesligamento = new System.Windows.Forms.MaskedTextBox();
            this.txtDataAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtControle = new System.Windows.Forms.TextBox();
            this.lblControle = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
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
            this.tspBotoes.Location = new System.Drawing.Point(0, 287);
            this.tspBotoes.Name = "tspBotoes";
            this.tspBotoes.Size = new System.Drawing.Size(529, 25);
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
            this.grpDadosChaveCargo.Controls.Add(this.btnBuscarFuncionario);
            this.grpDadosChaveCargo.Controls.Add(this.txtCodigoFuncionario);
            this.grpDadosChaveCargo.Controls.Add(this.lblCodigoFuncionario);
            this.grpDadosChaveCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDadosChaveCargo.Location = new System.Drawing.Point(0, 0);
            this.grpDadosChaveCargo.Name = "grpDadosChaveCargo";
            this.grpDadosChaveCargo.Size = new System.Drawing.Size(529, 67);
            this.grpDadosChaveCargo.TabIndex = 12;
            this.grpDadosChaveCargo.TabStop = false;
            // 
            // btnBuscarFuncionario
            // 
            this.btnBuscarFuncionario.Location = new System.Drawing.Point(245, 22);
            this.btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            this.btnBuscarFuncionario.Size = new System.Drawing.Size(112, 29);
            this.btnBuscarFuncionario.TabIndex = 2;
            this.btnBuscarFuncionario.Text = "Buscar";
            this.btnBuscarFuncionario.UseVisualStyleBackColor = true;
            this.btnBuscarFuncionario.Click += new System.EventHandler(this.btnBuscarFuncionario_Click);
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(119, 27);
            this.txtCodigoFuncionario.MaxLength = 15;
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(104, 20);
            this.txtCodigoFuncionario.TabIndex = 1;
            this.txtCodigoFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoFuncionario_KeyPress);
            // 
            // lblCodigoFuncionario
            // 
            this.lblCodigoFuncionario.AutoSize = true;
            this.lblCodigoFuncionario.Location = new System.Drawing.Point(12, 30);
            this.lblCodigoFuncionario.Name = "lblCodigoFuncionario";
            this.lblCodigoFuncionario.Size = new System.Drawing.Size(101, 13);
            this.lblCodigoFuncionario.TabIndex = 0;
            this.lblCodigoFuncionario.Text = "Código Funcionario:";
            // 
            // grpDadosBasicos
            // 
            this.grpDadosBasicos.Controls.Add(this.lblCodigoCargo);
            this.grpDadosBasicos.Controls.Add(this.lblDataDesligamento);
            this.grpDadosBasicos.Controls.Add(this.lblDataAdmissao);
            this.grpDadosBasicos.Controls.Add(this.lblDataNascimento);
            this.grpDadosBasicos.Controls.Add(this.cboCodigoCargo);
            this.grpDadosBasicos.Controls.Add(this.txtDataDesligamento);
            this.grpDadosBasicos.Controls.Add(this.txtDataAdmissao);
            this.grpDadosBasicos.Controls.Add(this.txtDataNascimento);
            this.grpDadosBasicos.Controls.Add(this.txtControle);
            this.grpDadosBasicos.Controls.Add(this.lblControle);
            this.grpDadosBasicos.Controls.Add(this.txtCpf);
            this.grpDadosBasicos.Controls.Add(this.lblCpf);
            this.grpDadosBasicos.Controls.Add(this.txtNomeFuncionario);
            this.grpDadosBasicos.Controls.Add(this.lblNomeFuncionario);
            this.grpDadosBasicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDadosBasicos.Enabled = false;
            this.grpDadosBasicos.Location = new System.Drawing.Point(0, 67);
            this.grpDadosBasicos.Name = "grpDadosBasicos";
            this.grpDadosBasicos.Size = new System.Drawing.Size(529, 220);
            this.grpDadosBasicos.TabIndex = 13;
            this.grpDadosBasicos.TabStop = false;
            // 
            // lblCodigoCargo
            // 
            this.lblCodigoCargo.AutoSize = true;
            this.lblCodigoCargo.Location = new System.Drawing.Point(12, 172);
            this.lblCodigoCargo.Name = "lblCodigoCargo";
            this.lblCodigoCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCodigoCargo.TabIndex = 19;
            this.lblCodigoCargo.Text = "Cargo:";
            // 
            // lblDataDesligamento
            // 
            this.lblDataDesligamento.AutoSize = true;
            this.lblDataDesligamento.Location = new System.Drawing.Point(12, 146);
            this.lblDataDesligamento.Name = "lblDataDesligamento";
            this.lblDataDesligamento.Size = new System.Drawing.Size(100, 13);
            this.lblDataDesligamento.TabIndex = 18;
            this.lblDataDesligamento.Text = "Data Desligamento:";
            // 
            // lblDataAdmissao
            // 
            this.lblDataAdmissao.AutoSize = true;
            this.lblDataAdmissao.Location = new System.Drawing.Point(12, 120);
            this.lblDataAdmissao.Name = "lblDataAdmissao";
            this.lblDataAdmissao.Size = new System.Drawing.Size(81, 13);
            this.lblDataAdmissao.TabIndex = 17;
            this.lblDataAdmissao.Text = "Data Admissão:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(12, 94);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascimento.TabIndex = 16;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // cboCodigoCargo
            // 
            this.cboCodigoCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoCargo.FormattingEnabled = true;
            this.cboCodigoCargo.Location = new System.Drawing.Point(119, 169);
            this.cboCodigoCargo.Name = "cboCodigoCargo";
            this.cboCodigoCargo.Size = new System.Drawing.Size(121, 21);
            this.cboCodigoCargo.TabIndex = 7;
            // 
            // txtDataDesligamento
            // 
            this.txtDataDesligamento.Location = new System.Drawing.Point(119, 143);
            this.txtDataDesligamento.Mask = "00/00/0000";
            this.txtDataDesligamento.Name = "txtDataDesligamento";
            this.txtDataDesligamento.Size = new System.Drawing.Size(100, 20);
            this.txtDataDesligamento.TabIndex = 6;
            this.txtDataDesligamento.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataAdmissao
            // 
            this.txtDataAdmissao.Location = new System.Drawing.Point(119, 117);
            this.txtDataAdmissao.Mask = "00/00/0000";
            this.txtDataAdmissao.Name = "txtDataAdmissao";
            this.txtDataAdmissao.Size = new System.Drawing.Size(100, 20);
            this.txtDataAdmissao.TabIndex = 5;
            this.txtDataAdmissao.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(119, 91);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtDataNascimento.TabIndex = 4;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtControle
            // 
            this.txtControle.Location = new System.Drawing.Point(119, 65);
            this.txtControle.MaxLength = 2;
            this.txtControle.Name = "txtControle";
            this.txtControle.Size = new System.Drawing.Size(44, 20);
            this.txtControle.TabIndex = 3;
            this.txtControle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtControle_KeyPress);
            // 
            // lblControle
            // 
            this.lblControle.AutoSize = true;
            this.lblControle.Location = new System.Drawing.Point(12, 68);
            this.lblControle.Name = "lblControle";
            this.lblControle.Size = new System.Drawing.Size(49, 13);
            this.lblControle.TabIndex = 10;
            this.lblControle.Text = "Controle:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(119, 39);
            this.txtCpf.MaxLength = 9;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(82, 20);
            this.txtCpf.TabIndex = 2;
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(12, 42);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 8;
            this.lblCpf.Text = "CPF:";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(119, 13);
            this.txtNomeFuncionario.MaxLength = 80;
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(241, 20);
            this.txtNomeFuncionario.TabIndex = 1;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(12, 16);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(38, 13);
            this.lblNomeFuncionario.TabIndex = 0;
            this.lblNomeFuncionario.Text = "Nome:";
            // 
            // FrmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 312);
            this.Controls.Add(this.grpDadosBasicos);
            this.Controls.Add(this.grpDadosChaveCargo);
            this.Controls.Add(this.tspBotoes);
            this.Name = "FrmCadastroFuncionario";
            this.Text = "Cadastro de Funcionario";
            this.Load += new System.EventHandler(this.FrmCadastroFuncionario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroFuncionario_KeyDown);
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
        private System.Windows.Forms.Button btnBuscarFuncionario;
        private System.Windows.Forms.TextBox txtCodigoFuncionario;
        private System.Windows.Forms.Label lblCodigoFuncionario;
        private System.Windows.Forms.GroupBox grpDadosBasicos;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.TextBox txtControle;
        private System.Windows.Forms.Label lblControle;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.ComboBox cboCodigoCargo;
        private System.Windows.Forms.MaskedTextBox txtDataDesligamento;
        private System.Windows.Forms.MaskedTextBox txtDataAdmissao;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.Label lblCodigoCargo;
        private System.Windows.Forms.Label lblDataDesligamento;
        private System.Windows.Forms.Label lblDataAdmissao;
        private System.Windows.Forms.Label lblDataNascimento;
    }
}