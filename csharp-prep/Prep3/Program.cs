using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber;
        int guessNumber;
        int counter = 0;
        Random randoNum = new Random();
        magicNumber = randoNum.Next(1, 100);
        //Console.Write("What is the magic number? ");
        //string smagicNumber = Console.ReadLine();

        do 
        {
            counter += 1;
            Console.Write("What is your guess? ");
            string sguessNumber = Console.ReadLine();

            //magicNumber = int.Parse(smagicNumber);
            guessNumber = int.Parse(sguessNumber);

            if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else if(magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {counter} tries.");
            }

        } while( magicNumber != guessNumber);
    }
}