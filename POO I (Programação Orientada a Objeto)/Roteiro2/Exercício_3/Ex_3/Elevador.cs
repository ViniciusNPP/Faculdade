using System;

namespace Roteiro.Roteiro2
{
    internal class Elevador
    {
        private int andarAtual = 0;
        private int totalAndares = 0;

        public Elevador(int andares)
        {
            TotalAndares = andares;
        }

        public void Subir()
        {
            if (AndarAtual >= TotalAndares)
            {
                Console.WriteLine("Você já está no último andar");
            }
            else { AndarAtual++; }
        }

        public void Descer()
        {
            if (AndarAtual <= 0)
            {
                Console.WriteLine("Você já está no térreo");
            }
            else { AndarAtual--; }
        }

        public int TotalAndares
        {
            get { return totalAndares; }
            set
            {
                if (value < 3)
                {
                    Console.WriteLine("Para ser um prédio deve ter no mínimo 3 andares");
                }
                else { totalAndares = value; }
            }
        }

        public int AndarAtual
        {
            get { return andarAtual; }
            set
            {
                if (andarAtual < 0 || andarAtual > TotalAndares)
                {
                    Console.WriteLine("Andar inválido");
                }
                else { andarAtual = value; }
            }
        }
    }
}
