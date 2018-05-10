using BancoDadosEcoville.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDadosEcoville.DAO;

namespace BancoDadosEcoville
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            do {
                
                Console.WriteLine("Selecione a opção abaixo!");
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Pessoa p = new Pessoa();
                       
                        Console.WriteLine("Digite o seu nome");
                        p.Nome = Console.ReadLine();
                        Console.WriteLine("Digite a data de nascimento");
                        p.Nascimento = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Digite o seu CPF");
                        p.Cpf = Console.ReadLine();
                        Console.WriteLine("Digite o seu telefone");
                        p.Telefone = Console.ReadLine();

                        PessoaDAO.Cadastrar(p);

                        Console.WriteLine("Salvo!");
                        Console.ReadKey();
                        break;

                    case "2":


                        break;
                    default:
                        break;
                }
            } while (op != "0");


          
        }
    }
}
