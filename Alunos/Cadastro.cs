using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos
{
    public class Cadastro
    {
        private string? nome { get; set; }
        private string notas { get; set; }
        private double frequencia { get; set; }

        public Cadastro(string? nome, string notas, double frequencia)
        {
            this.nome = nome;
            this.notas = notas;
            this.frequencia = frequencia;
        }

        public static List<Cadastro> cadastros;
        public static string InserirNotas(int inserir)
        {
            var res = new double[inserir];
            for (int n = 0; n < inserir; n++)
            {
                Console.Write($"INSIRA A NOTA DE NUMERO {n} AQUI: ");
                Double Nota = Double.Parse(Console.ReadLine());
                res[n] = Nota;
            }
            string notasInseridas = string.Join(" - ", res);
            return notasInseridas;
        }

        public static void ApresentarMenu()
        {
            cadastros = new List<Cadastro>();
            int novo = 1;
            while (novo == 1)
            {
                Console.Clear();
                Console.WriteLine("________OPÇÕES________");
                Console.WriteLine("[1]Cadastrar o aluno, sua frequencia e suas notas \n[2]Consultar aluno por código \n[3]Consultar todos os alunos");
                Console.Write("INSIRA O NÚMERO DA OPÇÃO QUE GOSTARIA DE EFETUAR: ");
                int opção = Int32.Parse(Console.ReadLine());
                if(opção == 1)
                {
                    Console.WriteLine("----------------------------");
                    Console.Write($"INSIRA O NOME DO ALUNO: ");
                    string nome = Console.ReadLine();
                    Console.Write($"INSIRA A FREQUÊNCIA DO ALUNO: ");
                    double frequencia = double.Parse(Console.ReadLine());
                    Console.Write("QUANTAS NOTAS VOCÊ GOSTARIA DE INSERIR?: ");
                    string notas = InserirNotas(Int32.Parse(Console.ReadLine()));
                    Console.WriteLine($"CADASTRO EFETUADO COM SUCESSO! CÓDIGO DO ALUNO: {cadastros.Count}");
                    cadastros.Add(new Cadastro(nome, notas, frequencia));
                    Console.WriteLine("----------------------------");
                }
                else if(opção == 2)
                {
                    Console.WriteLine("----------------------------");
                    Console.Write($"INSIRA O CÓDIGO DO ALUNO DO ALUNO: ");
                    int consulta = Int32.Parse(Console.ReadLine());
                    try
                    {
                        ConsultaCadastro(consulta);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("UM ERRO ACONTECEU!");
                    }
                    Console.WriteLine("----------------------------");
                }
                else if(opção == 3)
                {
                    Console.WriteLine("----------------------------");
                    Console.WriteLine($"CADASTROS EFETUADOS ATÉ O MOMENTO: {cadastros.Count}");
                    ApresentarAlunos();
                    Console.WriteLine("----------------------------");
                }
                Console.Write("GOSTARIA DE CONTINUAR UTILIZANDO O APLICATIVO? [1]SIM [2]NÃO: ");
                novo = Int32.Parse(Console.ReadLine());
                if (novo == 2)
                {
                    Console.WriteLine("VOCÊ ESCOLHEU FECHAR O APLICATIVO, ATÉ LOGO!");
                }
                else if (novo != 1)
                {
                    Console.WriteLine("OPÇÃO INVÁLIDA!!!");
                    Console.Write("GOSTARIA DE CONTINUAR UTILIZANDO O APLICATIVO? [1]SIM [2]NÃO: ");
                    novo = Int32.Parse(Console.ReadLine());
                }
            }
        }
        public static void ApresentarAlunos()
        {
            foreach (Cadastro cad in cadastros)
            {
                Console.WriteLine($"CÓDIGO DO ALUNO: {cadastros.IndexOf(cad)} / " +
                    $"NOME DO ALUNO: {cad.nome} / FREQUÊNCIA DO ALUNO: {cad.frequencia}% / NOTAS CADASTRADAS: {cad.notas}");
            }
        }
        public static void ConsultaCadastro(int index)
        {
            Console.WriteLine("O nome do aluno é: " + cadastros[index].nome);
            Console.WriteLine("Sua frequência foi de: " + cadastros[index].frequencia + "%");
            Console.WriteLine("Suas notas cadastradas foram: " + cadastros[index].notas);
        }
    }
}
