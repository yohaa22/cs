public class Ingles : Idiomas
{ public double Calcularjuros { get; set; }

        public bool certificado { get; set; }

    public Ingles (double Nota1,double Nota2, double Pagamento, string Curso ,bool Certificado)
        : base(Nota1, Nota2, Pagamento, Curso)
   {
        this.certificado = Certificado;
    }

    public double calcular()
    {
        return (Nota1 + Nota2) / 2;
    }

    public void verificar()
    {
        if (calcular() > 6)
        {
            Console.WriteLine("Parabéns, você conseguiu ser aprovado!!");
            Console.WriteLine("Parabéns, você concluiu o curso de ingles!!");
        }
        else
        {
            Console.WriteLine("Desculpe, mas sua média não foi batida.");
            certificado = true;
        }
    }
    public void manjar()
    {
        if (calcular() > 7)
        {
            Console.WriteLine("Aprendeu Ingles");
        }
        else
        {
            Console.WriteLine("Não aprendeu Ingles");
        }
    }
}


