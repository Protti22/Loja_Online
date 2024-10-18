using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Loja loja = new Loja();

        ProdutoFisico produto1 = new ProdutoFisico
        {
            Nome = "Notebook",
            Codigo = "NB123",
            Preco = 2500m,
            Peso = 2.5,
            Dimensao = new Dimensoes { Altura = 5, Largura = 35, Profundidade = 25 },
            Categoria = "Eletrônicos"
        };

        loja.CadastrarProduto(produto1);

        Cliente cliente = new Cliente
        {
            Nome = "João Silva",
            NumeroIdentificacao = "123456789",
            Endereco = "Rua das Flores, 123",
            Contato = "joao@email.com"
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
