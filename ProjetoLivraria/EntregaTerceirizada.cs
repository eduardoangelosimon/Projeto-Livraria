using System;
class EntregaTerceirizada : ISetorEntrega
{
    public void DespacharProdutos(Venda venda)
    {
        Verificar();
        Enviar();
    }
    private void Verificar()
    {
        Console.WriteLine("Verificando Parceiro.");
    }
    private void Enviar()
    {
        Random rand = new Random();
        Console.WriteLine($"Produto chegara em {rand.Next(1 , 360)} dias");
    }
}

