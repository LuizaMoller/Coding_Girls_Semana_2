using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaExemplo
{
    public abstract class Forma
    {
        public abstract double CalcularArea();
    }
    public class Quadrado : Forma
    {
        public double lado { get; set; }
        public override double CalcularArea()
        {
            double area = lado * lado;
            return area;
        }

    }
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
    public class Circulo : Forma
    {
        public double raio { get; set; }
        public override double CalcularArea()
        {
            double area = 3.14 * (raio * raio);
            return area;
        }

    }
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
