class Address{
    private string _street = "";
    private string _city = "";
    private string _state = "";
    //private string _province = "";
    private string _country = "";

    public Address (string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;

    }

    public bool IsInUSA(){
        if (_country == "USA" || _country == "US" || _country == "usa" || _country == "us") {
            return true;
        }
        else{ 
            return false;
        }
    }

    public string GetAddress(){
        string address = $"{_street}\n{_city}, {_state}\n{_country}";
        return address;
    }

}