using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjossSystem.Metodos
{
    class Conexao : DbContext
    {
        private readonly string schema;

        public Conexao(string schema)
          : base("conexao")
        {
            this.schema = schema;
        }

        public DbSet<Cadastro> Cadastro { get; set; }

        public DbSet<DadosFiscaisBasicos> DadosFiscaisBasicos { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.HasDefaultSchema(this.schema);
            base.OnModelCreating(builder);
        }
    }
}
