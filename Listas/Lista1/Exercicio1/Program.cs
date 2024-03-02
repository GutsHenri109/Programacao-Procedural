using System;

class Program
{
  static void Main (string[] args)
  {
    
    double  nota1 = double.Parse(Console.ReadLine());
    double  nota2 = double.Parse(Console.ReadLine());
    double  nota3 = double.Parse(Console.ReadLine());
    double  nota4 = double.Parse(Console.ReadLine());

    double Media = (nota1 + nota2 + nota3 + nota4) / 4.0;

    Console.WriteLine("A media do aluno é: " + Media);

  }



}
