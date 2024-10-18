public class Dimensoes
{
    public double Altura { get; set; }
    public double Largura { get; set; }
    public double Profundidade { get; set; }
}

public class ProdutoFisico : Produto
{
    public double Peso { get; set; }
    public Dimensoes Dimensao { get; set; }
    public string Categoria { get; set; }

    public override decimal CalcularPrecoFinal()
    {
        decimal taxaImposto = 0.1m;
        decimal custoEnvio = (decimal)Peso * 10;
        decimal precoComImposto = Preco + (Preco * taxaImposto);
        return precoComImposto + custoEnvio;
    }
}
