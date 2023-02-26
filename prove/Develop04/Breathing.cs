class Breathing : Activity {
    public Breathing() {
        _activityName = "Breathing";
        _activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void BreathIn(){
        Console.Write("Breathe in...");
        Countdown(4);
        Console.WriteLine();
    }

    public void BreathOut(){
        Console.Write("Breath out...");
        Countdown(5);
        Console.WriteLine();
        Console.WriteLine();
    }

    public void BreathingDuration() {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_activityDuration);
        while(currentTime < endTime){
            BreathIn();
            BreathOut();
            currentTime = DateTime.Now;
        }
    }

    protected override void ActivitySpecific(){
                BreathingDuration();
    }
}