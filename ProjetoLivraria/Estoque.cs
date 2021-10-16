using System.Collections.Generic;
public class Estoque
{
    public Estoque()
    {
        _produtos = new Dictionary<int, int>();
    }
    private Dictionary<int, int> _produtos;
    public bool VerificaDisponibilidade(Produto prod)
    {
        int qtd = _produtos[prod.Id];

        if (qtd > 0)
            return true;
        else
            return false;
    }
    public void CadastrarProduto(Produto prod, int qtdInicial)
    {
        _produtos.Add(prod.Id, qtdInicial);
    }
    public void DarBaixaDeProduto(Produto prod)
    {
        _produtos[prod.Id]--;
    }
}
