class Reflection : Activity {
    private List<string> _prompts = new List<string>(){
        "Think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless"
    };
    private List<string> _questions = new List<string>(){
        "Why was this experience meaninful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection(){
        _activityName = "Reflection";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public string GetPrompt(){
        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Count)];
        return prompt;
    }

    public string GetQuestion(){
        Random rnd = new Random();
        string question = _questions[rnd.Next(_questions.Count)];
        return question;
    }

    public void DisplayPrompt(){
        ConsoleKeyInfo keyPressed;
        string prompt = GetPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");

        keyPressed = Console.ReadKey();
        if(keyPressed.Key == ConsoleKey.Enter){
            Console.WriteLine();
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.Write("You may begin in: ");
            Countdown(5);
        }
    }

    public void DisplayQuestion(){
        string question = GetQuestion();
        Console.Write(question + " ");
        Spinner(10);
    }

    public int HowManyQuestions(){
        int numOfQuestions = _activityDuration / 10;
        return numOfQuestions;
    }

    protected override void ActivitySpecific(){
        DisplayPrompt();
        Console.Clear();
        for(int i = 0; i < HowManyQuestions(); i++){
            DisplayQuestion();
        }
    }
}