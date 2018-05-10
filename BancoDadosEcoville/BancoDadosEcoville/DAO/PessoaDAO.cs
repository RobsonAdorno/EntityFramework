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
        
        private static Context ctx = new Context();
        public static void Cadastrar(Pessoa p)
        {
            ctx.Pessoas.Add(p);
            ctx.SaveChanges();
        }


        public static List<Pessoa> ListarPessoa()
        {
            return ctx.Pessoas.ToList();
        }

        public static Pessoa BuscarPessoaPeloCPF(Pessoa p)
        {
           return ctx.Pessoas.FirstOrDefault(x => x.Cpf.Equals(p.Cpf));
            //Retorna apenas o primeiro valor 
        }
        public static List<Pessoa> BuscarPessoaPeloNome(Pessoa p)
        {
            return ctx.Pessoas.Where(x => x.Nome.Contains(p.Nome)).ToList();
            //Aqui ele retorna todos os nomes por causa do Where

        }
    }
}
    

