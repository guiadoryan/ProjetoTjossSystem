using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjossSystem.Metodos
{
    [Table("dadosfiscaisbasicos")] //Nome da tabela tem que ser igual a do banco de dados.
    public class DadosFiscaisBasicos
    {
        [Key] //Define que é cheve primaria
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //faz com que o banco não gere valores.
        public int codigocadastro { get; set; }

        [Key]
        [Column(Order = 2)]
        public string cpfcnpj { get; set; }
    }
}
