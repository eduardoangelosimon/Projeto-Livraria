using System;
using System.Collections.Generic;
class Venda
{
    public Venda(int id, Vendedor vendedor, Cliente cliente, Estoque estoque)
    {
        Id = id;
        Vendedor = vendedor;
        Cliente = cliente;
        _produtos = new List<Produto>();
        _estoque = estoque;
    }
    private List<Produto> _produtos;
    private Estoque _estoque;
    public int Id { get; set; }
    public Vendedor Vendedor { get; set; }
    public Cliente Cliente { get; set; }
    public void AddProduto(Produto prod)
    {
        bool status = _estoque.VerificaDisponibilidade(prod);
        if (status)
            _produtos.Add(prod);
        else
            throw new Exception($"Não há estoque do produto:{prod.Id}");
    }
}

