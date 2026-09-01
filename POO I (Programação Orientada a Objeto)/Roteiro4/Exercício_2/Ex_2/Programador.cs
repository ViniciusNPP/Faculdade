using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro.Roteiro4.Roteiro4._2
{
    internal class Programador : Funcionario
    {
        public override void CalcularSalario()
        {
            Salario = Salario + 0.05 * Salario;
            Console.WriteLine($"O salário é: {Salario}");
        }
    }
}
