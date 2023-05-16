using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuCalculadora
{
    class Resta : Calculadora
    {
        public void Restar(double valor)
        {
            valorInicial -= valor;
        }
    }
}
