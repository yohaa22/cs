using System;




//so pra testar
//exercicio01
// namespace SistemaDeGerenciamentoDeFuncionarios
// {
//     class Programa
//     {
//         static void Main(string[] args)
//         {
//             Gerente meuGerente = new Gerente();
//             meuGerente.Nome = "João";
//             meuGerente.Departamento = "Vendas";
//             meuGerente.Trabalhar(); // João está trabalhando.
//             meuGerente.Gerenciar(); // João está gerenciando o departamento Vendas.

//             Desenvolvedor meuDesenvolvedor = new Desenvolvedor();
//             meuDesenvolvedor.Nome = "Maria";
//             meuDesenvolvedor.LinguagemDeProgramacao = "C#";
//             meuDesenvolvedor.Trabalhar(); // Maria está trabalhando.
//             meuDesenvolvedor.Programar(); // Maria está programando em C#.
//         }
//     }
// }
// //final do exercicio01


////////////////////////////////////////////////////////////////////////////////////////////
///

// //final do exercicio02



// public class Program
// {
//     static void Main(string[] args)
//     {
//         // Exemplo de pagamento com cartão de crédito
//         CartaoCredito cartaoCredito = new CartaoCredito();
//         decimal valorCompraCartao = 500.50m;
//         cartaoCredito.ProcessarPagamento(valorCompraCartao);

//         // Exemplo de pagamento com débito
//         Debito debito = new Debito();
//         decimal valorCompraDebito = 300.25m;
//         debito.ProcessarPagamento(valorCompraDebito);
//     }
// }









//////////////////////////////////////////////////////////////


//exercicio03 (sobrecarga)


// public class programaSC
// {
//     public static void Main()
//     {
//         calcSC calc = new calcSC();

//         // Chamadas dos métodos sobrecarregados
//         Console.WriteLine("Soma de dois inteiros: " + calc.Soma(10, 20));
//         Console.WriteLine("Soma de três inteiros: " + calc.Soma(10, 20, 30));
//         Console.WriteLine("Soma de dois números de ponto flutuante: " + calc.Soma(10.5, 20.5));
//     }
// }
//  //final do exercicio03 (sobrecarga)

//////////////////////////////////////////////////////////////////////////////////////////////////////



//exercicio03 (sobreposição)


// class Programa {

// static void Main(string[] args) {
        
//         VeiculoSB meuVeiculo = new VeiculoSB();
//         meuVeiculo.Mover(); // Veículo está se movendo

//         CarroSB meuCarro = new CarroSB();
//         meuCarro.Mover(); // Carro está se movendo rapidamente

//         // Chamada da sobrecarga com velocidade
//         meuCarro.Mover(100); // Carro está se movendo rapidamente a 100 km/h
//     }

// }


//  //final do exercicio03 (sobreposição)
//////////////////////////////////////////////////////////////////////////////////////////////////////////



//exercicio04
// class Programa {

// static void Main(string[] args) {

// Produto nvProduto = new Produto("short" , 49.99 , 120); 


// nvProduto.AdicionarUnidades(6);

// nvProduto.RemoverUnidades(17);




// double VLT = nvProduto.ValorTotalEmEstoque();


// Console.WriteLine("o tanto q tem é " + nvProduto.quantidadeEmEstoque);
// Console.WriteLine("o valor no estoque é  " + VLT);
// }
// }

//final do exercicio04
///////////////////////////////////////////////////////////////////////////////////////////////////////

//Exercicio05
// class Programa {

// static void Main(string[] args) {

// filmes filmao = new filmes("chapeuzinho vermelho", "ação" , 120, false); 

// filmes filmao2 = new filmes("vingadores", "ação" , 120, true); 

// filmes filmao3 = new filmes("chapeuzinho branca", "ação" , 120, true); 


// filmao.Alugar();
// Console.WriteLine("o filme é o " + filmao.Titulo);

// Console.WriteLine("\n\no filme é o " + filmao2.Titulo);
// filmao2.verificacao();

// Console.WriteLine("\n\no filme é o " + filmao3.Titulo);
// filmao3.Devolver();



// }
// }


//final do exercicio 05
////////////////////////////////////////////////////////////////////////////////////////////////////////


//exercicio 06


// class Programa {

//     static void Main(string[] args)
//     {
//     

//         Motos minhaMoto = new Motos("Honda", "CG 160", 2, 2020, "Manual", 160);
//         Carros meuCarro = new Carros("Toyota", "Corolla", 4, 2021, 4, "Sedan");
//         Bicicleta minhaBicicleta = new Bicicleta("caloi", "bmx",2, 2019, 22,"Mountain Bike");

      
//         Console.WriteLine($"Minha bicicleta: {minhaBicicleta.Marca} {minhaBicicleta.Modelo} - Número de marchas: {minhaBicicleta.NumeroMarcha} - ano dela {minhaBicicleta.Ano}");
//         Console.WriteLine($"Minha moto: {minhaMoto.Marca} {minhaMoto.Modelo} - cilindradas: {minhaMoto.Cilindradas} - ano dela {minhaMoto.Ano} numero de rodas{minhaMoto.Rodas}");
//         Console.WriteLine($"meu carro: {meuCarro.Marca} {meuCarro.Modelo} - Número de marchas: {meuCarro.NumeroPortas} - ano dele {meuCarro.Ano}");
//     }
//     }
    
    
//final do exercicio06
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//exercicio 07


