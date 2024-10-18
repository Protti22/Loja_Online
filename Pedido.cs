public class Pedido : ICarriavel
{
    public Cliente Cliente { get; set; }
    public DateTime DataPedido { get; private set; }
    public string Status { get; set; }
    private List<Produto> Produtos { get; set; }

    public Pedido(Cliente cliente)
    {
        Cliente = cliente;
        DataPedido = DateTime.Now;
        Status = "Em Processamento";
        Produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        if (produto != null)
            Produtos.Add(produto);
    }

    public void RemoverProduto(Produto produto)
    {
        Produtos.Remove(produto);
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var produto in Produtos)
        {
            total += produto.CalcularPrecoFinal();
        }
        return total;
    }

    public void FinalizarPedido()
    {
        Status = "Concluído";
        // Aqui poderia haver lógica para atualizar estoque
    }
}
