﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjossSystem.Metodos
{
    public class ModuloDeItens
    {
        #region :: Cadastro Itens ::
        /// <summary>
        /// Método que Regista/Altera itens no sistema
        /// </summary>
        /// <param name="pItemDI">Objeto com os dados do item</param>
        /// <param name="pErro">Mensagem de erro</param>
        /// <returns>True caso Registrar/Alterar uma item, false caso o contrario.</returns>
        public bool RegistrarItem(ItemDI pItemDI, out string pErro)
        {
            tjossEntities objConexao = new tjossEntities();
            itens objItens = new itens();
            bool blnNovoItem = false;

            try
            {
                objItens = objConexao.itens.Where(c => c.codigoitem == pItemDI.CodigoItem && c.codigoitem != 0).FirstOrDefault();

                if (objItens == null)
                {
                    objItens = new itens();
                    blnNovoItem = true;
                }

                objItens.descricaoitem = pItemDI.DescricaoItens;
                objItens.codigotipoitem = pItemDI.CodigoTipoItem;
                objItens.situacao = pItemDI.SituacaoItem;
                objItens.datahalteracao = pItemDI.DatahAlteracao;
                objItens.codigofuncionario = pItemDI.CodigoFuncionario;

                if (blnNovoItem)
                {
                    objConexao.itens.Add(objItens);
                }

                objConexao.SaveChanges();
                pErro = string.Empty;
                return true;
            }
            catch (Exception pEx)
            {
                pErro = $"Exceção ao executar o metodo RegistrarItem.{Environment.NewLine}{pEx.InnerException.InnerException}";
                return false;
            }
        }

        /// <summary>
        /// Método que busca os dados do item
        /// </summary>
        /// <param name="pCodigoItem">Código do item</param>
        /// <returns>Retorna um objeto com todos os dados do item</returns>
        public ItemDI ConsultarItem(int pCodigoItem)
        {
            tjossEntities objConexao = new tjossEntities();
            itens objItem = new itens();

            ItemDI objItemDI;

            try
            {
                objItem = objConexao.itens.Where(c => c.codigoitem == pCodigoItem && c.codigoitem != 0).FirstOrDefault();
                if (objItem == null)
                {
                    //retornar
                    return new ItemDI();
                }

                objItemDI = new ItemDI
                {
                    CodigoItem = objItem.codigoitem,
                    DescricaoItens = objItem.descricaoitem,
                    SituacaoItem = objItem.situacao,
                    CodigoTipoItem = objItem.codigotipoitem,
                    DatahAlteracao = objItem.datahalteracao,
                    CodigoFuncionario = objItem.codigofuncionario
                };

                return objItemDI;
            }
            catch (Exception pE)
            {
                string strErro = pE.InnerException.InnerException.Message;
                return null;
            }
        }

        #endregion

        #region :: Tipo Estoque ::
        /// <summary>
        /// Método que Regista/Altera tipo estoque no sistema
        /// </summary>
        /// <param name="pTipoEstoqueDI">Objeto com os dados do tipo estoque</param>
        /// <param name="pErro">Mensagem de erro</param>
        /// <returns>True caso Registrar/Alterar um tipo de estoque, false caso o contrario.</returns>
        public bool RegistrarTipoEstoque(TipoEstoqueDI pTipoEstoqueDI, out string pErro)
        {
            tjossEntities objConexao = new tjossEntities();
            tipoestoque objTipoEstoque = new tipoestoque();
            bool blnNovoTipoEstoque = false;
            int intCodigoTipoEstoque = 0;
            try
            {
                objTipoEstoque = objConexao.tipoestoque.Where(c => c.codigotipoestoque == pTipoEstoqueDI.CodigoTipoEstoque && c.codigotipoestoque != 0).FirstOrDefault();

                if (objTipoEstoque == null)
                {
                    objTipoEstoque = new tipoestoque();
                    blnNovoTipoEstoque = true;
                    intCodigoTipoEstoque = objConexao.tipoestoque.OrderByDescending(il => il.codigotipoestoque).FirstOrDefault() != null ?
                                           objConexao.tipoestoque.OrderByDescending(il => il.codigotipoestoque).FirstOrDefault().codigotipoestoque + 1 : 1;
                    objTipoEstoque.codigotipoestoque = intCodigoTipoEstoque;
                }

                objTipoEstoque.descricaotipoestoque = pTipoEstoqueDI.DescricaoTipoEstoque;
                objTipoEstoque.situacao = pTipoEstoqueDI.SituacaoTipoEstoque;

                if (blnNovoTipoEstoque)
                {
                    objConexao.tipoestoque.Add(objTipoEstoque);
                }

                objConexao.SaveChanges();
                pErro = string.Empty;
                return true;
            }
            catch (Exception pEx)
            {
                pErro = $"Exceção ao executar o metodo RegistrarItem.{Environment.NewLine}{pEx.InnerException.InnerException}";
                return false;
            }
        }

        /// <summary>
        /// Método que busca os dados do tipo do estoque
        /// </summary>
        /// <param name="pCodigoTipoEstoque">Código do tipo estoque</param>
        /// <returns>Retorna um objeto com todos os dados do tipo estoque</returns>
        public TipoEstoqueDI ConsultarTipoEstoque(int pCodigoTipoEstoque)
        {
            tjossEntities objConexao = new tjossEntities();
            tipoestoque objTipoEstoque = new tipoestoque();

            TipoEstoqueDI objTipoEstoqueDI;

            try
            {
                objTipoEstoque = objConexao.tipoestoque.Where(c => c.codigotipoestoque == pCodigoTipoEstoque && c.codigotipoestoque != 0).FirstOrDefault();
                if (objTipoEstoque == null)
                {
                    //retornar
                    return new TipoEstoqueDI();
                }

                objTipoEstoqueDI = new TipoEstoqueDI
                {
                    CodigoTipoEstoque = objTipoEstoque.codigotipoestoque,
                    DescricaoTipoEstoque = objTipoEstoque.descricaotipoestoque,
                    SituacaoTipoEstoque = objTipoEstoque.situacao
                };

                return objTipoEstoqueDI;
            }
            catch (Exception pE)
            {
                string strErro = pE.InnerException.InnerException.Message;
                return null;
            }
        }

        #endregion

        #region :: Tipo Item
        /// <summary>
        /// Método que Regista/Altera tipo item no sistema
        /// </summary>
        /// <param name="pTipoItemDI">Objeto com os dados do tipo item</param>
        /// <param name="pErro">Mensagem de erro</param>
        /// <returns>True caso Registrar/Alterar uma item, false caso o contrario.</returns>
        public bool RegistrarTipoItem(TipoItemDI pTipoItemDI, out string pErro)
        {
            tjossEntities objConexao = new tjossEntities();
            tipoitem objTipoItens = new tipoitem();
            bool blnNovoItem = false;
            int intCodigoTipoItem = 0;
            try
            {
                objTipoItens = objConexao.tipoitem.Where(c => c.codigotipoitem == pTipoItemDI.CodigoTipoItem && c.codigotipoitem != 0).FirstOrDefault();

                if (objTipoItens == null)
                {
                    objTipoItens = new tipoitem();
                    blnNovoItem = true;
                    intCodigoTipoItem = objConexao.itens.OrderByDescending(il => il.codigoitem).FirstOrDefault() != null ?
                                        objConexao.itens.OrderByDescending(il => il.codigoitem).FirstOrDefault().codigoitem + 1 : 1;
                    objTipoItens.codigotipoitem = intCodigoTipoItem;
                }

                objTipoItens.descricaotipoitem = pTipoItemDI.DescricaoTipoItem;
                objTipoItens.codigotipoitem = pTipoItemDI.CodigoTipoItem;
                objTipoItens.situacaotipoitem = pTipoItemDI.SituacaoTipoItem;

                if (blnNovoItem)
                {
                    objConexao.tipoitem.Add(objTipoItens);
                }

                objConexao.SaveChanges();
                pErro = string.Empty;
                return true;
            }
            catch (Exception pEx)
            {
                pErro = $"Exceção ao executar o metodo RegistrarTipoItem.{Environment.NewLine}{pEx.InnerException.InnerException}";
                return false;
            }
        }

        /// <summary>
        /// Método que busca os dados do tipo item
        /// </summary>
        /// <param name="pCodigoTipoItem">Código do tipo item</param>
        /// <returns>Retorna um objeto com todos os dados do tipo item</returns>
        public TipoItemDI ConsultarTipoItem(int pCodigoTipoItem)
        {
            tjossEntities objConexao = new tjossEntities();
            tipoitem objTipoItem = new tipoitem();

            TipoItemDI objTipoItemDI;

            try
            {
                objTipoItem = objConexao.tipoitem.Where(c => c.codigotipoitem == pCodigoTipoItem && c.codigotipoitem != 0).FirstOrDefault();
                if (objTipoItem == null)
                {
                    //retornar
                    return new TipoItemDI();
                }

                objTipoItemDI = new TipoItemDI
                {
                    CodigoTipoItem = objTipoItem.codigotipoitem,
                    DescricaoTipoItem = objTipoItem.descricaotipoitem,
                    SituacaoTipoItem = objTipoItem.situacaotipoitem
                };

                return objTipoItemDI;
            }
            catch (Exception pE)
            {
                string strErro = pE.InnerException.InnerException.Message;
                return null;
            }
        }

        /// <summary>
        /// Método que consulta todos os tipos de itens registrados
        /// </summary>
        /// <returns>Retorna uma lisca com os tipos de itens registrados</returns>
        public List<TipoItemDI> BuscarTiposItens()
        {
            tjossEntities objConexao = new tjossEntities();
            List<TipoItemDI> lstTipoItemDI = new List<TipoItemDI>();
            List<tipoitem> lstTipoItem;

            lstTipoItem = objConexao.tipoitem.ToList();

            if (lstTipoItem.Count > 0)
            {
                TipoItemDI objTipoItemDI;
                foreach (tipoitem objTipoCadastro in lstTipoItem)
                {
                    objTipoItemDI = new TipoItemDI { CodigoTipoItem = objTipoCadastro.codigotipoitem,  DescricaoComboBox = $"{objTipoCadastro.codigotipoitem} - {objTipoCadastro.descricaotipoitem}" };
                    lstTipoItemDI.Add(objTipoItemDI);
                }

                return lstTipoItemDI;
            }
            else
            {
                return null;
            }
        }

        #endregion
    }
}