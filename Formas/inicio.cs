using Formas;
using System;

namespace aulaExemplo
{
    public class Excutar
    {
        public static void Main()
        {
            Console.WriteLine("********* OPÇÕES **********");
            Console.WriteLine(" [1] QUADRADO\n [2] TRIÂNGULO\n [3] CÍRCULO" +
                "\n [4] RETÂNGULO\n");
            Console.Write("ESCOLHA A ÁREA QUE DESEJA CALCULAR: ");
            int escolha = int.Parse(Console.ReadLine());

            if(escolha == 1)
            {
                Quadrado quadrado = new Quadrado();
                Console.Write("INSIRA A MEDIDA DO LADO DO QUADRADO: ");
                quadrado.lado = Double.Parse(Console.ReadLine());
                double area = quadrado.CalcularArea();
                Console.WriteLine("ÁREA DO QUADRADO: " + area);
            }
            else if(escolha == 2)
            {
                Triangulo triangulo = new Triangulo();
                Console.Write("INSIRA A MEDIDA DA ALTURA DO TRIANGULO: ");
                triangulo.altura = Double.Parse(Console.ReadLine());
                Console.Write("INSIRA A MEDIDA DA BASE DO TRIANGULO: ");
                triangulo.baseT = Double.Parse(Console.ReadLine());
                double areaDoTriangulo = triangulo.CalcularArea();
                Console.WriteLine("ÁREA DO TRIANGULO: " + areaDoTriangulo);
            }
            else if(escolha == 3)
            {
                Circulo circulo = new Circulo();
                Console.WriteLine("INSIRA A MEDIDA DO RAIO DO CÍRCULO: ");
                circulo.raio = Double.Parse(Console.ReadLine());
                double areaDoCirculo = circulo.CalcularArea();
                Console.WriteLine("ÁREA DO CÍRCULO: " + areaDoCirculo);
            }
            else if(escolha == 4)
            {
                Retangulo retangulo = new Retangulo();
                Console.Write("INSIRA A MEDIDA DA ALTURA DO TRIANGULO: ");
                retangulo.altura = Double.Parse(Console.ReadLine());
                Console.Write("INSIRA A MEDIDA DA BASE DO TRIANGULO: ");
                retangulo.baseR = Double.Parse(Console.ReadLine());
                double areaDoRetangulo = retangulo.CalcularArea();
                Console.WriteLine("ÁREA DO RETÂNGULO: " + areaDoRetangulo);
            }

        }

    }
}

