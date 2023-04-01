class Cycling : Activity {

    public Cycling(string date, double duration, double speed) : base(date, duration){
        _speed = speed;
        _activity = "Cycling";
        
    }
    protected override void SetDistance()
    {
        _distance = Math.Round(_speed * (_duration / 60), 2);
    }
    protected override void SetSpeed(){}

}