using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a altura do retângulo: ");
        int altura = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a base do retângulo: ");
        int largura = int.Parse(Console.ReadLine());

        for (int linha = 0; linha < altura; linha++)
        {
            for (int coluna = 0; coluna < largura; coluna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
