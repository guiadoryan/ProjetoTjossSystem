
namespace TjossSystem
{
    partial class FrmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
            this.tspBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.tsbGravar = new System.Windows.Forms.ToolStripButton();
            this.grpDadosChaveCargo = new System.Windows.Forms.GroupBox();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.btnFecharPedido = new System.Windows.Forms.Button();
            this.blnNovoPedido = new System.Windows.Forms.Button();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.cboCodigoTipoContrato = new System.Windows.Forms.ComboBox();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.txtNumeroContrato = new System.Windows.Forms.TextBox();
            this.lblNumeroContrato = new System.Windows.Forms.Label();
            this.lblTipoPedido = new System.Windows.Forms.Label();
            this.cboCodigoTipoPedido = new System.Windows.Forms.ComboBox();
            this.btnCriarPrePedido = new System.Windows.Forms.Button();
            this.btnFiltrarPedidos = new System.Windows.Forms.Button();
            this.txtCodigoCadastro = new System.Windows.Forms.TextBox();
            this.lblCodigoCadastro = new System.Windows.Forms.Label();
            this.grpDadosBasicos = new System.Windows.Forms.GroupBox();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.clnNumeroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoTipoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSituacaoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataConclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumeroContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoTipoContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValorTotalPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspBotoes.SuspendLayout();
            this.grpDadosChaveCargo.SuspendLayout();
            this.grpDadosBasicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tspBotoes
            // 
            this.tspBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFechar,
            this.tsbLimpar,
            this.tsbGravar});
            this.tspBotoes.Location = new System.Drawing.Point(0, 541);
            this.tspBotoes.Name = "tspBotoes";
            this.tspBotoes.Size = new System.Drawing.Size(964, 25);
            this.tspBotoes.TabIndex = 3;
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
            this.grpDadosChaveCargo.Controls.Add(this.btnCancelarPedido);
            this.grpDadosChaveCargo.Controls.Add(this.btnFecharPedido);
            this.grpDadosChaveCargo.Controls.Add(this.blnNovoPedido);
            this.grpDadosChaveCargo.Controls.Add(this.txtNumeroPedido);
            this.grpDadosChaveCargo.Controls.Add(this.lblNumeroPedido);
            this.grpDadosChaveCargo.Controls.Add(this.cboCodigoTipoContrato);
            this.grpDadosChaveCargo.Controls.Add(this.lblTipoContrato);
            this.grpDadosChaveCargo.Controls.Add(this.txtNumeroContrato);
            this.grpDadosChaveCargo.Controls.Add(this.lblNumeroContrato);
            this.grpDadosChaveCargo.Controls.Add(this.lblTipoPedido);
            this.grpDadosChaveCargo.Controls.Add(this.cboCodigoTipoPedido);
            this.grpDadosChaveCargo.Controls.Add(this.btnCriarPrePedido);
            this.grpDadosChaveCargo.Controls.Add(this.btnFiltrarPedidos);
            this.grpDadosChaveCargo.Controls.Add(this.txtCodigoCadastro);
            this.grpDadosChaveCargo.Controls.Add(this.lblCodigoCadastro);
            this.grpDadosChaveCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDadosChaveCargo.Location = new System.Drawing.Point(0, 0);
            this.grpDadosChaveCargo.Name = "grpDadosChaveCargo";
            this.grpDadosChaveCargo.Size = new System.Drawing.Size(964, 90);
            this.grpDadosChaveCargo.TabIndex = 14;
            this.grpDadosChaveCargo.TabStop = false;
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Location = new System.Drawing.Point(728, 12);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(112, 29);
            this.btnCancelarPedido.TabIndex = 14;
            this.btnCancelarPedido.Text = "Cancelar Pedido";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // btnFecharPedido
            // 
            this.btnFecharPedido.Location = new System.Drawing.Point(846, 12);
            this.btnFecharPedido.Name = "btnFecharPedido";
            this.btnFecharPedido.Size = new System.Drawing.Size(112, 29);
            this.btnFecharPedido.TabIndex = 13;
            this.btnFecharPedido.Text = "Fechar Pedido";
            this.btnFecharPedido.UseVisualStyleBackColor = true;
            this.btnFecharPedido.Click += new System.EventHandler(this.btnFecharPedido_Click);
            // 
            // blnNovoPedido
            // 
            this.blnNovoPedido.Location = new System.Drawing.Point(846, 47);
            this.blnNovoPedido.Name = "blnNovoPedido";
            this.blnNovoPedido.Size = new System.Drawing.Size(112, 29);
            this.blnNovoPedido.TabIndex = 12;
            this.blnNovoPedido.Text = "Novo Pedido";
            this.blnNovoPedido.UseVisualStyleBackColor = true;
            this.blnNovoPedido.Click += new System.EventHandler(this.blnNovoPedido_Click);
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Location = new System.Drawing.Point(119, 12);
            this.txtNumeroPedido.MaxLength = 15;
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(104, 20);
            this.txtNumeroPedido.TabIndex = 11;
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.Location = new System.Drawing.Point(12, 15);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(83, 13);
            this.lblNumeroPedido.TabIndex = 10;
            this.lblNumeroPedido.Text = "Número Pedido:";
            // 
            // cboCodigoTipoContrato
            // 
            this.cboCodigoTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoTipoContrato.FormattingEnabled = true;
            this.cboCodigoTipoContrato.Location = new System.Drawing.Point(557, 41);
            this.cboCodigoTipoContrato.Name = "cboCodigoTipoContrato";
            this.cboCodigoTipoContrato.Size = new System.Drawing.Size(104, 21);
            this.cboCodigoTipoContrato.TabIndex = 9;
            this.cboCodigoTipoContrato.Visible = false;
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Location = new System.Drawing.Point(450, 44);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(74, 13);
            this.lblTipoContrato.TabIndex = 8;
            this.lblTipoContrato.Text = "Tipo Contrato:";
            this.lblTipoContrato.Visible = false;
            // 
            // txtNumeroContrato
            // 
            this.txtNumeroContrato.Location = new System.Drawing.Point(557, 12);
            this.txtNumeroContrato.MaxLength = 15;
            this.txtNumeroContrato.Name = "txtNumeroContrato";
            this.txtNumeroContrato.Size = new System.Drawing.Size(104, 20);
            this.txtNumeroContrato.TabIndex = 7;
            this.txtNumeroContrato.Visible = false;
            // 
            // lblNumeroContrato
            // 
            this.lblNumeroContrato.AutoSize = true;
            this.lblNumeroContrato.Location = new System.Drawing.Point(450, 15);
            this.lblNumeroContrato.Name = "lblNumeroContrato";
            this.lblNumeroContrato.Size = new System.Drawing.Size(90, 13);
            this.lblNumeroContrato.TabIndex = 6;
            this.lblNumeroContrato.Text = "Número Contrato:";
            this.lblNumeroContrato.Visible = false;
            // 
            // lblTipoPedido
            // 
            this.lblTipoPedido.AutoSize = true;
            this.lblTipoPedido.Location = new System.Drawing.Point(257, 16);
            this.lblTipoPedido.Name = "lblTipoPedido";
            this.lblTipoPedido.Size = new System.Drawing.Size(67, 13);
            this.lblTipoPedido.TabIndex = 5;
            this.lblTipoPedido.Text = "Tipo Pedido:";
            // 
            // cboCodigoTipoPedido
            // 
            this.cboCodigoTipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoTipoPedido.FormattingEnabled = true;
            this.cboCodigoTipoPedido.Location = new System.Drawing.Point(330, 12);
            this.cboCodigoTipoPedido.Name = "cboCodigoTipoPedido";
            this.cboCodigoTipoPedido.Size = new System.Drawing.Size(104, 21);
            this.cboCodigoTipoPedido.TabIndex = 4;
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
            this.btnCriarPrePedido.Click += new System.EventHandler(this.btnCriarPrePedido_Click);
            // 
            // btnFiltrarPedidos
            // 
            this.btnFiltrarPedidos.Location = new System.Drawing.Point(728, 47);
            this.btnFiltrarPedidos.Name = "btnFiltrarPedidos";
            this.btnFiltrarPedidos.Size = new System.Drawing.Size(112, 29);
            this.btnFiltrarPedidos.TabIndex = 2;
            this.btnFiltrarPedidos.Text = "Filtrar";
            this.btnFiltrarPedidos.UseVisualStyleBackColor = true;
            this.btnFiltrarPedidos.Click += new System.EventHandler(this.btnFiltrarPedidos_Click);
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
            this.grpDadosBasicos.Controls.Add(this.dgvPedidos);
            this.grpDadosBasicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDadosBasicos.Location = new System.Drawing.Point(0, 90);
            this.grpDadosBasicos.Name = "grpDadosBasicos";
            this.grpDadosBasicos.Size = new System.Drawing.Size(964, 451);
            this.grpDadosBasicos.TabIndex = 15;
            this.grpDadosBasicos.TabStop = false;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToResizeRows = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNumeroPedido,
            this.clnCodigoTipoPedido,
            this.clnCodigoCadastro,
            this.clnSituacaoPedido,
            this.clnDataConclusao,
            this.clnNumeroContrato,
            this.clnCodigoTipoContrato,
            this.clnValorTotalPedido});
            this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidos.Location = new System.Drawing.Point(3, 16);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(958, 432);
            this.dgvPedidos.TabIndex = 0;
            this.dgvPedidos.DoubleClick += new System.EventHandler(this.dgvPedidos_DoubleClick);
            // 
            // clnNumeroPedido
            // 
            this.clnNumeroPedido.DataPropertyName = "NumeroPedido";
            this.clnNumeroPedido.HeaderText = "Número Pedido";
            this.clnNumeroPedido.Name = "clnNumeroPedido";
            this.clnNumeroPedido.ReadOnly = true;
            // 
            // clnCodigoTipoPedido
            // 
            this.clnCodigoTipoPedido.DataPropertyName = "CodigoTipoPedido";
            this.clnCodigoTipoPedido.HeaderText = "Tipo Pedido";
            this.clnCodigoTipoPedido.Name = "clnCodigoTipoPedido";
            this.clnCodigoTipoPedido.ReadOnly = true;
            // 
            // clnCodigoCadastro
            // 
            this.clnCodigoCadastro.DataPropertyName = "CodigoCadastro";
            this.clnCodigoCadastro.HeaderText = "Código Cadastro";
            this.clnCodigoCadastro.Name = "clnCodigoCadastro";
            this.clnCodigoCadastro.ReadOnly = true;
            // 
            // clnSituacaoPedido
            // 
            this.clnSituacaoPedido.DataPropertyName = "SituacaoPedido";
            this.clnSituacaoPedido.HeaderText = "Situação Pedido";
            this.clnSituacaoPedido.Name = "clnSituacaoPedido";
            this.clnSituacaoPedido.ReadOnly = true;
            // 
            // clnDataConclusao
            // 
            this.clnDataConclusao.DataPropertyName = "DataConclusao";
            this.clnDataConclusao.HeaderText = "Data Conclusão";
            this.clnDataConclusao.Name = "clnDataConclusao";
            this.clnDataConclusao.ReadOnly = true;
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
            // clnValorTotalPedido
            // 
            this.clnValorTotalPedido.DataPropertyName = "ValorTotalPedido";
            this.clnValorTotalPedido.HeaderText = "Valor Total";
            this.clnValorTotalPedido.Name = "clnValorTotalPedido";
            this.clnValorTotalPedido.ReadOnly = true;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 566);
            this.Controls.Add(this.grpDadosBasicos);
            this.Controls.Add(this.grpDadosChaveCargo);
            this.Controls.Add(this.tspBotoes);
            this.Name = "FrmPedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPedidos_KeyDown);
            this.tspBotoes.ResumeLayout(false);
            this.tspBotoes.PerformLayout();
            this.grpDadosChaveCargo.ResumeLayout(false);
            this.grpDadosChaveCargo.PerformLayout();
            this.grpDadosBasicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspBotoes;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.ToolStripButton tsbLimpar;
        private System.Windows.Forms.ToolStripButton tsbGravar;
        private System.Windows.Forms.GroupBox grpDadosChaveCargo;
        private System.Windows.Forms.Button btnFiltrarPedidos;
        private System.Windows.Forms.TextBox txtCodigoCadastro;
        private System.Windows.Forms.Label lblCodigoCadastro;
        private System.Windows.Forms.GroupBox grpDadosBasicos;
        private System.Windows.Forms.Button btnCriarPrePedido;
        private System.Windows.Forms.Label lblTipoPedido;
        private System.Windows.Forms.ComboBox cboCodigoTipoPedido;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.TextBox txtNumeroContrato;
        private System.Windows.Forms.Label lblNumeroContrato;
        private System.Windows.Forms.ComboBox cboCodigoTipoContrato;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoTipoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSituacaoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataConclusao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoTipoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValorTotalPedido;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.Button blnNovoPedido;
        private System.Windows.Forms.Button btnFecharPedido;
        private System.Windows.Forms.Button btnCancelarPedido;
    }
}