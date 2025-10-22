using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Produto> CarregarProdutos()
    {
        List<Produto> produtos = new List<Produto>();

        if (File.Exists("produtos.txt"))
        {
            string[] linhas = File.ReadAllLines("produtos.txt");

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(';');

                if (partes.Length == 3 &&
                    int.TryParse(partes[1], out int quantidade) &&
                    double.TryParse(partes[2], out double preco))
                {
                    produtos.Add(new Produto(partes[0], quantidade, preco));
                }
            }
        }

        return produtos;
    }

    static void SalvarProdutos(List<Produto> produtos)
    {
        List<string> linhas = new List<string>();

        foreach (var p in produtos)
        {
            linhas.Add($"{p.Nome};{p.Quantidade};{p.Preco}");
        }

        File.WriteAllLines("produtos.txt", linhas);
    }

    static void Main()
    {
        List<Produto> produtos = CarregarProdutos();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n📦 Bem-vinda ao StockApp!");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1. Adicionar produto");
            Console.WriteLine("2. Listar produtos");
            Console.WriteLine("3. Atualizar quantidade");
            Console.WriteLine("4. Remover produto");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine()!;


            switch (opcao)
            {
                case "1":
                    Console.Write("Nome do produto: ");
                   string nome = Console.ReadLine()!;


                    Console.Write("Quantidade: ");
                    bool qOk = int.TryParse(Console.ReadLine(), out int quantidade);

                    Console.Write("Preço: ");
                    bool pOk = double.TryParse(Console.ReadLine(), out double preco);

                    if (!string.IsNullOrEmpty(nome) && qOk && pOk)
                    {
                        produtos.Add(new Produto(nome, quantidade, preco));
                        SalvarProdutos(produtos);
                        Console.WriteLine("Produto adicionado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Dados inválidos. Tente novamente.");
                    }
                    break;

                case "2":
                    Console.WriteLine("\n📋 Lista de Produtos:");
                    if (produtos.Count == 0)
                    {
                        Console.WriteLine("Nenhum produto cadastrado.");
                    }
                    else
                    {
                        for (int i = 0; i < produtos.Count; i++)
                        {
                            Produto p = produtos[i];
                            double total = p.Quantidade * p.Preco;
                            Console.WriteLine($"{i + 1}. 🧺 {p.Nome} | Quantidade: {p.Quantidade} | Preço: R$ {p.Preco:F2} | Total: R$ {total:F2}");
                        }
                    }
                    break;

                case "3":
                    if (produtos.Count == 0)
                    {
                        Console.WriteLine("Nenhum produto cadastrado para atualizar.");
                        break;
                    }

                    Console.WriteLine("\nQual produto deseja atualizar a quantidade?");
                    for (int i = 0; i < produtos.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {produtos[i].Nome} - Quantidade: {produtos[i].Quantidade}");
                    }
                    Console.Write("Número do produto: ");

                    if (int.TryParse(Console.ReadLine(), out int idxAtualizar) && idxAtualizar >= 1 && idxAtualizar <= produtos.Count)
                    {
                        Console.Write("Nova quantidade: ");
                        if (int.TryParse(Console.ReadLine(), out int novaQtd))
                        {
                            produtos[idxAtualizar - 1].Quantidade = novaQtd;
                            SalvarProdutos(produtos);
                            Console.WriteLine("✅ Quantidade atualizada com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("🚫 Quantidade inválida.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("🚫 Número inválido.");
                    }
                    break;

                case "4":
                    if (produtos.Count == 0)
                    {
                        Console.WriteLine("Nenhum produto cadastrado para remover.");
                        break;
                    }

                    Console.WriteLine("\nQual produto deseja remover?");
                    for (int i = 0; i < produtos.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {produtos[i].Nome}");
                    }
                    Console.Write("Número do produto: ");

                    if (int.TryParse(Console.ReadLine(), out int idxRemover) && idxRemover >= 1 && idxRemover <= produtos.Count)
                    {
                        produtos.RemoveAt(idxRemover - 1);
                        SalvarProdutos(produtos);
                        Console.WriteLine("✅ Produto removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("🚫 Número inválido.");
                    }
                    break;

                case "5":
                    Console.WriteLine("👋 Saindo...");
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("🚫 Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
