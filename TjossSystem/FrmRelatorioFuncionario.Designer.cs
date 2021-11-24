
namespace TjossSystem
{
    partial class FrmRelatorioFuncionario
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VizualizadorRelatorio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FuncionarioDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FuncionarioDIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VizualizadorRelatorio
            // 
            this.VizualizadorRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Funcionario";
            reportDataSource1.Value = this.FuncionarioDIBindingSource;
            this.VizualizadorRelatorio.LocalReport.DataSources.Add(reportDataSource1);
            this.VizualizadorRelatorio.LocalReport.ReportEmbeddedResource = "TjossSystem.RelFuncionarios.rdlc";
            this.VizualizadorRelatorio.Location = new System.Drawing.Point(0, 0);
            this.VizualizadorRelatorio.Name = "VizualizadorRelatorio";
            this.VizualizadorRelatorio.ServerReport.BearerToken = null;
            this.VizualizadorRelatorio.Size = new System.Drawing.Size(800, 450);
            this.VizualizadorRelatorio.TabIndex = 1;
            // 
            // FuncionarioDIBindingSource
            // 
            this.FuncionarioDIBindingSource.DataSource = typeof(TjossSystem.Metodos.FuncionarioDI);
            // 
            // FrmRelatorioFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VizualizadorRelatorio);
            this.Name = "FrmRelatorioFuncionario";
            this.Text = "Relatório Funcionário";
            this.Load += new System.EventHandler(this.FrmRelatorioFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FuncionarioDIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer VizualizadorRelatorio;
        private System.Windows.Forms.BindingSource FuncionarioDIBindingSource;
    }
}