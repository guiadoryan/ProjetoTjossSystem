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
    public partial class FrmRelatorioFuncionario : FrmPadrao
    {
        DataTable dttFuncionarios = new DataTable();

        public FrmRelatorioFuncionario()
        {
            InitializeComponent();
        }

        private void FrmRelatorioFuncionario_Load(object sender, EventArgs e)
        {
            dttFuncionarios = GerarDados();
            VizualizadorRelatorio.LocalReport.DataSources.Clear();
            VizualizadorRelatorio.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Funcionario", dttFuncionarios));
            this.VizualizadorRelatorio.RefreshReport();
        }

        private DataTable GerarDados()
        {
            var dttDadosFuncionario = new DataTable();
            //tjossEntities objConexão = new tjossEntities();
            ModuloUsuarios objModuloUsuarios = new ModuloUsuarios();

            dttDadosFuncionario.Columns.Add("CodigoFuncionario");
            dttDadosFuncionario.Columns.Add("Nome");
            dttDadosFuncionario.Columns.Add("Cpf");
            dttDadosFuncionario.Columns.Add("CpfControle");
            dttDadosFuncionario.Columns.Add("DataNascimento");
            dttDadosFuncionario.Columns.Add("DataAdmissao");
            dttDadosFuncionario.Columns.Add("DataDesligamento");
            dttDadosFuncionario.Columns.Add("CodigoCargo");

            List<FuncionarioDI> lstFuncionariosDI = new List<FuncionarioDI>();
            lstFuncionariosDI = objModuloUsuarios.ListarFuncionariosRelatorio();

            foreach (var cad in lstFuncionariosDI)
            {
                dttDadosFuncionario.Rows.Add(cad.CodigoFuncionario,
                                             cad.Nome,
                                             cad.Cpf,
                                             cad.CpfControle,
                                             cad.DataNascimento,
                                             cad.DataAdmissao,
                                             cad.DataDesligamento,
                                             cad.CodigoCargo);
            }

            return dttDadosFuncionario;
        }
    }
}
