using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjossSystem.Metodos
{
    public class Metodos
    {
        public bool RegistrarCadastro(int pCodigoCadastro, string pNomeCadastro, string pNomeFantasia, int pCodigoTipoCadastro, int pCpfCnpj, int pControle, out string pErro)
        {
            Conexao objConexao = new Conexao("public");
            Cadastro objCadastro = new Cadastro();
            bool blnNovo = false;
            try
            {
                objCadastro = objConexao.Cadastro.Where(c => c.codigocadastro == pCodigoCadastro && c.codigocadastro != 0).FirstOrDefault();

                if (objCadastro == null)
                {
                    objCadastro = new Cadastro();
                    blnNovo = true;
                    objCadastro.codigocadastro = objConexao.Cadastro.Where(c => c.codigocadastro == pCodigoCadastro).FirstOrDefault().codigocadastro != 0 ? objConexao.Cadastro.Where(c => c.codigocadastro == pCodigoCadastro).FirstOrDefault().codigocadastro + 1 : 1;
                }

                objCadastro.nomecadastro = pNomeCadastro;
                objCadastro.nomefantasia = pNomeFantasia;
                objCadastro.codigotipocadastro = pCodigoTipoCadastro;
                objCadastro.cpfcnpj = pCpfCnpj;
                objCadastro.controle = pControle;
                objCadastro.datahalteracao = DateTime.Now;
                objCadastro.codigofuncionario = 0; //Alterar para pegar do sistema.

                if (blnNovo)
                {
                    objConexao.Cadastro.Add(objCadastro);
                }

                objConexao.SaveChanges();
                pErro = string.Empty;
                return true;
            }
            catch(Exception pEx)
            {
                pErro = $"Exceção ao executar o metodo RegistrarCadastro.{Environment.NewLine}{pEx.InnerException.Message}";
                return false;
            }
        }

        public CadastroDI ConsultarCadastro()
        {
            return new CadastroDI();
        }
    }
}
