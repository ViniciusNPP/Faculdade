using System;

namespace Roteiro.Roteiro2
{
    internal class Produto
    {
        private string nome = "";
        private float preco = 0;

        public Produto(string nome, float preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Produto: {Nome}\nPreço: {Preco}");
        }

        public string Nome
        {
            get { return nome; }
            private set { nome = value; }
        }

        public float Preco
        {
            get { return preco; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Preço inválido");
                }
                else { preco = value; }
            }
        }
    }
}
