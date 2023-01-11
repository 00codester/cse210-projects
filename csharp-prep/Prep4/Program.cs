using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input = -1;
        int sumNumbers = 0;
        float average;
        int largestNum;
        Console.WriteLine("Enter a list of nubmer, type 0 when finished.");
        while (input != 0)
        {

            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        } 
        largestNum = numbers[0];
        int closestZero = numbers[0];
        foreach (int number in numbers)
        {
            sumNumbers += number;
            if (largestNum < number)
            {
                largestNum = number;
            }
            if (number > 0 && number < closestZero)
            {
                closestZero = number;
            }
            Console.WriteLine(number);

        }
        Console.WriteLine(closestZero);

        average = ((float)sumNumbers / (numbers.Count));
        Console.WriteLine($"The sum is: {sumNumbers}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
        if (closestZero < 0 )
        {
            Console.WriteLine( "There were no positive numbers");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {closestZero}");
        }

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}