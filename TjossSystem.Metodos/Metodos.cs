using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjossSystem.Metodos
{
    public class Metodos
    {
        public bool RegistrarCadastro(int pCodigoCadastro, string pNomeCadastro, out string pErro)
        {
            Conexao objConexao = new Conexao("public");
            Cadastro objCadastro = new Cadastro();
            bool blnNovo = false;
            try
            {
                objCadastro = objConexao.Cadastro.Where(c => c.codigocadastro == pCodigoCadastro).FirstOrDefault();

                if (objCadastro == null)
                {
                    objCadastro = new Cadastro();
                    blnNovo = true;
                    objCadastro.codigocadastro = objConexao.Cadastro.Where(c => c.codigocadastro == pCodigoCadastro).FirstOrDefault().codigocadastro != 0 ? objConexao.Cadastro.Where(c => c.codigocadastro == pCodigoCadastro).FirstOrDefault().codigocadastro + 1 : 1;
                }

                objCadastro.nomecadastro = "Guilherme Adoryan";
                objCadastro.nomefantasia = "Guilherme A";
                objCadastro.codigotipocadastro = 1;
                objCadastro.datahalteracao = DateTime.Now;
                objCadastro.codigofuncionario = 0;

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
                pErro = $"Exceção ao executar o metodo RegistrarCadastro. {pEx.InnerException.Message}";
                return false;
            }
        }
    }
}
