Console.WriteLine("Digite uma frase que contenha espaços no ínicio e no fim e separe as palavras por vírgula.");
Console.WriteLine("Exemplo: '   Oi, eu, me, chamo, João   '");

string frase = Console.ReadLine() ?? string.Empty; //'??' Se o valor for null ou undefined, atribui uma string vazia

frase = frase.Trim(); //Espaços removidos do início e do fim
var palavras = frase.Split(','); //Cria uma lista de palavras separadas por virgula (a ',' não entra na lista)

frase = frase.Replace(palavras[0], "Pica Pau"); //Substitui a primeira palavra por 'Pica Pau'

Console.WriteLine("Frase alterada: " + frase);

if (frase.StartsWith("Pica")) //Verifica se a frase começa com 'Pica' de 'Pica Pau'
{
    Console.WriteLine("Porque vc escreveu Pica Pau?");
} 

if (frase.EndsWith('a')) //Verifica se a frase termina com 'a'
{
    Console.WriteLine("A ultima letra é 'a'!");
}