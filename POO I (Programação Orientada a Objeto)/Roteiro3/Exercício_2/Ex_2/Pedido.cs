using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro.Roteiro3
{
    internal class Pedido
    {
        private string pedido;

        public void FazerPedido(string pedido)
        {
            this.pedido = pedido;
            Console.WriteLine($"Pedido realizado: {pedido}");
        }
    }
}
