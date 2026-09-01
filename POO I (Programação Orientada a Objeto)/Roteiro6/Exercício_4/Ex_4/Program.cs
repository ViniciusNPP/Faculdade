using Ex_4;

public class Program
{
    public static void VerificarIdade(int idade)
    {
        if (idade < 18)
        {
            throw new IdadeInvalidaException("Idade mínima para acesso é 18 anos.");
        }
        Console.WriteLine("Acesso permitido.");
    }

    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine()!);

            VerificarIdade(idade);
        }
        catch (IdadeInvalidaException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}