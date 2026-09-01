float StringToCelsius(string temp)
{
    float celsius = float.Parse(temp);
    return celsius;
}
while (true)
{
    try
    {
        Console.Write("Insira uma temperatura: ");
        string temp = Console.ReadLine() ?? "";

        float celsius = StringToCelsius(temp);

        Console.WriteLine($"Temperatura em Celsius é: {celsius}°C");
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Formato inválido. Por favor, insira um número válido.");
    }
}