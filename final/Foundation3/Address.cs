class Address{

    string _street;
    string _city;
    string _state;
    string _zip;

    public Address (string street, string city, string state, string zip){
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
    }

    public void DisplayAddress(){
        Console.WriteLine($"{_street}");
        Console.WriteLine($"{_city}, {_state} {_zip}");
        
    }
}