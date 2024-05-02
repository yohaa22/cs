using System.ComponentModel;

public class filmes{
    public string Titulo;
    public string Genero;
    public double duracao;
    public bool disponivel;



public filmes(string Titulo, string Genero, double duracao, bool disponivel)
{
        this.Titulo = Titulo;
        this.Genero = Genero;
        this.duracao = duracao;
        this.disponivel = disponivel;

    }

        public void Alugar()
    {
        if (disponivel)
        {
            disponivel = false;
            Console.WriteLine($"O filme foi alugado.");
        }
        else
        {
            Console.WriteLine("Desculpe, o filme  não está disponível para locação no momento.");
        }
    }
    

        public void Devolver()
    {
        disponivel = true;
        Console.WriteLine("O filme foi devolvido e agora está disponível para locação.");
    }

    public void verificacao()
    {
        if (disponivel)
        {
            Console.WriteLine($"  está disponível para locação.");
        }
        else
        {
            Console.WriteLine($" não está disponível para locação no momento.");



} 
    }
}

