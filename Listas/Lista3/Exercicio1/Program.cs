using System;

class Program{

    static void Main(string[]args)
    {
        double somaSalario = 0;
        int somaFilhos = 0;
        double maiorSalario = 0;

        Console.WriteLine("Por favor, digite as informações de salário e número de filhos para cada habitante:");

        for (int contador = 1; contador <= 20; contador++)
        {
            Console.WriteLine("Habitante " + contador + ":");
            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Número de filhos: ");
            int quantidadeFilhos = int.Parse(Console.ReadLine());
            somaSalario += salario;
            somaFilhos += quantidadeFilhos;

            if (salario > maiorSalario)
        {
                maiorSalario = salario;
        }
        }

        double mediaSalario = somaSalario / 20;
        double mediaFilhos = (double)somaFilhos / 20;

        Console.WriteLine("Media salarial = " + Math.Round(mediaSalario, 2));
        Console.WriteLine("Media do numero de filhos por habitante = " + Math.Round(mediaFilhos, 1));
        Console.WriteLine("Maior salario = " + Math.Round(maiorSalario, 2));
    }
}



