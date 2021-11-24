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
    public partial class FrmRelatorioCadastro : FrmPadrao
    {
        DataTable dttCadastro = new DataTable();

        public FrmRelatorioCadastro()
        {
            InitializeComponent();
        }

        private void FrmRelatorioCadastro_Load(object sender, EventArgs e)
        {
            dttCadastro = GerarDados();
            VizualizadorRelatorio.LocalReport.DataSources.Clear();
            VizualizadorRelatorio.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Cadastro", dttCadastro));
            this.VizualizadorRelatorio.RefreshReport();
        }

        private DataTable GerarDados()
        {
            var dttDadosCadastro = new DataTable();
            //tjossEntities objConexão = new tjossEntities();
            Metodos.Metodos objMetodos = new Metodos.Metodos();

            dttDadosCadastro.Columns.Add("CodigoCadastro");
            dttDadosCadastro.Columns.Add("NomeCadastro");
            dttDadosCadastro.Columns.Add("NomeFantasia");
            dttDadosCadastro.Columns.Add("CodigoTipoCadastro");
            dttDadosCadastro.Columns.Add("CpfCnpj");
            dttDadosCadastro.Columns.Add("Controle");
            dttDadosCadastro.Columns.Add("DatahAlteracao");
            dttDadosCadastro.Columns.Add("CodigoFuncionario");

            List<CadastroDI> lstCadastro = new List<CadastroDI>();
            lstCadastro = objMetodos.ListarCadastrosRelatorio();

            foreach (var cad in lstCadastro)
            {
                dttDadosCadastro.Rows.Add(cad.CodigoCadastro, 
                                          cad.NomeCadastro, 
                                          cad.NomeFantasia, 
                                          cad.CodigoTipoCadastro, 
                                          cad.CpfCnpj, 
                                          cad.Controle, 
                                          cad.DatahAlteracao, 
                                          cad.CodigoFuncionario);
            }

            return dttDadosCadastro;
        }
    }
}
