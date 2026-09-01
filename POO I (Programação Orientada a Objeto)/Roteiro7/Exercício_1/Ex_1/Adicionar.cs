using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Adicionar
    {
        public string item;

        public void AdicionarItem(List<string>lista)
        {
            Console.Clear();
            Console.WriteLine("Digite os itens que deseja adicionar.");
            Console.WriteLine("Se for mais de um item, separe-os por vírgula.");
            Console.WriteLine("Exemplo: arroz, feijão, macarrão");
            Console.Write("\n---> ");

            item = Console.ReadLine()!;
            string[] itens = item.Split(',');

            foreach (string i in itens)
            {
                lista.Add(i.Trim());
            }

            Console.WriteLine("\nItem(ns) adicionado(s) com sucesso!");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }
}
