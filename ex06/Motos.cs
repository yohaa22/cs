
public class Motos : Veiculos
{
    public int Cilindradas { get; set; }
    public string TipoTrocaMarcha { get; set; }

    public Motos(string marca, string modelo, int rodas, int ano, string tipoTrocaMarcha, int cilindradas)
        : base(marca, modelo, rodas, ano)
    {
        TipoTrocaMarcha = tipoTrocaMarcha;
        Cilindradas = cilindradas;
    }
}
