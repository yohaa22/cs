public class CartaoCredito : IMetodoPagamento
{
    public bool ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Pagamento de {valor} processado com cartão de crédito.");
        return true;
    }
}
