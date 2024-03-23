using System;

class Program
{
    static void Main(string[] args)
    {
        for (int contador = 10; contador >= 1; contador--)
        {
            for (int multiplicar = 0; multiplicar <= 10; multiplicar++)
            {
                Console.WriteLine($"{contador} x {multiplicar} = {contador * multiplicar}");
            }
            Console.WriteLine(); //
        }
    }
}
