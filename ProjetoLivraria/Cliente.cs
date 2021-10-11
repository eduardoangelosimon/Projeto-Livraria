class Cliente
{
    public Cliente(int id, string nome, string endereco)
    {
        Id = id;
        Nome = nome;
        Endereco = endereco;
    }
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
}

