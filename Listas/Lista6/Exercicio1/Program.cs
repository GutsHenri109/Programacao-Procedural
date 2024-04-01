using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[10];
        System.Console.WriteLine("Digite os 10 nomes:");
        for (int i = 0; i < 10; i++)
        {
            System.Console.Write($"Nome {i + 1}: ");
            nomes[i] = Console.ReadLine();
        }
        System.Console.Write("Digite o nome a ser buscado: ");
        string nomeBusca = Console.ReadLine();
        bool encontrado = false;
        for (int i = 0; i < 10; i++)
        {
            if (nomes[i] == nomeBusca)
            {
                encontrado = true;
                break;
            }
        }
        if (encontrado)
        {
            Console.WriteLine("ACHEI");
        }
        else
        {
            Console.WriteLine("NAO ACHEI");
        }
    }
}