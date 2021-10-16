public class Produto
{
    public Produto(int id, string categoria, string nome, double preco)
    {
        Id = id;
        Categoria = categoria;
        Nome = nome;
        Preco = preco;
    }
    public int Id { get; set; }
    public string Categoria { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }
}

