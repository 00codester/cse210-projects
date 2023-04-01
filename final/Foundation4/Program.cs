using System;

class Program
{
    
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        Running _run = new Running("03 Nov 2022", 30, 3);
        Cycling _cycle = new Cycling("04 Nov 2022", 20, 30);
        Swimming _swim = new Swimming("05 Nov 2022", 30, 50);

        _activities.Add(_run);
        _activities.Add(_cycle);
        _activities.Add(_swim);

        foreach(Activity act in _activities){
            act.GetSummary();
        }
        
    }
}