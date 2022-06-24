using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Circulo : Forma
    {
        public double raio { get; set; }
        public override double CalcularArea()
        {
            double area = 3.14 * (raio * raio);
            return area;
        }

    }
}
