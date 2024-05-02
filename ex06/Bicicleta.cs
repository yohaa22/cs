public class Bicicleta : Veiculos{
    public int NumeroMarcha { get; set; }
    public string Tipo{ get; set; }
    


public Bicicleta(string marca, string modelo, int rodas, int ano,int NumeroMarcha, string Tipo)
        : base(marca, modelo, rodas, ano){
        this.NumeroMarcha = NumeroMarcha;
        this.Tipo = Tipo;

    }

}