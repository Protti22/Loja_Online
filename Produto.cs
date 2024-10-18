public abstract class Produto
{
    public string Nome {get; set;}
    public string Codigo {get; set;}
    public decimal Preco {get; set;}

    public abstract decimal CalcularPrecoFinal();
}