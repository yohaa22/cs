using System;

namespace SistemaDeGerenciamentoDeFuncionarios
{
    class Programa
    {
        static void Main(string[] args)
        {
            Gerente meuGerente = new Gerente();
            meuGerente.Nome = "João";
            meuGerente.Departamento = "Vendas";
            meuGerente.Trabalhar(); // João está trabalhando.
            meuGerente.Gerenciar(); // João está gerenciando o departamento Vendas.

            Desenvolvedor meuDesenvolvedor = new Desenvolvedor();
            meuDesenvolvedor.Nome = "Maria";
            meuDesenvolvedor.LinguagemDeProgramacao = "C#";
            meuDesenvolvedor.Trabalhar(); // Maria está trabalhando.
            meuDesenvolvedor.Programar(); // Maria está programando em C#.
        }
    }
}
