using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[3, 3];
        Console.WriteLine("Digite os 9 números inteiros:");
        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write($"Número na posição [{linha},{coluna}]: ");
                matriz[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }
        int somaDiagonal = 0;
        for (int linha = 0; linha < 3; linha++)
        {
            somaDiagonal += matriz[linha, linha];
        }
        Console.WriteLine($"\nA soma dos valores da diagonal é: {somaDiagonal}");
    }
}
