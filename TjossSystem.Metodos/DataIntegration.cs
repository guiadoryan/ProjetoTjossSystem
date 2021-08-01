using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TjossSystem.Metodos
{
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

        [DataMember]
        public List<EnderecoDI> EnderecosDI { get; set; }
    }

    [DataContract]
    public class EnderecoDI
    {
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
}
