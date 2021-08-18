﻿using System;
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

        [DataMember(EmitDefaultValue = false)]
        public List<EnderecoDI> EnderecosDI { get; set; }
    }

    [DataContract]
    public class MedidaDI
    {
        [DataMember]
        public int CodigoCadastro { get; set; }

        [DataMember]
        public int CodigoMedida { get; set; }

        [DataMember]
        public decimal Altura { get; set; }

        [DataMember]
        public decimal Cintura { get; set; }

        [DataMember]
        public decimal OmbroAhOmbro { get; set; }

        [DataMember]
        public decimal Busto { get; set; }

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
        public int CodigoFilial { get; set; }

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
    public class CidadeDI
    {
        [DataMember]
        public int CodigoCidade { get; set; }

        [DataMember]
        public string DescricaoCidade { get; set; }
    }
}
