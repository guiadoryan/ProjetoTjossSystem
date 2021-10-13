using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TjossSystem.Metodos
{
    //auto-generated

    #region :: CADASTRO ::
    [DataContract]
    public class CadastroDI
    {
        [DataMember]
        public int CodigoCadastro { get; set; }

        [DataMember]
        public string NomeCadastro { get; set; }

        [DataMember]
        public string NomeFantasia { get; set; }

        [DataMember]
        public int CodigoTipoCadastro { get; set; }

        [DataMember]
        public string CpfCnpj { get; set; }

        [DataMember]
        public string Controle { get; set; }

        [DataMember]
        public DateTime DatahAlteracao { get; set; }

        [DataMember]
        public int CodigoFuncionario { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<EnderecoDI> EnderecoDI { get; set; }

        public List<MedidaDI> MedidaDI { get; set; }

        public List<DefinicaoDI> DefinicaoDI { get; set; }
    }

    [DataContract]
    public class MedidaDI
    {
        [DataMember]
        public int CodigoCadastro { get; set; }

        [DataMember]
        public int CodigoMedida { get; set; }

        [DataMember]
        public decimal? Altura { get; set; }

        [DataMember]
        public decimal? Cintura { get; set; }

        [DataMember]
        public decimal? OmbroAhOmbro { get; set; }

        [DataMember]
        public decimal? Busto { get; set; }

        [DataMember]
        public string ObservacaoMedida { get; set; }

        [DataMember]
        public string SituacaoMedida { get; set; }

        [DataMember]
        public DateTime DatahAlteracao { get; set; }

        [DataMember]
        public int CodigoFuncionario { get; set; }
    }

    [DataContract]
    public class EnderecoDI
    {
        [DataMember]
        public int? CodigoCadastro { get; set; }

        [DataMember]
        public string CodigoFilial { get; set; }

        [DataMember]
        public string Endereco { get; set; }

        [DataMember]
        public string Bairro { get; set; }

        [DataMember]
        public int NumeroEndereco { get; set; }

        [DataMember]
        public string Complemento { get; set; }

        [DataMember]
        public string CepEndereco { get; set; }

        [DataMember]
        public string SituacaoEndereco { get; set; }

        [DataMember]
        public int? CodigoCidade { get; set; }

        [DataMember]
        public DateTime? DatahAlteracao { get; set; }

        [DataMember]
        public int? CodigoFuncionario { get; set; }
    }

    [DataContract]
    public class DefinicaoDI
    {
        [DataMember]
        public int CodigoCadastro { get; set; }

        [DataMember]
        public int CodigoDefinicao { get; set; }

        [DataMember]
        public string SituacaoDefinicao { get; set; }

        [DataMember]
        public DateTime DatahAlteracao { get; set; }

        [DataMember]
        public int CodigoFuncionario { get; set; }
    }

    [DataContract]
    public class TipoCadastroDI
    {
        [DataMember]
        public int CodigoTipoCadastro { get; set; }

        [DataMember]
        public string DescricaoTipoCadastro { get; set; }
    }

    [DataContract]
    public class TipoDefinicaoDI
    {
        [DataMember]
        public int CodigoTipoDefinicao { get; set; }

        [DataMember]
        public string DescricaoTipoDefinicao { get; set; }
    }

    #endregion

    [DataContract]
    public class CidadeDI
    {
        [DataMember]
        public int CodigoCidade { get; set; }

        [DataMember]
        public string DescricaoCidade { get; set; }

        [DataMember]
        public string SiglaCidade { get; set; }

        public int CodigoEstadoCit { get; set; }

        [DataMember]
        public List<EstadoDI> EstadoDI { get; set; }
    }

    [DataContract]
    public class EstadoDI
    {
        [DataMember]
        public int CodigoEstado { get; set; }

        [DataMember]
        public string DescricaoEstado { get; set; }

        [DataMember]
        public string SiglaEstado { get; set; }

        public int CodigoPaisEst { get; set; }

        [DataMember]
        public List<PaisDI> PaisDI { get; set; }
    }

    public class PaisDI
    {
        [DataMember]
        public int CodigoPais { get; set; }

        [DataMember]
        public string DescricaoPais { get; set; }

        [DataMember]
        public string SiglaPais { get; set; }
    }
}
