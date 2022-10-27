using System;

class Program
{
    static void Main(string[] args)
    {
        int ano = 0;
        int ano1 = 2000;
        Console.WriteLine("Digite o ano que nasceu:");
        ano = Convert.ToInt32(Console.ReadLine());
      

        if( ano >= ano1)
        {
            Console.WriteLine("voce pode votar!");
        }
        else
        {
            Console.WriteLine("Voce nao pode votar!");
        }
        Console.ReadKey();
    }
}