using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Listar
    {
        public void ListarItens(Dictionary<int, string> dic)
        {
            Console.Clear();

            foreach (int key in dic.Keys)
            {
                Console.WriteLine($"{key} - {dic[key]}");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }
    }
}
