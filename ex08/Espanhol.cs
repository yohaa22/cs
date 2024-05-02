public class Espanhol : Idiomas
{
    public bool certificado { get; set; }
    public bool saber {get; set; }

    public Espanhol(double Nota1, double Nota2, double Pagamento, string Curso, bool Certificado,  bool saber)
        : base(Nota1, Nota2, Pagamento, Curso)
    {
        this.certificado = Certificado;
         this.saber = saber;
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
            Console.WriteLine("Parabéns, você concluiu o curso de Espanhol!!");
        }
        else
        {
            Console.WriteLine("Desculpe, mas sua média não foi batida.");
         
        }
    }


  public void manjar()
    {
        if (calcular() > 7)
        {
            Console.WriteLine("Aprendeu Espanhol");
        }
        else
        {
            Console.WriteLine("Não aprendeu Espanhol");
        }
    }
}