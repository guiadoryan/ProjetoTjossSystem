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
    
    public partial class itemestoque
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public itemestoque()
        {
            this.movimentoestoque = new HashSet<movimentoestoque>();
        }
    
        public int codigoitem { get; set; }
        public int codigotipoestoque { get; set; }
        public decimal quantidadedisponivel { get; set; }
        public decimal valorproduto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movimentoestoque> movimentoestoque { get; set; }
        public virtual itens itens { get; set; }
        public virtual tipoestoque tipoestoque { get; set; }
    }
}
