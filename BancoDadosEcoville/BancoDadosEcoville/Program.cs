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
            Pessoa p = new Pessoa();
            do {
                
                Console.WriteLine("Selecione a opção abaixo!");
                Console.WriteLine("1 - Cadastrar Usuário");
                Console.WriteLine("2 - Listar Usuário");
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                       
                        Console.WriteLine("Digite o seu nome");
                        p.Nome = Console.ReadLine();
                        p.Nascimento = DateTime.Now;
                        Console.WriteLine("Digite o seu CPF");
                        p.Cpf = Console.ReadLine();
                        Console.WriteLine("Digite o seu telefone");
                        p.Telefone = Console.ReadLine();

                        PessoaDAO.Cadastrar(p);

                        Console.WriteLine("Salvo!");
                        Console.ReadKey();
                        break;

                    case "2":
                        foreach (Pessoa item in PessoaDAO.ListarPessoa())
                        {
                            Console.WriteLine(item.Nome);
                        }
                       
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Digite uma tecla para terminar a aplicação! ");
                Console.ReadLine();
            } while (op != "0");


          
        }
    }
}
