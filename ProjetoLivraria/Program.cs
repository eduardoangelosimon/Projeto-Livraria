using System;
class Program
{
    static void Main(string[] args)
    {
        Cliente ricardo = new Cliente(1, "Ricardo Mendes", "Vila Velha");

        Vendedor cleyton = new Vendedor(525, "Cleyton");

        Produto mouse = new Produto(1, "Informatica", "Mouse", 15.00m);
        Produto teclado = new Produto(2, "Informatica", "Teclado", 35.99m);
        Produto cadeira = new Produto(3, "Informatica", "Cadeira Gamer", 1999.99m);

        Estoque estoque = new Estoque();
        estoque.CadastrarProduto(mouse, 100);
        estoque.CadastrarProduto(teclado, 33);
        estoque.CadastrarProduto(cadeira, 0);

        Venda venda01 = new Venda(1, cleyton, ricardo, estoque);
        try
        {
            venda01.AddProduto(mouse);
            venda01.AddProduto(mouse);
            venda01.AddProduto(cadeira);
        }
        catch
        {
            Console.WriteLine("Produto adicionado não possui estoque. Venda Cancelada");
        }
        ISetorEntrega entrega = new EntregaTerceirizada();
        entrega.DespacharProdutos(venda01);
    }
}
