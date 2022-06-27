using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal
{
    internal class MundoAnimal
    {
        public List<Animal> Animal = new();

        public void Mostrar(Animal animal)
        {
            animal.Data();
        }
    }
}
