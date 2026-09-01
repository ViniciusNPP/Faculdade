using System;

namespace Roteiro.Roteiro1
{
    internal class Pessoa
    {
        public string nome = "";
        public int idade;
        public string cargo = "";

        public void apresentar()
        {
            Console.WriteLine($"Olá!, meu nome é {nome}, tenho {idade} e meu cargo é {cargo}.");
        }

        public void apresentarSalario()
        {
            switch (cargo)
            {
                case "Gerente":
                    Console.WriteLine("Recebo R$10.000,00");
                    break;

                case "Desenvolvedor":
                    Console.WriteLine("Recebo R$5.000,00");
                    break;

                case "Estagiario":
                    Console.WriteLine("Recebo R$100,00");
                    break;

                default:
                    Console.WriteLine("Eu não sei o meu salário...");
                    break;
            }

        }
    }
}
