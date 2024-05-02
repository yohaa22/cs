public class Credito : IMetodoPagar

{
    public double preco1;
    public double valor1;

    public void RealizarPagamento()
    {
        // Lógica para realizar o pagamento com cartão de crédito
    }


       public void VerificarStatusPagamento()
    {
        if (preco1 >= valor1)
        {
            Console.WriteLine("fatura paga (vencimento do cartao dia 11)\n");
        }
        else
        {
            Console.WriteLine("Pagamento não realizado (valor insuficiente)\n");
        }
    }

    public void DefinirPreco(double preco)
    {
        this.preco1 = preco;
    }

    public void DefinirValor(double valor)
    {
        this.valor1 = valor;
    }
}
    

