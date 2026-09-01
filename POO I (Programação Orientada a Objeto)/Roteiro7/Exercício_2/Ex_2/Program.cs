using Ex_1;
using Ex_2;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Adicionar adicionar = new();
        Listar listar = new();
        Busca buscar = new();
        Dictionary<int, string> dic = [];
        
        while (true)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("ARMAZENAMENTO DE PRODUTOS");
                Console.WriteLine("===========================================\n");

                Console.WriteLine("1- Adicionar produto(s)");
                Console.WriteLine("2- pesquisar produto por chave");
                Console.WriteLine("3- listar produtos(s)");
                Console.WriteLine("4- Sair do programa");

                Console.Write("\n---> ");
                int opção = int.Parse(Console.ReadLine()!);

                if (opção == 4)
                {
                    break;
                }
                if (opção > 4 || opção <= 0)
                {
                    Console.WriteLine("Opção inválida. Por favor, digite uma opção válida.");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }
                if (opção == 1)
                {
                    adicionar.AdicionarItem(dic);
                }
                if (opção == 2)
                {
                    buscar.BuscarItem(dic);
                }
                if (opção == 3)
                {
                    listar.ListarItens(dic);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Opção de formato inválido. Por favor, digite uma opção válida.");
                Thread.Sleep(1500);
                Console.Clear();
            }
        }
    }
}