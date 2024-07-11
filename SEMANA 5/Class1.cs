namespace menu
{
    public class Class1
    {

    }
}
using System;

namespace MenuOptionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("Menu de Opções:");
                Console.WriteLine("1. Criar Produto");
                Console.WriteLine("2. Listar Produtos");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CriarProduto();
                        break;
                    case 2:
                        ListarProdutos();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (choice != 0);
        }

        private static void CriarProduto()
        {
            // Lógica para criar um produto
            Console.WriteLine("Função de criar produto.");
        }

        private static void ListarProdutos()
        {
            // Lógica para listar produtos
            Console.WriteLine("Função de listar produtos.");
        }
    }
}
