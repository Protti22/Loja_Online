using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Loja loja = new Loja();

        ProdutoFisico produto1 = new ProdutoFisico
        {
            Nome = "PC",
            Codigo = "NP2346",
            Preco = 12000m,
            Peso = 4,
            Dimensao = new Dimensoes { Altura = 30, Largura = 30, Profundidade = 60 },
            Categoria = "Eletrônicos"
        };

        loja.CadastrarProduto(produto1);

        Cliente cliente = new Cliente
        {
            Nome = "Jose Junior",
            NumeroIdentificacao = "987654321",
            Endereco = "Rua rio das contas, 661",
            Contato = "juniorjose@gmail.com"
        };

        loja.CadastrarCliente(cliente);

        Pedido pedido = loja.CriarPedido(cliente);

        pedido.AdicionarProduto(produto1);

        decimal total = pedido.CalcularTotal();
        Console.WriteLine($"Total do pedido: {total:C}");

        pedido.FinalizarPedido();
        Console.WriteLine($"Status do pedido: {pedido.Status}");
    }
}
