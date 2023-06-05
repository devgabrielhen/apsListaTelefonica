using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Contato
{
    private static int contador = 0;

    public int ID { get; }
    public string Nome { get; }
    public int Telefone { get; }

    public Contato(string nome, int telefone)
    {
        contador++;
        ID = contador;
        Nome = nome;
        Telefone = telefone;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Telefone: {Telefone}");
        Console.WriteLine("----------------------");
    }
}