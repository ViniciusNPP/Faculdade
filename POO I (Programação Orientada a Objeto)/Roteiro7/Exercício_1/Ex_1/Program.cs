using Ex_1;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Adicionar adicionar = new();
        Remover remover = new();
        Listar listar = new();
        List<string> lista = [];

        while (true)
        {
            try
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("LISTA DE COMPRAS");
                Console.WriteLine("===========================================\n");

                Console.WriteLine("1- Adicionar item(ns)");
                Console.WriteLine("2- remover item(ns)");
                Console.WriteLine("3- listar item(ns)");
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
                    adicionar.AdicionarItem(lista);
                }
                if (opção == 2)
                {
                    remover.RemoverItem(lista);
                }
                if (opção == 3)
                {
                    listar.ListarItens(lista);
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Opção de formato inválido. Por favor, digite uma opção válida.");
                Thread.Sleep(1500);
                Console.Clear();
            }
        }
    }
}