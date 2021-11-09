using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjossSystem.Metodos
{
    public class MovimentacaoEstoque
    {
        /// <summary>
        /// Tipo Movimento de Entrada
        /// </summary>
        private const string ENTRADA = "E";

        /// <summary>
        /// Tipo Movimento de Saida
        /// </summary>
        private const string SAIDA = "S";

        //Movimento de estoque que será usado para movimentar os pedidos e entradas manuais.
        /// <summary>
        /// Método que registra movimentação de estoque
        /// </summary>
        /// <param name="pMovimentoEstoque">Objeto com os dados para movimentação</param>
        /// <param name="pErro">Mensagem de erro</param>
        /// <returns>True se registrar com sucesso, false caso o contrario</returns>
        public bool RegistrarMovimentacaoEstoque(MovimentacaoEstoqueDI pMovimentoEstoque, out string pErro)
        {
            try
            {
                tjossEntities objConexao = new tjossEntities();
                itemestoque objItemEstoque = objConexao.itemestoque.Where(i => i.codigoitem == pMovimentoEstoque.CodigoItem && i.codigotipoestoque == pMovimentoEstoque.CodigoTipoEstoque).FirstOrDefault();

                if (objItemEstoque == null)
                {
                    pErro = $"Item Estoque não foi cadastrado, verifique!";
                    return false;
                }

                if (pMovimentoEstoque.TipoMovimento == ENTRADA)
                {
                    //Faz Soma
                    if (objItemEstoque.quantidadedisponivel + pMovimentoEstoque.QuantidadeMovimentada < 0)
                    {
                        pErro = $"Adicione mais saldo para que o estoque não fique negativo";
                        return false;
                    }
                }
                else if (pMovimentoEstoque.TipoMovimento == SAIDA)
                {
                    //Faz Sub
                    if (objItemEstoque.quantidadedisponivel - pMovimentoEstoque.QuantidadeMovimentada < 0)
                    {
                        pErro = $"Quantidade de estoque negativado, Verifique!";
                        return false;
                    }
                }
                else
                {
                    pErro = $"Tipo de movimento {pMovimentoEstoque.TipoMovimento} Desconhecido, Verifique!";
                    return false;
                }

                objItemEstoque.quantidadedisponivel += pMovimentoEstoque.QuantidadeMovimentada;

                objConexao.movimentoestoque.Add(new movimentoestoque
                {
                    codigoitem = pMovimentoEstoque.CodigoItem,
                    codigotipoestoque = pMovimentoEstoque.CodigoTipoEstoque,
                    tipomovimento = pMovimentoEstoque.TipoMovimento,
                    quantidademovimentada = pMovimentoEstoque.QuantidadeMovimentada,
                    datahmovimento = pMovimentoEstoque.DatahMovimento,
                    codigofuncionario = pMovimentoEstoque.CodigoFuncionario,
                    numeropedido = pMovimentoEstoque.NumeroPedido,
                    codigotipopedido = pMovimentoEstoque.CodigoTipoPedido,
                    observacaomovimento = pMovimentoEstoque.ObservacaoMovimento
                });

                objConexao.SaveChanges();
                pErro = string.Empty;
                return true;
            }
            catch(Exception pEx)
            {
                pErro = $"Erro ao executar o método RegistrarMovimentacaoEstoque{Environment.NewLine}{pEx.InnerException.Message}";
                return false;
            }
        }
    }
}
