using System;
class Program 
{
     static void Main (string[] args)
     {
        int crescente = 0;
        int decrescente = 200;

        while (crescente <= 100 && decrescente >= 0)
        {
            Console.WriteLine($"{crescente} - {decrescente}");
            crescente += 2;
            decrescente -= 4;
        }
     }
}
