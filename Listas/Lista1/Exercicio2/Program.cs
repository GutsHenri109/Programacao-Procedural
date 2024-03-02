using System;
using Microsoft.VisualBasic;

class Program

{
  static void Main (string[] args)
  {   
    Console.WriteLine("Digite a base do triangulo");
    double baseTriangulo = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a altura do triangulo");
    double alturaTriangulo = double.Parse(Console.ReadLine());

    double area = (baseTriangulo * alturaTriangulo);

    bool ehMaiordevinte = (area > 20);
    Console.WriteLine("A area do Triangulo eh maior que 20? " + ehMaiordevinte);

  }


}



