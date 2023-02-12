using System;

class Program
{
    static void Main(string[] args)
    {
        Random randScrip = new Random();
        Scripture verse;
        int randNum = randScrip.Next(2);
        if (randNum == 1) {
            verse = new Scripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        }
        else {
            verse = new Scripture("Proverbs", 3, 5, 6,"Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        }

        string answer = "";
        bool gameOver = false;
        Console.Clear();
        verse.Display();

        while ((gameOver == false) && (answer != "quit") ){
            
            Console.WriteLine($"\nPress enter to continue or type 'quit' to finish:");
            answer = Console.ReadLine();
            verse.HiddenWordSelector();
            Console.Clear();
            verse.Display();
            gameOver = verse.GameOver();


        }
    }
}