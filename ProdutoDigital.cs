public class ProdutoDigital : Produto
{
    public double TamanhoArquivo { get; set; }
    public string Formato { get; set; }

    public override decimal CalcularPrecoFinal()
    {
        decimal taxaDesconto = 0.1m;
        decimal desconto = Preco * taxaDesconto;
        return Preco - desconto;
    }
}
