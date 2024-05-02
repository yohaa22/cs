public class Produto
{
    public string nome;
    public double preco;
    public int quantidadeEmEstoque;



    public Produto(string nome, double preco, int quantidadeEmEstoque)
    {
        this.nome = nome;
        this.preco = preco;
        this.quantidadeEmEstoque = quantidadeEmEstoque;
    }

    public void AdicionarUnidades(int quantidade)
    {
        this.quantidadeEmEstoque += quantidade;
    }

    public void RemoverUnidades(int quantidade)
    {
        this.quantidadeEmEstoque -= quantidade;
    }

    public double ValorTotalEmEstoque()
    {
        return this.preco * this.quantidadeEmEstoque;
    }
}

