using System;

struct Produto
{
    public int id;
    public string nome;
    public double preco;
    public bool disponivelEmEstoque;
}

class Program
{
    static void Main(string[] args)
    {
        Produto[] vitrine = new Produto[4];

        for (int contador = 0; contador < vitrine.Length; contador++)
        {
            System.Console.WriteLine($"Digite os dados do produto {contador + 1}:");
            System.Console.WriteLine("ID: ");
            vitrine[contador].id = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Nome: ");
            vitrine[contador].nome = System.Console.ReadLine();

            System.Console.WriteLine("Preço: ");
            vitrine[contador].preco = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Disponível em estoque (true/false): ");
            vitrine[contador].disponivelEmEstoque = bool.Parse(System.Console.ReadLine());
        }

        System.Console.WriteLine("\nProdutos disponíveis em estoque:");
        for (int contador = 0; contador < vitrine.Length; contador++)
        {
            if (vitrine[contador].disponivelEmEstoque)
            {
                System.Console.WriteLine($"{vitrine[contador].nome} - R$ {vitrine[contador].preco: F2}");
            }
        }
    }
}