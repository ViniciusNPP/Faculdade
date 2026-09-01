using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro.Roteiro3.Roteiro3._4
{
    internal class Pato : IVoar, INadar
    {
        public void Nadar()
        {
            Console.WriteLine("O pato está nadando");
        }

        public void Voar()
        {
            Console.WriteLine("O pato está voando");
        }
    }
}
