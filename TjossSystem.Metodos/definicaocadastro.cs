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
    
    public partial class definicaocadastro
    {
        public int codigocadastro { get; set; }
        public int codigotipodefinicao { get; set; }
        public string situacao { get; set; }
        public System.DateTime datahalteracao { get; set; }
        public int codigofuncionario { get; set; }
    
        public virtual cadastro cadastro { get; set; }
        public virtual funcionarios funcionarios { get; set; }
        public virtual tipodefinicao tipodefinicao { get; set; }
    }
}
