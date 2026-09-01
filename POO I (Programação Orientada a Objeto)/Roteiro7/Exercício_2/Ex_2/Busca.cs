using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    internal class Busca
    {
        public void BuscarItem(Dictionary<int, string> dic)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite o código do produto que deseja buscar:");
                Console.Write("\n---> ");

                string busca = Console.ReadLine()!;

                if(int.TryParse(busca, out int key))
                {
                    if (dic.ContainsKey(key))
                    {
                        Console.WriteLine($"{key} - {dic[key]}");
                        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
                        Console.ReadKey();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Produto não encotrado.");
                        Thread.Sleep(1500);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Código inválido. Por favor, digite um número inteiro");
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
