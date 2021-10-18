using System;
using System.Collections.Generic;
class Venda
{
    public Venda(int id, Vendedor vendedor, Cliente cliente, Loja loja)
    {
        Id = id;
        Vendedor = vendedor;
        Cliente = cliente;
        _produtos = new List<Produto>();
        Loja = loja;
    }
    public List<Produto> _produtos;
    private Estoque _estoque;
    public int Id { get; set; }
    public Vendedor Vendedor { get; set; }
    public Cliente Cliente { get; set; }
    public Loja Loja { get; set; }
    public void AddProduto(Produto prod)
    {
        bool status = _estoque.VerificaDisponibilidade(prod);
        if (status) 
        {
            _produtos.Add(prod);
            Console.WriteLine("Teste");
        }

        else
            throw new Exception($"Não há estoque do produto:{prod.Id}");
    }
}