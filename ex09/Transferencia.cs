public class Transferencia : IMetodoPagar
{
    public double preco1;
    public double valor1;

    public void RealizarPagamento()
    {
        // Lógica para realizar o pagamento com transferência bancária
    }

    public void VerificarStatusPagamento()
    {
  if (preco1 >= valor1)
        {
            Console.WriteLine("tranferencia realizada)\n");
        }
        else
        {
            Console.WriteLine("saldo insuficiente\n");
        }    }



  public void DefinirPreco(double preco)
    {
        this.preco1 = preco;
    }

    public void DefinirValor(double valor)
    {
        this.valor1 = valor;
    }
}
    

