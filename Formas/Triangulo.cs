using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Triangulo : Forma
    {
        public double baseT { get; set; }
        public double altura { get; set; }
        public override double CalcularArea()
        {
            double area = (baseT * altura) / 2;
            return area;
        }
    }
}