// class Program
// {
//     static void Main(string[] args)
//     {
//    
//         contaCorrente cc = new contaCorrente("Corrente", 1000.0, 500.0, 100.0, "jorge soares de lima");
//         Console.WriteLine("Conta Corrente: " + cc.Nome + "\n Tipo: " + cc.Tipo + "\nSaldo: " + cc.Saldo + "\nEmpréstimo: " + cc.Emprestimo + "\nSaldo Mínimo: " + cc.saldoMinimo);

//     Console.WriteLine("\n\n\n");

//         contaEmpresarial ce = new contaEmpresarial("Empresarial", 2000.0, 1000.0, 200.0);
//         Console.WriteLine("Conta Empresarial:");
//         Console.WriteLine("Tipo: " + ce.Tipo);
//         Console.WriteLine("Saldo: " + ce.Saldo);
//         Console.WriteLine("Empréstimo: " + ce.Emprestimo);
//         Console.WriteLine("Saldo Mínimo: " + ce.saldoMinimo);
//         Console.WriteLine();

//      
//         contaPoupanca cp = new contaPoupanca("Poupança", 500.0, 0.0, 0.05);
//         Console.WriteLine("Conta Poupança:");
//         Console.WriteLine("Tipo: " + cp.Tipo);
//         Console.WriteLine("Saldo: " + cp.Saldo);
//         Console.WriteLine("Empréstimo: " + cp.Emprestimo);
//         Console.WriteLine("Taxa de Juros: " + cp.Calcularjuros);
//         Console.WriteLine();
//     }
// }


//final do exercicio07
//////////////////////////////////////////////////////////////////////////////////////////////////////////////


//exercicio 08


// public class Program
// {
//     static void Main(string[] args)
//     {
//         Espanhol cursoEspanhol = new Espanhol(10, 4, 1200, "Espanhol", false, true);
//         cursoEspanhol.verificar();
//         cursoEspanhol.manjar();



//         Ingles cursoIngles = new Ingles (2, 4, 1200, "Ingles", true);

//         cursoIngles.verificar();
//         cursoIngles.manjar();


//              Frances cursoFrances = new Frances (9, 7, 1200, "Ingles", true);

//         cursoFrances.verificar();
//         cursoFrances.manjar();




//     }
// }

//final do exericio 08
//////////////////////////////////////////////////////////////////////////////////////////////////////


//exercicio09
// public class Program
// {
//  static void Main(string[] args)
//     {

//         Boleto boleto = new Boleto();

//         Credito credito = new Credito();

//         Transferencia Transferencia = new Transferencia();        


//         boleto.DefinirPreco1(150.0);
//         boleto.DefinirValor1(1210.0);

//         credito.DefinirPreco(999999999999999999.99);
//         credito.DefinirValor(1500);

//         Transferencia.DefinirPreco(12.0);
//         Transferencia.DefinirValor(12.0);
   



  
//         boleto.VerificarStatusPagamento();

//         credito.VerificarStatusPagamento();

//         Transferencia.VerificarStatusPagamento();

//     }

// }
//final do exericio 09

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

///exercicio10 ultimo, finaleiraa
///
public class Program
{
    static void Main(string[] args)
    {
        Regular reservaRegular = new Regular();
        reservaRegular.preco = 1000.0;
        reservaRegular.PrecoMaximo = 8000.0; 
        reservaRegular.Cancelar = false;


        Upgrade reservaUpagrade = new Upgrade();
        reservaUpagrade.preco = 1000.0;
        reservaUpagrade.PrecoMaximo = 800.0; 
        reservaUpagrade.Cancelar = true;
        

        Top reservaTop = new Top();
        reservaTop.preco = 1000.0;
        reservaTop.PrecoMaximo = 800.0; 
        reservaTop.Cancelar = false;

       
        Console.WriteLine("Reservando voo:");
        reservaRegular.ReservarVoo();

        Console.WriteLine("Cancelando reserva:");
        reservaRegular.CancelarReserva();

        Console.WriteLine("Verificando status da reserva:");
        reservaRegular.VerificarStatusReserva();





                Console.WriteLine("Reservando voo:");
        reservaUpagrade.ReservarVoo();

               Console.WriteLine("Cancelando reserva:");
        reservaUpagrade.CancelarReserva();

                Console.WriteLine("Verificando status da reserva:");
        reservaUpagrade.VerificarStatusReserva();



         Console.WriteLine("Reservando voo:");
        reservaTop.ReservarVoo();

        Console.WriteLine("Cancelando reserva:");
        reservaTop.CancelarReserva();

         Console.WriteLine("Verificando status da reserva:");
        reservaTop.VerificarStatusReserva();








    }

}