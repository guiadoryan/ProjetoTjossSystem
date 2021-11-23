
namespace TjossSystem
{
    partial class FrmContratos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContratos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tspBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.tsbGravar = new System.Windows.Forms.ToolStripButton();
            this.grpDadosChaveCargo = new System.Windows.Forms.GroupBox();
            this.btnCancelarContrato = new System.Windows.Forms.Button();
            this.btnFecharContrato = new System.Windows.Forms.Button();
            this.blnNovoContrato = new System.Windows.Forms.Button();
            this.cboCodigoTipoContrato = new System.Windows.Forms.ComboBox();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.txtNumeroContrato = new System.Windows.Forms.TextBox();
            this.lblNumeroContrato = new System.Windows.Forms.Label();
            this.btnCriarPrePedido = new System.Windows.Forms.Button();
            this.btnFiltrarContratos = new System.Windows.Forms.Button();
            this.txtCodigoCadastro = new System.Windows.Forms.TextBox();
            this.lblCodigoCadastro = new System.Windows.Forms.Label();
            this.grpDadosBasicos = new System.Windows.Forms.GroupBox();
            this.dgvContratos = new System.Windows.Forms.DataGridView();
            this.clnNumeroContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoTipoContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSituacaoContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDatahAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspBotoes.SuspendLayout();
            this.grpDadosChaveCargo.SuspendLayout();
            this.grpDadosBasicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // tspBotoes
            // 
            this.tspBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFechar,
            this.tsbLimpar,
            this.tsbGravar});
            this.tspBotoes.Location = new System.Drawing.Point(0, 542);
            this.tspBotoes.Name = "tspBotoes";
            this.tspBotoes.Size = new System.Drawing.Size(973, 25);
            this.tspBotoes.TabIndex = 4;
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
            // 
            // grpDadosChaveCargo
            // 
            this.grpDadosChaveCargo.Controls.Add(this.btnCancelarContrato);
            this.grpDadosChaveCargo.Controls.Add(this.btnFecharContrato);
            this.grpDadosChaveCargo.Controls.Add(this.blnNovoContrato);
            this.grpDadosChaveCargo.Controls.Add(this.cboCodigoTipoContrato);
            this.grpDadosChaveCargo.Controls.Add(this.lblTipoContrato);
            this.grpDadosChaveCargo.Controls.Add(this.txtNumeroContrato);
            this.grpDadosChaveCargo.Controls.Add(this.lblNumeroContrato);
            this.grpDadosChaveCargo.Controls.Add(this.btnCriarPrePedido);
            this.grpDadosChaveCargo.Controls.Add(this.btnFiltrarContratos);
            this.grpDadosChaveCargo.Controls.Add(this.txtCodigoCadastro);
            this.grpDadosChaveCargo.Controls.Add(this.lblCodigoCadastro);
            this.grpDadosChaveCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDadosChaveCargo.Location = new System.Drawing.Point(0, 0);
            this.grpDadosChaveCargo.Name = "grpDadosChaveCargo";
            this.grpDadosChaveCargo.Size = new System.Drawing.Size(973, 84);
            this.grpDadosChaveCargo.TabIndex = 15;
            this.grpDadosChaveCargo.TabStop = false;
            // 
            // btnCancelarContrato
            // 
            this.btnCancelarContrato.Location = new System.Drawing.Point(728, 12);
            this.btnCancelarContrato.Name = "btnCancelarContrato";
            this.btnCancelarContrato.Size = new System.Drawing.Size(112, 29);
            this.btnCancelarContrato.TabIndex = 14;
            this.btnCancelarContrato.Text = "Cancelar Contrato";
            this.btnCancelarContrato.UseVisualStyleBackColor = true;
            this.btnCancelarContrato.Click += new System.EventHandler(this.btnCancelarContrato_Click);
            // 
            // btnFecharContrato
            // 
            this.btnFecharContrato.Location = new System.Drawing.Point(846, 12);
            this.btnFecharContrato.Name = "btnFecharContrato";
            this.btnFecharContrato.Size = new System.Drawing.Size(112, 29);
            this.btnFecharContrato.TabIndex = 13;
            this.btnFecharContrato.Text = "Fechar Contrato";
            this.btnFecharContrato.UseVisualStyleBackColor = true;
            this.btnFecharContrato.Click += new System.EventHandler(this.btnFecharContrato_Click);
            // 
            // blnNovoContrato
            // 
            this.blnNovoContrato.Location = new System.Drawing.Point(846, 47);
            this.blnNovoContrato.Name = "blnNovoContrato";
            this.blnNovoContrato.Size = new System.Drawing.Size(112, 29);
            this.blnNovoContrato.TabIndex = 12;
            this.blnNovoContrato.Text = "Novo Contrato";
            this.blnNovoContrato.UseVisualStyleBackColor = true;
            this.blnNovoContrato.Click += new System.EventHandler(this.blnNovoContrato_Click);
            // 
            // cboCodigoTipoContrato
            // 
            this.cboCodigoTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoTipoContrato.FormattingEnabled = true;
            this.cboCodigoTipoContrato.Location = new System.Drawing.Point(330, 12);
            this.cboCodigoTipoContrato.Name = "cboCodigoTipoContrato";
            this.cboCodigoTipoContrato.Size = new System.Drawing.Size(104, 21);
            this.cboCodigoTipoContrato.TabIndex = 9;
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Location = new System.Drawing.Point(223, 15);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(74, 13);
            this.lblTipoContrato.TabIndex = 8;
            this.lblTipoContrato.Text = "Tipo Contrato:";
            // 
            // txtNumeroContrato
            // 
            this.txtNumeroContrato.Location = new System.Drawing.Point(119, 12);
            this.txtNumeroContrato.MaxLength = 15;
            this.txtNumeroContrato.Name = "txtNumeroContrato";
            this.txtNumeroContrato.Size = new System.Drawing.Size(104, 20);
            this.txtNumeroContrato.TabIndex = 7;
            // 
            // lblNumeroContrato
            // 
            this.lblNumeroContrato.AutoSize = true;
            this.lblNumeroContrato.Location = new System.Drawing.Point(12, 15);
            this.lblNumeroContrato.Name = "lblNumeroContrato";
            this.lblNumeroContrato.Size = new System.Drawing.Size(90, 13);
            this.lblNumeroContrato.TabIndex = 6;
            this.lblNumeroContrato.Text = "Número Contrato:";
            // 
            // btnCriarPrePedido
            // 
            this.btnCriarPrePedido.Enabled = false;
            this.btnCriarPrePedido.Location = new System.Drawing.Point(322, 39);
            this.btnCriarPrePedido.Name = "btnCriarPrePedido";
            this.btnCriarPrePedido.Size = new System.Drawing.Size(112, 29);
            this.btnCriarPrePedido.TabIndex = 3;
            this.btnCriarPrePedido.Text = "Criar Pré-Pedido";
            this.btnCriarPrePedido.UseVisualStyleBackColor = true;
            this.btnCriarPrePedido.Visible = false;
            // 
            // btnFiltrarContratos
            // 
            this.btnFiltrarContratos.Location = new System.Drawing.Point(728, 47);
            this.btnFiltrarContratos.Name = "btnFiltrarContratos";
            this.btnFiltrarContratos.Size = new System.Drawing.Size(112, 29);
            this.btnFiltrarContratos.TabIndex = 2;
            this.btnFiltrarContratos.Text = "Filtrar";
            this.btnFiltrarContratos.UseVisualStyleBackColor = true;
            this.btnFiltrarContratos.Click += new System.EventHandler(this.btnFiltrarContratos_Click);
            // 
            // txtCodigoCadastro
            // 
            this.txtCodigoCadastro.Location = new System.Drawing.Point(119, 38);
            this.txtCodigoCadastro.MaxLength = 15;
            this.txtCodigoCadastro.Name = "txtCodigoCadastro";
            this.txtCodigoCadastro.Size = new System.Drawing.Size(104, 20);
            this.txtCodigoCadastro.TabIndex = 1;
            // 
            // lblCodigoCadastro
            // 
            this.lblCodigoCadastro.AutoSize = true;
            this.lblCodigoCadastro.Location = new System.Drawing.Point(12, 41);
            this.lblCodigoCadastro.Name = "lblCodigoCadastro";
            this.lblCodigoCadastro.Size = new System.Drawing.Size(88, 13);
            this.lblCodigoCadastro.TabIndex = 0;
            this.lblCodigoCadastro.Text = "Código Cadastro:";
            // 
            // grpDadosBasicos
            // 
            this.grpDadosBasicos.Controls.Add(this.dgvContratos);
            this.grpDadosBasicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDadosBasicos.Location = new System.Drawing.Point(0, 84);
            this.grpDadosBasicos.Name = "grpDadosBasicos";
            this.grpDadosBasicos.Size = new System.Drawing.Size(973, 458);
            this.grpDadosBasicos.TabIndex = 16;
            this.grpDadosBasicos.TabStop = false;
            // 
            // dgvContratos
            // 
            this.dgvContratos.AllowUserToAddRows = false;
            this.dgvContratos.AllowUserToDeleteRows = false;
            this.dgvContratos.AllowUserToResizeRows = false;
            this.dgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContratos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNumeroContrato,
            this.clnCodigoTipoContrato,
            this.clnCodigoCadastro,
            this.clnDataContrato,
            this.clnDataVencimento,
            this.clnSituacaoContrato,
            this.clnCodigoVendedor,
            this.clnDatahAlteracao,
            this.clnCodigoFuncionario});
            this.dgvContratos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContratos.Location = new System.Drawing.Point(3, 16);
            this.dgvContratos.MultiSelect = false;
            this.dgvContratos.Name = "dgvContratos";
            this.dgvContratos.RowHeadersVisible = false;
            this.dgvContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContratos.Size = new System.Drawing.Size(967, 439);
            this.dgvContratos.TabIndex = 0;
            this.dgvContratos.DoubleClick += new System.EventHandler(this.dgvContratos_DoubleClick);
            // 
            // clnNumeroContrato
            // 
            this.clnNumeroContrato.DataPropertyName = "NumeroContrato";
            this.clnNumeroContrato.HeaderText = "Número Contrato";
            this.clnNumeroContrato.Name = "clnNumeroContrato";
            this.clnNumeroContrato.ReadOnly = true;
            // 
            // clnCodigoTipoContrato
            // 
            this.clnCodigoTipoContrato.DataPropertyName = "CodigoTipoContrato";
            this.clnCodigoTipoContrato.HeaderText = "Tipo Contrato";
            this.clnCodigoTipoContrato.Name = "clnCodigoTipoContrato";
            this.clnCodigoTipoContrato.ReadOnly = true;
            // 
            // clnCodigoCadastro
            // 
            this.clnCodigoCadastro.DataPropertyName = "CodigoCadastro";
            this.clnCodigoCadastro.HeaderText = "Código Cadastro";
            this.clnCodigoCadastro.Name = "clnCodigoCadastro";
            this.clnCodigoCadastro.ReadOnly = true;
            // 
            // clnDataContrato
            // 
            this.clnDataContrato.DataPropertyName = "DataContrato";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.clnDataContrato.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnDataContrato.HeaderText = "Data do Contrato";
            this.clnDataContrato.Name = "clnDataContrato";
            this.clnDataContrato.ReadOnly = true;
            // 
            // clnDataVencimento
            // 
            this.clnDataVencimento.DataPropertyName = "DataVencimento";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.clnDataVencimento.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnDataVencimento.HeaderText = "Data de Vencimento";
            this.clnDataVencimento.Name = "clnDataVencimento";
            this.clnDataVencimento.ReadOnly = true;
            // 
            // clnSituacaoContrato
            // 
            this.clnSituacaoContrato.DataPropertyName = "SituacaoContrato";
            this.clnSituacaoContrato.HeaderText = "Situação";
            this.clnSituacaoContrato.Name = "clnSituacaoContrato";
            this.clnSituacaoContrato.ReadOnly = true;
            // 
            // clnCodigoVendedor
            // 
            this.clnCodigoVendedor.DataPropertyName = "CodigoVendedor";
            this.clnCodigoVendedor.HeaderText = "Código Vendedor";
            this.clnCodigoVendedor.Name = "clnCodigoVendedor";
            this.clnCodigoVendedor.ReadOnly = true;
            this.clnCodigoVendedor.Visible = false;
            // 
            // clnDatahAlteracao
            // 
            this.clnDatahAlteracao.DataPropertyName = "DatahAlteracao";
            this.clnDatahAlteracao.HeaderText = "Data de Alteração";
            this.clnDatahAlteracao.Name = "clnDatahAlteracao";
            this.clnDatahAlteracao.ReadOnly = true;
            this.clnDatahAlteracao.Visible = false;
            // 
            // clnCodigoFuncionario
            // 
            this.clnCodigoFuncionario.DataPropertyName = "CodigoFuncionario";
            this.clnCodigoFuncionario.HeaderText = "Código Funcionario";
            this.clnCodigoFuncionario.Name = "clnCodigoFuncionario";
            this.clnCodigoFuncionario.ReadOnly = true;
            this.clnCodigoFuncionario.Visible = false;
            // 
            // FrmContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 567);
            this.Controls.Add(this.grpDadosBasicos);
            this.Controls.Add(this.grpDadosChaveCargo);
            this.Controls.Add(this.tspBotoes);
            this.Name = "FrmContratos";
            this.Text = "Contratos";
            this.Load += new System.EventHandler(this.FrmContratos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmContratos_KeyDown);
            this.tspBotoes.ResumeLayout(false);
            this.tspBotoes.PerformLayout();
            this.grpDadosChaveCargo.ResumeLayout(false);
            this.grpDadosChaveCargo.PerformLayout();
            this.grpDadosBasicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspBotoes;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.ToolStripButton tsbLimpar;
        private System.Windows.Forms.ToolStripButton tsbGravar;
        private System.Windows.Forms.GroupBox grpDadosChaveCargo;
        private System.Windows.Forms.Button btnCancelarContrato;
        private System.Windows.Forms.Button btnFecharContrato;
        private System.Windows.Forms.Button blnNovoContrato;
        private System.Windows.Forms.ComboBox cboCodigoTipoContrato;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.TextBox txtNumeroContrato;
        private System.Windows.Forms.Label lblNumeroContrato;
        private System.Windows.Forms.Button btnCriarPrePedido;
        private System.Windows.Forms.Button btnFiltrarContratos;
        private System.Windows.Forms.TextBox txtCodigoCadastro;
        private System.Windows.Forms.Label lblCodigoCadastro;
        private System.Windows.Forms.GroupBox grpDadosBasicos;
        private System.Windows.Forms.DataGridView dgvContratos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoTipoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSituacaoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDatahAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoFuncionario;
    }
}