using System;

class Program
{
    static bool VerificarPar(int numero)
    {
        if (numero % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main(string[] args)
    {
        System.Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());
        bool resultado = VerificarPar(numero);

        if (resultado)
        {
            System.Console.WriteLine("verdadeiro");
        }
        else
        {
            System.Console.WriteLine("falso");
        }
    }
}