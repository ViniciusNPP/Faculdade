using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Adicionar
    {
        public string cliente = "";

        public void AdicionarItem(Queue<string>queue)
        {
            Console.Clear();
            Console.WriteLine("Digite o(s) nome(s) que deseja adicionar.");
            Console.WriteLine("Se for mais de um cliente, separe-os por vírgula.");
            Console.WriteLine("Exemplo: Guilherme, Maria Cecília, Adalberto");
            Console.Write("\n---> ");

            cliente = Console.ReadLine()!;
            string[] clientes = cliente.Split(',');

            foreach (string i in clientes)
            {
                queue.Enqueue(i.Trim());
            }

            Console.WriteLine("\nCliente(ns) adicionado(s) com sucesso!");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }
}
