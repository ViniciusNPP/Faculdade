using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro.Roteiro4.Roteiro4._1
{
    internal class BoletoBancario : Pagamento
    {
        public override void ProcessarPagamento()
        {
            Console.WriteLine("Processando pagamento via boleto bancário...");
        }
    }
}
