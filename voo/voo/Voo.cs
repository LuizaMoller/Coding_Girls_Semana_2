using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace voo
{
    public class Voo
    {
        private static string data = "03-11-2022";
        private static string horario = "00:00";
        private static int assento = 100;
        public static string situation = "livre";
        public static string[] aeronave = Enumerable.Repeat(situation, assento).ToArray();

       
        public static void Menu()
        {
            int busca = 4;
            while(busca == 4)
            {
                Console.Clear();
                Console.WriteLine("******************************************");
                Console.WriteLine($"[1] Ocupar Vaga\n[2] Consultar Vagas livres\n[3] Consultar Próxima" +
                    $" Cadeira Livre\n[4] Consultar Disponibilidade geral da aeronave\n[5] Ver Data e Horário\n");
                Console.WriteLine("******************************************");
                Console.WriteLine("            LUGARES DE 0 À 99             ");
                Console.WriteLine("******************************************");
                Console.Write("Digite sua opção: ");
               
                int option = Int32.Parse(Console.ReadLine());
                
                if (option == 1)
                {
                    Console.WriteLine("Insira a vaga que deseja ocupar:");
                    Console.Write("> ");
                    int vaga = Int32.Parse(Console.ReadLine());
                    OcuparVaga(vaga);
                }
                if (option == 2)
                {
                    Console.WriteLine("Insira a vaga que deseja consultar:");
                    Console.Write("> ");
                    int vaga = Int32.Parse(Console.ReadLine());
                    Consultar(vaga);
                }
                if (option == 3)
                {
                    CadeiraLivre();
                }
                else if (option == 4)
                {
                    VagasLivres();
                }
                else if (option == 5)
                {
                    VerHorario();
                }
                Console.WriteLine("Deseja realizar continuar utilizando o aplicativo? [1] Sim [2] Não");
                Console.Write("> ");
                int contnuarApp = Int32.Parse(Console.ReadLine());
                if (contnuarApp == 1)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("VOCÊ ESCOLHEU FECHAR O APLICATIVO, ATÉ LOGO!");

                    break;
                }
            }
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

        public static void CadeiraLivre()
        {
            string busca = "livre";
            int proxCadeira = Array.IndexOf(aeronave, busca);
            Console.WriteLine($"A próxima cadeira livre é a de número: {proxCadeira}");
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
        public static void VerHorario()
        {
            Console.WriteLine($"Seu voo é dia: {data}, às {horario}");
        }

    }
}
