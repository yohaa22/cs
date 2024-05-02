// Classe derivada
public class Desenvolvedor : Funcionario
{
    public string LinguagemDeProgramacao { get; set; }

    public void Programar()
    {
        Console.WriteLine($"{Nome} está programando em {LinguagemDeProgramacao}.");
    }
}