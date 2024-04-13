using System;

struct Pizza
{
    public int id;
    public string sabor;
    public double preco;
}

class Program
{
    static void Main(string[] args)
    {
        Pizza pizza;

        System.Console.WriteLine("Digite o ID da pizza:");
        pizza.id = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("Digite o sabor da pizza:");
        pizza.sabor = System.Console.ReadLine();

        System.Console.WriteLine("Digite o preço da pizza:");
        pizza.preco = double.Parse(System.Console.ReadLine());

        System.Console.WriteLine("\nDados da pizza:");
        System.Console.WriteLine($"ID: {pizza.id}");
        System.Console.WriteLine($"Sabor: {pizza.sabor}");
        System.Console.WriteLine($"Preço: {pizza.preco}");
    }
}