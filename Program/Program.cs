using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static List<Contato> contatos = new List<Contato>();

    static void AdicionarContato()
    {
        Console.Write("Digite o nome do contato: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o telefone do contato (sem identificador de região): ");
        int telefone = int.Parse(Console.ReadLine());

        Contato contato = new Contato(nome, telefone);
        contatos.Add(contato);

        Console.WriteLine("Contato adicionado com sucesso!");
    }

    static void BuscarContatoPorTelefone()
    {
        Console.Write("Digite o telefone do contato a ser buscado: ");
        int telefone = int.Parse(Console.ReadLine());

        Contato contato = contatos.Find(c => c.Telefone == telefone);

        if (contato != null)
        {
            contato.ExibirDetalhes();
        }
        else
        {
            Console.WriteLine("Contato não encontrado.");
        }
    }

    static void BuscarContatoPorNome()
    {
        Console.Write("Digite o nome do contato a ser buscado: ");
        string nome = Console.ReadLine();

        List<Contato> contatosEncontrados = contatos.FindAll(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

        if (contatosEncontrados.Count > 0)
        {
            foreach (Contato contato in contatosEncontrados)
            {
                contato.ExibirDetalhes();
            }
        }
        else
        {
            Console.WriteLine("Contato não encontrado.");
        }
    }

    static void ExcluirContatoPorTelefone()
    {
        Console.Write("Digite o telefone do contato a ser excluído: ");
        int telefone = int.Parse(Console.ReadLine());

        Contato contato = contatos.Find(c => c.Telefone == telefone);

        if (contato != null)
        {
            contatos.Remove(contato);
            Console.WriteLine("Contato excluído com sucesso!");
        }
        else
        {
            Console.WriteLine("Contato não encontrado.");
        }
    }

    static void ExcluirContatoPorNome()
    {
        Console.Write("Digite o nome do contato a ser excluído: ");
        string nome = Console.ReadLine();

        List<Contato> contatosEncontrados = contatos.FindAll(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

        if (contatosEncontrados.Count > 0)
        {
            foreach (Contato contato in contatosEncontrados)
            {
                contatos.Remove(contato);
            }

            Console.WriteLine("Contato(s) excluído(s) com sucesso!");
        }
        else
        {
            Console.WriteLine("Contato não encontrado.");
        }
    }

    static void OrdenarPorNome()
    {
        contatos.Sort((c1, c2) => c1.Nome.CompareTo(c2.Nome));
        Console.WriteLine("Contatos ordenados por nome:");
        ExibirContatos();
    }

    static void OrdenarPorTelefone()
    {
        contatos.Sort((c1, c2) => c1.Telefone.CompareTo(c2.Telefone));
        Console.WriteLine("Contatos ordenados por telefone:");
        ExibirContatos();
    }

    static void ExibirContatos()
    {
        if (contatos.Count == 0)
        {
            Console.WriteLine("Não há contatos cadastrados.");
        }
        else
        {
            foreach (Contato contato in contatos)
            {
                contato.ExibirDetalhes();
            }
        }
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Adicionar contato");
            Console.WriteLine("2 - Buscar contato por telefone");
            Console.WriteLine("3 - Buscar contato por nome");
            Console.WriteLine("4 - Excluir contato por telefone");
            Console.WriteLine("5 - Excluir contato por nome");
            Console.WriteLine("6 - Ordenar lista por nome");
            Console.WriteLine("7 - Ordenar lista por telefone");
            Console.WriteLine("8 - Exibir todos os contatos");
            Console.WriteLine("9 - Sair");

            Console.Write("Digite a opção desejada: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarContato();
                    break;
                case "2":
                    BuscarContatoPorTelefone();
                    break;
                case "3":
                    BuscarContatoPorNome();
                    break;
                case "4":
                    ExcluirContatoPorTelefone();
                    break;
                case "5":
                    ExcluirContatoPorNome();
                    break;
                case "6":
                    OrdenarPorNome();
                    break;
                case "7":
                    OrdenarPorTelefone();
                    break;
                case "8":
                    ExibirContatos();
                    break;
                case "9":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Digite novamente.");
                    break;
            }
        }
    }
}


