class Lectures : Event{
    string _speaker;
    string _capacity;
    public Lectures(string title, string description, string date, string time, string street, string city, string state, string zipcode, string speaker, string capacity) : base(title, description, date, time, street, city, state, zipcode) {
        _speaker = speaker;
        _capacity = capacity;
        _eventType = "Lecture";
    }

    public override void FullDetails()
    {
        base.FullDetails();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}