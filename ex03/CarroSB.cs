public class CarroSB : VeiculoSB {
    public override void Mover() {
        Console.WriteLine("Carro está se movendo rapidamente");
    }

    // Sobrecarga do método Mover para aceitar uma velocidade
    public void Mover(int velocidade) {
        Console.WriteLine($"Carro está se movendo rapidamente a {velocidade} km/h");
    }
}