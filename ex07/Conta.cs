// using System;
// using System.Dynamic;

// public class Conta{
// public string Tipo {get ; set ;}
// public  double Saldo {get ; set ;}
// public double Emprestimo {get ; set ;}


//  public Conta(string tipo, double saldo, double emprestimo)
 
//     {
//         Tipo = Tipo;
//         Saldo = Saldo;
//         Emprestimo = Emprestimo;
//     }
// }

using System;

public class Conta
{
    public string Tipo { get; set; }
    public double Saldo { get; set; }
    public double Emprestimo { get; set; }

    public Conta(string tipo, double saldo, double emprestimo)
    {
        Tipo = tipo; 
        Saldo = saldo; 
        Emprestimo = emprestimo; 
    }
}


