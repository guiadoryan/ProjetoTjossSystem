
namespace TjossSystem
{
    partial class FrmPedidoNovo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoNovo));
            this.grpDadosChaveCargo = new System.Windows.Forms.GroupBox();
            this.cboCodigoTipoContrato = new System.Windows.Forms.ComboBox();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.txtNumeroContrato = new System.Windows.Forms.TextBox();
            this.lblNumeroContrato = new System.Windows.Forms.Label();
            this.lblTipoPedido = new System.Windows.Forms.Label();
            this.cboCodigoTipoPedido = new System.Windows.Forms.ComboBox();
            this.txtCodigoCadastro = new System.Windows.Forms.TextBox();
            this.lblCodigoCadastro = new System.Windows.Forms.Label();
            this.tspBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.tsbGravar = new System.Windows.Forms.ToolStripButton();
            this.grpDadosBasicos = new System.Windows.Forms.GroupBox();
            this.dgvItensPedido = new System.Windows.Forms.DataGridView();
            this.clnNumeroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoTipoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValorTotalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoCadastroMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCamposItem = new System.Windows.Forms.GroupBox();
            this.bntEditarItem = new System.Windows.Forms.Button();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.lblValorUnitarioItem = new System.Windows.Forms.Label();
            this.txtCodigoMedida = new System.Windows.Forms.TextBox();
            this.lblCodigoMedida = new System.Windows.Forms.Label();
            this.txtCodigoCadastroMedida = new System.Windows.Forms.TextBox();
            this.lblCodigoCadastroMedida = new System.Windows.Forms.Label();
            this.txtQuantidadeSolicitada = new System.Windows.Forms.TextBox();
            this.lblQuantidadeSolicitada = new System.Windows.Forms.Label();
            this.txtCodigoItem = new System.Windows.Forms.TextBox();
            this.lblCodigoItem = new System.Windows.Forms.Label();
            this.blnAdicionarItem = new System.Windows.Forms.Button();
            this.grpDadosChaveCargo.SuspendLayout();
            this.tspBotoes.SuspendLayout();
            this.grpDadosBasicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensPedido)).BeginInit();
            this.grpCamposItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosChaveCargo
            // 
            this.grpDadosChaveCargo.Controls.Add(this.cboCodigoTipoContrato);
            this.grpDadosChaveCargo.Controls.Add(this.lblTipoContrato);
            this.grpDadosChaveCargo.Controls.Add(this.txtNumeroContrato);
            this.grpDadosChaveCargo.Controls.Add(this.lblNumeroContrato);
            this.grpDadosChaveCargo.Controls.Add(this.lblTipoPedido);
            this.grpDadosChaveCargo.Controls.Add(this.cboCodigoTipoPedido);
            this.grpDadosChaveCargo.Controls.Add(this.txtCodigoCadastro);
            this.grpDadosChaveCargo.Controls.Add(this.lblCodigoCadastro);
            this.grpDadosChaveCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDadosChaveCargo.Location = new System.Drawing.Point(0, 0);
            this.grpDadosChaveCargo.Name = "grpDadosChaveCargo";
            this.grpDadosChaveCargo.Size = new System.Drawing.Size(986, 83);
            this.grpDadosChaveCargo.TabIndex = 0;
            this.grpDadosChaveCargo.TabStop = false;
            this.grpDadosChaveCargo.Validated += new System.EventHandler(this.grpDadosChaveCargo_Validated);
            // 
            // cboCodigoTipoContrato
            // 
            this.cboCodigoTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoTipoContrato.FormattingEnabled = true;
            this.cboCodigoTipoContrato.Location = new System.Drawing.Point(336, 40);
            this.cboCodigoTipoContrato.Name = "cboCodigoTipoContrato";
            this.cboCodigoTipoContrato.Size = new System.Drawing.Size(104, 21);
            this.cboCodigoTipoContrato.TabIndex = 3;
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Location = new System.Drawing.Point(229, 43);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(74, 13);
            this.lblTipoContrato.TabIndex = 8;
            this.lblTipoContrato.Text = "Tipo Contrato:";
            // 
            // txtNumeroContrato
            // 
            this.txtNumeroContrato.Location = new System.Drawing.Point(336, 11);
            this.txtNumeroContrato.MaxLength = 15;
            this.txtNumeroContrato.Name = "txtNumeroContrato";
            this.txtNumeroContrato.Size = new System.Drawing.Size(104, 20);
            this.txtNumeroContrato.TabIndex = 2;
            // 
            // lblNumeroContrato
            // 
            this.lblNumeroContrato.AutoSize = true;
            this.lblNumeroContrato.Location = new System.Drawing.Point(229, 14);
            this.lblNumeroContrato.Name = "lblNumeroContrato";
            this.lblNumeroContrato.Size = new System.Drawing.Size(90, 13);
            this.lblNumeroContrato.TabIndex = 6;
            this.lblNumeroContrato.Text = "Número Contrato:";
            // 
            // lblTipoPedido
            // 
            this.lblTipoPedido.AutoSize = true;
            this.lblTipoPedido.Location = new System.Drawing.Point(12, 14);
            this.lblTipoPedido.Name = "lblTipoPedido";
            this.lblTipoPedido.Size = new System.Drawing.Size(67, 13);
            this.lblTipoPedido.TabIndex = 5;
            this.lblTipoPedido.Text = "Tipo Pedido:";
            // 
            // cboCodigoTipoPedido
            // 
            this.cboCodigoTipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoTipoPedido.FormattingEnabled = true;
            this.cboCodigoTipoPedido.Location = new System.Drawing.Point(119, 11);
            this.cboCodigoTipoPedido.Name = "cboCodigoTipoPedido";
            this.cboCodigoTipoPedido.Size = new System.Drawing.Size(104, 21);
            this.cboCodigoTipoPedido.TabIndex = 0;
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
            // tspBotoes
            // 
            this.tspBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFechar,
            this.tsbLimpar,
            this.tsbGravar});
            this.tspBotoes.Location = new System.Drawing.Point(0, 550);
            this.tspBotoes.Name = "tspBotoes";
            this.tspBotoes.Size = new System.Drawing.Size(986, 25);
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
            this.tsbGravar.Enabled = false;
            this.tsbGravar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGravar.Image")));
            this.tsbGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGravar.Name = "tsbGravar";
            this.tsbGravar.Size = new System.Drawing.Size(68, 22);
            this.tsbGravar.Text = "F9 - Gravar";
            this.tsbGravar.Click += new System.EventHandler(this.tsbGravar_Click);
            // 
            // grpDadosBasicos
            // 
            this.grpDadosBasicos.Controls.Add(this.dgvItensPedido);
            this.grpDadosBasicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDadosBasicos.Location = new System.Drawing.Point(0, 189);
            this.grpDadosBasicos.Name = "grpDadosBasicos";
            this.grpDadosBasicos.Size = new System.Drawing.Size(986, 361);
            this.grpDadosBasicos.TabIndex = 3;
            this.grpDadosBasicos.TabStop = false;
            // 
            // dgvItensPedido
            // 
            this.dgvItensPedido.AllowUserToAddRows = false;
            this.dgvItensPedido.AllowUserToDeleteRows = false;
            this.dgvItensPedido.AllowUserToResizeRows = false;
            this.dgvItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNumeroPedido,
            this.clnCodigoTipoPedido,
            this.clnCodigoItem,
            this.clnValorUnitario,
            this.clnValorTotalItem,
            this.clnCodigoCadastroMedida,
            this.clnCodigoMedida});
            this.dgvItensPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItensPedido.Location = new System.Drawing.Point(3, 16);
            this.dgvItensPedido.MultiSelect = false;
            this.dgvItensPedido.Name = "dgvItensPedido";
            this.dgvItensPedido.RowHeadersVisible = false;
            this.dgvItensPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensPedido.Size = new System.Drawing.Size(980, 342);
            this.dgvItensPedido.TabIndex = 0;
            // 
            // clnNumeroPedido
            // 
            this.clnNumeroPedido.DataPropertyName = "NumeroPedido";
            this.clnNumeroPedido.HeaderText = "N° Pedido";
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
            // clnCodigoItem
            // 
            this.clnCodigoItem.DataPropertyName = "CodigoItem";
            this.clnCodigoItem.HeaderText = "Código Item";
            this.clnCodigoItem.Name = "clnCodigoItem";
            this.clnCodigoItem.ReadOnly = true;
            // 
            // clnValorUnitario
            // 
            this.clnValorUnitario.DataPropertyName = "ValorUnitario";
            this.clnValorUnitario.HeaderText = "Valor Unitario";
            this.clnValorUnitario.Name = "clnValorUnitario";
            this.clnValorUnitario.ReadOnly = true;
            // 
            // clnValorTotalItem
            // 
            this.clnValorTotalItem.DataPropertyName = "ValorTotalItem";
            this.clnValorTotalItem.HeaderText = "Valor Total Item";
            this.clnValorTotalItem.Name = "clnValorTotalItem";
            this.clnValorTotalItem.ReadOnly = true;
            // 
            // clnCodigoCadastroMedida
            // 
            this.clnCodigoCadastroMedida.DataPropertyName = "CodigoCadastro";
            this.clnCodigoCadastroMedida.HeaderText = "Código Cadastro";
            this.clnCodigoCadastroMedida.Name = "clnCodigoCadastroMedida";
            this.clnCodigoCadastroMedida.ReadOnly = true;
            // 
            // clnCodigoMedida
            // 
            this.clnCodigoMedida.DataPropertyName = "CodigoMedida";
            this.clnCodigoMedida.HeaderText = "Código Medida";
            this.clnCodigoMedida.Name = "clnCodigoMedida";
            this.clnCodigoMedida.ReadOnly = true;
            // 
            // grpCamposItem
            // 
            this.grpCamposItem.Controls.Add(this.bntEditarItem);
            this.grpCamposItem.Controls.Add(this.txtValorUnitario);
            this.grpCamposItem.Controls.Add(this.lblValorUnitarioItem);
            this.grpCamposItem.Controls.Add(this.txtCodigoMedida);
            this.grpCamposItem.Controls.Add(this.lblCodigoMedida);
            this.grpCamposItem.Controls.Add(this.txtCodigoCadastroMedida);
            this.grpCamposItem.Controls.Add(this.lblCodigoCadastroMedida);
            this.grpCamposItem.Controls.Add(this.txtQuantidadeSolicitada);
            this.grpCamposItem.Controls.Add(this.lblQuantidadeSolicitada);
            this.grpCamposItem.Controls.Add(this.txtCodigoItem);
            this.grpCamposItem.Controls.Add(this.lblCodigoItem);
            this.grpCamposItem.Controls.Add(this.blnAdicionarItem);
            this.grpCamposItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCamposItem.Location = new System.Drawing.Point(0, 83);
            this.grpCamposItem.Name = "grpCamposItem";
            this.grpCamposItem.Size = new System.Drawing.Size(986, 106);
            this.grpCamposItem.TabIndex = 1;
            this.grpCamposItem.TabStop = false;
            // 
            // bntEditarItem
            // 
            this.bntEditarItem.Location = new System.Drawing.Point(740, 66);
            this.bntEditarItem.Name = "bntEditarItem";
            this.bntEditarItem.Size = new System.Drawing.Size(112, 29);
            this.bntEditarItem.TabIndex = 24;
            this.bntEditarItem.Text = "Editar Item";
            this.bntEditarItem.UseVisualStyleBackColor = true;
            this.bntEditarItem.Click += new System.EventHandler(this.bntEditarItem_Click);
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Enabled = false;
            this.txtValorUnitario.Location = new System.Drawing.Point(135, 71);
            this.txtValorUnitario.MaxLength = 15;
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(104, 20);
            this.txtValorUnitario.TabIndex = 2;
            // 
            // lblValorUnitarioItem
            // 
            this.lblValorUnitarioItem.AutoSize = true;
            this.lblValorUnitarioItem.Location = new System.Drawing.Point(12, 74);
            this.lblValorUnitarioItem.Name = "lblValorUnitarioItem";
            this.lblValorUnitarioItem.Size = new System.Drawing.Size(73, 13);
            this.lblValorUnitarioItem.TabIndex = 23;
            this.lblValorUnitarioItem.Text = "Valor Unitário:";
            // 
            // txtCodigoMedida
            // 
            this.txtCodigoMedida.Location = new System.Drawing.Point(356, 45);
            this.txtCodigoMedida.MaxLength = 15;
            this.txtCodigoMedida.Name = "txtCodigoMedida";
            this.txtCodigoMedida.Size = new System.Drawing.Size(104, 20);
            this.txtCodigoMedida.TabIndex = 4;
            // 
            // lblCodigoMedida
            // 
            this.lblCodigoMedida.AutoSize = true;
            this.lblCodigoMedida.Location = new System.Drawing.Point(249, 48);
            this.lblCodigoMedida.Name = "lblCodigoMedida";
            this.lblCodigoMedida.Size = new System.Drawing.Size(81, 13);
            this.lblCodigoMedida.TabIndex = 21;
            this.lblCodigoMedida.Text = "Código Medida:";
            // 
            // txtCodigoCadastroMedida
            // 
            this.txtCodigoCadastroMedida.Location = new System.Drawing.Point(356, 19);
            this.txtCodigoCadastroMedida.MaxLength = 15;
            this.txtCodigoCadastroMedida.Name = "txtCodigoCadastroMedida";
            this.txtCodigoCadastroMedida.Size = new System.Drawing.Size(104, 20);
            this.txtCodigoCadastroMedida.TabIndex = 3;
            // 
            // lblCodigoCadastroMedida
            // 
            this.lblCodigoCadastroMedida.AutoSize = true;
            this.lblCodigoCadastroMedida.Location = new System.Drawing.Point(249, 22);
            this.lblCodigoCadastroMedida.Name = "lblCodigoCadastroMedida";
            this.lblCodigoCadastroMedida.Size = new System.Drawing.Size(88, 13);
            this.lblCodigoCadastroMedida.TabIndex = 19;
            this.lblCodigoCadastroMedida.Text = "Código Cadastro:";
            // 
            // txtQuantidadeSolicitada
            // 
            this.txtQuantidadeSolicitada.Location = new System.Drawing.Point(135, 45);
            this.txtQuantidadeSolicitada.MaxLength = 15;
            this.txtQuantidadeSolicitada.Name = "txtQuantidadeSolicitada";
            this.txtQuantidadeSolicitada.Size = new System.Drawing.Size(104, 20);
            this.txtQuantidadeSolicitada.TabIndex = 1;
            // 
            // lblQuantidadeSolicitada
            // 
            this.lblQuantidadeSolicitada.AutoSize = true;
            this.lblQuantidadeSolicitada.Location = new System.Drawing.Point(12, 48);
            this.lblQuantidadeSolicitada.Name = "lblQuantidadeSolicitada";
            this.lblQuantidadeSolicitada.Size = new System.Drawing.Size(114, 13);
            this.lblQuantidadeSolicitada.TabIndex = 15;
            this.lblQuantidadeSolicitada.Text = "Quantidade Solicitada:";
            // 
            // txtCodigoItem
            // 
            this.txtCodigoItem.Location = new System.Drawing.Point(135, 19);
            this.txtCodigoItem.MaxLength = 15;
            this.txtCodigoItem.Name = "txtCodigoItem";
            this.txtCodigoItem.Size = new System.Drawing.Size(104, 20);
            this.txtCodigoItem.TabIndex = 0;
            // 
            // lblCodigoItem
            // 
            this.lblCodigoItem.AutoSize = true;
            this.lblCodigoItem.Location = new System.Drawing.Point(12, 22);
            this.lblCodigoItem.Name = "lblCodigoItem";
            this.lblCodigoItem.Size = new System.Drawing.Size(66, 13);
            this.lblCodigoItem.TabIndex = 13;
            this.lblCodigoItem.Text = "Código Item:";
            // 
            // blnAdicionarItem
            // 
            this.blnAdicionarItem.Location = new System.Drawing.Point(868, 66);
            this.blnAdicionarItem.Name = "blnAdicionarItem";
            this.blnAdicionarItem.Size = new System.Drawing.Size(112, 29);
            this.blnAdicionarItem.TabIndex = 5;
            this.blnAdicionarItem.Text = "Adicionar Item";
            this.blnAdicionarItem.UseVisualStyleBackColor = true;
            this.blnAdicionarItem.Click += new System.EventHandler(this.blnAdicionarItem_Click);
            // 
            // FrmPedidoNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 575);
            this.Controls.Add(this.grpDadosBasicos);
            this.Controls.Add(this.grpCamposItem);
            this.Controls.Add(this.tspBotoes);
            this.Controls.Add(this.grpDadosChaveCargo);
            this.Name = "FrmPedidoNovo";
            this.Text = "Pedido Novo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPedidoNovo_FormClosing);
            this.Load += new System.EventHandler(this.FrmPedidoNovo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPedidoNovo_KeyDown);
            this.grpDadosChaveCargo.ResumeLayout(false);
            this.grpDadosChaveCargo.PerformLayout();
            this.tspBotoes.ResumeLayout(false);
            this.tspBotoes.PerformLayout();
            this.grpDadosBasicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensPedido)).EndInit();
            this.grpCamposItem.ResumeLayout(false);
            this.grpCamposItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosChaveCargo;
        private System.Windows.Forms.ComboBox cboCodigoTipoContrato;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.TextBox txtNumeroContrato;
        private System.Windows.Forms.Label lblNumeroContrato;
        private System.Windows.Forms.Label lblTipoPedido;
        private System.Windows.Forms.ComboBox cboCodigoTipoPedido;
        private System.Windows.Forms.TextBox txtCodigoCadastro;
        private System.Windows.Forms.Label lblCodigoCadastro;
        private System.Windows.Forms.ToolStrip tspBotoes;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.ToolStripButton tsbLimpar;
        private System.Windows.Forms.ToolStripButton tsbGravar;
        private System.Windows.Forms.GroupBox grpDadosBasicos;
        private System.Windows.Forms.DataGridView dgvItensPedido;
        private System.Windows.Forms.GroupBox grpCamposItem;
        private System.Windows.Forms.Button blnAdicionarItem;
        private System.Windows.Forms.TextBox txtCodigoMedida;
        private System.Windows.Forms.Label lblCodigoMedida;
        private System.Windows.Forms.TextBox txtCodigoCadastroMedida;
        private System.Windows.Forms.Label lblCodigoCadastroMedida;
        private System.Windows.Forms.TextBox txtQuantidadeSolicitada;
        private System.Windows.Forms.Label lblQuantidadeSolicitada;
        private System.Windows.Forms.TextBox txtCodigoItem;
        private System.Windows.Forms.Label lblCodigoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoTipoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValorTotalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoCadastroMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoMedida;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label lblValorUnitarioItem;
        private System.Windows.Forms.Button bntEditarItem;
    }
}