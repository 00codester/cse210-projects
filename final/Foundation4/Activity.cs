class Activity {

    protected string _date;
    protected string _activity;
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected double _duration;

    public Activity(string date, double duration){
        _date = date;
        _duration = duration;
        _activity = "Default";
    }

    protected virtual void SetDistance(){}
    protected virtual void SetSpeed()
    {
        _speed = Math.Round(_distance / _duration * 60, 2);
    }
    protected virtual void SetPace()
    {
        _pace = Math.Round(_duration / _distance, 2);
    }

    public virtual void GetSummary(){
        SetDistance();
        SetSpeed();
        SetPace();
        Console.WriteLine($"{_date} {_activity} ({_duration} min)- Distance: {_distance} miles, Speed: {_speed} mph Pace: {_pace} min per mile");
    }
}