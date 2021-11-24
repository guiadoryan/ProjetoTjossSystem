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
    public partial class FrmRelatorioPedidos : FrmPadrao
    {
        DataTable dttPedidos = new DataTable();

        public FrmRelatorioPedidos()
        {
            InitializeComponent();
        }

        private void FrmRelatorioPedidos_Load(object sender, EventArgs e)
        {
            dttPedidos = GerarDados();
            VizualizadorRelatorio.LocalReport.DataSources.Clear();
            VizualizadorRelatorio.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Pedidos", dttPedidos));
            this.VizualizadorRelatorio.RefreshReport();
        }

        private DataTable GerarDados()
        {
            var dttDadosMovEst = new DataTable();
            ModuloPedidos objItens = new ModuloPedidos();

            dttDadosMovEst.Columns.Add("NumeroPedido");
            dttDadosMovEst.Columns.Add("CodigoTipoPedido");
            dttDadosMovEst.Columns.Add("CodigoCadastro");
            dttDadosMovEst.Columns.Add("SituacaoPedido");
            dttDadosMovEst.Columns.Add("DataConclusao");
            dttDadosMovEst.Columns.Add("NumeroContrato");
            dttDadosMovEst.Columns.Add("CodigoTipoContrato");
            dttDadosMovEst.Columns.Add("ValorTotalPedido");

            List<PedidoDI> lstPedidoDI = new List<PedidoDI>();
            lstPedidoDI = objItens.ListarTodosPedidos();

            foreach (var cad in lstPedidoDI)
            {
                dttDadosMovEst.Rows.Add(cad.NumeroPedido,
                                        cad.CodigoTipoPedido,
                                        cad.CodigoCadastro,
                                        cad.SituacaoPedido,
                                        cad.DataConclusao,
                                        cad.NumeroContrato,
                                        cad.CodigoTipoContrato,
                                        cad.ValorTotalPedido);
            }

            return dttDadosMovEst;
        }
    }
}
