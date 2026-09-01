using Ex_1;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Adicionar adicionar = new();
        Atender remover = new();
        Listar listar = new();
        Queue<string> queue = [];

        while (true)
        {
            try
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("FILA DE CLIENTES");
                Console.WriteLine("===========================================\n");

                Console.WriteLine("1- Adicionar cliente");
                Console.WriteLine("2- atender próximo cliente");
                Console.WriteLine("3- mostrar todos os clientes");
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
                    adicionar.AdicionarItem(queue);
                }
                if (opção == 2)
                {
                    remover.RemoverCliente(queue);
                }
                if (opção == 3)
                {
                    listar.ListarItens(queue);
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