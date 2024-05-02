using System;

public class calcSC
{
    // Sobrecarga do método Soma para dois números inteiros
    public int Soma(int a, int b)
    {
        return a + b;
    }

    // Sobrecarga do método Soma para três números inteiros
    public int Soma(int a, int b, int c)
    {
        return a + b + c;
    }

    // Sobrecarga do método Soma para dois números de ponto flutuante
    public double Soma(double a, double b)
    {
        return a + b;
    }
}