public class Debito : IMetodoPagamento
{
    public bool ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Pagamento de {valor} processado com debito.");
        return true;
    }
}
