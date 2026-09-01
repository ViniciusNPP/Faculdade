using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Atender
    {
        string item = "";

        public void RemoverCliente(Queue<string> queue)
        {
            Console.Clear();
            if (queue.Count == 0)
            {
                Console.WriteLine("A fila está vazia. Não tem ninguém para atender.");
                Thread.Sleep(1500);
                Console.Clear();
                return;
            }

            queue.TryDequeue(out string? client);
            Console.WriteLine($"Cliente {client} atendido.");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }
}
