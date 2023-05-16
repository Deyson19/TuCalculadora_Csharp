using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuCalculadora
{
    class Division : Calculadora
    {
        public void Dividir(double valor)
        {
            if (valor == 0)
            {
                Console.WriteLine("Error: no se puede dividir por cero");
                return;
            }
            valorInicial /= valor;
        }
    }
}
