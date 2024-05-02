public class Carros : Veiculos{
    public int NumeroPortas { get; set; }
    public string nome { get; set; }
    


public Carros(string marca, string modelo, int rodas, int ano, int NumeroPortas, string nome)
        : base(marca, modelo, rodas, ano)
{
        this.NumeroPortas = NumeroPortas;
        this.nome = nome;

    }

}