using System;

public class Idiomas
{
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Pagamento { get; set; }
    public string Curso { get; set; }

    public Idiomas(double Nota1, double Nota2, double Pagamento, string Curso)
    {
        this.Nota1 = Nota1;
        this.Nota2 = Nota2;
        this.Pagamento = Pagamento;
        this.Curso = Curso;
    }
}