using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Stack<char> pilha = [];

        Console.WriteLine("Digite uma palavra");
        string palavra = Console.ReadLine()!;

        foreach (char i in palavra)
        {
            pilha.Push(i);
        }

        int count = pilha.Count;

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(pilha.Peek());
            pilha.Pop();
        }
    }
}