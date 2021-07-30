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
        public int NumeroCadastro { get; set; }

        [DataMember]
        public string NomeCadastro { get; set; }

        [DataMember]
        public string NomeFantasia { get; set; }

        [DataMember]
        public int CodigoTipoCadastro { get; set; }

        [DataMember]
        public int CpfCnpj { get; set; }

        [DataMember]
        public int Controle { get; set; }

        [DataMember]
        public DateTime DatahAlteracao { get; set; }

        [DataMember]
        public int CodigoFuncionario { get; set; }
    }
}
