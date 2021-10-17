using System;
using System.Collections.Generic;

class EntregaCorreios : ISetorEntrega
{
    public void DespacharProdutos(Venda venda, Estoque _estoque)
    {
        foreach (var item in venda._produtos)
        {
            Enviar(_estoque, item);
        }
    }
    private void Enviar(Estoque _estoque, Produto _produto)
    {

        if(_estoque.VerificaDisponibilidade(_produto)){
            Console.WriteLine($"Produto em falta no estoque!");
        }

        else
        {
            Random rand = new Random();
            Console.WriteLine($"A sua compra chegará em {rand.Next(1 , 50)} dias");
        }
    }
}