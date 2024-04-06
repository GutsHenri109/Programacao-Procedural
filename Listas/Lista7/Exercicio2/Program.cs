using System;
class Program
{
    static int MaiorNumero(int numero1, int numero2, int numero3)
    {
        int maiorValor = numero1; 
        if (numero2 > maiorValor)
        {
            maiorValor = numero2;
        }
        if (numero3 > maiorValor)
        {
            maiorValor = numero3;
        }
        return maiorValor;
    }
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite três números inteiros:");
        int numero1 = int.Parse(Console.ReadLine());
        int numero2 = int.Parse(Console.ReadLine());
        int numero3 = int.Parse(Console.ReadLine());
        int maiorValor = MaiorNumero(numero1, numero2, numero3);
        System.Console.WriteLine($"O maior número é: {maiorValor}");
    }
}