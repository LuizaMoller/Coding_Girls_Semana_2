using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal
{
    public class Menu
    {
        static void Main()
        {
            MundoAnimal animal = new();
            List<Animal> individuos = new()
            {
                new Peixes("Enguia", 0, "cinza", "rios e mares", 10, "Produz energia eletrica"),
                new Mamiferos("Baleia Azul", 0, "azul", "Oceano Atlântico", 8, "krill")
            };

            foreach (Animal i in individuos)
            {
                animal.Mostrar(i);
            }

        }
    }
}
