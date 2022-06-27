using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal
{
    internal class Peixes : Animal
    {
        public string Caracteristicas { get; set; }
        public Peixes(string nome, int patas, string cor, string ambiente, double velocidade, string caracteristicas) : base(nome, patas, cor, ambiente, velocidade)
        {
            Caracteristicas = caracteristicas;
        }

        public override void Data()
        {
            base.Data();
            Console.WriteLine($"Características: {Caracteristicas}");
        }


    }
}
