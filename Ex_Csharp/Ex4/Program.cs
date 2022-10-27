using System;

class Program
{
    static void Main(string[] args)
    {
        double val = 0;
        double val1 = 0;
        double val2 = 0;

        Console.WriteLine("Digite tres valores abaixo em ordem crescente:");
        val = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");
        val1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");
        val2 = Convert.ToDouble(Console.ReadLine());

        Console.ReadKey();
    }
}