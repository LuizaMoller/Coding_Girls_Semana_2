using System;

public class atividadeMedia
{
    public static double calcularMedia(double nota1, double nota2, double notaTrabalho)
    {
        double soma = nota1 + nota2 + notaTrabalho;
        double media = soma / 3;
        return media;
    } 
    public static void Main(string[] args)
    {
        Console.WriteLine("INSIRA SUA MATRICULA: ");
        int matricula = int.Parse(Console.ReadLine());
        Console.WriteLine("INSIRA SEU NOME: ");
        string nome = Console.ReadLine();
        Console.WriteLine("INSIRA A PRIMEIRA NOTA: ");
        double primeiraNota = double.Parse(Console.ReadLine());
        Console.WriteLine("INSIRA A SEGUNDA NOTA: ");
        double segundaNota = double.Parse(Console.ReadLine());
        Console.WriteLine("INSIRA A NOTA DO TRABALHO: ");
        double notaDoTrabalho = double.Parse(Console.ReadLine());
        double media = calcularMedia(primeiraNota, segundaNota, notaDoTrabalho);

        if(media >= 7)
        {
            Console.WriteLine($"PARABÊNS {nome}, VOCÊ JÁ ESTÁ APROVADO!");
        }

        Console.WriteLine(Math.Round(media));
    }
}