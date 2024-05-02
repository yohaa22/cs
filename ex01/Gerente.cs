// Classe derivada
public class Gerente : Funcionario
{
    public string Departamento { get; set; }

    public void Gerenciar()
    {
        Console.WriteLine($"{Nome} está gerenciando o departamento {Departamento}.");
    }
}