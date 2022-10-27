using System;

class Program
{
    static void Main(string[] args)
    {
        int var = 0;
        int var1 = 0;
        
        Console.WriteLine("Escreva dois valores abaixo:");
        var = Convert.ToInt32(Console.ReadLine());
        var1 = Convert.ToInt32(Console.ReadLine());

        if(var >= var1)
        {
            Console.WriteLine("");
        }
        Console.WriteLine("esse é o maior numero");

        Console.ReadKey();


    }
}
