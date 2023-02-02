using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction f = new Fraction();
        Fraction ft = new Fraction(5);
        Fraction ftb = new Fraction(3,4);
        Fraction ftb2 = new Fraction(1,3);
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());
        Console.WriteLine(ft.GetFractionString());
        Console.WriteLine(ft.GetDecimalValue());
        Console.WriteLine(ftb.GetFractionString());
        Console.WriteLine(ftb.GetDecimalValue());
        Console.WriteLine(ftb2.GetFractionString());
        Console.WriteLine(ftb2.GetDecimalValue());

    }
}