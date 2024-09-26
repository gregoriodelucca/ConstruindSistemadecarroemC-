using System;
using System.Collections.Generic;

public class Program
{
    static List<Carro> estacionamento = new List<Carro>();

    public static void Main(string[] args)
    {
        int opcao;
        do
        {
            Console.WriteLine("Sistema de Estacionamento");
            Console.WriteLine("1. Adicionar Carro");
            Console.WriteLine("2. Remover Carro");
            Console.WriteLine("3. Listar Carros");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarCarro();
                    break;
                case 2:
                    RemoverCarro();
                    break;
                case 3:
                    ListarCarros();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (opcao != 0);
    }

    static void AdicionarCarro()
    {
        Console.Write("Informe a placa do carro: ");
        string placa = Console.ReadLine();
        estacionamento.Add(new Carro { Placa = placa });
        Console.WriteLine("Carro adicionado com sucesso!");
    }

    static void RemoverCarro()
    {
        Console.Write("Informe a placa do carro a ser removido: ");
        string placa = Console.ReadLine();
        var carro = estacionamento.Find(c => c.Placa == placa);
        if (carro != null)
        {
            estacionamento.Remove(carro);
            Console.WriteLine("Carro removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Carro não encontrado.");
        }
    }

    static void ListarCarros()
    {
        Console.WriteLine("Carros no estacionamento:");
        foreach (var carro in estacionamento)
        {
            Console.WriteLine($"Placa: {carro.Placa}");
        }
    }
}

public class Carro
{
    public string Placa { get; set; }
}
