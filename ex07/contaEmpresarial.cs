// public class contaEmpresarial : Conta
// {
//     public double saldoMinimo { get; set; }



//     public contaEmpresarial (string Tipo, double Saldo, double Emprestimo, double saldominimo)
//         : base(Tipo, Saldo, Emprestimo)
//     {
//         this.saldoMinimo = saldoMinimo;
//     }
// }

public class contaEmpresarial : Conta
{
    public double saldoMinimo { get; set; }

    public contaEmpresarial(string tipo, double saldo, double emprestimo, double saldoMinimo)
        : base(tipo, saldo, emprestimo)
    {
        this.saldoMinimo = saldoMinimo; 
    }
}
