using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuCalculadora
{
    public class Calculadora
    {
        protected double valorInicial;
        protected double valorGuardado;

        public Calculadora()
        {
            valorInicial = 0;
            valorGuardado = 0;
        }
        public double ValorActual
        {
            get { return valorInicial; }
            set { valorInicial = value; }
        }

        public double ValorMemoria
        {
            get { return valorGuardado; }
            set { valorGuardado = value; }
        }
    }
            
}
