using System;

class Program
{
    static void Main (string[]args)
    {
        Console.WriteLine("Digite o numero de centavos");
        int centavos = int.Parse(Console.ReadLine());

        int reais = centavos / 100;
        int restoCentavos = centavos % 100;

        Console.WriteLine("O total em dinheiro eh: " + reais + " real(is) e " + restoCentavos + " centavo(s)"); 

    } 



  
}
