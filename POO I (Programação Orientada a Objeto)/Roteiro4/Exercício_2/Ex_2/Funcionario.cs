using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro.Roteiro4.Roteiro4._2
{
    internal abstract class Funcionario
    {
        public double Salario { get; set; }

        public abstract void CalcularSalario();
    }
}
