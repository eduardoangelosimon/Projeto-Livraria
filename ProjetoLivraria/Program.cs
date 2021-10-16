using System;
class Program
{
    static void Main(string[] args)
    {
        Cliente cliente1 = new Cliente(11111111, "Eduardo Simon", "Vila Velha");
        Cliente cliente2 = new Cliente(22222222, "Larissa Dantier", "Campos dos Goytacazes");
        Cliente cliente3 = new Cliente(33333333, "Marcio Pinheiro", "Vila Velha");
        Cliente cliente4 = new Cliente (44444444, "Allan Faé", "Cariacica");

        Vendedor vendedor1 = new Vendedor(1000, "Rafael Costa");
        Vendedor vendedor2 = new Vendedor(1001, "Gabriel Palhares");
        Vendedor vendedor3 = new Vendedor(1002, "Fernando Prass");

        Produto produto1 = new Produto(1, "Acessório", "Marcador de Página", 2.50m);
        Produto produto2 = new Produto(2, "Livro", "O Poder do Hábito", 35.99m);
        Produto produto3 = new Produto(3, "Livro", "Código Limpo", 1999.99m);
        Produto produto4 = new Produto(4, "Papelaria", "Caderno", 14.99m);
        Produto produto5 = new Produto(5, "Games", "Gift Card", 50.00m);

        Estoque estoque1 = new Estoque();
        estoque1.CadastrarProduto(produto1, 100);
        estoque1.CadastrarProduto(produto2, 33);
        estoque1.CadastrarProduto(produto3, 0);
        estoque1.CadastrarProduto(produto4, 25);
        estoque1.CadastrarProduto(produto5, 43);

        Estoque estoque2 = new Estoque();
        estoque2.CadastrarProduto(produto1, 11);
        estoque2.CadastrarProduto(produto2, 20);
        estoque2.CadastrarProduto(produto3, 6);
        estoque2.CadastrarProduto(produto4, 92);
        estoque2.CadastrarProduto(produto5, 63);

        Estoque estoque3 = new Estoque();
        estoque2.CadastrarProduto(produto1, 45);
        estoque2.CadastrarProduto(produto2, 67);
        estoque2.CadastrarProduto(produto3, 13);
        estoque2.CadastrarProduto(produto4, 7);
        estoque2.CadastrarProduto(produto5, 41);

        Loja loja1 = new Loja(1, estoque1);
        Loja loja2 = new Loja(2, estoque2);
        Loja loja3 = new Loja(3, estoque3);



        Venda venda01 = new Venda(1, vendedor2, cliente4, loja1);
        try
        {
            venda01.AddProduto(produto3);
            venda01.AddProduto(produto1);
        }
        catch
        {
            Console.WriteLine("Produto adicionado não possui estoque. Venda Cancelada");
        }
        ISetorEntrega entrega = new EntregaTerceirizada();
        entrega.DespacharProdutos(venda01);
    }
}
