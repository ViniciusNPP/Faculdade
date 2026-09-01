using System;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection.Metadata;

namespace Ex_1
{
    internal class Adicionar
    {
        public string item = "";

        public void AdicionarItem(Dictionary<int, string> dic)
        {
            string[] chavesRepetidas = [];
            
            Console.Clear();
            Console.WriteLine("Digite o código do produto e seu nome.");
            Console.WriteLine("Se for mais de um, use vírgula para separar os produtos");
            Console.WriteLine("Exemplo: 12 arroz, 89 feijão, 001 carne");
            Console.Write("\n---> ");

            item = Console.ReadLine()!;
            var regex = Regex.Matches(item, @"\d+\s*[^,]+"); //vai pegar uma sequencia que tenha numeros seguidos e qualquer caractere que nao seja virgula
            //saida: ["12 arroz", " 89 feijão", " 001 carne"]

            if (regex.Count == 0)
            {
                Console.WriteLine("\nNenhum produto válido foi encontrado. Tente novamente.");
                Thread.Sleep(1500);
                return;
            }
            
            foreach (Match match in regex)
            {
                string[] parts = match.Value.Split(' ', 2); //divide a string em duas partes: codigo e nome
                
                if (!dic.ContainsKey(int.Parse(parts[0]))) //Verifica se a chave já existe no dicionário
                {
                    dic.Add(int.Parse(parts[0]), parts[1].Trim()); //transforma o código em inteiro e tira espaços em branco do nome
                }
                else
                {
                    chavesRepetidas = chavesRepetidas.Append(parts[0]).ToArray();
                }
            }

            if (chavesRepetidas.Count() > 0)
            {
                Console.WriteLine("\nOs seguintes códigos já existem e não foram adicionados:");

                foreach (string key in chavesRepetidas)
                {
                    Console.WriteLine($"- {key}");
                }
            }

            Console.WriteLine("\nProduto(s) adicionado(s) com sucesso!");
            Thread.Sleep(1500);
        }
    }
}
