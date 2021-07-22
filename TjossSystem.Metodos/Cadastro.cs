using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjossSystem.Metodos
{
    [Table("cadastro")] //Nome da tabela tem que ser igual a do banco de dados.
    public class Cadastro
    {
        public Cadastro()
        {
            this.DadosFiscaisBasicos = new HashSet<DadosFiscaisBasicos>();
        }
        [Key] //Define que é cheve primaria
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //faz com que o banco não gere valores.
        public int codigocadastro { get; set; }

        public string nomecadastro { get; set; }
        public string nomefantasia { get; set; }
        public int codigotipocadastro { get; set; }
        public DateTime datahalteracao { get; set; }
        public int codigofuncionario { get; set; }

        public virtual ICollection<DadosFiscaisBasicos> DadosFiscaisBasicos { get; private set; }
    }
}
