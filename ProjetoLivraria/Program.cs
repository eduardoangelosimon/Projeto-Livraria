using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        ISetorEntrega correios = new EntregaCorreios();
        ISetorEntrega terceirizada = new EntregaTerceirizada();

        Cliente cliente = new Cliente(11111111, "Eduardo Simon", "Vila Velha");

        Vendedor vendedor = new Vendedor(1000, "Rafael Costa");

        Dictionary <int, double> listaDeProdutos = new Dictionary<int, double>();
        Dictionary <int, double> carrinho = new Dictionary <int, double>();
        Dictionary <int, Loja> listaLojas = new Dictionary <int, Loja>();

        Produto produto1 = new Produto(1, "Acessório", "Marcador de Página", 2.50);
        listaDeProdutos.Add(produto1.Id, produto1.Preco);

        Produto produto2 = new Produto(2, "Livro", "O Poder do Hábito", 35.99);
        listaDeProdutos.Add(produto2.Id, produto2.Preco);

        Produto produto3 = new Produto(3, "Livro", "Código Limpo", 89.99);
        listaDeProdutos.Add(produto3.Id, produto3.Preco);

        Produto produto4 = new Produto(4, "Papelaria", "Caderno", 14.99);
        listaDeProdutos.Add(produto4.Id, produto4.Preco);

        Produto produto5 = new Produto(5, "Games", "Gift Card", 50.00);
        listaDeProdutos.Add(produto5.Id, produto5.Preco);

        Estoque estoque1 = new Estoque();
        estoque1.CadastrarProduto(produto1, 1);
        estoque1.CadastrarProduto(produto2, 1);
        estoque1.CadastrarProduto(produto3, 1);
        estoque1.CadastrarProduto(produto4, 1);
        estoque1.CadastrarProduto(produto5, 1);

        Estoque estoque2 = new Estoque();
        estoque2.CadastrarProduto(produto1, 1);
        estoque2.CadastrarProduto(produto2, 1);
        estoque2.CadastrarProduto(produto3, 1);
        estoque2.CadastrarProduto(produto4, 1);
        estoque2.CadastrarProduto(produto5, 1);

        Estoque estoque3 = new Estoque();
        estoque3.CadastrarProduto(produto1, 1);
        estoque3.CadastrarProduto(produto2, 1);
        estoque3.CadastrarProduto(produto3, 1);
        estoque3.CadastrarProduto(produto4, 1);
        estoque3.CadastrarProduto(produto5, 1);

        Loja loja1 = new Loja(1, "Vila Velha, Praia da Costa, 1804", estoque1);
        listaLojas.Add(loja1.Id, loja1);
        Loja loja2 = new Loja(2, "Vitoria, Jardim da Penha, 654",estoque2);
        listaLojas.Add(loja2.Id, loja2);
        Loja loja3 = new Loja(3, "Cariacica, Campo Grande, 902",estoque3);
        listaLojas.Add(loja3.Id, loja3);

        double valorTotal = 0;
        while (true)
        {
            Console.WriteLine("Escolha uma das opções a seguir: ");
            Console.WriteLine("1 - Adicionar Produto no Carrinho (use o ID da lista de produtos para isso)");
            Console.WriteLine("2 - Concluir venda");
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

                Console.WriteLine("Qual produto deseja comprar? ");
                int produtoEscolhido = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Em qual loja deseja comprar? (1,2 ou 3)");
                int lojaEscolhida = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qual frete deseja escolher? ");
                Console.WriteLine("1 - Correios, Grátis (25 a 50 dias)");
                Console.WriteLine("2 - Terceirizada, R$10 (1 a 25 dias");
                int tipoEntrega = Convert.ToInt32(Console.ReadLine());
                
                carrinho.Add(produtoEscolhido, listaDeProdutos[produtoEscolhido]);

                int id = 1;
                Venda venda = new Venda(id, vendedor, cliente, listaLojas[lojaEscolhida]);
                id++;

                foreach (var preco in carrinho)
                {
                    valorTotal += preco.Value;
                }

                if (tipoEntrega == 1)
                {
                    correios.DespacharProdutos(venda, venda.Loja._Estoque);
                }

                if(tipoEntrega == 2)
                {
                    valorTotal += 10;
                    terceirizada.DespacharProdutos(venda, venda.Loja._Estoque);
                }

            }

            if (opcao == 2)
            {
                Console.WriteLine($"O valor total da sua compra foi de: R${valorTotal}");
                break;
            }
        }
    }
}