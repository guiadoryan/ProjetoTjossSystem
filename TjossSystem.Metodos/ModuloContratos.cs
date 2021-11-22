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

    }
}
