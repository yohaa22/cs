public class Boleto : IMetodoPagar
{
    public double preco1;
    public double valor1;

    public void RealizarPagamento()
    {
        // Lógica para realizar o pagamento com boleto bancário
    }

    public void VerificarStatusPagamento()
    {
        if (preco1 >= valor1)
        {
            Console.WriteLine("Pagamento realizado (em processamento)\n");
        }
        else
        {
            Console.WriteLine("Pagamento não realizado (valor insuficiente)\n");
        }
    }

    public void DefinirPreco1(double preco)
    {
        this.preco1 = preco;
    }

    public void DefinirValor1(double valor)
    {
        this.valor1 = valor;
    }
}