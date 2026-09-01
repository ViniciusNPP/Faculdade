using System;

namespace Roteiro.Roteiro2
{
    internal class Carro
    {
        private string modelo = "";
        private int velocidadeAtual = 0;

        public Carro(string modelo)
        {
            Modelo = modelo;
        }

        public void Acelerar(int valor)
        {
            velocidadeAtual += valor;
        }

        public void Frear(int valor)
        {
            velocidadeAtual -= valor;
            VelocidadeAtual = velocidadeAtual;
        }

        public string Modelo
        {
            get { return modelo; }
            private set { modelo = value; }
        }

        public int VelocidadeAtual
        {
            get { return velocidadeAtual; }
            private set
            {
                if (velocidadeAtual < 0)
                {
                    velocidadeAtual = 0;
                    Console.WriteLine($"O carro parou.\nVelocidade: {velocidadeAtual}km/h");
                }
            }
        }

    }
}
