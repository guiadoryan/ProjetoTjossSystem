
namespace TjossSystem
{
    partial class FrmContratoNovo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContratoNovo));
            this.tspBotoes = new System.Windows.Forms.ToolStrip();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.tsbGravar = new System.Windows.Forms.ToolStripButton();
            this.grpDadosChaveCargo = new System.Windows.Forms.GroupBox();
            this.cboCodigoTipoContrato = new System.Windows.Forms.ComboBox();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.txtCodigoCadastro = new System.Windows.Forms.TextBox();
            this.lblCodigoCadastro = new System.Windows.Forms.Label();
            this.grpCamposItem = new System.Windows.Forms.GroupBox();
            this.bntEditarItem = new System.Windows.Forms.Button();
            this.txtValorItem = new System.Windows.Forms.TextBox();
            this.lblValorItem = new System.Windows.Forms.Label();
            this.txtSaldoContratado = new System.Windows.Forms.TextBox();
            this.lblSaldoContratado = new System.Windows.Forms.Label();
            this.txtCodigoItem = new System.Windows.Forms.TextBox();
            this.lblCodigoItem = new System.Windows.Forms.Label();
            this.blnAdicionarItem = new System.Windows.Forms.Button();
            this.grpDadosBasicos = new System.Windows.Forms.GroupBox();
            this.dgvItensContrato = new System.Windows.Forms.DataGridView();
            this.clnNumeroContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoTipoContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSaldoContratado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSaldoAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValorItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspBotoes.SuspendLayout();
            this.grpDadosChaveCargo.SuspendLayout();
            this.grpCamposItem.SuspendLayout();
            this.grpDadosBasicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // tspBotoes
            // 
            this.tspBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFechar,
            this.tsbLimpar,
            this.tsbGravar});
            this.tspBotoes.Location = new System.Drawing.Point(0, 531);
            this.tspBotoes.Name = "tspBotoes";
            this.tspBotoes.Size = new System.Drawing.Size(990, 25);
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
            this.grpDadosChaveCargo.Controls.Add(this.cboCodigoTipoContrato);
            this.grpDadosChaveCargo.Controls.Add(this.lblTipoContrato);
            this.grpDadosChaveCargo.Controls.Add(this.txtCodigoCadastro);
            this.grpDadosChaveCargo.Controls.Add(this.lblCodigoCadastro);
            this.grpDadosChaveCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDadosChaveCargo.Location = new System.Drawing.Point(0, 0);
            this.grpDadosChaveCargo.Name = "grpDadosChaveCargo";
            this.grpDadosChaveCargo.Size = new System.Drawing.Size(990, 77);
            this.grpDadosChaveCargo.TabIndex = 4;
            this.grpDadosChaveCargo.TabStop = false;
            this.grpDadosChaveCargo.Validated += new System.EventHandler(this.grpDadosChaveCargo_Validated);
            // 
            // cboCodigoTipoContrato
            // 
            this.cboCodigoTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoTipoContrato.FormattingEnabled = true;
            this.cboCodigoTipoContrato.Location = new System.Drawing.Point(119, 11);
            this.cboCodigoTipoContrato.Name = "cboCodigoTipoContrato";
            this.cboCodigoTipoContrato.Size = new System.Drawing.Size(104, 21);
            this.cboCodigoTipoContrato.TabIndex = 3;
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Location = new System.Drawing.Point(12, 14);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(74, 13);
            this.lblTipoContrato.TabIndex = 8;
            this.lblTipoContrato.Text = "Tipo Contrato:";
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
            // grpCamposItem
            // 
            this.grpCamposItem.Controls.Add(this.bntEditarItem);
            this.grpCamposItem.Controls.Add(this.txtValorItem);
            this.grpCamposItem.Controls.Add(this.lblValorItem);
            this.grpCamposItem.Controls.Add(this.txtSaldoContratado);
            this.grpCamposItem.Controls.Add(this.lblSaldoContratado);
            this.grpCamposItem.Controls.Add(this.txtCodigoItem);
            this.grpCamposItem.Controls.Add(this.lblCodigoItem);
            this.grpCamposItem.Controls.Add(this.blnAdicionarItem);
            this.grpCamposItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCamposItem.Location = new System.Drawing.Point(0, 77);
            this.grpCamposItem.Name = "grpCamposItem";
            this.grpCamposItem.Size = new System.Drawing.Size(990, 106);
            this.grpCamposItem.TabIndex = 5;
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
            // txtValorItem
            // 
            this.txtValorItem.Enabled = false;
            this.txtValorItem.Location = new System.Drawing.Point(135, 71);
            this.txtValorItem.MaxLength = 15;
            this.txtValorItem.Name = "txtValorItem";
            this.txtValorItem.Size = new System.Drawing.Size(104, 20);
            this.txtValorItem.TabIndex = 2;
            // 
            // lblValorItem
            // 
            this.lblValorItem.AutoSize = true;
            this.lblValorItem.Location = new System.Drawing.Point(12, 74);
            this.lblValorItem.Name = "lblValorItem";
            this.lblValorItem.Size = new System.Drawing.Size(72, 13);
            this.lblValorItem.TabIndex = 23;
            this.lblValorItem.Text = "Valor do Item:";
            // 
            // txtSaldoContratado
            // 
            this.txtSaldoContratado.Location = new System.Drawing.Point(135, 45);
            this.txtSaldoContratado.MaxLength = 15;
            this.txtSaldoContratado.Name = "txtSaldoContratado";
            this.txtSaldoContratado.Size = new System.Drawing.Size(104, 20);
            this.txtSaldoContratado.TabIndex = 1;
            // 
            // lblSaldoContratado
            // 
            this.lblSaldoContratado.AutoSize = true;
            this.lblSaldoContratado.Location = new System.Drawing.Point(12, 48);
            this.lblSaldoContratado.Name = "lblSaldoContratado";
            this.lblSaldoContratado.Size = new System.Drawing.Size(92, 13);
            this.lblSaldoContratado.TabIndex = 15;
            this.lblSaldoContratado.Text = "Saldo Contratado:";
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
            // grpDadosBasicos
            // 
            this.grpDadosBasicos.Controls.Add(this.dgvItensContrato);
            this.grpDadosBasicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDadosBasicos.Location = new System.Drawing.Point(0, 183);
            this.grpDadosBasicos.Name = "grpDadosBasicos";
            this.grpDadosBasicos.Size = new System.Drawing.Size(990, 348);
            this.grpDadosBasicos.TabIndex = 6;
            this.grpDadosBasicos.TabStop = false;
            // 
            // dgvItensContrato
            // 
            this.dgvItensContrato.AllowUserToAddRows = false;
            this.dgvItensContrato.AllowUserToDeleteRows = false;
            this.dgvItensContrato.AllowUserToResizeRows = false;
            this.dgvItensContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensContrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNumeroContrato,
            this.clnCodigoTipoContrato,
            this.clnCodigoItem,
            this.clnSaldoContratado,
            this.clnSaldoAtual,
            this.clnValorItem});
            this.dgvItensContrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItensContrato.Location = new System.Drawing.Point(3, 16);
            this.dgvItensContrato.MultiSelect = false;
            this.dgvItensContrato.Name = "dgvItensContrato";
            this.dgvItensContrato.RowHeadersVisible = false;
            this.dgvItensContrato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensContrato.Size = new System.Drawing.Size(984, 329);
            this.dgvItensContrato.TabIndex = 0;
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
            // clnCodigoItem
            // 
            this.clnCodigoItem.DataPropertyName = "CodigoItem";
            this.clnCodigoItem.HeaderText = "Código Item";
            this.clnCodigoItem.Name = "clnCodigoItem";
            this.clnCodigoItem.ReadOnly = true;
            // 
            // clnSaldoContratado
            // 
            this.clnSaldoContratado.DataPropertyName = "SaldoContratado";
            this.clnSaldoContratado.HeaderText = "Saldo Contratado";
            this.clnSaldoContratado.Name = "clnSaldoContratado";
            this.clnSaldoContratado.ReadOnly = true;
            // 
            // clnSaldoAtual
            // 
            this.clnSaldoAtual.DataPropertyName = "SaldoAtual";
            this.clnSaldoAtual.HeaderText = "Saldo Atual";
            this.clnSaldoAtual.Name = "clnSaldoAtual";
            this.clnSaldoAtual.ReadOnly = true;
            // 
            // clnValorItem
            // 
            this.clnValorItem.DataPropertyName = "ValorItem";
            this.clnValorItem.HeaderText = "Valor do Item";
            this.clnValorItem.Name = "clnValorItem";
            this.clnValorItem.ReadOnly = true;
            // 
            // FrmContratoNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 556);
            this.Controls.Add(this.grpDadosBasicos);
            this.Controls.Add(this.grpCamposItem);
            this.Controls.Add(this.grpDadosChaveCargo);
            this.Controls.Add(this.tspBotoes);
            this.Name = "FrmContratoNovo";
            this.Text = "Itens Contrato";
            this.Load += new System.EventHandler(this.FrmContratoNovo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmContratoNovo_KeyDown);
            this.tspBotoes.ResumeLayout(false);
            this.tspBotoes.PerformLayout();
            this.grpDadosChaveCargo.ResumeLayout(false);
            this.grpDadosChaveCargo.PerformLayout();
            this.grpCamposItem.ResumeLayout(false);
            this.grpCamposItem.PerformLayout();
            this.grpDadosBasicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensContrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspBotoes;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.ToolStripButton tsbLimpar;
        private System.Windows.Forms.ToolStripButton tsbGravar;
        private System.Windows.Forms.GroupBox grpDadosChaveCargo;
        private System.Windows.Forms.ComboBox cboCodigoTipoContrato;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.TextBox txtCodigoCadastro;
        private System.Windows.Forms.Label lblCodigoCadastro;
        private System.Windows.Forms.GroupBox grpCamposItem;
        private System.Windows.Forms.Button bntEditarItem;
        private System.Windows.Forms.TextBox txtValorItem;
        private System.Windows.Forms.Label lblValorItem;
        private System.Windows.Forms.TextBox txtSaldoContratado;
        private System.Windows.Forms.Label lblSaldoContratado;
        private System.Windows.Forms.TextBox txtCodigoItem;
        private System.Windows.Forms.Label lblCodigoItem;
        private System.Windows.Forms.Button blnAdicionarItem;
        private System.Windows.Forms.GroupBox grpDadosBasicos;
        private System.Windows.Forms.DataGridView dgvItensContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoTipoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSaldoContratado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSaldoAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValorItem;
    }
}