using System;

class EntregaCorreios : ISetorEntrega
{
    public void DespacharProdutos(Venda venda)
    {
        Console.WriteLine("Produto Despachado.");
        Console.WriteLine("Um dia seu produto será entregue, se não extraviar.");
    }
}

