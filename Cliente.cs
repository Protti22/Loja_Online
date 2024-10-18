public class Cliente
{
    public string Nome { get; set; }
    public string NumeroIdentificacao { get; set; }
    public string Endereco { get; set; }
    public string Contato { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome} ID: {NumeroIdentificacao} Endereço: {Endereco} Contato: {Contato}");
    }
}
