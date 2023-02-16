using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mass = new MathAssignment("Roberto Rodriquez", "Fractions", "7.3", "8-19");
        Console.WriteLine();
        Console.WriteLine(mass.GetSummary());
        Console.WriteLine(mass.GetHomeworkList());

        WritingAssignment wass = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine();
        Console.WriteLine(wass.GetSummary());
        Console.WriteLine(wass.GetWritingInformation());
    }
}