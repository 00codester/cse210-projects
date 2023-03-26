class Product{
    private string _name = "";
    private string _id = "";
    private double _price = 0.0;
    private double _quantity = 0.0;

    public Product(string name, string id, double price, double quantity){
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double GetPrice(){
        return Math.Round(_price, 2);
    }

    public string GetName(){
        return _name;
    }

    public string GetId (){
        return _id;
    }

    public double TotalPrice(){
        double total = _price * _quantity;
        return Math.Round(total, 2);
    }
}