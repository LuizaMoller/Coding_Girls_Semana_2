using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace voo
{
    class Program
    {
        public string data = "03-11-2022";
        public string horario = "00:00";
        public static int assento = 10;
        public static string situation = "livre";
        public static string[] aeronave = Enumerable.Repeat(situation, assento).ToArray();


        public static void Menu()
        {
            int busca = 4;
            int proximaBusca = 0;
            while(busca == 4)
            {
                Console.Clear();
                Console.WriteLine("******************************************");
                Console.WriteLine($"[1] Ocupar Vaga\n[2] Consultar Vagas livres\n[3] Consultar Próxima" +
                    $"Cadeira Livre\n[4] Consultar Disponibilidade\n[5] Ver Horário");
                Console.WriteLine("******************************************");
                Console.Write("Digite sua opção: ");
               
                int option = Int32.Parse(Console.ReadLine());
                
                if (option == 1)
                {
                    Console.WriteLine("Insira a vaga que deseja ocupar:");
                    Console.Write("> ");
                    int vaga = Int32.Parse(Console.ReadLine());
                    OcuparVaga(vaga);
                    proximaBusca++;
                    Thread.Sleep(1000);
                    

                }
                if (option == 2)
                {
                    Console.WriteLine("Insira a vaga que deseja consultar:");
                    Console.Write("> ");
                    int vaga = Int32.Parse(Console.ReadLine());
                    Consultar(vaga);
                    Thread.Sleep(1000);
                }
                if (option == 3)
                {
                    VagasLivres();
                    Thread.Sleep(1500);
                }
                if (proximaBusca == 2)
                {
                    break;
                }
            }
            Console.WriteLine("\n");
            foreach(string i in aeronave)
            {
                
                Console.WriteLine(i);
            }


        }
        
        public static void Main()
        {
            Menu();
        }

        public static void OcuparVaga(int lugar)
        {
           
            if (aeronave[lugar] == "livre")
            {
                aeronave[lugar] = "ocupado";
                Console.WriteLine("Lugar reservado com sucesso!");

            }
            else if (aeronave[lugar] == "ocupado")
            {
                aeronave[lugar] = "ocupado";
                Console.WriteLine("Voce não pode escolher este lugar");
            }
            


        }

        public static void VagasLivres()
        {
            var VagasLivres = aeronave.Count(vagas => vagas == "livre");
            var VagasOcupadas = aeronave.Count(vagas => vagas == "ocupado");

            Console.WriteLine("******************************************");
            Console.WriteLine($"Total de vagas livres: {VagasLivres}\nTotal de vagas ocupadas: {VagasOcupadas}");
        }

        public void CadeiraLivre()
        {

        }

        public static void Consultar(int lugar)
        {
            if (aeronave[lugar] == "livre")
            {
                Console.WriteLine("Este lugar está livre!");
            }
            else if (aeronave[lugar] == "ocupado")
            {
              Console.WriteLine("Este lugar está ocupado!");
            }
           

        }

        public void VerHorario()
        {
            Console.WriteLine($"Seu voo é dia: {data}, às {horario}");
        }

    }
}
