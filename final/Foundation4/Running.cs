class Running : Activity{

    public Running (string date, double duration, double distance) : base(date, duration) {
        _distance = distance;
        _activity = "Running";
    }

    protected override void SetDistance(){}
}