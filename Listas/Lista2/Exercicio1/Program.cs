using System;

class Program
{
  static void Main (string[] args)
  {

     Console.WriteLine ("Digite seu nome de usuario");
     string NomeUsuario = (Console.ReadLine());

     Console.WriteLine ("Digite sua senha");
     int senha = int.Parse(ConsoleReadLine());

     if (NomeUsuario == "Admin") && (senha == "123senha");

     {
        Console.WriteLine("Login Realizado com sucesso");
     }
     else
     {
        Console.WriteLine("Credenciais Invalidas");
     }

     


  }



}
