using System;
using System.Globalization;
using System.Collections.Generic;

namespace CaixaMercado
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> carrinho = new List<Produto>();
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("1. Adicionar Produto");
                Console.WriteLine("2. Listar Produtos");
                Console.WriteLine("3. Finalizar Compra");
                Console.WriteLine("4. Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarProduto(carrinho);
                        break;
                    case 2:
                        ListarProdutos(carrinho);
                        break;
                    case 3:
                        FinalizarCompra(carrinho);
                        carrinho.Clear();
                        break;
                    case 4:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }

        }

        static void AdicionarProduto(List<Produto> carrinho)
        {
            Console.WriteLine("Nome do Produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Preço do Produto: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            carrinho.Add(new Produto { Nome = nome, Preco = preco });
            Console.WriteLine("Produto adicionado com sucesso!\n");
        }

        static void ListarProdutos(List<Produto> carrinho)
        {
            Console.WriteLine("Produtos no Carrinho:");
            foreach (var produto in carrinho)
            {
                Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco:C}");
            }
            Console.WriteLine();
        }
        static void FinalizarCompra(List<Produto> carrinho)
        {
            decimal total = 0;

            Console.WriteLine("Resumo da Compra: ");
            foreach (var produto in carrinho) 
            {
                Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco:C}");
                total += produto.Preco;
            }

            Console.WriteLine($"Total a pagar: {total:C}\n");
        }
        class Produto
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }
        }
    }
}

