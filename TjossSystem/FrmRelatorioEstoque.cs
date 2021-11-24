using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TjossSystem.Metodos;

namespace TjossSystem
{
    public partial class FrmRelatorioEstoque : FrmPadrao
    {
        DataTable dttEstoque = new DataTable();

        public FrmRelatorioEstoque()
        {
            InitializeComponent();
        }

        private void FrmRelatorioEstoque_Load(object sender, EventArgs e)
        {
            dttEstoque = GerarDados();
            VizualizadorRelatorio.LocalReport.DataSources.Clear();
            VizualizadorRelatorio.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Estoque", dttEstoque));
            this.VizualizadorRelatorio.RefreshReport();
        }

        private DataTable GerarDados()
        {
            var dttDadosCadastro = new DataTable();
            ModuloDeItens objItens = new ModuloDeItens();

            dttDadosCadastro.Columns.Add("CodigoItem");
            dttDadosCadastro.Columns.Add("CodigoTipoEstoque");
            dttDadosCadastro.Columns.Add("Quantidade");
            dttDadosCadastro.Columns.Add("ValorUnitario");

            List<EstoqueItemDI> lstEstoque = new List<EstoqueItemDI>();
            lstEstoque = objItens.ListarEstoqueRelatorio();

            foreach (var cad in lstEstoque)
            {
                dttDadosCadastro.Rows.Add(cad.CodigoItem,
                                          cad.CodigoTipoEstoque,
                                          cad.Quantidade,
                                          cad.ValorUnitario);
            }

            return dttDadosCadastro;
        }
    }
}
