using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAnimal
{
    internal class Animal
    {
        public string Nome { get; set; }
        public int Patas { get; set; }
        public string Cor { get; set; }
        public string Ambiente { get; set; }
        public double Velocidade { get; set;}
        public Animal(string nome, int patas, string cor, string ambiente, double velocidade)
        {
            Nome = nome;
            Patas = patas;
            Cor = cor;
            Ambiente = ambiente;
            Velocidade = velocidade;
        }

        public virtual void Data()
        {
            Console.WriteLine($"----Dados o animal ----");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Número de patas: {Patas}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Ambiente: {Ambiente}");
            Console.WriteLine($"Velocidade média: {Velocidade} Km/h");
        }
    }

}
