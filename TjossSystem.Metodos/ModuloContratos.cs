using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjossSystem.Metodos
{
    public class ModuloContratos
    {
        /// <summary>
        /// Método que consulta todas os tipos de contratos cadastradas
        /// </summary>
        /// <returns>Retorna uma lisca com os tipos de contratos</returns>
        public List<TipoContratoDI> ListarTiposContrato()
        {
            tjossEntities objConexao = new tjossEntities();
            List<TipoContratoDI> lstTipoContratoDI = new List<TipoContratoDI>();

            List<tipocontrato> lstTipoContrato = objConexao.tipocontrato.ToList();

            if (lstTipoContrato.Count > 0)
            {
                TipoContratoDI objTipoContratoDI;
                foreach (var objTipoPedido in lstTipoContrato)
                {
                    objTipoContratoDI = new TipoContratoDI
                    {
                        CodigoTipoContrato = objTipoPedido.codigotipocontrato,
                        DescricaoComboBox = $"{objTipoPedido.codigotipocontrato} - {objTipoPedido.descricaotipocontrato}",
                        DescricaoTipoContrato = objTipoPedido.descricaotipocontrato,
                        SituacaoTipoContrato = objTipoPedido.situacao
                    };

                    lstTipoContratoDI.Add(objTipoContratoDI);
                }

                return lstTipoContratoDI;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Método que busca item do contrato
        /// </summary>
        /// <param name="pNumeroContrato">Número do contrato</param>
        /// <param name="pCodigoTipoContrato">Código tipo do contrato</param>
        /// <param name="pCodigoItem">Código do item</param>
        /// <returns>Retorna um objeto com os dados registrados</returns>
        public ItensContratoDI BuscarItemDoContrato(int pNumeroContrato, int pCodigoTipoContrato, int pCodigoItem)
        {
            tjossEntities objConexao = new tjossEntities();
            itenscontrato objItemContrato = new itenscontrato();

            ItensContratoDI objItemContratoDI;

            try
            {
                objItemContrato = objConexao.itenscontrato.Where(c => c.numerocontrato == pNumeroContrato && c.codigotipocontrato == pCodigoTipoContrato &&
                                                                      (c.codigoitem == pCodigoItem && c.codigoitem != 0)).FirstOrDefault();
                if (objItemContrato == null)
                {
                    //retornar
                    return null;
                }

                objItemContratoDI = new ItensContratoDI
                {
                    NumeroContrato = objItemContrato.numerocontrato,
                    CodigoTipoContrato = objItemContrato.codigotipocontrato,
                    CodigoItem = objItemContrato.codigoitem,
                    SaldoContratado = objItemContrato.saldocontratado,
                    SaldoAtual = objItemContrato.saldoatual,
                    ValorItem = objItemContrato.valoritem
                };

                return objItemContratoDI;
            }
            catch (Exception pE)
            {
                string strErro = pE.InnerException.InnerException.Message;
                return null;
            }
        }

        /// <summary>
        /// Método que busca itens do contrato
        /// </summary>
        /// <param name="pNumeroContrato">Número do contrato</param>
        /// <param name="pCodigoTipoContrato">Código tipo do contrato</param>
        /// <returns>Retorna uma lista com os dados registrados</returns>
        public List<ItensContratoDI> BuscarItensContrato(int pNumeroContrato, int pCodigoTipoContrato)
        {
            tjossEntities objConexao = new tjossEntities();
            List<itenscontrato> lstItensContrato = new List<itenscontrato>();

            ItensContratoDI objItensContratoDI;
            List<ItensContratoDI> lstItensContratoDI = new List<ItensContratoDI>();

            try
            {
                lstItensContrato = objConexao.itenscontrato.Where(p => pNumeroContrato > 0 ? p.numerocontrato == pNumeroContrato : 1 == 1 &&
                                                                   pCodigoTipoContrato > 0 ? p.codigotipocontrato == pCodigoTipoContrato : 1 == 1).ToList();

                foreach (var objItensContrato in lstItensContrato)
                {
                    objItensContratoDI = new ItensContratoDI
                    {
                        NumeroContrato = objItensContrato.numerocontrato,
                        CodigoTipoContrato = objItensContrato.codigotipocontrato,
                        CodigoItem = objItensContrato.codigoitem,
                        SaldoContratado = objItensContrato.saldocontratado,
                        SaldoAtual = objItensContrato.saldoatual,
                        ValorItem = objItensContrato.valoritem
                    };

                    lstItensContratoDI.Add(objItensContratoDI);
                }

                return lstItensContratoDI;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Método que busca os contratos não cancelados e sem vinculo com pedido
        /// </summary>
        /// <param name="pNumeroContrato">Número do contrato</param>
        /// <param name="pCodigoTipoContrato">Código tipo do contrato</param>
        /// <param name="pCodigoCadastro">Código do item</param>
        /// <returns>Retorna uma lista com os dados registrados</returns>
        public List<ContratoDI> ListarContratos(int pNumeroContrato, int pCodigoTipoContrato, int? pCodigoCadastro)
        {
            tjossEntities objConexao = new tjossEntities();
            List<contrato> lstContratos = new List<contrato>();

            ContratoDI objContratoDI;
            List<ContratoDI> lstContratoDI = new List<ContratoDI>();

            try
            {
                DateTime dtaDataVencimento = DateTime.Now.Date;
                lstContratos = objConexao.contrato.Where(p => (pNumeroContrato > 0 ? p.numerocontrato == pNumeroContrato : 1 == 1) &&
                                                           (pCodigoTipoContrato > 0 ? p.codigotipocontrato == pCodigoTipoContrato : 1 == 1) &&
                                                           (pCodigoCadastro > 0 ? p.codigocadastro == pCodigoCadastro : 1 == 1) &&
                                                           p.situacao != "C" &&
                                                           p.datavencimento >= dtaDataVencimento).ToList();

                foreach (var objContrato in lstContratos)
                {
                    //Só retorna contratos sem vinculo com pedidos.
                    pedidos objPedido = objConexao.pedidos.Where(p => p.numerocontrato == objContrato.numerocontrato && p.codigotipocontrato == objContrato.codigotipocontrato).FirstOrDefault();

                    if(objPedido == null)
                    {
                        objContratoDI = new ContratoDI
                        {
                            NumeroContrato = objContrato.numerocontrato,
                            CodigoTipoContrato = objContrato.codigotipocontrato,
                            CodigoCadastro = objContrato.codigocadastro,
                            DataContrato = objContrato.datacontrato,
                            DataVencimento = objContrato.datavencimento,
                            SituacaoContrato = objContrato.situacao,
                            CodigoVendedor = objContrato.codigovendedor,
                            DatahAlteracao = objContrato.datahalteracao,
                            CodigoFuncionario = objContrato.codigofuncionario
                        };

                        lstContratoDI.Add(objContratoDI);
                    }
                }

                return lstContratoDI;
            }
            catch(Exception pEx)
            {
                string strErro = pEx.InnerException.Message;
                return null;
            }

        }


        /// <summary>
        /// Método que faz o fechamento do contrato
        /// </summary>
        /// <param name="pContrato">Objeto com os dados do contrato</param>
        /// <param name="pErro">Mensagem de erro</param>
        /// <returns>True se fechou com sucesso, false caso o contrario</returns>
        public bool FecharContrato(ContratoDI pContrato, out string pErro)
        {
            tjossEntities objConexao = new tjossEntities();
            contrato objContrato = new contrato();
            itenscontrato objItensContrato = new itenscontrato();

            try
            {
                if (pContrato.SituacaoContrato != "F")
                {
                    pErro = $"Contrato tem que estar em fechamento!";
                    return false;
                }

                objContrato = objConexao.contrato.Where(c => c.numerocontrato == pContrato.NumeroContrato && c.codigotipocontrato == pContrato.CodigoTipoContrato && c.situacao == "A").FirstOrDefault();

                if (objContrato == null)
                {
                    objContrato = null;
                    pErro = $"Contrato não está valido!";
                    return false;
                }

                objContrato.situacao = pContrato.SituacaoContrato;
                objContrato.datahalteracao = DateTime.Now;
                objContrato.codigofuncionario = pContrato.CodigoFuncionario;

                //Pega o numero do pedido que foi gerado pelo auto-increment.
                int intNumeroContrato = objContrato.numerocontrato;

                if (objContrato.itenscontrato.Count <= 0)
                {
                    pErro = $"Contrato tem ter mais de um item!";
                    return false;
                }

                foreach (var objItemContratoDI in objContrato.itenscontrato)
                {
                    objItensContrato = objConexao.itenscontrato.Where(ip => ip.numerocontrato == intNumeroContrato &&
                                                                            ip.codigotipocontrato == pContrato.CodigoTipoContrato &&
                                                                            ip.codigoitem == objItemContratoDI.codigoitem).FirstOrDefault();
                    if (objItensContrato == null)
                    {
                        objItensContrato = null;
                        pErro = $"Itens do Contrato não estão validos!";
                        return false;
                    }

                    objItensContrato.saldoatual = objItensContrato.saldocontratado;
                }

                objConexao.SaveChanges();
                pErro = string.Empty;
                return true;
            }
            catch (Exception pEx)
            {
                pErro = $"Exceção ao executar o metodo FecharContrato.{Environment.NewLine}{pEx.InnerException.InnerException}";
                return false;
            }
        }

        /// <summary>
        /// Método que faz o cancelamento do contrato
        /// </summary>
        /// <param name="pContrato">Objeto com os dados do contrato</param>
        /// <param name="pErro">Mensagem de erro</param>
        /// <returns>True se cancelou com sucesso, false caso o contrario</returns>
        public bool CancelarContrato(ContratoDI pContrato, out string pErro)
        {
            tjossEntities objConexao = new tjossEntities();
            contrato objContratos = new contrato();
            itenscontrato objItensContrato = new itenscontrato();

            try
            {
                if (pContrato.SituacaoContrato != "C")
                {
                    pErro = $"Metodo só pode ser chamado quando for cancelamento";
                    return false;
                }

                objContratos = objConexao.contrato.Where(c => c.numerocontrato == pContrato.NumeroContrato && c.codigotipocontrato == pContrato.CodigoTipoContrato && c.situacao != "C").FirstOrDefault();

                if (objContratos == null)
                {
                    objContratos = null;
                    pErro = $"Contrato não foi encontrado ou já foi cancelado!";
                    return false;
                }

                objContratos.situacao = pContrato.SituacaoContrato;
                objContratos.datahalteracao = DateTime.Now;
                objContratos.codigofuncionario = pContrato.CodigoFuncionario;

                objConexao.SaveChanges();

                pErro = string.Empty;
                return true;
            }
            catch (Exception pEx)
            {
                pErro = $"Exceção ao executar o metodo CancelarContrato.{Environment.NewLine}{pEx.InnerException.InnerException}";
                return false;
            }
        }

        /// <summary>
        /// Método que faz o registro do contrato
        /// </summary>
        /// <param name="pContrato">Objeto com os dados do contrato</param>
        /// <param name="pErro">Mensagem de erro</param>
        /// <returns>True se registrou com sucesso, false caso o contrario</returns>
        public bool RegistrarContrato(ContratoDI pContrato, out string pErro)
        {
            tjossEntities objConexao = new tjossEntities();
            contrato objContrato = new contrato();
            itenscontrato objItensContrato = new itenscontrato();
            bool blnNovoContrato = false;
            int intNumeroContrato = 0;

            try
            {
                objContrato = objConexao.contrato.Where(c => c.numerocontrato == pContrato.NumeroContrato && c.codigotipocontrato == pContrato.CodigoTipoContrato).FirstOrDefault();

                if (objContrato == null)
                {
                    objContrato = new contrato();
                    blnNovoContrato = true;
                    intNumeroContrato = objConexao.contrato.Where(c => c.codigotipocontrato == pContrato.CodigoTipoContrato).OrderByDescending(il => il.numerocontrato).FirstOrDefault() != null ?
                                        objConexao.contrato.Where(c => c.codigotipocontrato == pContrato.CodigoTipoContrato).OrderByDescending(il => il.numerocontrato).FirstOrDefault().numerocontrato + 1 : 1;
                    objContrato.numerocontrato = intNumeroContrato;
                    objContrato.codigotipocontrato = pContrato.CodigoTipoContrato;
                }

                objContrato.codigocadastro = pContrato.CodigoCadastro;
                objContrato.datacontrato = pContrato.DataContrato;
                objContrato.datavencimento = pContrato.DataVencimento;
                objContrato.situacao = pContrato.SituacaoContrato;
                //null se não for com contrato vinculado.
                objContrato.codigovendedor = pContrato.CodigoVendedor <= 0 ? null : pContrato.CodigoVendedor;
                objContrato.datahalteracao = pContrato.DatahAlteracao;
                objContrato.codigofuncionario = pContrato.CodigoFuncionario;

                if (blnNovoContrato)
                {
                    objConexao.contrato.Add(objContrato);
                }

                bool blnNovoItemContrato = false;
                foreach (var objItemContratoDI in pContrato.ItensContrato)
                {
                    blnNovoItemContrato = false;
                    objItensContrato = objConexao.itenscontrato.Where(ip => ip.numerocontrato == intNumeroContrato &&
                                                                            ip.codigotipocontrato == pContrato.CodigoTipoContrato &&
                                                                            ip.codigoitem == objItemContratoDI.CodigoItem).FirstOrDefault();
                    if (objItensContrato == null)
                    {
                        objItensContrato = new itenscontrato();
                        blnNovoItemContrato = true;
                        objItensContrato.numerocontrato = intNumeroContrato;
                        objItensContrato.codigotipocontrato = pContrato.CodigoTipoContrato;
                        objItensContrato.codigoitem = objItemContratoDI.CodigoItem;
                    }

                    objItensContrato.saldocontratado = objItemContratoDI.SaldoContratado;
                    objItensContrato.saldoatual = objItemContratoDI.SaldoAtual;
                    objItensContrato.valoritem = objItemContratoDI.ValorItem;

                    if (blnNovoItemContrato)
                    {
                        objConexao.itenscontrato.Add(objItensContrato);
                    }

                    objConexao.SaveChanges();
                }

                pErro = string.Empty;
                return true;
            }
            catch (Exception pEx)
            {
                pErro = $"Exceção ao executar o metodo RegistrarContrato.{Environment.NewLine}{pEx.InnerException.InnerException}";
                return false;
            }
        }
    }
}
