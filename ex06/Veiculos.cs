using System;
using System.Dynamic;

public class Veiculos{
public string Marca {get ; set ;}
public  string Modelo {get ; set ;}
public int Rodas {get ; set ;}
public int Ano {get ; set ;}

 public Veiculos(string marca, string modelo, int rodas, int ano)
 
    {
        Marca = marca;
        Modelo = modelo;
        Rodas = rodas;
        Ano = ano;
    }
}

