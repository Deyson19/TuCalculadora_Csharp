using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuCalculadora
{
    class Multiplicacion : Calculadora
    {
        public void Multiplicar(double valor)
        {
            valorInicial *= valor;
        }
    }
}
