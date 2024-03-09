using System;

class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Digite a quantidade de itens comprados");
          int quantidadeItens = int.Parse (Console.ReadLine());
          int contador = 0;
          double valorTotal = 0;

          while (contador < quantidadeItens){
          contador ++;     
          Console.WriteLine("Digite o valor da sua " + contador + "° compra:");
          int valorCompra = int.Parse(Console.ReadLine());
          valorTotal += valorCompra;
          }
         if (valorTotal >= 150)
         {
            Console.WriteLine("Parabens! Voce ganhou frete gratis em sua compra de valor " + valorTotal );
         }
         else
         {
            Console.WriteLine("A compra nao possui frete gratis");
         }

    }

    
}