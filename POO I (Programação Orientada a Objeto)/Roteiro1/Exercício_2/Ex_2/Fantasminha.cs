using System;

namespace Roteiro.Roteiro1
{
    internal class Fantasminha
    {
        public string habilidade = "";
        public string nick = "";
        public string cor = "";

        public void gerarFantasminha()
        {
            Console.WriteLine($"Nick: {this.nick}\nCor: {this.cor}\nHabilidade: {this.habilidade}\nSPAWNOU");
        }

        public void Mover(string lugar)
        {
            Console.WriteLine($"O Fantasminha {this.nick} se moveu para {lugar}.");
        }
    }
}
