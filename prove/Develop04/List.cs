class List : Activity {
    
    public List(){
        _activityName = "List";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    private List<string> _prompts = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public string GetPrompt(){
        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Count())];
        return prompt;
    }

    public void DisplayPrompt(){
        string prompt = GetPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.WriteLine();
    }

    public int ListCounter(){
        int counter = 0;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_activityDuration);

        while (DateTime.Now < endTime){
            Console.Write("> ");
            string newLine = Console.ReadLine();
            counter += 1;
            //currentTime = DateTime.Now;
        }
        return counter;
    }

    public void DisplayCounter(){
        int counter = ListCounter();
        Console.WriteLine($"You listed {counter} items!");
    }

    protected override void ActivitySpecific()
    {
        DisplayPrompt();
        DisplayCounter();
    }
}