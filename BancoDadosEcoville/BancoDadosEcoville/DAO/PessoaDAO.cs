using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDadosEcoville.Model;

namespace BancoDadosEcoville.DAO
{
    class PessoaDAO
    {
        public static void Cadastrar(Pessoa p)
        {

            Context ctx = new Context();
            ctx.Pessoas.Add(p);
            ctx.SaveChanges();

        }
    }
}
