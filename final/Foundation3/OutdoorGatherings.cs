class OutdoorGatherings : Event {
    string _weather;
    public OutdoorGatherings(string title, string description, string date, string time, string street, string city, string state, string zipcode, string weather) : base(title, description, date, time, street, city, state, zipcode){
        _weather = weather;
        _eventType = "Outdoor Gathering";
    }
    
    public override void FullDetails()
    {
        base.FullDetails();
        Console.WriteLine($"Projected Weather: {_weather}");
    }
}