class Event {
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _eventType;

    public Event (string title, string description, string date, string time, string street, string city, string state, string zipcode){

        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = new Address(street, city, state, zipcode);
    }

public void StandardDetails (){
    
    Console.WriteLine($"Event: {_title}");
    Console.WriteLine($"Description: {_description}");
    Console.WriteLine($"Date: {_date}");
    Console.WriteLine($"Time: {_time}");
    Console.WriteLine("Location:");
    _address.DisplayAddress();
    
}

public virtual void FullDetails(){
    
    Console.WriteLine($"Event Type: {_eventType}");
    StandardDetails();
}

public void ShortDescription(){
    
    Console.WriteLine($"Event Type: {_eventType}");
    Console.WriteLine($"Event: {_title}");
    Console.WriteLine($"Date: {_date}");
}


}