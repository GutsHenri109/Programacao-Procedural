using System;

class Program{
    static void Main (string[]args){

        string usuarioCorreto  = "admin";
        string senhaCorreta = "123senha";
        int numeroTentativas = 3;

        do
        {
            System.Console.WriteLine("Digite seu nome de Usuario: ");
            string nomeUsuario = Console.ReadLine();
            System.Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();

            if (nomeUsuario == usuarioCorreto && senha ==  senhaCorreta){
                System.Console.WriteLine("Login realizado com sucesso");
                break;
            }
            else
            {
                numeroTentativas--;
                if(numeroTentativas > 0)
                {
                    System.Console.WriteLine("Usuario ou senha incorretos");
                }
                else
                {
                    System.Console.WriteLine("Sua conta foi bloqueada");
                }

            }
        

        }while(numeroTentativas > 0);
        
    }
}
