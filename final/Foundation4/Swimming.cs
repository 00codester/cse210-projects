class Swimming : Activity{
    private int _numLaps;

    public Swimming(string date, double duration, int lapNum) : base(date, duration){
        _numLaps = lapNum;
        _activity = "Swimming";
    }

    protected override void SetDistance()
    {
        _distance = Math.Round((_numLaps * 50 / 1000 * 0.62), 2);
    }

}