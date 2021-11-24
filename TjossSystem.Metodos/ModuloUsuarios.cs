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

        /// <summary>
        /// Método que busca os cargos cadastrados no sistema
        /// </summary>
        /// <param name="pCodigoCargo">Código do cargo</param>
        /// <returns>Retorna um objeto com os dados do cargo</returns>
        public CargoFuncionarioDI ConsultarCargo(int pCodigoCargo)
        {
            tjossEntities objConexao = new tjossEntities();
            cargofuncionario objCargo = new cargofuncionario();

            CargoFuncionarioDI objCargoDI;

            try
            {
                objCargo = objConexao.cargofuncionario.Where(c => c.codigocargo == pCodigoCargo && c.codigocargo != 0).FirstOrDefault();
                if (objCargo == null)
                {
                    //retornar
                    return null;
                }

                objCargoDI = new CargoFuncionarioDI
                {
                    CodigoCargo = objCargo.codigocargo,
                    DescricaoCargo = objCargo.descricaocargo,
                    SituacaoCargo = objCargo.situacao
                };

                return objCargoDI;
            }
            catch (Exception pE)
            {
                string strErro = pE.InnerException.InnerException.Message;
                return null;
            }
        }

        /// <summary>
        /// Metodo que lista todos os cargos registrados
        /// </summary>
        /// <returns>Retorna uma lista de cargos</returns>
        public List<CargoFuncionarioDI> ListarCargos()
        {
            tjossEntities objConexao = new tjossEntities();
            List<CargoFuncionarioDI> lstCargoDI = new List<CargoFuncionarioDI>();

            List<cargofuncionario> lstCargo = objConexao.cargofuncionario.Where(c => c.codigocargo != 0).ToList();

            if (lstCargo.Count > 0)
            {
                CargoFuncionarioDI objCargoDI;
                foreach (var objCargo in lstCargo)
                {
                    objCargoDI = new CargoFuncionarioDI { CodigoCargo = objCargo.codigocargo, DescricaoCargo = $"{objCargo.codigocargo} - {objCargo.descricaocargo}" };
                    lstCargoDI.Add(objCargoDI);
                }

                return lstCargoDI;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Método que registrar cargo do funcionarios do banco de dados
        /// </summary>
        /// <param name="pCargoFuncionarioDI">Objeto com os dados do cargo</param>
        /// <param name="pErro">Mensagem de erro</param>
        /// <returns>True se registrar com sucesso, false caso o contrario</returns>
        public bool RegistrarCargo(CargoFuncionarioDI pCargoFuncionarioDI, out string pErro)
        {
            tjossEntities objConexao = new tjossEntities();
            cargofuncionario objCargo = new cargofuncionario();
            bool blnNovoCargo = false;
            int intCodigoCargo = 0;

            try
            {
                objCargo = objConexao.cargofuncionario.Where(c => c.codigocargo == pCargoFuncionarioDI.CodigoCargo && c.codigocargo != 0).FirstOrDefault();

                if (objCargo == null)
                {
                    objCargo = new cargofuncionario();
                    blnNovoCargo = true;
                    intCodigoCargo = objConexao.cargofuncionario.OrderByDescending(il => il.codigocargo).FirstOrDefault() != null ?
                                        objConexao.cargofuncionario.OrderByDescending(il => il.codigocargo).FirstOrDefault().codigocargo + 1 : 1;
                    objCargo.codigocargo = intCodigoCargo;
                }

                objCargo.descricaocargo = pCargoFuncionarioDI.DescricaoCargo;
                objCargo.situacao = pCargoFuncionarioDI.SituacaoCargo;

                if (blnNovoCargo)
                {
                    objConexao.cargofuncionario.Add(objCargo);
                }

                objConexao.SaveChanges();
                pErro = string.Empty;
                return true;
            }
            catch (Exception pEx)
            {
                pErro = $"Exceção ao executar o metodo RegistrarCargo.{Environment.NewLine}{pEx.InnerException.InnerException}";
                return false;
            }
        }

        /// <summary>
        /// Método que registrar os funcionarios no banco de dados
        /// </summary>
        /// <param name="pFuncionarioDI">Objeto com os dados do funcionario</param>
        /// <param name="pErro">Mensagem de erro</param>
        /// <returns>True se registrar com sucesso, false caso o contrario</returns>
        public bool RegistrarFuncionario(FuncionarioDI pFuncionarioDI, out string pErro)
        {
            tjossEntities objConexao = new tjossEntities();
            funcionarios objFuncionarios = new funcionarios();
            bool blnNovoFuncionario = false;
            int intCodigoFuncionario = 0;

            try
            {
                objFuncionarios = objConexao.funcionarios.Where(c => c.codigofuncionario == pFuncionarioDI.CodigoFuncionario && c.codigofuncionario != 0).FirstOrDefault();

                if (objFuncionarios == null)
                {
                    objFuncionarios = new funcionarios();
                    blnNovoFuncionario = true;
                    intCodigoFuncionario = objConexao.funcionarios.OrderByDescending(il => il.codigofuncionario).FirstOrDefault() != null ?
                                           objConexao.funcionarios.OrderByDescending(il => il.codigofuncionario).FirstOrDefault().codigofuncionario + 1 : 1;
                    objFuncionarios.codigofuncionario = intCodigoFuncionario;
                }

                objFuncionarios.nome = pFuncionarioDI.Nome;
                objFuncionarios.cpf = pFuncionarioDI.Cpf;
                objFuncionarios.cpfcontrole = pFuncionarioDI.CpfControle;
                objFuncionarios.datanascimento = pFuncionarioDI.DataNascimento;
                objFuncionarios.dataadmissao = pFuncionarioDI.DataAdmissao;
                objFuncionarios.datadesligamento = pFuncionarioDI.DataDesligamento;
                objFuncionarios.codigocargo = pFuncionarioDI.CodigoCargo;

                if (blnNovoFuncionario)
                {
                    objConexao.funcionarios.Add(objFuncionarios);
                }

                objConexao.SaveChanges();
                pErro = string.Empty;
                return true;
            }
            catch (Exception pEx)
            {
                pErro = $"Exceção ao executar o metodo RegistrarFuncionario.{Environment.NewLine}{pEx.InnerException.InnerException}";
                return false;
            }
        }

        /// <summary>
        /// Método que busca as informações do funcionario
        /// </summary>
        /// <param name="pCodigoFuncionario">Código do funcionario</param>
        /// <returns>Retorna um objeto com os dados do funcionario</returns>
        public FuncionarioDI ConsultarFuncionario(int pCodigoFuncionario)
        {
            tjossEntities objConexao = new tjossEntities();
            funcionarios objFuncionario = new funcionarios();

            FuncionarioDI objFuncionarioDI;

            try
            {
                objFuncionario = objConexao.funcionarios.Where(c => c.codigofuncionario == pCodigoFuncionario && c.codigofuncionario != 0).FirstOrDefault();
                if (objFuncionario == null)
                {
                    //retornar
                    return null;
                }

                objFuncionarioDI = new FuncionarioDI
                {
                    CodigoFuncionario = objFuncionario.codigofuncionario,
                    Nome = objFuncionario.nome,
                    Cpf = objFuncionario.cpf,
                    CpfControle = objFuncionario.cpfcontrole,
                    DataNascimento = objFuncionario.datanascimento,
                    DataAdmissao = objFuncionario.dataadmissao,
                    DataDesligamento = objFuncionario.datadesligamento,
                    CodigoCargo = objFuncionario.codigocargo
                };

                return objFuncionarioDI;
            }
            catch (Exception pE)
            {
                string strErro = pE.InnerException.InnerException.Message;
                return null;
            }
        }

        /// <summary>
        /// Método que registrar os usuarios no banco de dados
        /// </summary>
        /// <param name="pUsuarioDI">Objeto com os dados do usuario</param>
        /// <param name="pErro">Mensagem de erro</param>
        /// <returns>True se registrar com sucesso, false caso o contrario</returns>
        public bool RegistrarUsuario(UsuarioDI pUsuarioDI, out string pErro)
        {
            tjossEntities objConexao = new tjossEntities();
            usuarios objUsuario = new usuarios();
            bool blnNovoUsuario = false;
            int intCodigoUsuario = 0;

            try
            {
                objUsuario = objConexao.usuarios.Where(c => c.codigofuncionario == pUsuarioDI.CodigoFuncionario && c.codigofuncionario != 0).FirstOrDefault();

                if (objUsuario == null)
                {
                    objUsuario = new usuarios();
                    blnNovoUsuario = true;
                    intCodigoUsuario = pUsuarioDI.CodigoFuncionario;/*objConexao.funcionarios.OrderByDescending(il => il.codigofuncionario).FirstOrDefault() != null ?
                                       objConexao.funcionarios.OrderByDescending(il => il.codigofuncionario).FirstOrDefault().codigofuncionario + 1 : 1;*/
                    objUsuario.codigofuncionario = intCodigoUsuario;
                    objUsuario.datahcadastro = pUsuarioDI.DatahCadastro;
                }

                objUsuario.senha = pUsuarioDI.Senha;

                if (blnNovoUsuario)
                {
                    objConexao.usuarios.Add(objUsuario);
                }

                objConexao.SaveChanges();
                pErro = string.Empty;
                return true;
            }
            catch (Exception pEx)
            {
                pErro = $"Exceção ao executar o metodo RegistrarUsuario.{Environment.NewLine}{pEx.InnerException.InnerException}";
                return false;
            }
        }

        /// <summary>
        /// Método que busca as informações do usuario
        /// </summary>
        /// <param name="pCodigoFuncionario">Código do funcionario</param>
        /// <returns>Retorna um objeto com os dados do usuario</returns>
        public UsuarioDI ConsultarUsuario(int pCodigoFuncionario)
        {
            tjossEntities objConexao = new tjossEntities();
            usuarios objUsuario = new usuarios();

            UsuarioDI objUsuarioDI;

            try
            {
                objUsuario = objConexao.usuarios.Where(c => c.codigofuncionario == pCodigoFuncionario && c.codigofuncionario != 0).FirstOrDefault();
                if (objUsuario == null)
                {
                    //retornar
                    return null;
                }

                objUsuarioDI = new UsuarioDI
                {
                    CodigoFuncionario = objUsuario.codigofuncionario,
                    Senha = objUsuario.senha,
                    DatahCadastro = objUsuario.datahcadastro
                };

                return objUsuarioDI;
            }
            catch (Exception pE)
            {
                string strErro = pE.InnerException.InnerException.Message;
                return null;
            }
        }

        /// <summary>
        /// Metodo que lista todos os funcionarios registrados
        /// </summary>
        /// <returns>Retorna uma lista de funcionarios</returns>
        public List<FuncionarioDI> ListarFuncionariosRelatorio()
        {
            tjossEntities objConexao = new tjossEntities();
            List<FuncionarioDI> lstFuncionariosDI = new List<FuncionarioDI>();

            List<funcionarios> lstFuncionarios = objConexao.funcionarios.Where(c => c.codigofuncionario != 0).OrderBy(o => o.codigofuncionario).ToList();

            if (lstFuncionarios.Count > 0)
            {
                FuncionarioDI objFuncionarioDI;
                foreach (var objFuncionario in lstFuncionarios)
                {
                    objFuncionarioDI = new FuncionarioDI
                    {
                        CodigoFuncionario = objFuncionario.codigofuncionario,
                        Nome = objFuncionario.nome,
                        Cpf = objFuncionario.cpf,
                        CpfControle = objFuncionario.cpfcontrole,
                        DataNascimento = objFuncionario.datanascimento,
                        DataAdmissao = objFuncionario.dataadmissao,
                        DataDesligamento = objFuncionario.datadesligamento,
                        CodigoCargo = objFuncionario.codigocargo
                    };
                    lstFuncionariosDI.Add(objFuncionarioDI);
                }

                return lstFuncionariosDI;
            }
            else
            {
                return null;
            }
        }
    }
}
