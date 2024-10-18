public class Loja
{
    private List<Produto> Produtos { get; set; }
    private List<Cliente> Clientes { get; set; }
    private List<Pedido> Pedidos { get; set; }

    public Loja()
    {
        Produtos = new List<Produto>();
        Clientes = new List<Cliente>();
        Pedidos = new List<Pedido>();
    }

    public void CadastrarProduto(Produto produto)
    {
        if (produto != null && !Produtos.Any(p => p.Codigo == produto.Codigo))
        {
            Produtos.Add(produto);
            Console.WriteLine("Produto cadastrado com sucesso.");
        }
    }

    public void CadastrarCliente(Cliente cliente)
    {
        if (cliente != null && !Clientes.Any(c => c.NumeroIdentificacao == cliente.NumeroIdentificacao))
        {
            Clientes.Add(cliente);
            Console.WriteLine("Cliente cadastrado com sucesso.");
        }
    }

    public Pedido CriarPedido(Cliente cliente)
    {
        if (Clientes.Contains(cliente))
        {
            var pedido = new Pedido(cliente);
            Pedidos.Add(pedido);
            return pedido;
        }
        return null;
    }

    public void ListarProdutos()
    {
        foreach (var produto in Produtos)
        {
            Console.WriteLine($"Produto: {produto.Nome}, Código: {produto.Codigo}, Preço: {produto.Preco}");
        }
    }
}
