using System;


class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        int userNum = -1;
        while(userNum != 5){
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            userNum = int.Parse(Console.ReadLine());
            if (userNum == 1){
                myJournal.WriteEntry();
            }
            else if (userNum == 2) {
                myJournal.DisplayEntry();
            }
            else if (userNum == 3) {
                myJournal.LoadFile();
            }

            else if (userNum == 4) {
                foreach (List<string> entry in myJournal._entryList) {
                    myJournal.SaveFile();
                }
            }


            
        }
    }
}