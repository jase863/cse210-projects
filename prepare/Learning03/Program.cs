using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();

        Console.Write("Top number please: ");

        int givenTop = int.Parse(Console.ReadLine());

        Console.Write("Bottom number please: ");

        int givenBottom = int.Parse(Console.ReadLine());

        f1.SetTop(givenTop);
        f1.SetBottom(givenBottom);

        Console.WriteLine(f1.GetFractionString());

        Console.WriteLine(f1.GetDecimalValue());
    }
}
