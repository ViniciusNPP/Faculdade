using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Erro : Exception
    {
        public Erro(string message) : base(message) {}
    }
}
