
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
            this.lblNumeroCadastro = new System.Windows.Forms.Label();
            this.txtNumeroCadastro = new System.Windows.Forms.TextBox();
            this.tbcDadosCadastro = new System.Windows.Forms.TabControl();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.txtDatahAlteracao = new System.Windows.Forms.TextBox();
            this.txtControle = new System.Windows.Forms.TextBox();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.txtCodigoTipoCadastro = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtNomeCadastro = new System.Windows.Forms.TextBox();
            this.lblCodigoFuncionario = new System.Windows.Forms.Label();
            this.lblDatahAlteracao = new System.Windows.Forms.Label();
            this.lblControle = new System.Windows.Forms.Label();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblCodigoTipoCadastro = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.tabMedidas = new System.Windows.Forms.TabPage();
            this.btnInativar = new System.Windows.Forms.Button();
            this.btnAdicionarMedida = new System.Windows.Forms.Button();
            this.grpMedidas = new System.Windows.Forms.GroupBox();
            this.dgvMedidas = new System.Windows.Forms.DataGridView();
            this.txtOmbroAhOmbro = new System.Windows.Forms.TextBox();
            this.lblOmbroAhOmbro = new System.Windows.Forms.Label();
            this.txtCintura = new System.Windows.Forms.TextBox();
            this.lblCintura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtCodigoMedida = new System.Windows.Forms.TextBox();
            this.lblCodigoMedida = new System.Windows.Forms.Label();
            this.tabEndereco = new System.Windows.Forms.TabPage();
            this.grpEnderecos = new System.Windows.Forms.GroupBox();
            this.dgvEnderecos = new System.Windows.Forms.DataGridView();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtFilial = new System.Windows.Forms.TextBox();
            this.lblFilial = new System.Windows.Forms.Label();
            this.tabDefinicao = new System.Windows.Forms.TabPage();
            this.grpDefinicao = new System.Windows.Forms.GroupBox();
            this.dgvDefinicao = new System.Windows.Forms.DataGridView();
            this.txtCodigoDefinicao = new System.Windows.Forms.TextBox();
            this.lblCodigoDefinicao = new System.Windows.Forms.Label();
            this.tspBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.tsbGravar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInativarEndereco = new System.Windows.Forms.Button();
            this.blnAdicionarEndereco = new System.Windows.Forms.Button();
            this.cboTipoCadastro = new System.Windows.Forms.ComboBox();
            this.grpDadosChave.SuspendLayout();
            this.tbcDadosCadastro.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.tabMedidas.SuspendLayout();
            this.grpMedidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedidas)).BeginInit();
            this.tabEndereco.SuspendLayout();
            this.grpEnderecos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).BeginInit();
            this.tabDefinicao.SuspendLayout();
            this.grpDefinicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefinicao)).BeginInit();
            this.tspBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosChave
            // 
            this.grpDadosChave.Controls.Add(this.btnBuscar);
            this.grpDadosChave.Controls.Add(this.lblNumeroCadastro);
            this.grpDadosChave.Controls.Add(this.txtNumeroCadastro);
            this.grpDadosChave.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDadosChave.Location = new System.Drawing.Point(0, 0);
            this.grpDadosChave.Name = "grpDadosChave";
            this.grpDadosChave.Size = new System.Drawing.Size(989, 88);
            this.grpDadosChave.TabIndex = 0;
            this.grpDadosChave.TabStop = false;
            this.grpDadosChave.Text = "Dados Basicos";
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
            // txtNumeroCadastro
            // 
            this.txtNumeroCadastro.Location = new System.Drawing.Point(121, 35);
            this.txtNumeroCadastro.Name = "txtNumeroCadastro";
            this.txtNumeroCadastro.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCadastro.TabIndex = 0;
            this.txtNumeroCadastro.Leave += new System.EventHandler(this.txtNumeroCadastro_Leave);
            // 
            // tbcDadosCadastro
            // 
            this.tbcDadosCadastro.Controls.Add(this.tabCadastro);
            this.tbcDadosCadastro.Controls.Add(this.tabMedidas);
            this.tbcDadosCadastro.Controls.Add(this.tabEndereco);
            this.tbcDadosCadastro.Controls.Add(this.tabDefinicao);
            this.tbcDadosCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcDadosCadastro.Location = new System.Drawing.Point(0, 88);
            this.tbcDadosCadastro.Name = "tbcDadosCadastro";
            this.tbcDadosCadastro.SelectedIndex = 0;
            this.tbcDadosCadastro.Size = new System.Drawing.Size(989, 486);
            this.tbcDadosCadastro.TabIndex = 1;
            // 
            // tabCadastro
            // 
            this.tabCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.tabCadastro.Controls.Add(this.cboTipoCadastro);
            this.tabCadastro.Controls.Add(this.txtCodigoFuncionario);
            this.tabCadastro.Controls.Add(this.txtDatahAlteracao);
            this.tabCadastro.Controls.Add(this.txtControle);
            this.tabCadastro.Controls.Add(this.txtCpfCnpj);
            this.tabCadastro.Controls.Add(this.txtCodigoTipoCadastro);
            this.tabCadastro.Controls.Add(this.txtNomeFantasia);
            this.tabCadastro.Controls.Add(this.txtNomeCadastro);
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
            this.tabCadastro.Size = new System.Drawing.Size(981, 460);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "Dados Cadastro";
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Enabled = false;
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(117, 184);
            this.txtCodigoFuncionario.MaxLength = 20;
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(112, 20);
            this.txtCodigoFuncionario.TabIndex = 15;
            // 
            // txtDatahAlteracao
            // 
            this.txtDatahAlteracao.Enabled = false;
            this.txtDatahAlteracao.Location = new System.Drawing.Point(117, 158);
            this.txtDatahAlteracao.MaxLength = 50;
            this.txtDatahAlteracao.Name = "txtDatahAlteracao";
            this.txtDatahAlteracao.Size = new System.Drawing.Size(112, 20);
            this.txtDatahAlteracao.TabIndex = 14;
            // 
            // txtControle
            // 
            this.txtControle.Location = new System.Drawing.Point(117, 132);
            this.txtControle.MaxLength = 2;
            this.txtControle.Name = "txtControle";
            this.txtControle.Size = new System.Drawing.Size(55, 20);
            this.txtControle.TabIndex = 13;
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(117, 106);
            this.txtCpfCnpj.MaxLength = 11;
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(112, 20);
            this.txtCpfCnpj.TabIndex = 12;
            // 
            // txtCodigoTipoCadastro
            // 
            this.txtCodigoTipoCadastro.Location = new System.Drawing.Point(518, 80);
            this.txtCodigoTipoCadastro.MaxLength = 5;
            this.txtCodigoTipoCadastro.Name = "txtCodigoTipoCadastro";
            this.txtCodigoTipoCadastro.Size = new System.Drawing.Size(55, 20);
            this.txtCodigoTipoCadastro.TabIndex = 11;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(117, 54);
            this.txtNomeFantasia.MaxLength = 80;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(456, 20);
            this.txtNomeFantasia.TabIndex = 10;
            // 
            // txtNomeCadastro
            // 
            this.txtNomeCadastro.Location = new System.Drawing.Point(117, 28);
            this.txtNomeCadastro.MaxLength = 80;
            this.txtNomeCadastro.Name = "txtNomeCadastro";
            this.txtNomeCadastro.Size = new System.Drawing.Size(456, 20);
            this.txtNomeCadastro.TabIndex = 9;
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
            // lblDatahAlteracao
            // 
            this.lblDatahAlteracao.AutoSize = true;
            this.lblDatahAlteracao.Location = new System.Drawing.Point(20, 161);
            this.lblDatahAlteracao.Name = "lblDatahAlteracao";
            this.lblDatahAlteracao.Size = new System.Drawing.Size(80, 13);
            this.lblDatahAlteracao.TabIndex = 7;
            this.lblDatahAlteracao.Text = "Data alteração:";
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
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(20, 109);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(49, 13);
            this.lblCpfCnpj.TabIndex = 5;
            this.lblCpfCnpj.Text = "Cpf/Cnpj";
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
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(20, 57);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(78, 13);
            this.lblNomeFantasia.TabIndex = 3;
            this.lblNomeFantasia.Text = "Nome fantasia:";
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
            // tabMedidas
            // 
            this.tabMedidas.BackColor = System.Drawing.SystemColors.Control;
            this.tabMedidas.Controls.Add(this.btnInativar);
            this.tabMedidas.Controls.Add(this.btnAdicionarMedida);
            this.tabMedidas.Controls.Add(this.grpMedidas);
            this.tabMedidas.Controls.Add(this.txtOmbroAhOmbro);
            this.tabMedidas.Controls.Add(this.lblOmbroAhOmbro);
            this.tabMedidas.Controls.Add(this.txtCintura);
            this.tabMedidas.Controls.Add(this.lblCintura);
            this.tabMedidas.Controls.Add(this.txtAltura);
            this.tabMedidas.Controls.Add(this.lblAltura);
            this.tabMedidas.Controls.Add(this.txtCodigoMedida);
            this.tabMedidas.Controls.Add(this.lblCodigoMedida);
            this.tabMedidas.Location = new System.Drawing.Point(4, 22);
            this.tabMedidas.Name = "tabMedidas";
            this.tabMedidas.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedidas.Size = new System.Drawing.Size(981, 460);
            this.tabMedidas.TabIndex = 1;
            this.tabMedidas.Text = "Medidas";
            // 
            // btnInativar
            // 
            this.btnInativar.Location = new System.Drawing.Point(855, 92);
            this.btnInativar.Name = "btnInativar";
            this.btnInativar.Size = new System.Drawing.Size(115, 46);
            this.btnInativar.TabIndex = 22;
            this.btnInativar.Text = "Inativar";
            this.btnInativar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarMedida
            // 
            this.btnAdicionarMedida.Location = new System.Drawing.Point(724, 92);
            this.btnAdicionarMedida.Name = "btnAdicionarMedida";
            this.btnAdicionarMedida.Size = new System.Drawing.Size(115, 46);
            this.btnAdicionarMedida.TabIndex = 21;
            this.btnAdicionarMedida.Text = "Adicionar";
            this.btnAdicionarMedida.UseVisualStyleBackColor = true;
            // 
            // grpMedidas
            // 
            this.grpMedidas.Controls.Add(this.dgvMedidas);
            this.grpMedidas.Location = new System.Drawing.Point(8, 143);
            this.grpMedidas.Name = "grpMedidas";
            this.grpMedidas.Size = new System.Drawing.Size(965, 311);
            this.grpMedidas.TabIndex = 20;
            this.grpMedidas.TabStop = false;
            this.grpMedidas.Text = "Medidas";
            // 
            // dgvMedidas
            // 
            this.dgvMedidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedidas.Location = new System.Drawing.Point(3, 16);
            this.dgvMedidas.Name = "dgvMedidas";
            this.dgvMedidas.Size = new System.Drawing.Size(959, 292);
            this.dgvMedidas.TabIndex = 0;
            // 
            // txtOmbroAhOmbro
            // 
            this.txtOmbroAhOmbro.Location = new System.Drawing.Point(117, 106);
            this.txtOmbroAhOmbro.Name = "txtOmbroAhOmbro";
            this.txtOmbroAhOmbro.Size = new System.Drawing.Size(55, 20);
            this.txtOmbroAhOmbro.TabIndex = 19;
            // 
            // lblOmbroAhOmbro
            // 
            this.lblOmbroAhOmbro.AutoSize = true;
            this.lblOmbroAhOmbro.Location = new System.Drawing.Point(17, 109);
            this.lblOmbroAhOmbro.Name = "lblOmbroAhOmbro";
            this.lblOmbroAhOmbro.Size = new System.Drawing.Size(84, 13);
            this.lblOmbroAhOmbro.TabIndex = 18;
            this.lblOmbroAhOmbro.Text = "Ombro a Ombro:";
            // 
            // txtCintura
            // 
            this.txtCintura.Location = new System.Drawing.Point(117, 80);
            this.txtCintura.Name = "txtCintura";
            this.txtCintura.Size = new System.Drawing.Size(55, 20);
            this.txtCintura.TabIndex = 17;
            // 
            // lblCintura
            // 
            this.lblCintura.AutoSize = true;
            this.lblCintura.Location = new System.Drawing.Point(58, 83);
            this.lblCintura.Name = "lblCintura";
            this.lblCintura.Size = new System.Drawing.Size(43, 13);
            this.lblCintura.TabIndex = 16;
            this.lblCintura.Text = "Cintura:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(117, 54);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(55, 20);
            this.txtAltura.TabIndex = 15;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(64, 57);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 14;
            this.lblAltura.Text = "Altura:";
            // 
            // txtCodigoMedida
            // 
            this.txtCodigoMedida.Location = new System.Drawing.Point(117, 28);
            this.txtCodigoMedida.Name = "txtCodigoMedida";
            this.txtCodigoMedida.Size = new System.Drawing.Size(55, 20);
            this.txtCodigoMedida.TabIndex = 13;
            // 
            // lblCodigoMedida
            // 
            this.lblCodigoMedida.AutoSize = true;
            this.lblCodigoMedida.Location = new System.Drawing.Point(20, 31);
            this.lblCodigoMedida.Name = "lblCodigoMedida";
            this.lblCodigoMedida.Size = new System.Drawing.Size(81, 13);
            this.lblCodigoMedida.TabIndex = 12;
            this.lblCodigoMedida.Text = "Código Medida:";
            // 
            // tabEndereco
            // 
            this.tabEndereco.BackColor = System.Drawing.SystemColors.Control;
            this.tabEndereco.Controls.Add(this.btnInativarEndereco);
            this.tabEndereco.Controls.Add(this.blnAdicionarEndereco);
            this.tabEndereco.Controls.Add(this.grpEnderecos);
            this.tabEndereco.Controls.Add(this.txtComplemento);
            this.tabEndereco.Controls.Add(this.lblComplemento);
            this.tabEndereco.Controls.Add(this.txtNumero);
            this.tabEndereco.Controls.Add(this.lblNumero);
            this.tabEndereco.Controls.Add(this.txtBairro);
            this.tabEndereco.Controls.Add(this.lblBairro);
            this.tabEndereco.Controls.Add(this.txtEndereco);
            this.tabEndereco.Controls.Add(this.lblEndereco);
            this.tabEndereco.Controls.Add(this.txtFilial);
            this.tabEndereco.Controls.Add(this.lblFilial);
            this.tabEndereco.Location = new System.Drawing.Point(4, 22);
            this.tabEndereco.Name = "tabEndereco";
            this.tabEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.tabEndereco.Size = new System.Drawing.Size(981, 460);
            this.tabEndereco.TabIndex = 2;
            this.tabEndereco.Text = "Endereço";
            // 
            // grpEnderecos
            // 
            this.grpEnderecos.Controls.Add(this.dgvEnderecos);
            this.grpEnderecos.Location = new System.Drawing.Point(8, 145);
            this.grpEnderecos.Name = "grpEnderecos";
            this.grpEnderecos.Size = new System.Drawing.Size(970, 309);
            this.grpEnderecos.TabIndex = 24;
            this.grpEnderecos.TabStop = false;
            this.grpEnderecos.Text = "Enderecos";
            // 
            // dgvEnderecos
            // 
            this.dgvEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnderecos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnderecos.Location = new System.Drawing.Point(3, 16);
            this.dgvEnderecos.Name = "dgvEnderecos";
            this.dgvEnderecos.Size = new System.Drawing.Size(964, 290);
            this.dgvEnderecos.TabIndex = 0;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(107, 119);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(287, 20);
            this.txtComplemento.TabIndex = 23;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(20, 122);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 22;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(107, 93);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(60, 20);
            this.txtNumero.TabIndex = 21;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(20, 96);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 20;
            this.lblNumero.Text = "Número:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(107, 67);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(146, 20);
            this.txtBairro.TabIndex = 19;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(20, 70);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 18;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(107, 41);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(287, 20);
            this.txtEndereco.TabIndex = 17;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(20, 44);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 16;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtFilial
            // 
            this.txtFilial.Location = new System.Drawing.Point(107, 15);
            this.txtFilial.Name = "txtFilial";
            this.txtFilial.Size = new System.Drawing.Size(60, 20);
            this.txtFilial.TabIndex = 15;
            // 
            // lblFilial
            // 
            this.lblFilial.AutoSize = true;
            this.lblFilial.Location = new System.Drawing.Point(20, 18);
            this.lblFilial.Name = "lblFilial";
            this.lblFilial.Size = new System.Drawing.Size(30, 13);
            this.lblFilial.TabIndex = 14;
            this.lblFilial.Text = "Filial:";
            // 
            // tabDefinicao
            // 
            this.tabDefinicao.BackColor = System.Drawing.SystemColors.Control;
            this.tabDefinicao.Controls.Add(this.grpDefinicao);
            this.tabDefinicao.Controls.Add(this.txtCodigoDefinicao);
            this.tabDefinicao.Controls.Add(this.lblCodigoDefinicao);
            this.tabDefinicao.Location = new System.Drawing.Point(4, 22);
            this.tabDefinicao.Name = "tabDefinicao";
            this.tabDefinicao.Padding = new System.Windows.Forms.Padding(3);
            this.tabDefinicao.Size = new System.Drawing.Size(981, 460);
            this.tabDefinicao.TabIndex = 3;
            this.tabDefinicao.Text = "Definição";
            // 
            // grpDefinicao
            // 
            this.grpDefinicao.Controls.Add(this.dgvDefinicao);
            this.grpDefinicao.Location = new System.Drawing.Point(5, 76);
            this.grpDefinicao.Name = "grpDefinicao";
            this.grpDefinicao.Size = new System.Drawing.Size(970, 378);
            this.grpDefinicao.TabIndex = 25;
            this.grpDefinicao.TabStop = false;
            this.grpDefinicao.Text = "Definições";
            // 
            // dgvDefinicao
            // 
            this.dgvDefinicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDefinicao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDefinicao.Location = new System.Drawing.Point(3, 16);
            this.dgvDefinicao.Name = "dgvDefinicao";
            this.dgvDefinicao.Size = new System.Drawing.Size(964, 359);
            this.dgvDefinicao.TabIndex = 0;
            // 
            // txtCodigoDefinicao
            // 
            this.txtCodigoDefinicao.Location = new System.Drawing.Point(117, 16);
            this.txtCodigoDefinicao.Name = "txtCodigoDefinicao";
            this.txtCodigoDefinicao.Size = new System.Drawing.Size(55, 20);
            this.txtCodigoDefinicao.TabIndex = 13;
            // 
            // lblCodigoDefinicao
            // 
            this.lblCodigoDefinicao.AutoSize = true;
            this.lblCodigoDefinicao.Location = new System.Drawing.Point(20, 19);
            this.lblCodigoDefinicao.Name = "lblCodigoDefinicao";
            this.lblCodigoDefinicao.Size = new System.Drawing.Size(89, 13);
            this.lblCodigoDefinicao.TabIndex = 12;
            this.lblCodigoDefinicao.Text = "Código definição:";
            // 
            // tspBotoes
            // 
            this.tspBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFechar,
            this.tsbLimpar,
            this.tsbGravar});
            this.tspBotoes.Location = new System.Drawing.Point(0, 580);
            this.tspBotoes.Name = "tspBotoes";
            this.tspBotoes.Size = new System.Drawing.Size(989, 25);
            this.tspBotoes.TabIndex = 2;
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
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(293, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 46);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnInativarEndereco
            // 
            this.btnInativarEndereco.Location = new System.Drawing.Point(858, 96);
            this.btnInativarEndereco.Name = "btnInativarEndereco";
            this.btnInativarEndereco.Size = new System.Drawing.Size(115, 46);
            this.btnInativarEndereco.TabIndex = 26;
            this.btnInativarEndereco.Text = "Inativar";
            this.btnInativarEndereco.UseVisualStyleBackColor = true;
            // 
            // blnAdicionarEndereco
            // 
            this.blnAdicionarEndereco.Location = new System.Drawing.Point(727, 96);
            this.blnAdicionarEndereco.Name = "blnAdicionarEndereco";
            this.blnAdicionarEndereco.Size = new System.Drawing.Size(115, 46);
            this.blnAdicionarEndereco.TabIndex = 25;
            this.blnAdicionarEndereco.Text = "Adicionar";
            this.blnAdicionarEndereco.UseVisualStyleBackColor = true;
            this.blnAdicionarEndereco.Click += new System.EventHandler(this.blnAdicionarEndereco_Click);
            // 
            // cboTipoCadastro
            // 
            this.cboTipoCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCadastro.FormattingEnabled = true;
            this.cboTipoCadastro.Location = new System.Drawing.Point(117, 80);
            this.cboTipoCadastro.Name = "cboTipoCadastro";
            this.cboTipoCadastro.Size = new System.Drawing.Size(195, 21);
            this.cboTipoCadastro.TabIndex = 16;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 605);
            this.Controls.Add(this.tspBotoes);
            this.Controls.Add(this.tbcDadosCadastro);
            this.Controls.Add(this.grpDadosChave);
            this.Name = "FrmCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.grpDadosChave.ResumeLayout(false);
            this.grpDadosChave.PerformLayout();
            this.tbcDadosCadastro.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            this.tabMedidas.ResumeLayout(false);
            this.tabMedidas.PerformLayout();
            this.grpMedidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedidas)).EndInit();
            this.tabEndereco.ResumeLayout(false);
            this.tabEndereco.PerformLayout();
            this.grpEnderecos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).EndInit();
            this.tabDefinicao.ResumeLayout(false);
            this.tabDefinicao.PerformLayout();
            this.grpDefinicao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefinicao)).EndInit();
            this.tspBotoes.ResumeLayout(false);
            this.tspBotoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosChave;
        private System.Windows.Forms.Label lblNumeroCadastro;
        private System.Windows.Forms.TextBox txtNumeroCadastro;
        private System.Windows.Forms.TabControl tbcDadosCadastro;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.TabPage tabMedidas;
        private System.Windows.Forms.ToolStrip tspBotoes;
        private System.Windows.Forms.TextBox txtCodigoFuncionario;
        private System.Windows.Forms.TextBox txtDatahAlteracao;
        private System.Windows.Forms.TextBox txtControle;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.TextBox txtCodigoTipoCadastro;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.TextBox txtNomeCadastro;
        private System.Windows.Forms.Label lblCodigoFuncionario;
        private System.Windows.Forms.Label lblDatahAlteracao;
        private System.Windows.Forms.Label lblControle;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.Label lblCodigoTipoCadastro;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.ToolStripButton tsbLimpar;
        private System.Windows.Forms.ToolStripButton tsbGravar;
        private System.Windows.Forms.TabPage tabEndereco;
        private System.Windows.Forms.TabPage tabDefinicao;
        private System.Windows.Forms.GroupBox grpMedidas;
        private System.Windows.Forms.TextBox txtOmbroAhOmbro;
        private System.Windows.Forms.Label lblOmbroAhOmbro;
        private System.Windows.Forms.TextBox txtCintura;
        private System.Windows.Forms.Label lblCintura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtCodigoMedida;
        private System.Windows.Forms.Label lblCodigoMedida;
        private System.Windows.Forms.DataGridView dgvMedidas;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtFilial;
        private System.Windows.Forms.Label lblFilial;
        private System.Windows.Forms.Button btnAdicionarMedida;
        private System.Windows.Forms.Button btnInativar;
        private System.Windows.Forms.GroupBox grpEnderecos;
        private System.Windows.Forms.DataGridView dgvEnderecos;
        private System.Windows.Forms.GroupBox grpDefinicao;
        private System.Windows.Forms.DataGridView dgvDefinicao;
        private System.Windows.Forms.TextBox txtCodigoDefinicao;
        private System.Windows.Forms.Label lblCodigoDefinicao;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInativarEndereco;
        private System.Windows.Forms.Button blnAdicionarEndereco;
        private System.Windows.Forms.ComboBox cboTipoCadastro;
    }
}