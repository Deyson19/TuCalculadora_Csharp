using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuCalculadora
{
    class Suma : Calculadora
    {
        public void Sumar(double valor)
        {
            valorInicial += valor;
        }
    }
}
