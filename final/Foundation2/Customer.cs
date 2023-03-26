class Customer{
    private string _name = "";
    private Address _address;

    public Customer(string name, string street, string city, string state, string country){
        _name = name;
        _address = new Address(street, city, state, country);

    }

    public bool IsNational(){
        bool inUSA = _address.IsInUSA();
        return inUSA;
    }

    public string GetCustomerInfo(){
        string customerInfo = $"{_name}\n{_address.GetAddress()}";
        return customerInfo;
    }
}