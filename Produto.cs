public class Produto
{
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public double Preco { get; set; }

    public Produto(string nome, int quantidade, double preco)
    {
        Nome = nome;
        Quantidade = quantidade;
        Preco = preco;
    }
}
