using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Quadrado : Forma
    {
        public double lado { get; set; }
        public override double CalcularArea()
        {
            double area = lado * lado;
            return area;
        }

    }
}
