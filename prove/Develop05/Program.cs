using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int _totalPoints = 0;
        int menuChoice = 0;
        List<Goal> goalsList = new List<Goal>();
        while (menuChoice != 6){

            Console.WriteLine();
            Console.WriteLine($"You have {_totalPoints} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            menuChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (menuChoice == 1){
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. CheckList Goal");
                Console.Write("Which type of Goal would you like to create? ");
                int goalChoice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (goalChoice == 1){
                    Simple simpleGoal = new Simple();
                    simpleGoal.GetInfo();
                    goalsList.Add(simpleGoal);
                }
                else if (goalChoice == 2) {
                    Eternal eternalGoal = new Eternal();
                    eternalGoal.GetInfo();
                    goalsList.Add(eternalGoal);
                }
                else if (goalChoice == 3) {
                    Checklist checkGoal = new Checklist();
                    checkGoal.GetInfo();
                    goalsList.Add(checkGoal);
                }
            }

            else if (menuChoice == 2){
                int counter = 1;
                Console.WriteLine("The goals are:");
                foreach (Goal goal in goalsList){
                    goal.DisplayGoal(counter);
                    counter ++;
                }
            }

            else if (menuChoice == 3){
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName)){

                    outputFile.WriteLine(_totalPoints);
                    foreach (Goal goal in goalsList){
                        string goalString = goal.GetStringRepresentation();
                        outputFile.WriteLine(goalString);

                    }
                }

            }

            else if (menuChoice == 4){
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                _totalPoints = int.Parse(lines[0]);
                lines = lines.Skip(1).ToArray();
                foreach (string line in lines){
                    string[] parts = line.Split(":");
                    string objType = parts[0];
                    string valPair = parts[1];
                    string[] values = valPair.Split(",");

                    if (objType == "Simple"){
                        Simple newGoal = new Simple();
                        newGoal.SetName(values[0]);
                        newGoal.SetDesc(values[1]);
                        newGoal.SetPoints(int.Parse(values[2]));
                        if (bool.Parse(values[3]) == true){
                            newGoal.FinishedGoal();
                            newGoal.SetisCompleted(bool.Parse(values[3]));
                        }
                        goalsList.Add(newGoal);

                    }
                    else if (objType == "Checklist"){
                        Checklist newGoal = new Checklist();
                        newGoal.SetName(values[0]);
                        newGoal.SetDesc(values[1]);
                        newGoal.SetPoints(int.Parse(values[2]));
                        newGoal.SuperSetterChecklist(int.Parse(values[4]), int.Parse(values[5]), int.Parse(values[3]));
                        if (values[4] == values[5]){
                            newGoal.FinishedGoal();
                        }
                        goalsList.Add(newGoal);
                    }
                    else{
                        Eternal newGoal = new Eternal();
                        newGoal.SetName(values[0]);
                        newGoal.SetDesc(values[1]);
                        newGoal.SetPoints(int.Parse(values[2]));
                        goalsList.Add(newGoal);
                    }

                }

            }

            else if (menuChoice == 5){
                int counter = 1;
                Console.WriteLine("The goals are:");
                foreach (Goal goal in goalsList){
                    goal.EditGoalDisplay(counter);
                    counter ++;
                }
                Console.Write("Which goal did you accomplish? ");
                int listNum = int.Parse(Console.ReadLine()) - 1;
                int addPoints = goalsList[listNum].Congratulations();
                _totalPoints += addPoints;
                Console.WriteLine($"You now have {_totalPoints} points.");
            }

        }
    }
}