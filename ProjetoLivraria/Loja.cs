using System;
public class Loja
  {
    public int Id { get; set; }
    public string Endereco { get; set; }
    public Estoque _Estoque { get; set; }

  public Loja(int id, string endereco, Estoque estoque)
  {
    Id = id;
    Endereco = endereco;
    _Estoque = estoque;
  }
}
