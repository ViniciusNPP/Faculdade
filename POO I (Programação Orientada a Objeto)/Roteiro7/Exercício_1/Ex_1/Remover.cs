using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Remover
    {
        string item = "";

        public void RemoverItem(List<string> lista)
        {
            Console.Clear();
            if (lista.Count == 0)
            {
                Console.WriteLine("A lista está vazia. Não há itens para remover.");
                Thread.Sleep(1500);
                Console.Clear();
                return;
            } 
            else if (lista.Count == 1)
            {
                Console.WriteLine($"Deseja remover o único item da lista: {lista[0]}? (s/n)");

                if (Console.ReadLine()!.ToLower() == "s")
                {
                    lista.RemoveAt(0);

                    Console.WriteLine("Item removido com sucesso.");
                    Thread.Sleep(1500);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Nenhum item foi removido.");
                    Thread.Sleep(1500);
                    Console.Clear();
                }
                return;
            }

            Console.WriteLine("Digite os itens que deseja remover.");
            Console.WriteLine("Se for mais de um item, separe-os por vírgula.");
            Console.WriteLine("Exemplo: arroz, feijão, macarrão");
            Console.Write("\n---> ");

            item = Console.ReadLine()!;
            string[] itens = item.Split(',');

            foreach (string i in itens)
            {
                lista.Remove(i.Trim());
            }

            Console.WriteLine("Item(ns) removido(s) com sucesso.");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }
}
