class Activity{
    protected string _activityName;
    protected string _activityDescription;
    protected int _activityDuration = 0;

    public Activity (){
        _activityName = "default";
        _activityDescription = "description here";
    }

    public void Greeting(){
        Console.WriteLine($"Welcome to the {_activityName} Activity");
        Console.WriteLine();
        Console.WriteLine($"{_activityDescription}");
        Console.WriteLine();
    }

    public void ActivityDuration(){
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        _activityDuration = duration;
    }

    public void GetReady(){
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(); 
    }

    public void Congratulations(){
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Spinner();
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName} Activity.");
        Spinner();
    }

    public void Spinner(int duration = 5){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime){
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            currentTime = DateTime.Now;
        }
        Console.WriteLine();
    }

    public void Countdown(int timer){
        while (timer > 0){
            Console.Write($"{timer}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            timer = timer - 1;
        }
    }

    protected virtual void ActivitySpecific(){
    }

    public void RunActivity(){
        Greeting();
        ActivityDuration();
        GetReady();
        ActivitySpecific();
        Congratulations();
    }
}