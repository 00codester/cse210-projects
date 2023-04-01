class Receptions : Event {
    string _email;
    public Receptions(string title, string description, string date, string time, string street, string city, string state, string zipcode, string email) : base(title, description, date, time, street, city, state, zipcode) {
        _email = email;
        _eventType = "Reception";
    }

    public override void FullDetails()
    {
        base.FullDetails();
        Console.WriteLine($"Email: {_email}");
        
    }

}