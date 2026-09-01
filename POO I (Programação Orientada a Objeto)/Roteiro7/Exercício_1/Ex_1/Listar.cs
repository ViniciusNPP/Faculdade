using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Listar
    {
        public void ListarItens(List<string> lista)
        {
            Console.Clear();
            foreach (string i in lista)
            {
                Console.WriteLine($"- {i}");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
