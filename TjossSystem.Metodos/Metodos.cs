using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjossSystem.Metodos
{
    public class Metodos
    {
        public bool RegistrarCadastro(int pCodigoCadastro, string pNomeCadastro, string pNomeFantasia, int pCodigoTipoCadastro, int pCpfCnpj, int pControle, /*CadastroDI pCadastro,*/ out string pErro)
        {
            tjossEntities objConexao = new tjossEntities();
            cadastro objCadastro = new cadastro();
            List<dadosfisicos> lstEndereco = new List<dadosfisicos>(); 
            bool blnNovo = false;
            try
            {
                objCadastro = objConexao.cadastro.Where(c => c.codigocadastro == pCodigoCadastro && c.codigocadastro != 0).FirstOrDefault();

                if (objCadastro == null)
                {
                    objCadastro = new cadastro();
                    blnNovo = true;
                    objCadastro.codigocadastro = objConexao.cadastro.Where(c => c.codigocadastro == pCodigoCadastro).FirstOrDefault().codigocadastro != 0 ? objConexao.cadastro.Where(c => c.codigocadastro == pCodigoCadastro).FirstOrDefault().codigocadastro + 1 : 1;
                }

                objCadastro.nomecadastro = pNomeCadastro;
                objCadastro.nomefantasia = pNomeFantasia;
                objCadastro.codigotipocadastro = pCodigoTipoCadastro;
                objCadastro.cpfcnpj = pCpfCnpj.ToString();
                objCadastro.controle = pControle.ToString();
                objCadastro.datahalteracao = DateTime.Now;
                objCadastro.codigofuncionario = 0; //Alterar para pegar do sistema.

                if (blnNovo)
                {
                    objConexao.cadastro.Add(objCadastro);
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
                        CodigoFilial = objEndereco.codigofilial,
                        Endereco = objEndereco.endereco,
                        Bairro = objEndereco.bairro,
                        NumeroEndereco = objEndereco.numero,
                        Complemento = objEndereco.complemento
                    };
                    lstEnderecoDI.Add(objEnderecoDI);
                }
            }


            objCadastroDI.EnderecosDI = lstEnderecoDI;
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
    }
}
