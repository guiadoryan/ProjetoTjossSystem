using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjossSystem.Metodos
{
    public class ModuloPedidos
    {
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

                    objItensPedido.quantidadesolicitada = objItemPedidoDI.QuantidadeBaixada;
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

        public List<PedidoDI> ListarPedidos(int pNumeroPedido, int pCodigoTipoPedido, int? pCodigoCadastro)
        {
            tjossEntities objConexao = new tjossEntities();
            List<pedidos> lstPedidos = new List<pedidos>();

            PedidoDI objPedidoDI;
            List<PedidoDI> lstPedidoDI = new List<PedidoDI>();

            try
            {
                lstPedidos = objConexao.pedidos.Where(p => pNumeroPedido > 0 ? p.numeropedido == pNumeroPedido : 1 == 1 && 
                                                           pCodigoTipoPedido > 0 ? p.codigotipopedido == pCodigoTipoPedido : 1 == 1 &&
                                                           pCodigoCadastro > 0 ? p.codigocadastro == pCodigoCadastro : 1 == 1 ).ToList();

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
