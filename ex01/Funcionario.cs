// Classe base
public class Funcionario
{
    public string Nome { get; set; }
    public string ID { get; set; }

    public void Trabalhar()
    {
        Console.WriteLine($"{Nome} está trabalhando.");
    }
}