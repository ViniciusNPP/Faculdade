while (true)
{
    try
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"O número digitado foi: {numero}");
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
    }
}