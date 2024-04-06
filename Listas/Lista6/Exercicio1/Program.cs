using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[10];
        System.Console.WriteLine("Digite os 10 nomes:");
        for (int contador = 0; contador < 10; contador++)
        {
            System.Console.Write($"Nome {contador + 1}: ");
            nomes[contador] = Console.ReadLine();
        }
        System.Console.Write("Digite o nome a ser buscado: ");
        string nomeBusca = Console.ReadLine();
        bool encontrado = false;
        for (int contador = 0; contador < 10; contador++)
        {
            if (nomes[contador] == nomeBusca)
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
