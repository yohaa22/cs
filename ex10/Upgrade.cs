public class  Upgrade : IReserva
{     public double preco;
    public double PrecoMaximo;

    public bool vjCancelada;

     public bool Cancelar;
    
   
    public void ReservarVoo()
    {
        if (preco >= PrecoMaximo)
        {
            Console.WriteLine("parabens, você comprou conosco, BOA VIAGEM!\n");
        }
        else
        {
            Console.WriteLine("Recomendo olhar as ofertas na classe regular\n");
        }
    }
    

    public void CancelarReserva()
    {
          if (Cancelar == true || preco < PrecoMaximo)
        {
            Console.WriteLine("viagem cancelada!\n");
        }
        else
        {
            Console.WriteLine("ufaa, continue viajando com a gente, obg :)\n");
        }  
    }



    public void VerificarStatusReserva()
    {
     if (vjCancelada == false && Cancelar == false && preco >= PrecoMaximo)
        {
            Console.WriteLine("sua viagem está tudo certinho :)\n\n\n");
        }
        else
        {
            Console.WriteLine("Sinto muito, porem não tem nenhuma viagem marcada\n\n\n");
        }  
    }
}