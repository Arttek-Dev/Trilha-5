namespace cliente__
{
    public class Class1
    {

    }
}
public class Produto
{
    public string Nome { get; private set; }

    public Produto(string nome)
    {
        Nome = nome;
    }
}
public Produto(string nome)
{
    if (string.IsNullOrWhiteSpace(nome))
    {
        throw new ArgumentException("O nome do produto deve ser fornecido.");
    }
    Nome = nome;
}
var meuProduto = new Produto("Nome do Produto");



