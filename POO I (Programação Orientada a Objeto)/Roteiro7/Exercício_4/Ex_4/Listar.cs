using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Listar
    {
        public void ListarItens(Queue<string> queue)
        {
            Console.Clear();
            foreach (string i in queue)
            {
                Console.WriteLine($"- {i}");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
