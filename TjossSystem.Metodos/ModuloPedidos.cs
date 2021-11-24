using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjossSystem.Metodos
{
    public class ModuloPedidos
    {
        /// <summary>
        /// Método que faz o fechamento do pedido
        /// </summary>
        /// <param name="pPedido">Objeto com os dados do pedido</param>
        /// <param name="pCodigoFuncionario">Código do funcionario</param>
        /// <param name="pErro">Mensagem de erro</param>
        /// <returns>True se fechou com sucesso, false caso o contrario</returns>
        public bool FecharPedido(PedidoDI pPedido, int pCodigoFuncionario, out string pErro)
        {
            tjossEntities objConexao = new tjossEntities();
            pedidos objPedidos = new pedidos();
            itenspedido objItensPedido = new itenspedido();
            List<MovimentacaoEstoqueDI> lstMovimentoEstoqueDI = new List<MovimentacaoEstoqueDI>();

            try
            {
                if (pPedido.SituacaoPedido != "F")
                {
                    pErro = $"Pedido tem que estar em fechamento!";
                    return false;
                }

                objPedidos = objConexao.pedidos.Where(c => c.numeropedido == pPedido.NumeroPedido && c.codigotipopedido == pPedido.CodigoTipoPedido && c.situacaopedido == "A").FirstOrDefault();

                if (objPedidos == null)
                {
                    objPedidos = null;
                    pErro = $"Pedido não está valido!";
                    return false;                    
                }

                objPedidos.situacaopedido = pPedido.SituacaoPedido;
                objPedidos.dataconclusao = DateTime.Now.Date;

                //Pega o numero do pedido que foi gerado pelo auto-increment.
                int intNumeroPedido = objPedidos.numeropedido;

                if (objPedidos.itenspedido.Count <= 0)
                {
                    pErro = $"Pedido tem ter mais de um item!";
                    return false;
                }

                decimal decValorTotalPedido = 0;
                foreach (var objItemPedidoDI in objPedidos.itenspedido)
                {
                    objItensPedido = objConexao.itenspedido.Where(ip => ip.numeropedido == intNumeroPedido &&
                                                                  ip.codigotipopedido == pPedido.CodigoTipoPedido &&
                                                                  ip.codigoitem == objItemPedidoDI.codigoitem).FirstOrDefault();
                    if (objItensPedido == null)
                    {
                        objItensPedido = null;
                        pErro = $"Itens do Pedido não estão validos!";
                        return false;
                    }

                    objItensPedido.quantidadebaixada = objItensPedido.quantidadesolicitada;
                    objItensPedido.valortotalitem = objItemPedidoDI.valorunitario * objItemPedidoDI.quantidadebaixada;
                    decValorTotalPedido += objItensPedido.valortotalitem;

                    lstMovimentoEstoqueDI.Add(new MovimentacaoEstoqueDI
                    {
                        CodigoItem = objItemPedidoDI.codigoitem,
                        CodigoTipoEstoque = 1,
                        TipoMovimento = pPedido.CodigoTipoPedido == 1 ? "E" : "S",
                        QuantidadeMovimentada = objItemPedidoDI.quantidadebaixada,
                        DatahMovimento = DateTime.Now,
                        CodigoFuncionario = pCodigoFuncionario,
                        NumeroPedido = pPedido.NumeroPedido,
                        CodigoTipoPedido = pPedido.CodigoTipoPedido,
                        ObservacaoMovimento = $"{(pPedido.CodigoTipoPedido == 1 ? $"Entrada Pelo Pedido de compra {intNumeroPedido}" : $"Saida Pelo pedido de {(pPedido.CodigoTipoPedido == 3 ? "Aluguel" : "Venda")}")}."
                    });
                }

                if (decValorTotalPedido <= 0)
                {
                    pErro = $"Valor total do pedido é igual a zero!";
                    return false;
                }

                objPedidos.valortotalpedido = decValorTotalPedido;

                //Faz movimentacao de estoque
                foreach (var objMovimentoEstoque in lstMovimentoEstoqueDI)
                {
                    itemestoque objItemEstoque = objConexao.itemestoque.Where(i => i.codigoitem == objMovimentoEstoque.CodigoItem && i.codigotipoestoque == objMovimentoEstoque.CodigoTipoEstoque).FirstOrDefault();

                    if (objItemEstoque == null)
                    {
                        pErro = $"Item {objMovimentoEstoque.CodigoItem} não foi cadastrado, verifique!";
                        return false;
                    }

                    if(objMovimentoEstoque.TipoMovimento == "E")
                    {
                        objItemEstoque.quantidadedisponivel += objMovimentoEstoque.QuantidadeMovimentada;
                    }
                    else
                    {
                        if (objItemEstoque.quantidadedisponivel >= objMovimentoEstoque.QuantidadeMovimentada)
                        {
                            objItemEstoque.quantidadedisponivel -= objMovimentoEstoque.QuantidadeMovimentada;
                        }
                        else
                        {
                            pErro = $"Item {objMovimentoEstoque.CodigoItem} não possui estoque suficiente, verifique!";
                            return false;
                        }
                    }

                    objConexao.movimentoestoque.Add(new movimentoestoque
                    {
                        codigoitem = objMovimentoEstoque.CodigoItem,
                        codigotipoestoque = objMovimentoEstoque.CodigoTipoEstoque,
                        tipomovimento = objMovimentoEstoque.TipoMovimento,
                        quantidademovimentada = objMovimentoEstoque.QuantidadeMovimentada,
                        datahmovimento = objMovimentoEstoque.DatahMovimento,
                        codigofuncionario = objMovimentoEstoque.CodigoFuncionario,
                        numeropedido = objMovimentoEstoque.NumeroPedido,
                        codigotipopedido = objMovimentoEstoque.CodigoTipoPedido,
                        observacaomovimento = objMovimentoEstoque.ObservacaoMovimento
                    });
                }

                objConexao.SaveChanges();
                pErro = string.Empty;
                return true;
            }
            catch (Exception pEx)
            {
                pErro = $"Exceção ao executar o metodo FecharPedido.{Environment.NewLine}{pEx.InnerException.InnerException}";
                return false;
            }
        }

        /// <summary>
        /// Método que faz o cancelamento do pedido
        /// </summary>
        /// <param name="pPedido">Objeto com os dados do pedido</param>
        /// <param name="pErro">Mensagem de erro</param>
        /// <returns>True se cancelou com sucesso, false caso o contrario</returns>
        public bool CancelarPedido(PedidoDI pPedido, out string pErro)
        {
            tjossEntities objConexao = new tjossEntities();
            pedidos objPedidos = new pedidos();
            itenspedido objItensPedido = new itenspedido();
            bool blnNovoPedido = false;

            try
            {
                if (pPedido.SituacaoPedido != "C")
                {
                    pErro = $"Metodo só pode ser chamado quando for cancelamento";
                    return false;
                }

                objPedidos = objConexao.pedidos.Where(c => c.numeropedido == pPedido.NumeroPedido && c.codigotipopedido == pPedido.CodigoTipoPedido && c.situacaopedido != "C").FirstOrDefault();

                if (objPedidos == null)
                {
                    objPedidos = null;
                    pErro = $"Pedido não foi encontrado ou já foi cancelado!";
                    return false;
                }

                objPedidos.situacaopedido = pPedido.SituacaoPedido;
                objPedidos.dataconclusao = DateTime.Now.Date;

                if (blnNovoPedido)
                {
                    objConexao.pedidos.Add(objPedidos);
                }

                objConexao.SaveChanges();

                pErro = string.Empty;
                return true;
            }
            catch (Exception pEx)
            {
                pErro = $"Exceção ao executar o metodo CancelarPedido.{Environment.NewLine}{pEx.InnerException.InnerException}";
                return false;
            }
        }

        /// <summary>
        /// Método que faz o registro do pedido
        /// </summary>
        /// <param name="pPedido">Objeto com os dados do pedido</param>
        /// <param name="pErro">Mensagem de erro</param>
        /// <returns>True se registrou com sucesso, false caso o contrario</returns>
        public bool RegistrarPedido(PedidoDI pPedido, out string pErro)
        {
            tjossEntities objConexao = new tjossEntities();
            pedidos objPedidos = new pedidos();
            itenspedido objItensPedido = new itenspedido();
            bool blnNovoPedido = false;

            try
            {
                objPedidos = objConexao.pedidos.Where(c => c.numeropedido == pPedido.NumeroPedido && c.codigotipopedido == pPedido.CodigoTipoPedido).FirstOrDefault();

                if (objPedidos == null)
                {
                    objPedidos = new pedidos();
                    blnNovoPedido = true;
                    objPedidos.codigotipopedido = pPedido.CodigoTipoPedido;
                }

                objPedidos.codigocadastro = pPedido.CodigoCadastro;
                objPedidos.situacaopedido = pPedido.SituacaoPedido;
                objPedidos.valortotalpedido = pPedido.ValorTotalPedido;

                //null se não for com contrato vinculado.
                objPedidos.numerocontrato = pPedido.NumeroContrato <= 0 ? null : pPedido.NumeroContrato;
                objPedidos.codigotipocontrato = pPedido.NumeroContrato <= 0 ? null : pPedido.CodigoTipoContrato;

                if (blnNovoPedido)
                {
                    objConexao.pedidos.Add(objPedidos);
                }

                objConexao.SaveChanges();
                //Pega o numero do pedido que foi gerado pelo auto-increment.
                int intNumeroPedido = objPedidos.numeropedido;
                bool blnNovoItemPedido = false;
                foreach (var objItemPedidoDI in pPedido.ItensPedido)
                {
                    blnNovoItemPedido = false;
                    objItensPedido = objConexao.itenspedido.Where(ip => ip.numeropedido == intNumeroPedido && 
                                                                  ip.codigotipopedido == pPedido.CodigoTipoPedido &&
                                                                  ip.codigoitem == objItemPedidoDI.CodigoItem).FirstOrDefault();
                    if (objItensPedido == null)
                    {
                        objItensPedido = new itenspedido();
                        blnNovoItemPedido = true;
                        objItensPedido.numeropedido = intNumeroPedido;
                        objItensPedido.codigotipopedido = pPedido.CodigoTipoPedido;
                        objItensPedido.codigoitem = objItemPedidoDI.CodigoItem;
                    }

                    objItensPedido.quantidadebaixada = objItemPedidoDI.QuantidadeBaixada;
                    objItensPedido.quantidadesolicitada = objItemPedidoDI.QuantidadeSolicitada;
                    objItensPedido.valorunitario = objItemPedidoDI.ValorUnitario;
                    objItensPedido.valortotalitem = objItemPedidoDI.ValorTotalItem;

                    objItensPedido.codigocadastro = objItemPedidoDI.CodigoCadastro <= 0 ? null : objItemPedidoDI.CodigoCadastro;
                    objItensPedido.codigomedida = objItemPedidoDI.CodigoMedida <= 0 ? null : objItemPedidoDI.CodigoMedida;

                    if (blnNovoItemPedido)
                    {
                        objConexao.itenspedido.Add(objItensPedido);
                    }

                    objConexao.SaveChanges();
                }

                pErro = string.Empty;
                return true;
            }
            catch (Exception pEx)
            {
                pErro = $"Exceção ao executar o metodo RegistrarPedido.{Environment.NewLine}{pEx.InnerException.InnerException}";
                return false;
            }
        }

        /// <summary>
        /// Método que lista os pedidos
        /// </summary>
        /// <param name="pNumeroPedido">Número do pedido</param>
        /// <param name="pCodigoTipoPedido">Código tipo pedido</param>
        /// <param name="pCodigoCadastro">Código do cadastro</param>
        /// <returns>Lista com os pedidos</returns>
        public List<PedidoDI> ListarPedidos(int pNumeroPedido, int pCodigoTipoPedido, int? pCodigoCadastro)
        {
            tjossEntities objConexao = new tjossEntities();
            List<pedidos> lstPedidos = new List<pedidos>();

            PedidoDI objPedidoDI;
            List<PedidoDI> lstPedidoDI = new List<PedidoDI>();

            try
            {
                lstPedidos = objConexao.pedidos.Where(p => (pNumeroPedido > 0 ? p.numeropedido == pNumeroPedido : 1 == 1) && 
                                                           (pCodigoTipoPedido > 0 ? p.codigotipopedido == pCodigoTipoPedido : 1 == 1) &&
                                                           (pCodigoCadastro > 0 ? p.codigocadastro == pCodigoCadastro : 1 == 1) &&
                                                           p.situacaopedido == "A").ToList();

                foreach (var objPedido in lstPedidos)
                {
                    objPedidoDI = new PedidoDI
                    { 
                        NumeroPedido = objPedido.numeropedido,
                        CodigoTipoPedido = objPedido.codigotipopedido,
                        CodigoCadastro = objPedido.codigocadastro,
                        SituacaoPedido = objPedido.situacaopedido,
                        DataConclusao = objPedido.dataconclusao,
                        NumeroContrato = objPedido.numerocontrato,
                        CodigoTipoContrato = objPedido.codigotipocontrato,
                        ValorTotalPedido = objPedido.valortotalpedido
                    };

                    lstPedidoDI.Add(objPedidoDI);
                }

                return lstPedidoDI;
            }
            catch
            {
                return null;
            }
            
        }

        /// <summary>
        /// Método que lista os pedidos
        /// </summary>
        /// <returns>Lista com os pedidos</returns>
        public List<PedidoDI> ListarTodosPedidos()
        {
            tjossEntities objConexao = new tjossEntities();
            List<pedidos> lstPedidos = new List<pedidos>();

            PedidoDI objPedidoDI;
            List<PedidoDI> lstPedidoDI = new List<PedidoDI>();

            try
            {
                lstPedidos = objConexao.pedidos.OrderBy(p => p.codigocadastro).ToList();

                foreach (var objPedido in lstPedidos)
                {
                    objPedidoDI = new PedidoDI
                    {
                        NumeroPedido = objPedido.numeropedido,
                        CodigoTipoPedido = objPedido.codigotipopedido,
                        CodigoCadastro = objPedido.codigocadastro,
                        SituacaoPedido = objPedido.situacaopedido,
                        DataConclusao = objPedido.dataconclusao,
                        NumeroContrato = objPedido.numerocontrato,
                        CodigoTipoContrato = objPedido.codigotipocontrato,
                        ValorTotalPedido = objPedido.valortotalpedido
                    };

                    lstPedidoDI.Add(objPedidoDI);
                }

                return lstPedidoDI;
            }
            catch
            {
                return null;
            }

        }

        /// <summary>
        /// Método que lista os itens do pedido
        /// </summary>
        /// <param name="pNumeroPedido">Número do pedido</param>
        /// <param name="pCodigoTipoPedido">Código tipo pedido</param>
        /// <returns>Lista com os itens do pedido</returns>
        public List<ItensPedidoDI> BuscarItensPedido(int pNumeroPedido, int pCodigoTipoPedido)
        {
            tjossEntities objConexao = new tjossEntities();
            List<itenspedido> lstItensPedido = new List<itenspedido>();

            ItensPedidoDI objItensPedidoDI;
            List<ItensPedidoDI> lstItensPedidoDI = new List<ItensPedidoDI>();

            try
            {
                lstItensPedido = objConexao.itenspedido.Where(p => pNumeroPedido > 0 ? p.numeropedido == pNumeroPedido : 1 == 1 &&
                                                                   pCodigoTipoPedido > 0 ? p.codigotipopedido == pCodigoTipoPedido : 1 == 1).ToList();

                foreach (var objItensPedido in lstItensPedido)
                {
                    objItensPedidoDI = new ItensPedidoDI
                    {
                        NumeroPedido = objItensPedido.numeropedido,
                        CodigoTipoPedido = objItensPedido.codigotipopedido,
                        CodigoItem = objItensPedido.codigoitem,
                        QuantidadeSolicitada = objItensPedido.quantidadesolicitada,
                        QuantidadeBaixada = objItensPedido.quantidadebaixada,
                        ValorUnitario = objItensPedido.valorunitario,
                        ValorTotalItem = objItensPedido.valortotalitem,
                        CodigoCadastro = objItensPedido.codigocadastro,
                        CodigoMedida = objItensPedido.codigomedida                        
                    };

                    lstItensPedidoDI.Add(objItensPedidoDI);
                }

                return lstItensPedidoDI;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Método que consulta todas os tipos de pedidos cadastradas
        /// </summary>
        /// <returns>Retorna uma lisca com os tipos de pedidos</returns>
        public List<TipoPedidoDI> ListarTiposPedido()
        {
            tjossEntities objConexao = new tjossEntities();
            List<TipoPedidoDI> lstTipoPedidoDI = new List<TipoPedidoDI>();

            List<tipopedido> lstTipoPedido = objConexao.tipopedido.ToList();

            if (lstTipoPedido.Count > 0)
            {
                TipoPedidoDI objTipoPedidoDI;
                foreach (var objTipoPedido in lstTipoPedido)
                {
                    objTipoPedidoDI = new TipoPedidoDI 
                    {
                        CodigoTipoPedido = objTipoPedido.codigotipopedido,
                        DescricaoComboBox = $"{objTipoPedido.codigotipopedido} - {objTipoPedido.descricaotipopedido}",
                        DescricaoTipoPedido = objTipoPedido.descricaotipopedido,
                        SituacaoTipoPedido = objTipoPedido.situacao
                    };

                    lstTipoPedidoDI.Add(objTipoPedidoDI);
                }

                return lstTipoPedidoDI;
            }
            else
            {
                return null;
            }
        }
    }
}
