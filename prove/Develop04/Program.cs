using System;

class Program
{
    static void Main(string[] args)
    {
        //Main Menu
        int menuOption = 0;
        int breathingExercise = 0;
        int reflectionExercise = 0;
        int listExercise = 0;

        while (menuOption != 4){
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine(" 5. Review current session");
            Console.Write("Select a choice from the menu: ");
            menuOption = int.Parse(Console.ReadLine());

            //breathing activity
            if (menuOption == 1){
                Console.Clear();
                Breathing breathing = new Breathing();
                breathing.RunActivity();
                breathingExercise += 1;
            }
            // reflection activity
            else if (menuOption == 2){
                Console.Clear();
                Reflection reflection = new Reflection();
                reflection.RunActivity();
                reflectionExercise += 1;
            }
            // listing activity
            else if (menuOption == 3) {
                Console.Clear();
                List newList = new List();
                newList.RunActivity();
                listExercise += 1;
            }
            else if (menuOption == 5) {
                Console.Clear();
                Console.WriteLine("Exercises completed this session:");
                Console.WriteLine($"{breathingExercise} breathing exercises");
                Console.WriteLine($"{reflectionExercise} reflextion exercises");
                Console.WriteLine($"{listExercise} list exercises");
                Console.WriteLine();
                Console.WriteLine("press 'enter' to continue.");
                Console.ReadLine();

            }
        }
    }
}

//to exceed requirements, do a session activity tracker ie:
//menu option 5: show session results:
// you have done: 1 breathing activity
// you have done: 0 reflection activities
// you have done: 0 list activities


// also keep track of used quesitons in reflection activity
// only repeat if every other question has been used.