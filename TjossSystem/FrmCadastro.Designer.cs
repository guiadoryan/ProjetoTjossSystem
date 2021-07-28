
namespace TjossSystem
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.grpDadosChave = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNumeroCadastro = new System.Windows.Forms.Label();
            this.tbcDadosCadastro = new System.Windows.Forms.TabControl();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.tabDefinicao = new System.Windows.Forms.TabPage();
            this.tlsBotoes = new System.Windows.Forms.ToolStrip();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblCodigoTipoCadastro = new System.Windows.Forms.Label();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblControle = new System.Windows.Forms.Label();
            this.lblDatahAlteracao = new System.Windows.Forms.Label();
            this.lblCodigoFuncionario = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtDatahAlteracao = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.tsbGravar = new System.Windows.Forms.ToolStripButton();
            this.grpDadosChave.SuspendLayout();
            this.tbcDadosCadastro.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.tlsBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosChave
            // 
            this.grpDadosChave.Controls.Add(this.lblNumeroCadastro);
            this.grpDadosChave.Controls.Add(this.textBox1);
            this.grpDadosChave.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDadosChave.Location = new System.Drawing.Point(0, 0);
            this.grpDadosChave.Name = "grpDadosChave";
            this.grpDadosChave.Size = new System.Drawing.Size(833, 88);
            this.grpDadosChave.TabIndex = 0;
            this.grpDadosChave.TabStop = false;
            this.grpDadosChave.Text = "Dados Basicos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblNumeroCadastro
            // 
            this.lblNumeroCadastro.AutoSize = true;
            this.lblNumeroCadastro.Location = new System.Drawing.Point(24, 38);
            this.lblNumeroCadastro.Name = "lblNumeroCadastro";
            this.lblNumeroCadastro.Size = new System.Drawing.Size(91, 13);
            this.lblNumeroCadastro.TabIndex = 1;
            this.lblNumeroCadastro.Text = "Número cadastro:";
            // 
            // tbcDadosCadastro
            // 
            this.tbcDadosCadastro.Controls.Add(this.tabCadastro);
            this.tbcDadosCadastro.Controls.Add(this.tabDefinicao);
            this.tbcDadosCadastro.Location = new System.Drawing.Point(0, 94);
            this.tbcDadosCadastro.Name = "tbcDadosCadastro";
            this.tbcDadosCadastro.SelectedIndex = 0;
            this.tbcDadosCadastro.Size = new System.Drawing.Size(833, 419);
            this.tbcDadosCadastro.TabIndex = 1;
            // 
            // tabCadastro
            // 
            this.tabCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.tabCadastro.Controls.Add(this.textBox8);
            this.tabCadastro.Controls.Add(this.txtDatahAlteracao);
            this.tabCadastro.Controls.Add(this.textBox6);
            this.tabCadastro.Controls.Add(this.textBox5);
            this.tabCadastro.Controls.Add(this.textBox4);
            this.tabCadastro.Controls.Add(this.textBox3);
            this.tabCadastro.Controls.Add(this.textBox2);
            this.tabCadastro.Controls.Add(this.lblCodigoFuncionario);
            this.tabCadastro.Controls.Add(this.lblDatahAlteracao);
            this.tabCadastro.Controls.Add(this.lblControle);
            this.tabCadastro.Controls.Add(this.lblCpfCnpj);
            this.tabCadastro.Controls.Add(this.lblCodigoTipoCadastro);
            this.tabCadastro.Controls.Add(this.lblNomeFantasia);
            this.tabCadastro.Controls.Add(this.lblNomeCadastro);
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(825, 393);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "Dados Cadastro";
            // 
            // tabDefinicao
            // 
            this.tabDefinicao.BackColor = System.Drawing.SystemColors.Control;
            this.tabDefinicao.Location = new System.Drawing.Point(4, 22);
            this.tabDefinicao.Name = "tabDefinicao";
            this.tabDefinicao.Padding = new System.Windows.Forms.Padding(3);
            this.tabDefinicao.Size = new System.Drawing.Size(825, 393);
            this.tabDefinicao.TabIndex = 1;
            this.tabDefinicao.Text = "Definicao";
            // 
            // tlsBotoes
            // 
            this.tlsBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlsBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsbLimpar,
            this.tsbGravar});
            this.tlsBotoes.Location = new System.Drawing.Point(0, 516);
            this.tlsBotoes.Name = "tlsBotoes";
            this.tlsBotoes.Size = new System.Drawing.Size(833, 25);
            this.tlsBotoes.TabIndex = 2;
            this.tlsBotoes.Text = "toolStrip1";
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Location = new System.Drawing.Point(20, 31);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(82, 13);
            this.lblNomeCadastro.TabIndex = 2;
            this.lblNomeCadastro.Text = "Nome cadastro:";
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(20, 57);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(78, 13);
            this.lblNomeFantasia.TabIndex = 3;
            this.lblNomeFantasia.Text = "Nome fantasia:";
            // 
            // lblCodigoTipoCadastro
            // 
            this.lblCodigoTipoCadastro.AutoSize = true;
            this.lblCodigoTipoCadastro.Location = new System.Drawing.Point(20, 83);
            this.lblCodigoTipoCadastro.Name = "lblCodigoTipoCadastro";
            this.lblCodigoTipoCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblCodigoTipoCadastro.TabIndex = 4;
            this.lblCodigoTipoCadastro.Text = "Tipo cadastro:";
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(20, 109);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(49, 13);
            this.lblCpfCnpj.TabIndex = 5;
            this.lblCpfCnpj.Text = "Cpf/Cnpj";
            // 
            // lblControle
            // 
            this.lblControle.AutoSize = true;
            this.lblControle.Location = new System.Drawing.Point(20, 135);
            this.lblControle.Name = "lblControle";
            this.lblControle.Size = new System.Drawing.Size(49, 13);
            this.lblControle.TabIndex = 6;
            this.lblControle.Text = "Controle:";
            // 
            // lblDatahAlteracao
            // 
            this.lblDatahAlteracao.AutoSize = true;
            this.lblDatahAlteracao.Location = new System.Drawing.Point(20, 161);
            this.lblDatahAlteracao.Name = "lblDatahAlteracao";
            this.lblDatahAlteracao.Size = new System.Drawing.Size(80, 13);
            this.lblDatahAlteracao.TabIndex = 7;
            this.lblDatahAlteracao.Text = "Data alteração:";
            // 
            // lblCodigoFuncionario
            // 
            this.lblCodigoFuncionario.AutoSize = true;
            this.lblCodigoFuncionario.Location = new System.Drawing.Point(20, 187);
            this.lblCodigoFuncionario.Name = "lblCodigoFuncionario";
            this.lblCodigoFuncionario.Size = new System.Drawing.Size(65, 13);
            this.lblCodigoFuncionario.TabIndex = 8;
            this.lblCodigoFuncionario.Text = "Funcionario:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(456, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(456, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(55, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(117, 106);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(112, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(117, 132);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(55, 20);
            this.textBox6.TabIndex = 13;
            // 
            // txtDatahAlteracao
            // 
            this.txtDatahAlteracao.Location = new System.Drawing.Point(117, 158);
            this.txtDatahAlteracao.Name = "txtDatahAlteracao";
            this.txtDatahAlteracao.Size = new System.Drawing.Size(112, 20);
            this.txtDatahAlteracao.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(117, 184);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(112, 20);
            this.textBox8.TabIndex = 15;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(75, 22);
            this.toolStripButton1.Text = "F12 - Fechar";
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
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 541);
            this.Controls.Add(this.tlsBotoes);
            this.Controls.Add(this.tbcDadosCadastro);
            this.Controls.Add(this.grpDadosChave);
            this.Name = "FrmCadastro";
            this.Text = "FrmCadastro";
            this.grpDadosChave.ResumeLayout(false);
            this.grpDadosChave.PerformLayout();
            this.tbcDadosCadastro.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            this.tlsBotoes.ResumeLayout(false);
            this.tlsBotoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosChave;
        private System.Windows.Forms.Label lblNumeroCadastro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tbcDadosCadastro;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.TabPage tabDefinicao;
        private System.Windows.Forms.ToolStrip tlsBotoes;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtDatahAlteracao;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCodigoFuncionario;
        private System.Windows.Forms.Label lblDatahAlteracao;
        private System.Windows.Forms.Label lblControle;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.Label lblCodigoTipoCadastro;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbLimpar;
        private System.Windows.Forms.ToolStripButton tsbGravar;
    }
}