using System;
public class Loja
  {
    public int Id { get; set; }
    public Estoque _Estoque { get; set; }
  public Loja(int id, Estoque estoque)
  {
    Id = id;
    _Estoque = estoque;
  }
}
