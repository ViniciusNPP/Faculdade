using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro.Roteiro3
{
    internal class Animal
    {
        private string nome;

        public virtual void emitirSom()
        {
            Console.WriteLine("Som genérico do animal");
        }
    }
}
