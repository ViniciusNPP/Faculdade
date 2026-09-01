using System;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite quantos número inteiros quiser. Quando for para digite 0");
        HashSet<int> conjunto = [];

        while (true)
        {
            try
            {
                int input = int.Parse(Console.ReadLine()!);

                if (input == 0)
                {
                    foreach(int i in conjunto)
                    {
                        Console.WriteLine($"- {i}");
                    }
                    break;
                } 
                else
                {
                    conjunto.Add(input);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Valor inválido");
                Console.WriteLine(ex.ToString());
                break;
            }
        }
    }
}