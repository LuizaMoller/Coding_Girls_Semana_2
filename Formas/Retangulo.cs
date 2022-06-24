using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Retangulo : Forma
    {
        public double baseR { get; set; }
        public double altura { get; set; }
        public override double CalcularArea()
        {
            double area = (baseR * altura) / 2;
            return area;
        }
    }

}
