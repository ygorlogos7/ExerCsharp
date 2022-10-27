using System;

class Program {
    static void Main(string[] args)
    {
        int senha = 1234;

        Console.WriteLine("Digite a senha abaixo:");
        senha = Convert.ToInt32(Console.ReadLine());
        if (senha > 0)
        {
            Console.WriteLine("ACESSO PERMITIDO");
        }
        else
        {
            Console.WriteLine("ACESSO NEGADO");
        }

        Console.ReadKey();


            
    }
}
