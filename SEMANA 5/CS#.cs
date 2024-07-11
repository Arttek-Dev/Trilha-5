namespace cs_
{
    public class Class1
    {

    }
}
class Program
{
    static void Main()
    {
        // Criando um endereço
        var endereco = new Endereco
        {
            Bairro = "Centro",
            Cidade = "São Paulo",
            Complemento = "Apto 123",
            Estado = "SP",
            Rua = "Rua das Flores",
            Numero = 42
        };

        // Criando um cliente e associando o endereço
        var cliente = new Cliente
        {
            Nome = "João da Silva",
            CPF = "123.456.789-00",
            Email = "joao@email.com",
            Profissao = "Engenheiro",
            Telefone = "(11) 98765-4321",
            Endereco = endereco
        };

        // Exibindo informações do cliente e seu endereço
        Console.WriteLine($"Nome: {cliente.Nome}");
        Console.WriteLine($"CPF: {cliente.CPF}");
        Console.WriteLine($"E-mail: {cliente.Email}");
        Console.WriteLine($"Profissão: {cliente.Profissao}");
        Console.WriteLine($"Telefone: {cliente.Telefone}");
        Console.WriteLine($"Endereço: {cliente.Endereco.Rua}, {cliente.Endereco.Numero}, {cliente.Endereco.Bairro}, {cliente.Endereco.Cidade}, {cliente.Endereco.Estado}");

        
    }
}
