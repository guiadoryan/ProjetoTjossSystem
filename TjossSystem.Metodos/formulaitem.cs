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
    
    public partial class formulaitem
    {
        public int codigoitem { get; set; }
        public int numerosequencia { get; set; }
        public string observacaoformula { get; set; }
    
        public virtual itens itens { get; set; }
    }
}