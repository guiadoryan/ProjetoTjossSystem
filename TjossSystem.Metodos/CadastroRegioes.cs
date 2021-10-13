using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjossSystem.Metodos
{
    public class CadastroRegioes
    {
        /// <summary>
        /// Método que Regista/Altera Estado no sistema
        /// </summary>
        /// <param name="pEstadoDI">Objeto com os dados do estado</param>
        /// <param name="pErro">Mensagem de erro</param>
        /// <returns>True caso Registrar/Alterar um estado, false caso o contrario.</returns>
        public bool RegistrarEstado(EstadoDI pEstadoDI, out string pErro)
        {
            tjossEntities objConexao = new tjossEntities();
            estado objEstado = new estado();
            bool blnNovoCadastro = false;
            int intCodigoEstado = 0;
            try
            {
                objEstado = objConexao.estado.Where(c => c.codigoestado == pEstadoDI.CodigoEstado && c.codigoestado != 0).FirstOrDefault();

                if (objEstado == null)
                {
                    objEstado = new estado();
                    blnNovoCadastro = true;
                    intCodigoEstado = objConexao.estado.OrderByDescending(il => il.codigoestado).FirstOrDefault() != null ?
                                        objConexao.estado.OrderByDescending(il => il.codigoestado).FirstOrDefault().codigoestado + 1 : 1;
                    objEstado.codigoestado = intCodigoEstado;
                }

                objEstado.nomeestado = pEstadoDI.DescricaoEstado;
                objEstado.siglaestado = pEstadoDI.SiglaEstado;
                objEstado.codigopais = pEstadoDI.CodigoPaisEst;

                if (blnNovoCadastro)
                {
                    objConexao.estado.Add(objEstado);
                }

                objConexao.SaveChanges();
                pErro = string.Empty;
                return true;
            }
            catch (Exception pEx)
            {
                pErro = $"Exceção ao executar o metodo RegistrarEstado.{Environment.NewLine}{pEx.InnerException.InnerException}";
                return false;
            }
        }

        /// <summary>
        /// Método que Regista/Altera Cidade no sistema
        /// </summary>
        /// <param name="pCidadeDI">Objeto com os dados da cidade</param>
        /// <param name="pErro">Mensagem de erro</param>
        /// <returns>True caso Registrar/Alterar uma cidade, false caso o contrario.</returns>
        public bool RegistrarCidade(CidadeDI pCidadeDI, out string pErro)
        {
            tjossEntities objConexao = new tjossEntities();
            cidade objCidade = new cidade();
            bool blnNovaCidade = false;
            int intCodigoCidade = 0;
            try
            {
                objCidade = objConexao.cidade.Where(c => c.codigocidade == pCidadeDI.CodigoCidade && c.codigocidade != 0).FirstOrDefault();

                if (objCidade == null)
                {
                    objCidade = new cidade();
                    blnNovaCidade = true;
                    intCodigoCidade = objConexao.cidade.OrderByDescending(il => il.codigocidade).FirstOrDefault() != null ?
                                      objConexao.cidade.OrderByDescending(il => il.codigocidade).FirstOrDefault().codigocidade + 1 : 1;
                    objCidade.codigocidade = intCodigoCidade;
                }

                objCidade.nomecidade = pCidadeDI.DescricaoCidade;
                objCidade.siglacidade = pCidadeDI.SiglaCidade;
                objCidade.codigoestado = pCidadeDI.CodigoEstadoCit;

                if (blnNovaCidade)
                {
                    objConexao.cidade.Add(objCidade);
                }

                objConexao.SaveChanges();
                pErro = string.Empty;
                return true;
            }
            catch (Exception pEx)
            {
                pErro = $"Exceção ao executar o metodo RegistrarCidade.{Environment.NewLine}{pEx.InnerException.InnerException}";
                return false;
            }
        }

        /// <summary>
        /// Método que busca os dados do Estado
        /// </summary>
        /// <param name="pCodigoEstado">Código do estado</param>
        /// <returns>Retorna um objeto com todos os dados do estado</returns>
        public EstadoDI ConsultarEstado(int pCodigoEstado)
        {
            tjossEntities objConexao = new tjossEntities();
            estado objEstado = new estado();

            EstadoDI objEstadoDI;

            try
            {
                objEstado = objConexao.estado.Where(c => c.codigoestado == pCodigoEstado && c.codigoestado != 0).FirstOrDefault();
                if (objEstado == null)
                {
                    //retornar
                    return new EstadoDI();
                }

                objEstadoDI = new EstadoDI
                {
                    CodigoEstado = objEstado.codigoestado,
                    DescricaoEstado = objEstado.nomeestado,
                    SiglaEstado = objEstado.siglaestado,
                    CodigoPaisEst = objEstado.codigopais
                };

                return objEstadoDI;
            }
            catch (Exception pE)
            {
                string strErro = pE.InnerException.InnerException.Message;
                return null;
            }
        }

        /// <summary>
        /// Método que busca os dados do Cidade
        /// </summary>
        /// <param name="pCodigoCidade">Código da cidade</param>
        /// <returns>Retorna um objeto com todos os dados da cidade</returns>
        public CidadeDI ConsultarCidade(int pCodigoCidade)
        {
            tjossEntities objConexao = new tjossEntities();
            cidade objCidade = new cidade();

            CidadeDI objCidadeDI;

            try
            {
                objCidade = objConexao.cidade.Where(c => c.codigocidade == pCodigoCidade && c.codigocidade != 0).FirstOrDefault();
                if (objCidade == null)
                {
                    //retornar
                    return new CidadeDI();
                }

                objCidadeDI = new CidadeDI
                {
                    CodigoCidade = objCidade.codigocidade,
                    DescricaoCidade = objCidade.nomecidade,
                    SiglaCidade = objCidade.siglacidade,
                    CodigoEstadoCit = objCidade.codigoestado
                };

                return objCidadeDI;
            }
            catch (Exception pE)
            {
                string strErro = pE.InnerException.InnerException.Message;
                return null;
            }
        }
    }
}
