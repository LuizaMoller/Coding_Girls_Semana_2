using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal
{
    internal class Mamiferos : Animal
    {
        public string Alimento;
        public Mamiferos(string nome, int patas, string cor, string ambiente, double velocidade, string alimento) : base(nome, patas, cor, ambiente, velocidade)
        {
            Alimento = alimento;    
        }

        public override void Data()
        {
            base.Data();
            Console.WriteLine($"Alimentação: {Alimento}");
        }
    }
}
