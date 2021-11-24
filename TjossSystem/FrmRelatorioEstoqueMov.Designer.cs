
namespace TjossSystem
{
    partial class FrmRelatorioEstoqueMov
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VizualizadorRelatorio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EstoqueItemDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MovimentacaoEstoqueDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueItemDIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimentacaoEstoqueDIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VizualizadorRelatorio
            // 
            this.VizualizadorRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "MovimentacaoEstoque";
            reportDataSource2.Value = this.MovimentacaoEstoqueDIBindingSource;
            this.VizualizadorRelatorio.LocalReport.DataSources.Add(reportDataSource2);
            this.VizualizadorRelatorio.LocalReport.ReportEmbeddedResource = "TjossSystem.RelEstoqueMov.rdlc";
            this.VizualizadorRelatorio.Location = new System.Drawing.Point(0, 0);
            this.VizualizadorRelatorio.Name = "VizualizadorRelatorio";
            this.VizualizadorRelatorio.ServerReport.BearerToken = null;
            this.VizualizadorRelatorio.Size = new System.Drawing.Size(800, 450);
            this.VizualizadorRelatorio.TabIndex = 2;
            // 
            // EstoqueItemDIBindingSource
            // 
            this.EstoqueItemDIBindingSource.DataSource = typeof(TjossSystem.Metodos.EstoqueItemDI);
            // 
            // MovimentacaoEstoqueDIBindingSource
            // 
            this.MovimentacaoEstoqueDIBindingSource.DataSource = typeof(TjossSystem.Metodos.MovimentacaoEstoqueDI);
            // 
            // FrmRelatorioEstoqueMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VizualizadorRelatorio);
            this.Name = "FrmRelatorioEstoqueMov";
            this.Text = "Relatório Estoque Movovimento";
            this.Load += new System.EventHandler(this.FrmRelatorioEstoqueMov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueItemDIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimentacaoEstoqueDIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer VizualizadorRelatorio;
        private System.Windows.Forms.BindingSource EstoqueItemDIBindingSource;
        private System.Windows.Forms.BindingSource MovimentacaoEstoqueDIBindingSource;
    }
}