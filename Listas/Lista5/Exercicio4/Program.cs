using System;

class Program
{
    static void Main(string[] args)
    {
        int somaImpares = 0;

        do
        {
            int numero = int.Parse(Console.ReadLine());
            if (numero < 0)
            {
                break;
            }
            if (numero % 2 != 0)
            {
                somaImpares += numero;
            }
        }while(true);
        Console.WriteLine($"O somatório de ímpares é: {somaImpares}");
    }
}
