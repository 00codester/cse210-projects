using System;

class Program
{
    static void Main(string[] args)
    {
        //Asks user for first name
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();
        //Asks user for last name
        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();
        //prints the james bond style name phrase
        Console.WriteLine($"\nYour name is {lastname}, {firstname} {lastname}.");

    }
}