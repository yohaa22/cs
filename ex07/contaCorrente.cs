

public class contaCorrente : Conta
{
    public double saldoMinimo { get; set; }
        public string Nome { get; set; }


    public contaCorrente(string tipo, double saldo, double emprestimo, double saldoMinimo, string nome)
        : base(tipo, saldo, emprestimo)
    {
        this.saldoMinimo = saldoMinimo;
        this.Nome = nome; 
    }
}

