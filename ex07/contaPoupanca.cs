// public class contaPoupanca : Conta
// {
//     public double Calcularjuros { get; set; }
//     // public string TipoTrocaMarcha { get; set; }


//     public contaPoupanca (string Tipo, double Saldo, double Emprestimo, double calcularjuros)
//         : base(Tipo, Saldo, Emprestimo)
//     {
//         Calcularjuros = Calcularjuros;
//     }
// }

public class contaPoupanca : Conta
{
    public double Calcularjuros { get; set; }

    public contaPoupanca(string tipo, double saldo, double emprestimo, double calcularjuros)
        : base(tipo, saldo, emprestimo)
    {
        Calcularjuros = calcularjuros; 
    }
}

