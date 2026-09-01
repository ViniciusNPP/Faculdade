using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Produto
    {
        private string nome;
        private float preco;
        
        public Produto(string nome, float preco)
        {
            if (nome == "")
            {
                throw new Erro("Nome do produto nulo");
            }
            if (preco <= 0)
            {
                throw new Erro("Preço menor ou igual à 0");
            }
            
            this.nome = nome;
            this.preco = preco;
        }

        public string MostrarDados()
        {
            return $"Nome: {nome} | Preço: {preco}";
        }
    }
}
