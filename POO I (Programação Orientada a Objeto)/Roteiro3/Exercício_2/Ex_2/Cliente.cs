using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro.Roteiro3
{
    internal class Cliente
    {
        Pedido order;
        public Cliente()
        {
            order = new Pedido();
        }

        public void RealizarPedido(string pedido)
        {
            order.FazerPedido(pedido);
        }

    }
}
