using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjossSystem.Metodos
{
    public class ModuloUsuarios
    {
        /// <summary>
        /// Método que valida se o usuario informado é válido
        /// </summary>
        /// <param name="pUsuario">Código do Usuario (é o CodigoFuncionario)</param>
        /// <param name="pSenha">Senha do usuario</param>
        /// <param name="pCargo">Cargo que ele ocupa</param>
        /// <param name="pErro">Mensagem de erro</param>
        /// <returns>True caso validar com sucesso, false caso o contrario</returns>
        public bool ValidarUsuario(int pUsuario, string pSenha, ref int pCargo, out string pErro)
        {
            try
            {
                tjossEntities objConexao = new tjossEntities();

                usuarios objUsuario = objConexao.usuarios.Where(u => u.codigofuncionario == pUsuario).FirstOrDefault();
                if (objUsuario == null)
                {
                    pErro = $"Usuario:{pUsuario} não cadastrado!";
                    return false;
                }
                if (objUsuario.senha != pSenha)
                {
                    pErro = $"Senha Inválida!";
                    return false;
                }

                pErro = string.Empty;
                pCargo = objConexao.funcionarios.Where(c => c.codigofuncionario == pUsuario).FirstOrDefault().codigocargo;
                return true;
            }
            catch(Exception pEx)
            {
                pErro = $"Erro ao Validar Usuario!{Environment.NewLine}{pEx.InnerException.Message}";
                return false;
            }
        }
    }
}
