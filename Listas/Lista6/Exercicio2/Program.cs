using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[10];
        Console.WriteLine("Digite os 10 nomes:");
        for (int contador = 0; contador < 10; contador++)
        {
            Console.Write($"Nome {contador + 1}: ");
            nomes[contador] = Console.ReadLine();
        }
        Console.WriteLine("\nNomes nos índices pares (do último para o primeiro):");
        for (int contador = 8; contador >= 0; contador -= 2)
        {
            Console.WriteLine(nomes[contador]);
        }
    }
}
