class Cliente
{
    public Cliente(int cpf, string nome, string endereco)
    {
        CPF = cpf;
        Nome = nome;
        Endereco = endereco;
    }
    public int CPF { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
}

