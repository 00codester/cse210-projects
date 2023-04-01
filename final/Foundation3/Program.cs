using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures _lecture = new Lectures("Getting a New Car", "What is the best way to get a new car in todays market? That's what we discuss.",
        "March 29, 2023", "8:00 pm", "43 State St.", "Ogden", "UT", "84404", "Vladimir Putin", "100");

        Receptions _reception = new Receptions("Cody and Emily's Reception", "Gather together to celebrate the union of Cody and Emily",
        "June 20, 2023", "7:00 pm", "686 1st St.", "Ogden", "UT", "84404", "candereception@gmail.com");

        OutdoorGatherings _outdoor = new OutdoorGatherings("Farmington BBQ" , "Come one come all residents of Farmington to the annual BBQ to celebrate a new summer!",
        "July 7, 2023", "4:00 pm", "25 State St.", "Farmington", "UT", "84025", "Sunny");

        Console.WriteLine();
        Console.WriteLine("---------------------");
        _lecture.ShortDescription();
        Console.WriteLine();
        _lecture.StandardDetails();
        Console.WriteLine();
        _lecture.FullDetails();

        Console.WriteLine();
        Console.WriteLine("---------------------");
        _reception.ShortDescription();
        Console.WriteLine();
        _reception.StandardDetails();
        Console.WriteLine();
        _reception.FullDetails();

        Console.WriteLine();
        Console.WriteLine("---------------------");
        _outdoor.ShortDescription();
        Console.WriteLine();
        _outdoor.StandardDetails();
        Console.WriteLine();
        _outdoor.FullDetails();
        Console.WriteLine();
    }
}