//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TjossSystem.Metodos
{
    using System;
    using System.Collections.Generic;
    
    public partial class funcionarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public funcionarios()
        {
            this.cadastro = new HashSet<cadastro>();
            this.contrato = new HashSet<contrato>();
            this.definicaocadastro = new HashSet<definicaocadastro>();
            this.itens = new HashSet<itens>();
            this.movimentoestoque = new HashSet<movimentoestoque>();
        }
    
        public int codigofuncionario { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string cpfcontrole { get; set; }
        public System.DateTime datanascimento { get; set; }
        public System.DateTime dataadmissao { get; set; }
        public Nullable<System.DateTime> datadesligamento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cadastro> cadastro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contrato> contrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<definicaocadastro> definicaocadastro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itens> itens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movimentoestoque> movimentoestoque { get; set; }
    }
}