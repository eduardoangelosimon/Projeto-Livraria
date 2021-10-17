using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
                while (true)
        {
            Console.WriteLine("Escolha uma das opções a seguir: ");
            Console.WriteLine("1 - Mostrar lista de produtos");
            Console.WriteLine("2 - Mostrar lista de clientes");
            Console.WriteLine("0 - Sair do programa");

            Console.WriteLine("Digite o número da opção escolhida: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 0)
            {
                break;
            }

            if(opcao == 1)
            {
                StreamReader leitor = new StreamReader("produtos.txt", Encoding.Default);
                string[] linhas = leitor.ReadToEnd().Split('\n');

                foreach (var linha in linhas)
                {
                    Console.WriteLine(linha);
                }

                Console.ReadKey();
            }

            if (opcao == 2)
            {
                StreamReader leitor = new StreamReader("clientes.txt", Encoding.Default);
                string[] linhas = leitor.ReadToEnd().Split('\n');

                foreach (var linha in linhas)
                {
                    Console.WriteLine(linha);
                }

                Console.ReadKey();
            }
        }

        Cliente cliente1 = new Cliente(11111111, "Eduardo Simon", "Vila Velha");
        Cliente cliente2 = new Cliente(22222222, "Larissa Dantier", "Campos dos Goytacazes");
        Cliente cliente3 = new Cliente(33333333, "Marcio Pinheiro", "Vila Velha");
        Cliente cliente4 = new Cliente (44444444, "Allan Faé", "Cariacica");

        Vendedor vendedor1 = new Vendedor(1000, "Rafael Costa");
        Vendedor vendedor2 = new Vendedor(1001, "Gabriel Palhares");
        Vendedor vendedor3 = new Vendedor(1002, "Fernando Prass");

        Produto produto1 = new Produto(1, "Acessório", "Marcador de Página", 2.50);
        Produto produto2 = new Produto(2, "Livro", "O Poder do Hábito", 35.99);
        Produto produto3 = new Produto(3, "Livro", "Código Limpo", 89.99);
        Produto produto4 = new Produto(4, "Papelaria", "Caderno", 14.99);
        Produto produto5 = new Produto(5, "Games", "Gift Card", 50.00);

        Estoque estoque1 = new Estoque();
        estoque1.CadastrarProduto(produto1, 100);
        estoque1.CadastrarProduto(produto2, 33);
        estoque1.CadastrarProduto(produto3, 20);
        estoque1.CadastrarProduto(produto4, 25);
        estoque1.CadastrarProduto(produto5, 43);

        Estoque estoque2 = new Estoque();
        estoque2.CadastrarProduto(produto1, 11);
        estoque2.CadastrarProduto(produto2, 20);
        estoque2.CadastrarProduto(produto3, 6);
        estoque2.CadastrarProduto(produto4, 92);
        estoque2.CadastrarProduto(produto5, 63);

        Estoque estoque3 = new Estoque();
        estoque3.CadastrarProduto(produto1, 45);
        estoque3.CadastrarProduto(produto2, 67);
        estoque3.CadastrarProduto(produto3, 13);
        estoque3.CadastrarProduto(produto4, 7);
        estoque3.CadastrarProduto(produto5, 41);

        Loja loja1 = new Loja(1, "Vila Velha, Praia da Costa, 1804", estoque1);
        Loja loja2 = new Loja(2, "Vitoria, Jardim da Penha, 654",estoque2);
        Loja loja3 = new Loja(3, "Cariacica, Campo Grande, 902",estoque3);

        Venda venda01 = new Venda(1, 5000.0, vendedor2, cliente4, loja1);
        try
        {
            venda01.AddProduto(produto3);
            venda01.AddProduto(produto1);
        }
        catch
        {
            Console.WriteLine("Produto adicionado não possui estoque. Venda Cancelada!");
        }
        ISetorEntrega entrega = new EntregaTerceirizada();

        entrega.DespacharProdutos(venda01, venda01.Loja._Estoque);

    }
}