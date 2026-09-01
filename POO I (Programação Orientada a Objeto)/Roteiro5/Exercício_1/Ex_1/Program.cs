Console.Write("Digite um número decimal (exemplo: 10,5): --> ");
float numeroDecimal = 0;

if (!float.TryParse(Console.ReadLine(), out float num))
{
    Console.WriteLine("Entrada inválida. Por favor, insira um número decimal válido na próxima vez...");
    return;
}

numeroDecimal = num;

Console.WriteLine($"Número original: {numeroDecimal}");
Console.WriteLine($"Número arredondado padrão: {Math.Round(numeroDecimal)}");
Console.WriteLine($"Número arredondado para baixo: {Math.Floor(numeroDecimal)}");
Console.WriteLine($"Número arredondado para cima: {Math.Ceiling(numeroDecimal)}");
Console.WriteLine($"Número truncado: {Math.Truncate(numeroDecimal)}");