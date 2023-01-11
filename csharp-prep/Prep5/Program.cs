using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int favoriteNum = PromptUserNumber();
        int squaredNum = SquareNumber(favoriteNum);
        DisplayResult(username, squaredNum);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNum = int.Parse(Console.ReadLine());
        return favNum;
    }
    static int SquareNumber(int originalNum)
    {
        int squaredNum = originalNum * originalNum;
        return squaredNum;
    }
    static void DisplayResult(string username, int squaredNumber)
    {
        Console.WriteLine($"{username}, the square of your number is {squaredNumber}");
    }
}