using Microsoft.VisualBasic;

Console.WriteLine("Qual seu nome?");
string nome = Console.ReadLine() ?? "?";

Console.WriteLine("Qual a data (dd/MM/yyyy) do seu compromisso e a hora (HH:mm)?");
DateTime compromisso = DateTime.Parse(Console.ReadLine());

TimeSpan tempoRestante = compromisso - DateTime.Now;
string diaSemana = compromisso.ToString("dddd");

Console.WriteLine(string.Format("Olá, {0}!\nSeu compromisso será em {1} dias, na {2}.\nData marcada: {3} às {4}",
    nome, tempoRestante.Days, diaSemana, compromisso.ToString("dd/MM/yyyy"), compromisso.ToString("HH:mm")));