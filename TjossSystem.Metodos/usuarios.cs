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
    
    public partial class usuarios
    {
        public int codigofuncionario { get; set; }
        public string senha { get; set; }
        public System.DateTime datahcadastro { get; set; }
    
        public virtual funcionarios funcionarios { get; set; }
    }
}
