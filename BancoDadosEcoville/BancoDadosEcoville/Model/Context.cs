using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosEcoville.Model
{
    /// <summary>
    /// Representar o EntityFramework e o banco de dados 
    /// dentro do projeto
    /// </summary>
    class Context : DbContext
    {
        //Nomear o banco de dados
        public Context() : base("BancoDadosEcoville") { }

        //Mapear classes que vão virar tabelas dentro do banco
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
