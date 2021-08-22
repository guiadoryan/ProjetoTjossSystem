﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjossSystem.Metodos
{
    public class Metodos
    {
        /// <summary>
        /// Método que Regista/Altera Cadastro no sistema
        /// </summary>
        /// <param name="pCadastroDI">Objeto com os dados basicos do cadastro</param>
        /// <param name="pEnderecosDI">Objeto com dados do endereço do cadastro</param>
        /// <param name="pErro">Mensagem de erro</param>
        /// <returns>True caso Registrar/Alterar um cadastro, false caso o contrario.</returns>
        public bool RegistrarCadastro(CadastroDI pCadastroDI, List<EnderecoDI> pEnderecosDI, out string pErro)
        {
            tjossEntities objConexao = new tjossEntities();
            cadastro objCadastro = new cadastro();
            List<dadosfisicos> lstEndereco = new List<dadosfisicos>(); 
            bool blnNovoCadastro = false;
            try
            {
                objCadastro = objConexao.cadastro.Where(c => c.codigocadastro == pCadastroDI.CodigoCadastro && c.codigocadastro != 0).FirstOrDefault();

                if (objCadastro == null)
                {
                    objCadastro = new cadastro();
                    blnNovoCadastro = true;
                    objCadastro.codigocadastro = objConexao.cadastro.Where(c => c.codigocadastro == pCadastroDI.CodigoCadastro && c.codigocadastro != 0).FirstOrDefault() != null ? objConexao.cadastro.OrderByDescending(c => c.codigocadastro).FirstOrDefault().codigocadastro + 1 : 1;
                }

                objCadastro.nomecadastro = pCadastroDI.NomeCadastro;
                objCadastro.nomefantasia = pCadastroDI.NomeFantasia;
                objCadastro.codigotipocadastro = pCadastroDI.CodigoTipoCadastro;
                objCadastro.cpfcnpj = pCadastroDI.CpfCnpj;
                objCadastro.controle = pCadastroDI.Controle;
                objCadastro.datahalteracao = pCadastroDI.DatahAlteracao;
                objCadastro.codigofuncionario = pCadastroDI.CodigoFuncionario; //Alterar para pegar do sistema.

                if (blnNovoCadastro)
                {
                    objConexao.cadastro.Add(objCadastro);
                }

                bool blnNovoEndereco = false;
                foreach (var objEnderecoDI in pEnderecosDI)
                {
                    dadosfisicos objEndereco = new dadosfisicos();
                    objEndereco = objConexao.dadosfisicos.Where(c => c.codigocadastro == pCadastroDI.CodigoCadastro && c.codigocadastro != 0 && c.codigofilial == objEnderecoDI.CodigoFilial).FirstOrDefault();
                    if (objEndereco == null)
                    {
                        objEndereco = new dadosfisicos
                        {
                            codigocadastro = pCadastroDI.CodigoCadastro,
                            codigofilial = objEnderecoDI.CodigoFilial,
                            endereco = objEnderecoDI.Endereco,
                            bairro = objEnderecoDI.Bairro,
                            numero = objEnderecoDI.NumeroEndereco,
                            complemento = objEnderecoDI.Complemento,
                            cependereco = objEnderecoDI.CepEndereco,
                            codigocidade = objEnderecoDI.CodigoCidade,
                            situacao = objEnderecoDI.SituacaoEndereco
                        };
                        blnNovoEndereco = true;
                    }
                    else
                    {
                        objEndereco.endereco = objEnderecoDI.Endereco;
                        objEndereco.bairro = objEnderecoDI.Bairro;
                        objEndereco.numero = objEnderecoDI.NumeroEndereco;
                        objEndereco.complemento = objEnderecoDI.Complemento;
                        objEndereco.cependereco = objEnderecoDI.CepEndereco;
                        objEndereco.codigocidade = objEnderecoDI.CodigoCidade;
                        objEndereco.situacao = objEnderecoDI.SituacaoEndereco;
                    }

                    if (blnNovoEndereco)
                    {
                        objConexao.dadosfisicos.Add(objEndereco);
                    }
                }

                objConexao.SaveChanges();
                pErro = string.Empty;
                return true;
            }
            catch(Exception pEx)
            {
                pErro = $"Exceção ao executar o metodo RegistrarCadastro.{Environment.NewLine}{pEx.InnerException.Message}";
                return false;
            }
        }

        public CadastroDI ConsultarCadastro(int pCodigoCadastro)
        {
            tjossEntities objConexao = new tjossEntities();
            cadastro objCadastro = new cadastro();

            CadastroDI objCadastroDI;
            List<EnderecoDI> lstEnderecoDI = new List<EnderecoDI>();
            List<MedidaDI> lstMedidaDI = new List<MedidaDI>();
            List<DefinicaoDI> lstDefinicaoDI = new List<DefinicaoDI>();

            objCadastro = objConexao.cadastro.Where(c => c.codigocadastro == pCodigoCadastro && c.codigocadastro != 0).FirstOrDefault();
            if (objCadastro == null)
            {
                //retornar
                return new CadastroDI();
            }

            objCadastroDI = new CadastroDI
            {
                CodigoCadastro = objCadastro.codigocadastro,
                NomeCadastro = objCadastro.nomecadastro,
                NomeFantasia = objCadastro.nomefantasia,
                CodigoTipoCadastro = objCadastro.codigotipocadastro,
                CpfCnpj = objCadastro.cpfcnpj,
                Controle = objCadastro.controle,
                DatahAlteracao = objCadastro.datahalteracao,
                CodigoFuncionario = objCadastro.codigofuncionario,
            };

            List<dadosfisicos> lstEndereco = new List<dadosfisicos>();
            lstEndereco = objConexao.dadosfisicos.Where(c => c.codigocadastro == pCodigoCadastro).ToList();
            if (lstEndereco.Count > 0)
            {
                EnderecoDI objEnderecoDI = new EnderecoDI();
                foreach (var objEndereco in lstEndereco)
                {
                    objEnderecoDI = new EnderecoDI
                    {
                        CodigoCadastro = objEndereco.codigocadastro,
                        CodigoFilial = objEndereco.codigofilial,
                        Endereco = objEndereco.endereco,
                        Bairro = objEndereco.bairro,
                        NumeroEndereco = objEndereco.numero,
                        Complemento = objEndereco.complemento,
                        CepEndereco = objEndereco.cependereco,
                        SituacaoEndereco = objEndereco.situacao,
                        CodigoCidade = objEndereco.codigocidade
                    };
                    lstEnderecoDI.Add(objEnderecoDI);
                }
            }

            List<medida> lstMedida = new List<medida>();
            lstMedida = objConexao.medida.Where(c => c.codigocadastro == pCodigoCadastro).ToList();
            if (lstMedida.Count > 0)
            {
                MedidaDI objMedidaDI = new MedidaDI();
                foreach (var objMedida in lstMedida)
                {
                    objMedidaDI = new MedidaDI
                    {
                        CodigoCadastro = objMedida.codigocadastro,
                        CodigoMedida = objMedida.codigomedida,
                        Altura = objMedida.altura,
                        Cintura = objMedida.cintura,
                        OmbroAhOmbro = objMedida.ombroaombro,
                        Busto = objMedida.busto,
                        ObservacaoMedida = objMedida.observacao,
                        SituacaoMedida = objMedida.situacao
                    };
                    lstMedidaDI.Add(objMedidaDI);
                }
            }

            List<definicaocadastro> lstDefinicao = new List<definicaocadastro>();
            lstDefinicao = objConexao.definicaocadastro.Where(c => c.codigocadastro == pCodigoCadastro).ToList();
            if (lstDefinicao.Count > 0)
            {
                DefinicaoDI objDefinicaoDI = new DefinicaoDI();
                foreach (var objDefinicao in lstDefinicao)
                {
                    objDefinicaoDI = new DefinicaoDI
                    {
                        CodigoCadastro = objDefinicao.codigocadastro,
                        CodigoDefinicao = objDefinicao.codigotipodefinicao,
                        SituacaoDefinicao = objDefinicao.situacao,
                        DatahAlteracao = objDefinicao.datahalteracao,
                        CodigoFuncionario = objDefinicao.codigofuncionario
                    };
                    lstDefinicaoDI.Add(objDefinicaoDI);
                }
            }


            objCadastroDI.EnderecoDI = lstEnderecoDI;
            objCadastroDI.MedidaDI = lstMedidaDI;
            objCadastroDI.DefinicaoDI = lstDefinicaoDI;
            return objCadastroDI;
        }

        public List<TipoCadastroDI> ConsultarTipoCadastro()
        {
            tjossEntities objConexao = new tjossEntities();
            List<TipoCadastroDI> lstTipoCadastroDI = new List<TipoCadastroDI>();
            List<tipocadastro> lstTipoCadastro = new List<tipocadastro>();

            lstTipoCadastro = objConexao.tipocadastro.ToList();

            if (lstTipoCadastro.Count > 0)
            {
                TipoCadastroDI objTipoCadastroDI;
                foreach (var objTipoCadastro in lstTipoCadastro)
                {
                    objTipoCadastroDI = new TipoCadastroDI { CodigoTipoCadastro = objTipoCadastro.codigotipocadastro, DescricaoTipoCadastro = $"{objTipoCadastro.codigotipocadastro} - {objTipoCadastro.descricaotipocadastro}" };
                    lstTipoCadastroDI.Add(objTipoCadastroDI);
                }

                return lstTipoCadastroDI;
            }
            else
            {
                return null;
            }
        }

        public List<CidadeDI> ConsultarCidades()
        {
            tjossEntities objConexao = new tjossEntities();
            List<CidadeDI> lstCidadesDI = new List<CidadeDI>();

            List<cidade> lstCidades = objConexao.cidade.ToList();

            if (lstCidades.Count > 0)
            {
                CidadeDI objCidadeDI;
                foreach (var objCidade in lstCidades)
                {
                    objCidadeDI = new CidadeDI { CodigoCidade = objCidade.codigocidade, DescricaoCidade = $"{objCidade.codigocidade} - {objCidade.nomecidade}" };
                    lstCidadesDI.Add(objCidadeDI);
                }

                return lstCidadesDI;
            }
            else
            {
                return null;
            }
        }
    }
}
