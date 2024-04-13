using System;

class Program
{
    static string ClassificarNadador(int idade)
    {
        if (idade < 12)
        {
            return "Infantil";
        }
        else if (idade >= 12 && idade <= 14)
        {
            return "Juvenil A";
        }
        else if (idade >= 15 && idade <= 17)
        {
            return "Juvenil B";
        }
        else
        {
            return "Adulto";
        }
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite a idade do nadador: ");
        int idade = int.Parse(Console.ReadLine());
        string categoriaNadador = ClassificarNadador(idade);
        System.Console.WriteLine(categoriaNadador);
    }
}
