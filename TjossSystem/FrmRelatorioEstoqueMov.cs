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
    public partial class FrmRelatorioEstoqueMov : FrmPadrao
    {
        DataTable dttEstoqueMov = new DataTable();

        public FrmRelatorioEstoqueMov()
        {
            InitializeComponent();
        }

        private void FrmRelatorioEstoqueMov_Load(object sender, EventArgs e)
        {
            dttEstoqueMov = GerarDados();
            VizualizadorRelatorio.LocalReport.DataSources.Clear();
            VizualizadorRelatorio.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("MovimentacaoEstoque", dttEstoqueMov));
            this.VizualizadorRelatorio.RefreshReport();
        }

        private DataTable GerarDados()
        {
            var dttDadosMovEst = new DataTable();
            ModuloDeItens objItens = new ModuloDeItens();

            dttDadosMovEst.Columns.Add("CodigoItem");
            dttDadosMovEst.Columns.Add("CodigoTipoEstoque");
            dttDadosMovEst.Columns.Add("TipoMovimento");
            dttDadosMovEst.Columns.Add("QuantidadeMovimentada");
            dttDadosMovEst.Columns.Add("DatahMovimento");
            dttDadosMovEst.Columns.Add("CodigoFuncionario");
            dttDadosMovEst.Columns.Add("NumeroPedido");
            dttDadosMovEst.Columns.Add("CodigoTipoPedido");
            dttDadosMovEst.Columns.Add("ObservacaoMovimento");

            List<MovimentacaoEstoqueDI> lstEstoque = new List<MovimentacaoEstoqueDI>();
            lstEstoque = objItens.ListarMovimentoEstoqueRelatorio();

            foreach (var cad in lstEstoque)
            {
                dttDadosMovEst.Rows.Add(cad.CodigoItem,
                                        cad.CodigoTipoEstoque,
                                        cad.TipoMovimento,
                                        cad.QuantidadeMovimentada,
                                        cad.DatahMovimento,
                                        cad.CodigoFuncionario,
                                        cad.NumeroPedido,
                                        cad.CodigoTipoPedido,
                                        cad.ObservacaoMovimento);
            }

            return dttDadosMovEst;
        }
    }
}
