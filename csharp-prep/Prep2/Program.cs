using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        int gradePercent = int.Parse(userInput);
        string letter = "";

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        //getting grade sign of + or -
        string gradeSign = "";
        int lastDigit = gradePercent % (10);
        int firstNum = gradePercent;
        while (firstNum >= 10)
        {
            firstNum = firstNum /10;
        }
        Console.WriteLine(firstNum);
        Console.WriteLine(lastDigit);

        if (lastDigit >= 7 && firstNum != 9 && firstNum >= 6)
        {
            gradeSign = "+";
        }
        else if (lastDigit < 3 && firstNum >= 6)
        {
            gradeSign = "-";
        }

        //print out the letter grade of user
        Console.WriteLine($"You have a {letter}{gradeSign}.");

        //Pass or Fail message
        if (gradePercent >= 70)
        {
            Console.WriteLine("You passed! Congratulations!");
        }
        else
        {
            Console.WriteLine("You didn't pass this time, better luck next time!");
        }
    }
}