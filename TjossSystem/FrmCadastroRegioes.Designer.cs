
namespace TjossSystem
{
    partial class FrmCadastroRegioes
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
            this.grpCadastroRegiões = new System.Windows.Forms.GroupBox();
            this.tbcRegioes = new System.Windows.Forms.TabControl();
            this.tabCidade = new System.Windows.Forms.TabPage();
            this.grpDadosCidade = new System.Windows.Forms.GroupBox();
            this.txtNomeCidade = new System.Windows.Forms.TextBox();
            this.btnLimparCidade = new System.Windows.Forms.Button();
            this.btnGravarAtualizarCidade = new System.Windows.Forms.Button();
            this.cboCodigoEstado = new System.Windows.Forms.ComboBox();
            this.txtSiglaCidade = new System.Windows.Forms.TextBox();
            this.lblCodigoEstadoCidade = new System.Windows.Forms.Label();
            this.lblNomeCidade = new System.Windows.Forms.Label();
            this.lblSiglaCidade = new System.Windows.Forms.Label();
            this.grpDadosChaveCidade = new System.Windows.Forms.GroupBox();
            this.blnBuscarCidade = new System.Windows.Forms.Button();
            this.lblCodigoCidade = new System.Windows.Forms.Label();
            this.txtCodigoCidade = new System.Windows.Forms.TextBox();
            this.tabEstado = new System.Windows.Forms.TabPage();
            this.grpDadosBasicosEstado = new System.Windows.Forms.GroupBox();
            this.lblNomeEstado = new System.Windows.Forms.Label();
            this.btnGravarAtualizarEstado = new System.Windows.Forms.Button();
            this.btnLimparEstado = new System.Windows.Forms.Button();
            this.txtNomeEstado = new System.Windows.Forms.TextBox();
            this.cboCodigoPais = new System.Windows.Forms.ComboBox();
            this.txtSiglaEstado = new System.Windows.Forms.TextBox();
            this.lblCodigoPais = new System.Windows.Forms.Label();
            this.lblSiglaEstado = new System.Windows.Forms.Label();
            this.grpDadosChaveEstado = new System.Windows.Forms.GroupBox();
            this.btnBuscarEstado = new System.Windows.Forms.Button();
            this.lblCodigoEstado = new System.Windows.Forms.Label();
            this.txtCodigoEstado = new System.Windows.Forms.TextBox();
            this.grpCadastroRegiões.SuspendLayout();
            this.tbcRegioes.SuspendLayout();
            this.tabCidade.SuspendLayout();
            this.grpDadosCidade.SuspendLayout();
            this.grpDadosChaveCidade.SuspendLayout();
            this.tabEstado.SuspendLayout();
            this.grpDadosBasicosEstado.SuspendLayout();
            this.grpDadosChaveEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCadastroRegiões
            // 
            this.grpCadastroRegiões.Controls.Add(this.tbcRegioes);
            this.grpCadastroRegiões.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCadastroRegiões.Location = new System.Drawing.Point(0, 0);
            this.grpCadastroRegiões.Name = "grpCadastroRegiões";
            this.grpCadastroRegiões.Size = new System.Drawing.Size(820, 540);
            this.grpCadastroRegiões.TabIndex = 0;
            this.grpCadastroRegiões.TabStop = false;
            // 
            // tbcRegioes
            // 
            this.tbcRegioes.Controls.Add(this.tabCidade);
            this.tbcRegioes.Controls.Add(this.tabEstado);
            this.tbcRegioes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcRegioes.Location = new System.Drawing.Point(3, 16);
            this.tbcRegioes.Name = "tbcRegioes";
            this.tbcRegioes.SelectedIndex = 0;
            this.tbcRegioes.Size = new System.Drawing.Size(814, 521);
            this.tbcRegioes.TabIndex = 0;
            // 
            // tabCidade
            // 
            this.tabCidade.BackColor = System.Drawing.SystemColors.Control;
            this.tabCidade.Controls.Add(this.grpDadosCidade);
            this.tabCidade.Controls.Add(this.grpDadosChaveCidade);
            this.tabCidade.Location = new System.Drawing.Point(4, 22);
            this.tabCidade.Name = "tabCidade";
            this.tabCidade.Padding = new System.Windows.Forms.Padding(3);
            this.tabCidade.Size = new System.Drawing.Size(806, 495);
            this.tabCidade.TabIndex = 0;
            this.tabCidade.Text = "Cadastro de Cidade";
            // 
            // grpDadosCidade
            // 
            this.grpDadosCidade.Controls.Add(this.txtNomeCidade);
            this.grpDadosCidade.Controls.Add(this.btnLimparCidade);
            this.grpDadosCidade.Controls.Add(this.btnGravarAtualizarCidade);
            this.grpDadosCidade.Controls.Add(this.cboCodigoEstado);
            this.grpDadosCidade.Controls.Add(this.txtSiglaCidade);
            this.grpDadosCidade.Controls.Add(this.lblCodigoEstadoCidade);
            this.grpDadosCidade.Controls.Add(this.lblNomeCidade);
            this.grpDadosCidade.Controls.Add(this.lblSiglaCidade);
            this.grpDadosCidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDadosCidade.Enabled = false;
            this.grpDadosCidade.Location = new System.Drawing.Point(3, 56);
            this.grpDadosCidade.Name = "grpDadosCidade";
            this.grpDadosCidade.Size = new System.Drawing.Size(800, 436);
            this.grpDadosCidade.TabIndex = 1;
            this.grpDadosCidade.TabStop = false;
            // 
            // txtNomeCidade
            // 
            this.txtNomeCidade.Location = new System.Drawing.Point(94, 13);
            this.txtNomeCidade.MaxLength = 80;
            this.txtNomeCidade.Name = "txtNomeCidade";
            this.txtNomeCidade.Size = new System.Drawing.Size(139, 20);
            this.txtNomeCidade.TabIndex = 0;
            // 
            // btnLimparCidade
            // 
            this.btnLimparCidade.Location = new System.Drawing.Point(128, 92);
            this.btnLimparCidade.Name = "btnLimparCidade";
            this.btnLimparCidade.Size = new System.Drawing.Size(110, 45);
            this.btnLimparCidade.TabIndex = 4;
            this.btnLimparCidade.Text = "Limpar";
            this.btnLimparCidade.UseVisualStyleBackColor = true;
            this.btnLimparCidade.Click += new System.EventHandler(this.btnLimparCidade_Click);
            // 
            // btnGravarAtualizarCidade
            // 
            this.btnGravarAtualizarCidade.Location = new System.Drawing.Point(12, 92);
            this.btnGravarAtualizarCidade.Name = "btnGravarAtualizarCidade";
            this.btnGravarAtualizarCidade.Size = new System.Drawing.Size(110, 45);
            this.btnGravarAtualizarCidade.TabIndex = 3;
            this.btnGravarAtualizarCidade.Text = "Gravar/Atualizar";
            this.btnGravarAtualizarCidade.UseVisualStyleBackColor = true;
            this.btnGravarAtualizarCidade.Click += new System.EventHandler(this.btnGravarAtualizarCidade_Click);
            // 
            // cboCodigoEstado
            // 
            this.cboCodigoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoEstado.FormattingEnabled = true;
            this.cboCodigoEstado.Location = new System.Drawing.Point(94, 65);
            this.cboCodigoEstado.Name = "cboCodigoEstado";
            this.cboCodigoEstado.Size = new System.Drawing.Size(139, 21);
            this.cboCodigoEstado.TabIndex = 2;
            // 
            // txtSiglaCidade
            // 
            this.txtSiglaCidade.Location = new System.Drawing.Point(94, 39);
            this.txtSiglaCidade.MaxLength = 15;
            this.txtSiglaCidade.Name = "txtSiglaCidade";
            this.txtSiglaCidade.Size = new System.Drawing.Size(83, 20);
            this.txtSiglaCidade.TabIndex = 1;
            // 
            // lblCodigoEstadoCidade
            // 
            this.lblCodigoEstadoCidade.AutoSize = true;
            this.lblCodigoEstadoCidade.Location = new System.Drawing.Point(9, 68);
            this.lblCodigoEstadoCidade.Name = "lblCodigoEstadoCidade";
            this.lblCodigoEstadoCidade.Size = new System.Drawing.Size(79, 13);
            this.lblCodigoEstadoCidade.TabIndex = 26;
            this.lblCodigoEstadoCidade.Text = "Código Estado:";
            // 
            // lblNomeCidade
            // 
            this.lblNomeCidade.AutoSize = true;
            this.lblNomeCidade.Location = new System.Drawing.Point(9, 16);
            this.lblNomeCidade.Name = "lblNomeCidade";
            this.lblNomeCidade.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCidade.TabIndex = 22;
            this.lblNomeCidade.Text = "Nome:";
            // 
            // lblSiglaCidade
            // 
            this.lblSiglaCidade.AutoSize = true;
            this.lblSiglaCidade.Location = new System.Drawing.Point(9, 42);
            this.lblSiglaCidade.Name = "lblSiglaCidade";
            this.lblSiglaCidade.Size = new System.Drawing.Size(33, 13);
            this.lblSiglaCidade.TabIndex = 23;
            this.lblSiglaCidade.Text = "Sigla:";
            // 
            // grpDadosChaveCidade
            // 
            this.grpDadosChaveCidade.Controls.Add(this.blnBuscarCidade);
            this.grpDadosChaveCidade.Controls.Add(this.lblCodigoCidade);
            this.grpDadosChaveCidade.Controls.Add(this.txtCodigoCidade);
            this.grpDadosChaveCidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDadosChaveCidade.Location = new System.Drawing.Point(3, 3);
            this.grpDadosChaveCidade.Name = "grpDadosChaveCidade";
            this.grpDadosChaveCidade.Size = new System.Drawing.Size(800, 53);
            this.grpDadosChaveCidade.TabIndex = 0;
            this.grpDadosChaveCidade.TabStop = false;
            // 
            // blnBuscarCidade
            // 
            this.blnBuscarCidade.Location = new System.Drawing.Point(213, 8);
            this.blnBuscarCidade.Name = "blnBuscarCidade";
            this.blnBuscarCidade.Size = new System.Drawing.Size(110, 28);
            this.blnBuscarCidade.TabIndex = 1;
            this.blnBuscarCidade.Text = "Buscar";
            this.blnBuscarCidade.UseVisualStyleBackColor = true;
            this.blnBuscarCidade.Click += new System.EventHandler(this.blnBuscarCidade_Click);
            // 
            // lblCodigoCidade
            // 
            this.lblCodigoCidade.AutoSize = true;
            this.lblCodigoCidade.Location = new System.Drawing.Point(12, 16);
            this.lblCodigoCidade.Name = "lblCodigoCidade";
            this.lblCodigoCidade.Size = new System.Drawing.Size(79, 13);
            this.lblCodigoCidade.TabIndex = 21;
            this.lblCodigoCidade.Text = "Código Cidade:";
            // 
            // txtCodigoCidade
            // 
            this.txtCodigoCidade.Location = new System.Drawing.Point(97, 13);
            this.txtCodigoCidade.MaxLength = 10;
            this.txtCodigoCidade.Name = "txtCodigoCidade";
            this.txtCodigoCidade.Size = new System.Drawing.Size(83, 20);
            this.txtCodigoCidade.TabIndex = 0;
            // 
            // tabEstado
            // 
            this.tabEstado.BackColor = System.Drawing.SystemColors.Control;
            this.tabEstado.Controls.Add(this.grpDadosBasicosEstado);
            this.tabEstado.Controls.Add(this.grpDadosChaveEstado);
            this.tabEstado.Location = new System.Drawing.Point(4, 22);
            this.tabEstado.Name = "tabEstado";
            this.tabEstado.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstado.Size = new System.Drawing.Size(806, 495);
            this.tabEstado.TabIndex = 1;
            this.tabEstado.Text = "Cadastro de Estado";
            // 
            // grpDadosBasicosEstado
            // 
            this.grpDadosBasicosEstado.Controls.Add(this.lblNomeEstado);
            this.grpDadosBasicosEstado.Controls.Add(this.btnGravarAtualizarEstado);
            this.grpDadosBasicosEstado.Controls.Add(this.btnLimparEstado);
            this.grpDadosBasicosEstado.Controls.Add(this.txtNomeEstado);
            this.grpDadosBasicosEstado.Controls.Add(this.cboCodigoPais);
            this.grpDadosBasicosEstado.Controls.Add(this.txtSiglaEstado);
            this.grpDadosBasicosEstado.Controls.Add(this.lblCodigoPais);
            this.grpDadosBasicosEstado.Controls.Add(this.lblSiglaEstado);
            this.grpDadosBasicosEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDadosBasicosEstado.Enabled = false;
            this.grpDadosBasicosEstado.Location = new System.Drawing.Point(3, 55);
            this.grpDadosBasicosEstado.Name = "grpDadosBasicosEstado";
            this.grpDadosBasicosEstado.Size = new System.Drawing.Size(800, 437);
            this.grpDadosBasicosEstado.TabIndex = 20;
            this.grpDadosBasicosEstado.TabStop = false;
            // 
            // lblNomeEstado
            // 
            this.lblNomeEstado.AutoSize = true;
            this.lblNomeEstado.Location = new System.Drawing.Point(6, 16);
            this.lblNomeEstado.Name = "lblNomeEstado";
            this.lblNomeEstado.Size = new System.Drawing.Size(38, 13);
            this.lblNomeEstado.TabIndex = 12;
            this.lblNomeEstado.Text = "Nome:";
            // 
            // btnGravarAtualizarEstado
            // 
            this.btnGravarAtualizarEstado.Location = new System.Drawing.Point(9, 92);
            this.btnGravarAtualizarEstado.Name = "btnGravarAtualizarEstado";
            this.btnGravarAtualizarEstado.Size = new System.Drawing.Size(110, 45);
            this.btnGravarAtualizarEstado.TabIndex = 8;
            this.btnGravarAtualizarEstado.Text = "Gravar/Atualizar";
            this.btnGravarAtualizarEstado.UseVisualStyleBackColor = true;
            this.btnGravarAtualizarEstado.Click += new System.EventHandler(this.btnGravarAtualizarEstado_Click);
            // 
            // btnLimparEstado
            // 
            this.btnLimparEstado.Location = new System.Drawing.Point(125, 92);
            this.btnLimparEstado.Name = "btnLimparEstado";
            this.btnLimparEstado.Size = new System.Drawing.Size(110, 45);
            this.btnLimparEstado.TabIndex = 18;
            this.btnLimparEstado.Text = "Limpar";
            this.btnLimparEstado.UseVisualStyleBackColor = true;
            this.btnLimparEstado.Click += new System.EventHandler(this.btnLimparEstado_Click);
            // 
            // txtNomeEstado
            // 
            this.txtNomeEstado.Location = new System.Drawing.Point(91, 13);
            this.txtNomeEstado.MaxLength = 80;
            this.txtNomeEstado.Name = "txtNomeEstado";
            this.txtNomeEstado.Size = new System.Drawing.Size(139, 20);
            this.txtNomeEstado.TabIndex = 9;
            // 
            // cboCodigoPais
            // 
            this.cboCodigoPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoPais.FormattingEnabled = true;
            this.cboCodigoPais.Location = new System.Drawing.Point(91, 65);
            this.cboCodigoPais.Name = "cboCodigoPais";
            this.cboCodigoPais.Size = new System.Drawing.Size(139, 21);
            this.cboCodigoPais.TabIndex = 17;
            // 
            // txtSiglaEstado
            // 
            this.txtSiglaEstado.Location = new System.Drawing.Point(91, 39);
            this.txtSiglaEstado.MaxLength = 15;
            this.txtSiglaEstado.Name = "txtSiglaEstado";
            this.txtSiglaEstado.Size = new System.Drawing.Size(83, 20);
            this.txtSiglaEstado.TabIndex = 10;
            // 
            // lblCodigoPais
            // 
            this.lblCodigoPais.AutoSize = true;
            this.lblCodigoPais.Location = new System.Drawing.Point(6, 68);
            this.lblCodigoPais.Name = "lblCodigoPais";
            this.lblCodigoPais.Size = new System.Drawing.Size(68, 13);
            this.lblCodigoPais.TabIndex = 16;
            this.lblCodigoPais.Text = "Código País:";
            // 
            // lblSiglaEstado
            // 
            this.lblSiglaEstado.AutoSize = true;
            this.lblSiglaEstado.Location = new System.Drawing.Point(6, 42);
            this.lblSiglaEstado.Name = "lblSiglaEstado";
            this.lblSiglaEstado.Size = new System.Drawing.Size(33, 13);
            this.lblSiglaEstado.TabIndex = 13;
            this.lblSiglaEstado.Text = "Sigla:";
            // 
            // grpDadosChaveEstado
            // 
            this.grpDadosChaveEstado.Controls.Add(this.btnBuscarEstado);
            this.grpDadosChaveEstado.Controls.Add(this.lblCodigoEstado);
            this.grpDadosChaveEstado.Controls.Add(this.txtCodigoEstado);
            this.grpDadosChaveEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDadosChaveEstado.Location = new System.Drawing.Point(3, 3);
            this.grpDadosChaveEstado.Name = "grpDadosChaveEstado";
            this.grpDadosChaveEstado.Size = new System.Drawing.Size(800, 52);
            this.grpDadosChaveEstado.TabIndex = 19;
            this.grpDadosChaveEstado.TabStop = false;
            // 
            // btnBuscarEstado
            // 
            this.btnBuscarEstado.Location = new System.Drawing.Point(207, 8);
            this.btnBuscarEstado.Name = "btnBuscarEstado";
            this.btnBuscarEstado.Size = new System.Drawing.Size(110, 28);
            this.btnBuscarEstado.TabIndex = 15;
            this.btnBuscarEstado.Text = "Buscar";
            this.btnBuscarEstado.UseVisualStyleBackColor = true;
            this.btnBuscarEstado.Click += new System.EventHandler(this.btnBuscarEstado_Click);
            // 
            // lblCodigoEstado
            // 
            this.lblCodigoEstado.AutoSize = true;
            this.lblCodigoEstado.Location = new System.Drawing.Point(6, 16);
            this.lblCodigoEstado.Name = "lblCodigoEstado";
            this.lblCodigoEstado.Size = new System.Drawing.Size(79, 13);
            this.lblCodigoEstado.TabIndex = 11;
            this.lblCodigoEstado.Text = "Código Estado:";
            // 
            // txtCodigoEstado
            // 
            this.txtCodigoEstado.Location = new System.Drawing.Point(91, 13);
            this.txtCodigoEstado.MaxLength = 10;
            this.txtCodigoEstado.Name = "txtCodigoEstado";
            this.txtCodigoEstado.Size = new System.Drawing.Size(83, 20);
            this.txtCodigoEstado.TabIndex = 14;
            // 
            // FrmCadastroRegioes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 540);
            this.Controls.Add(this.grpCadastroRegiões);
            this.KeyPreview = true;
            this.Name = "FrmCadastroRegioes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Regiões";
            this.Load += new System.EventHandler(this.FrmCadastroRegioes_Load);
            this.grpCadastroRegiões.ResumeLayout(false);
            this.tbcRegioes.ResumeLayout(false);
            this.tabCidade.ResumeLayout(false);
            this.grpDadosCidade.ResumeLayout(false);
            this.grpDadosCidade.PerformLayout();
            this.grpDadosChaveCidade.ResumeLayout(false);
            this.grpDadosChaveCidade.PerformLayout();
            this.tabEstado.ResumeLayout(false);
            this.grpDadosBasicosEstado.ResumeLayout(false);
            this.grpDadosBasicosEstado.PerformLayout();
            this.grpDadosChaveEstado.ResumeLayout(false);
            this.grpDadosChaveEstado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCadastroRegiões;
        private System.Windows.Forms.TabControl tbcRegioes;
        private System.Windows.Forms.TabPage tabCidade;
        private System.Windows.Forms.TabPage tabEstado;
        private System.Windows.Forms.ComboBox cboCodigoPais;
        private System.Windows.Forms.Label lblCodigoPais;
        private System.Windows.Forms.Button btnBuscarEstado;
        private System.Windows.Forms.TextBox txtCodigoEstado;
        private System.Windows.Forms.Label lblSiglaEstado;
        private System.Windows.Forms.Label lblNomeEstado;
        private System.Windows.Forms.Label lblCodigoEstado;
        private System.Windows.Forms.TextBox txtSiglaEstado;
        private System.Windows.Forms.TextBox txtNomeEstado;
        private System.Windows.Forms.Button btnGravarAtualizarEstado;
        private System.Windows.Forms.ComboBox cboCodigoEstado;
        private System.Windows.Forms.Label lblCodigoEstadoCidade;
        private System.Windows.Forms.Button blnBuscarCidade;
        private System.Windows.Forms.TextBox txtCodigoCidade;
        private System.Windows.Forms.Label lblSiglaCidade;
        private System.Windows.Forms.Label lblNomeCidade;
        private System.Windows.Forms.Label lblCodigoCidade;
        private System.Windows.Forms.TextBox txtSiglaCidade;
        private System.Windows.Forms.TextBox txtNomeCidade;
        private System.Windows.Forms.Button btnGravarAtualizarCidade;
        private System.Windows.Forms.Button btnLimparEstado;
        private System.Windows.Forms.Button btnLimparCidade;
        private System.Windows.Forms.GroupBox grpDadosCidade;
        private System.Windows.Forms.GroupBox grpDadosChaveCidade;
        private System.Windows.Forms.GroupBox grpDadosBasicosEstado;
        private System.Windows.Forms.GroupBox grpDadosChaveEstado;
    }
}